import { useContext } from "react";
import { context } from "../context";
import Experience from "./Experience";
import Education from "./Education";
import SectionContainer from "./SectionContainer";
import TypeingAnimation from "./TypeingAnimation";
import personalInfo from "../data/personalInfo";
const About = () => {
  const { navChange } = useContext(context);
  return (
    <SectionContainer name="about">
      <div className="elisc_tm_about w-full float-left pt-[130px]">
        <div className="tm_content w-full max-w-[1250px] h-auto clear-both my-0 mx-auto py-0 px-[20px]">
          <div className="elisc_tm_biography w-full float-left flex mb-[40px]">
            <div className="left w-[40%]">
              <div className="title w-full float-left mb-[40px]">
                <span className="mini block uppercase font-medium mb-[12px]">
                  - Nice to meet you!
                </span>
                <h3 className="name font-extrabold text-[40px]">
                  {personalInfo.fullName}
                </h3>
                <span className="job font-semibold text-[20px] text-dark-color">
                  <span className="cd-headline rotate-1">
                    {" "}
                    {/* ANIMATE TEXT VALUES: zoom, rotate-1, letters type, letters rotate-2, loading-bar, slide, clip, letters rotate-3, letters scale, push,  */}
                    <TypeingAnimation />
                  </span>
                </span>
              </div>
              <div className="elisc_tm_button transition_link">
                <a href="#contact" onClick={() => navChange("contact")}>
                    Let's work together
                </a>
              </div>
            </div>
            <div className="right w-[60%]">
              <div className="text w-full float-left mb-[44px]">
                <p className="mb-[30px]">
                  Hello there! My name is{" "}
                  <span className="text-yellow-color">{personalInfo.fullName}</span>. I am
                  a CTO, engineering manager and software engineer.
                </p>
                <p>
                  With {personalInfo.yearsExperience()} years experience as a professional a software engineer,
                  I know what it takes to make a successful software project.
                </p>
              </div>
              <div className="info w-full float-left">
                <ul>
                  <li className="mr-[40px] mb-[20px] inline-block">
                    <span className="block uppercase underline">Age</span>
                    <span className="block font-inter font-bold text-dark-color">
                      {personalInfo.age()}
                    </span>
                  </li>
                  <li className="mr-[40px] mb-[20px] inline-block">
                    <span className="block uppercase underline">From</span>
                    <span className="block font-inter font-bold text-dark-color">
                      <a className="href_location" href="#">
                        {personalInfo.from}
                      </a>
                    </span>
                  </li>
                  <li className="mr-[40px] mb-[20px] inline-block">
                    <span className="block uppercase underline">Mail</span>
                    <span className="block font-inter font-bold text-dark-color">
                      <a href={"mailto:" + personalInfo.emailAddress}>{personalInfo.emailAddress}</a>
                    </span>
                  </li>
                  <li className="mr-[40px] mb-[20px] inline-block">
                    <span className="block uppercase underline">Phone</span>
                    <span className="block font-inter font-bold text-dark-color">
                      <a href={"tel:" + personalInfo.phoneNumber}>{personalInfo.phoneNumber}</a>
                    </span>
                  </li>
                </ul>
              </div>
            </div>
          </div>
        </div>
        {/* Experience section */}
        <Experience />
        {/* Education section */}
        <Education />
      </div>
    </SectionContainer>
  );
};
export default About;
