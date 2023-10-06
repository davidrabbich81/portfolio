import { useContext } from "react";
import { context } from "../context";
import personalInfo from "../data/personalInfo";

const Sidebar = () => {
  const { navChange, nav, menus } = useContext(context);

  const socialLinks = [
    { id: 3, name: "linkedin", link: "https://www.linkedin.com/in/david-rabbich-87b73414/", icon: "icon-linkedin-1" }
  ];

  return (
    <div className="elisc_tm_sidebar w-[370px] h-[100vh] fixed left-0 top-0 border-solid bg-[#302345] border-[rgba(85,82,124,.1)] border-r">
      <div className="sidebar_inner w-full float-left h-auto clear-both text-center">
        <div className="author w-full float-left pt-[60px]">
          <div className="image relative w-[118px] inline-block">
            <img
              className="relative opacity-0 min-w-full"
              src="assets/img/logo/me.jpg"
              alt="image"
            />
            <div
              className="main absolute inset-0 bg-no-repeat bg-cover bg-center rounded-full"
              data-img-url="assets/img/logo/me.jpg"
            />
          </div>
          <div className="name w-full float-left mt-[-19px]">
            <h3>
              <span>
                &nbsp;<span className="back">{personalInfo.fullName}</span>
              </span>
            </h3>
          </div>
        </div>
        <div className="menu scrollable w-full float-left">
          <ul className="transition_link h-full flex items-center justify-center flex-col">
            {menus.map((menu, i) => (
              <li
                className={`mb-[15px] ${nav === menu.href ? "active" : ""}`}
                key={"menu" + menu.id}
              >
                <a href={`#${menu.href}`} onClick={() => navChange(menu.href)}>
                  {menu.name}
                </a>
              </li>
            ))}
          </ul>
        </div>
        <div className="copyright absolute bottom-[50px]">
          <div className="social w-full float-left mb-[7px]">
            <ul>
              {socialLinks.map((link) => (
                <li className="mr-[3px] inline-block" key={link.id}>
                  <a
                    className="w-[40px] h-[40px] inline-block relative rounded-full text-light-color"
                    href={link.link}
                  >
                    <i
                      className={`${link.icon} absolute top-1/2 left-1/2 translate-x-[-50%] translate-y-[-50%] text-[16px]`}
                    />
                  </a>
                </li>
              ))}
            </ul>
          </div>
          <div className="text py-0 px-[50px]">
            <p>
              Copyright © {new Date().getFullYear()} {personalInfo.fullName}. All rights reserved.
            </p>
          </div>
        </div>
      </div>
    </div>
  );
};
export default Sidebar;
