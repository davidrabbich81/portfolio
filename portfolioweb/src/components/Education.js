import { useContext } from "react";
import { context } from "../context";

const education = [
  {
    id: 1,
    date: "2000",
    school: "Lancaster & Morecambe College",
    qualification: "AutoCAD Level 2",
    synopsis: "synopsis"
  },
  {
    id: 2,
    date: "1999",
    school: "Lancaster & Morecambe College",
    qualification: "AutoCAD Level 1",
    synopsis: "synopsis"
  },
  {
    id: 3,
    date: "1997 - 1999",
    school: "Heysham High School",
    qualification: "A-levels",
    synopsis: "synopsis about a-levels."
  },
  {
    id: 4,
    date: "1992 - 1997",
    school: "Heysham High School",
    qualification: "GCSEs",
    synopsis: "Synopsis about GCSEs."
  }
];
const Education = () => {
  const { modalToggle, setexperienceModal } = useContext(context);
  return (
    <div className="elisc_tm_education w-full float-left bg-[#F3F9FF] pt-[20px] pb-[20px] px-0">
      <div className="tm_content w-full max-w-[1250px] h-auto clear-both my-0 mx-auto py-0 px-[20px]">
        <div className="elisc_tm_title w-full float-left">
          <h3 className="text-[40px] font-extrabold">Education</h3>
        </div>
        <div className="list w-full float-left mt-[40px]">
          <ul className="ml-[-30px] flex flex-wrap">
            {education.map((edu) => (
              <li
                className="mb-[40px] pl-[30px] float-left w-1/2"
                key={"education" + edu.id}
              >
                <div className="list_inner w-full float-left clear-both bg-white rounded-[4px] px-[70px] py-[45px] relative">
                  <div className="short w-full float-left flex justify-between mb-[16px]">
                    <div className="job">
                      <span className="text-yellow-color font-medium inline-block mb-[4px]">
                        {edu.date}
                      </span>
                      <h3 className="text-[20px]">{edu.qualification} - {edu.school}</h3>
                    </div>
                  </div>
                  <div className="text w-full float-left">
                    <p className="opacity-[0.7]">
                      {edu.synopsis}
                    </p>
                  </div>
                </div>
              </li>
            ))}
          </ul>
        </div>
      </div>
    </div>
  );
};
export default Education;
