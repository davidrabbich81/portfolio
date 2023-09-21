import { useContext } from "react";
import { context } from "../context";

const experiences = [
  {
    id: 1,
    image: "assets/img/experience/1.jpg",
    date: "2020 - Present",
    company: "Fuuse",
    designation: "CTO / Principle engineer",
    synopsis: "Responsible for the creation of a world-class EV charging CSMS."
  },
  {
    id: 2,
    image: "assets/img/experience/2.jpg",
    date: "2015 - 2020",
    company: "Head of engineering",
    designation: "Cloud Commerce Pro",
    synopsis: "Managed & implemented the expansion of a multi-channel warehouse management solution."
  },
  {
    id: 3,
    image: "assets/img/experience/3.jpg",
    date: "2010 - 2015",
    company: "Fat Media",
    designation: "Senior software engineer",
    synopsis: "Responsible for completing software clients projects for a leading digital agency."
  },
  {
    id: 4,
    image: "assets/img/experience/4.jpg",
    date: "2007 - 2010",
    company: "BF Internet",
    designation: "Senior Software engineer",
    synopsis: "Secondment to a leading online florist and the management of the development team."
  },
  {
    id: 5,
    image: "assets/img/experience/4.jpg",
    date: "2004 - 2007",
    company: "EKM",
    designation: "Software engineer",
    synopsis: "Development of anscillary software projects for a (at the time), startup ecommerce provider"
  },
  {
    id: 6,
    image: "assets/img/experience/4.jpg",
    date: "1998 - 2004",
    company: "Business Serve",
    designation: "Website designer & engineer",
    synopsis: "Rapid development of SME websites and internal systems for an early UK ISP"
  },
];
const Experience = () => {
  const { modalToggle, setexperienceModal } = useContext(context);
  return (
    <div className="elisc_tm_experience w-full float-left bg-[#F3F9FF] pt-[40px] pb-[70px] px-0">
      <div className="tm_content w-full max-w-[1250px] h-auto clear-both my-0 mx-auto py-0 px-[20px]">
        <div className="elisc_tm_title w-full float-left">
          <span className="w-full float-left font-medium uppercase inline-block mb-[12px]">
            - Experience
          </span>
          <h3 className="text-[40px] font-extrabold">Everything about me!</h3>
        </div>
        <div className="list w-full float-left mt-[40px]">
          <ul className="ml-[-30px] flex flex-wrap">
            {experiences.map((experience) => (
              <li
                className="mb-[40px] pl-[30px] float-left w-1/2"
                key={experience.id}
              >
                <img
                  className="popup_image"
                  src="assets/img/experience/1.jpg"
                  alt="image"
                />
                <div className="list_inner w-full float-left clear-both bg-white rounded-[4px] px-[70px] py-[45px] relative">
                  <div className="short w-full float-left flex justify-between mb-[16px]">
                    <div className="job">
                      <span className="text-yellow-color font-medium inline-block mb-[4px]">
                        {experience.date}
                      </span>
                      <h3 className="text-[20px]">{experience.designation}</h3>
                    </div>
                    <div className="place">
                      <span className="font-medium font-inter">
                        {experience.company}
                      </span>
                    </div>
                  </div>
                  <div className="text w-full float-left">
                    <p className="opacity-[0.7]">
                      {experience.synopsis}
                    </p>
                  </div>
                  <a
                    className="elisc_tm_full_link absolute inset-0 z-[5]"
                    href="#"
                    onClick={(e) => {
                      e.preventDefault();
                      modalToggle(true);
                      setexperienceModal(experience);
                    }}
                  />
                </div>
              </li>
            ))}
          </ul>
        </div>
      </div>
    </div>
  );
};
export default Experience;
