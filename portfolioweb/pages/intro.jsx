import { Fragment } from "react";
const Intro = () => {
  return (
    <Fragment>
      <div
        className="elisc_tm_all_wrap w-full h-auto clear-both float-left relative"
        data-magic-cursor="show"
        data-enter="fadeInLeft"
        data-exit
      >
        <div className="elisc_tm_intro">
          <div className="elisc_tm_intro_fixed_price">
            <span className="anim" />
            <span className="anim" />
            <span className="anim" />
            <a
              href="https://themeforest.net/user/marketify/portfolio"
              target="_blank"
              className="pricing-info anim"
            >
              Buy
            </a>
          </div>
          <div className="short_info">
            <img
              className="inline-block"
              src="assets/img/logo/logo.png"
              alt="image"
            />
            <h3>Personal Portfolio React NextJS Template</h3>
          </div>
          <span className="intro_line" />
          <span className="intro_line_2" />
          <span className="intro_line_3" />
          <div className="demos">
            <div className="left">
              <div className="desc">
                <img src="assets/img/intro/1.png" alt="image" />
                <h3 className="title">vCard Version</h3>
              </div>
              <a className="intro_link" href="/" target="_blank" />
            </div>
            <div className="right">
              <div className="desc">
                <img src="assets/img/intro/1.png" alt="image" />
                <h3 className="title">One Page Version</h3>
              </div>
              <a className="intro_link" href="index-one-page" target="_blank" />
            </div>
          </div>
        </div>
      </div>
    </Fragment>
  );
};
export default Intro;
