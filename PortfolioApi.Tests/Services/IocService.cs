using PortfolioApi.Services;
using PortfolioApi.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortfolioApi.Tests.Services
{
    public class IoCService
    {
        #region Fields

        private Dictionary<string, object> _serviceDictionary = new Dictionary<string, object>();

        #endregion


        #region Ctors


        #endregion

        #region Methods

        private void DefineServices()
        {
            AddService<IFileService>(new FileService());
            AddService<IMarkdownConverterService>(new MarkdownConverterService(GetService<IFileService>()));
            AddService<IBlogService>(
                new BlogService(GetService<IMarkdownConverterService>(), GetService<IFileService>()));
            AddService<IExperienceService>(
                new ExperienceService(GetService<IMarkdownConverterService>(), GetService<IFileService>()));
        }
        public T GetService<T>()
        {

            string serviceName = typeof(T).Name;
            if (_serviceDictionary.ContainsKey(serviceName))
                return (T)_serviceDictionary[serviceName];

            throw new ArgumentException($"The requested service of type: {nameof(T)} was not found");
        }

        private void AddService<TInterface>(TInterface instanceOfService) where TInterface : class
        {
            _serviceDictionary.Add(typeof(TInterface).Name, instanceOfService);
        }

        #endregion

        private static readonly IoCService _controller = new IoCService();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static IoCService()
        {
        }

        private IoCService()
        {
            DefineServices();
        }

        public static IoCService Controller
        {
            get
            {
                return _controller;
            }
        }

    }
}
