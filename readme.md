# David Rabbich portfolio

I decided to put a portfolio website together to teach myself a few new skills.  I'm predominantly a Microsoft stack developer who focuses on C#, SQL Server, Powershell, Azure etc, but I wanted to dive into React and Next.js too.

I've already had plenty of exposure to Node.js code over the last few years building a socket server for EV charge points but I wanted to look at blending a React SPA with a .Net 7 Api to see how I could blend my skills.

## Here's the layout for my portfolio project

- PortfolioApi: A .Net 7 Api project that delivers experience and blog posts (soon) to my portfolio site.
- PortfolioApi.Tests: A Test library that runs a small set of unit tests around the functionality of my Api endpoints.
- portfolioweb: A React portfolio site running under a Next.js server.


All the above is hosted in Azure on a Free tier App service plan.  CI/CD pipelines publish the projects on commit to the main branch.  Each project is configured to only react to changes within its own folder so that the entire project does not have to be published for a small text change.