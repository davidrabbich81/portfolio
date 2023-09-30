import { useContext } from "react";
import { context } from "../context";
import personalInfo from "../data/personalInfo";
import SectionContainer from "./SectionContainer";
const skillset = [
  {
    id: 1,
    name: "C# / .Net",
    synopsis: "Development of Enterprise-level applications and APIs in .Net Core"
  },
  {
    id: 10,
    name: "Node.Js",
    synopsis: "Development of Lightweight realtime communication applications in Node.Js"
  },
  {
    id: 2,
    name: "SQL Server",
    synopsis: "Management and implementation of relational databases using SQL Server"
  },
  {
    id: 11,
    name: "HTML/CSS/JS",
    synopsis: "Full knowledge of the entire frontend web stack including popular frameworks such as React and Vue"
  },
  {
    id: 3,
    name: "Azure Devops (YAML)",
    synopsis: "Implementation of CI/CD pipelines in Azure Devops using YAML"
  },
  {
    id: 4,
    name: "Cloud resource + cost management",
    synopsis: "Deployment and management of resources within Azure cloud platform"
  },
  {
    id: 5,
    name: "Observability",
    synopsis: "Creation of network observability and alerting framework for application maintenance"
  },
  {
    id: 6,
    name: "EV Network infrastructure",
    synopsis: "Complete knowledge and understanding of electric vehicle infrastructure"
  },
  {
    id: 7,
    name: "Team management",
    synopsis: "9+ years experience managing multi-discipline engineering teams"
  },
  {
    id: 8,
    name: "Product development",
    synopsis: "9+ years experience developing products in SaaS businesses"
  },
  {
    id: 9,
    name: "Mentoring",
    synopsis: "Direct 1:1 development of both development and soft skills with engineering teams"
  },
  {
    id: 12,
    name: "Customer/Investor communication",
    synopsis: "Fully adept at handling communications with both customers and investors translating business requirements to development goals"
  },
];
const Skills = () => {
  const { setServiceModal, modalToggle } = useContext(context);

  return (
    <SectionContainer name="skills">
      <div className="elisc_tm_services w-full float-left pt-[110px]">
        <div className="tm_content w-full max-w-[1250px] h-auto clear-both my-0 mx-auto py-0 px-[20px]">
          <div className="elisc_tm_service_title w-full float-left flex justify-between items-end">
            <div className="elisc_tm_title w-auto float-left">
              <h3 className="text-[40px] font-extrabold">My Skills</h3>
            </div>
            <a href={"mailto:" + personalInfo.emailAddress}>{personalInfo.emailAddress}</a>
          </div>
          <div className="service_list w-full float-left mt-[40px] mb-[50px]">
            <ul className="ml-[-30px] flex flex-wrap">
              {skillset.map((skill) => (
                <li
                  className="mb-[30px] pl-[30px] w-1/3 float-left"
                  key={"skill" + skill.id}
                >
                  <div className="list_inner w-full float-left clear-both h-full relative px-[40px] pt-[32px] pb-[55px] rounded-[4px]">
                    <div className="details w-full float-left relative z-[1]">
                      <div className="title w-full float-left mb-[13px]">
                        <h3 className="text-[20px]">{skill.name}</h3>
                      </div>
                      <div className="text w-full float-left mb-[25px]">
                        <p className="text-[#55527C] opacity-[0.7]">
                          {skill.synopsis}
                        </p>
                      </div>
                      {/* <div className="elisc_tm_read_more">
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
                      </div> */}
                    </div>
                    {/* <a
                      className="elisc_tm_full_link absolute inset-0 z-[5]"
                      href="#"
                      onClick={(e) => {
                        e.preventDefault();
                        modalToggle(true);
                        setServiceModal(skill);
                      }}
                    /> */}
                  </div>
                </li>
              ))}
            </ul>
          </div>
        </div>
      </div>
    </SectionContainer>
  );
};
export default Skills;
