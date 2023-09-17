import { useContext } from "react";
import { context } from "../context";
import SectionContainer from "./SectionContainer";
const services = [
  {
    id: 1,
    name: "Web Design",
    image: "assets/img/service/1.jpg",
  },
  {
    id: 2,
    name: "Content Writing",
    image: "assets/img/service/2.jpg",
  },
  {
    id: 3,
    name: "Brand Identity",
    image: "assets/img/service/3.jpg",
  },
  {
    id: 4,
    name: "Live Chat",
    image: "assets/img/service/4.jpg",
  },
  {
    id: 5,
    name: "After Effects",
    image: "assets/img/service/1.jpg",
  },
  {
    id: 6,
    name: "Mobile App",
    image: "assets/img/service/2.jpg",
  },
];
const Services = () => {
  const { setServiceModal, modalToggle } = useContext(context);

  return (
    <SectionContainer name="service">
      <div className="elisc_tm_services w-full float-left pt-[110px]">
        <div className="tm_content w-full max-w-[1250px] h-auto clear-both my-0 mx-auto py-0 px-[20px]">
          <div className="elisc_tm_service_title w-full float-left flex justify-between items-end">
            <div className="elisc_tm_title w-auto float-left">
              <span className="w-full float-left font-medium uppercase inline-block mb-[12px]">
                - Services
              </span>
              <h3 className="text-[40px] font-extrabold">My Services</h3>
            </div>
            <a href="mailto:support@elisc.com">support@elisc.com</a>
          </div>
          <div className="service_list w-full float-left mt-[40px] mb-[50px]">
            <ul className="ml-[-30px] flex flex-wrap">
              {services.map((service) => (
                <li
                  className="mb-[30px] pl-[30px] w-1/3 float-left"
                  key={service.id}
                >
                  <img
                    className="popup_image"
                    src={service.image}
                    alt="image"
                  />
                  <div className="list_inner w-full float-left clear-both h-full relative px-[40px] pt-[32px] pb-[55px] rounded-[4px]">
                    <div className="details w-full float-left relative z-[1]">
                      <div className="title w-full float-left mb-[13px]">
                        <span className="font-inter font-medium text-[20px] text-[rgba(19,15,73,.5)] inline-block mb-[15px]">
                          0{service.id}
                        </span>
                        <h3 className="text-[20px]">{service.name}</h3>
                      </div>
                      <div className="text w-full float-left mb-[25px]">
                        <p className="text-[#55527C] opacity-[0.7]">
                          Web development is the process of building,
                          programming...
                        </p>
                      </div>
                      <div className="elisc_tm_read_more">
                        <a href="#">
                          Read More
                          <span className="inline-block">
                            <img
                              className="svg"
                              src="assets/img/svg/rightArrow.svg"
                              alt="image"
                            />
                          </span>
                        </a>
                      </div>
                    </div>
                    <a
                      className="elisc_tm_full_link absolute inset-0 z-[5]"
                      href="#"
                      onClick={(e) => {
                        e.preventDefault();
                        modalToggle(true);
                        setServiceModal(service);
                      }}
                    />
                  </div>
                </li>
              ))}
            </ul>
          </div>
          <div className="elisc_tm_video w-full float-left relative mb-[120px] overflow-hidden rounded-[4px]">
            <img
              className="placeholder min-w-full opacity-0 relative"
              src="assets/img/thumbs/4-2.jpg"
              alt="image"
            />
            <div
              className="image absolute inset-0 bg-no-repeat bg-cover bg-center"
              data-img-url="assets/img/service/1.jpg"
            />
            <div className="overlay absolute inset-0 bg-[rgba(0,0,0,.4)]" />
            <span className="play absolute top-1/2 left-1/2 translate-x-[-50%] translate-y-[-50%] z-[2] w-[111px] h-[111px] bg-white rounded-full">
              <img
                className="svg absolute top-1/2 left-1/2 translate-x-[-50%] translate-y-[-50%] w-[18px] h-[18px] ml-[2px]"
                src="assets/img/svg/play.svg"
                alt="image"
              />
            </span>
            <div className="text absolute bottom-[16px] right-[16px] bg-white py-[20px] px-[30px]">
              <h3 className="text-[#51586A] text-[17px] font-bold uppercase">
                Intro Video
              </h3>
            </div>
            <a
              className="elisc_tm_full_link absolute inset-0 z-5 popup-youtube"
              href="https://www.youtube.com/watch?v=7e90gBu4pas"
            />
          </div>
        </div>
      </div>
    </SectionContainer>
  );
};
export default Services;
