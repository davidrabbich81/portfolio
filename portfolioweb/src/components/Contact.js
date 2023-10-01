import emailjs from "emailjs-com";
import { useState } from "react";
import SectionContainer from "./SectionContainer";
import personalInfo from "../data/personalInfo";
const Contact = () => {
  const [mailData, setMailData] = useState({
    name: "",
    email: "",
    message: "",
  });
  const { name, email, message } = mailData;
  const [error, setError] = useState(null);
  const onChange = (e) =>
    setMailData({ ...mailData, [e.target.name]: e.target.value });
  const onSubmit = (e) => {
    e.preventDefault();
    if (name.length === 0 || email.length === 0 || message.length === 0) {
      setError(true);
      clearError();
    } else {
      emailjs
        .send(
          "service_apuhca5", // service id
          "template_yco93ni", // template id
          mailData,
          "kUWhehy_1NHrXE_kd" // public api
        )
        .then(
          (response) => {
            setError(false);
            clearError();
            setMailData({ name: "", email: "", message: "" });
          },
          (err) => {
            console.log(err.text);
          }
        );
    }
  };
  const clearError = () => {
    setTimeout(() => {
      setError(null);
    }, 2000);
  };
  return (
    <SectionContainer name="contact">
      <div className="elisc_tm_contact w-full min-h-[100vh] float-left bg-[#E9F9FF] pt-[120px]">
        <div className="tm_content w-full max-w-[1250px] h-auto clear-both my-0 mx-auto py-0 px-[20px]">
          <div className="wrapper w-full float-left flex">
            <div className="left w-1/2 pr-[50px]">
              <div className="elisc_tm_title w-full float-left">
                <span className="w-full float-left font-medium uppercase inline-block mb-[12px]">
                  - Let's Connect
                </span>
                <h3 className="text-[40px] font-extrabold">Get in touch</h3>
              </div>
              <div className="text w-full float-left mt-[20px] mb-[40px]">
                <p>
                  I'm currently avaliable to take on new projects, so feel free
                  to send me a message about anything that you want to run past
                  me. You can contact anytime at 24/7
                </p>
              </div>
              <div className="info w-full float-left">
                <ul>
                  <li className="mb-[8px] w-full float-left">
                    <a
                      className="text-dark-color font-semibold font-inter inline-block relative"
                      href={"tel:" + personalInfo.phoneNumber}
                    >
                      {personalInfo.phoneNumber}
                    </a>
                  </li>
                  <li className="mb-[8px] w-full float-left">
                    <a
                      className="text-dark-color font-semibold font-inter inline-block relative"
                      href={"mailto:" + personalInfo.emailAddress}
                      >
                      {personalInfo.emailAddress}
                    </a>
                  </li>
                  <li className="w-full float-left">
                    <a
                      className="href_location text-dark-color font-semibold font-inter inline-block relative"
                      href="#"
                    >
                      {personalInfo.from}
                    </a>
                  </li>
                </ul>
              </div>
            </div>
            <div className="right w-1/2 pl-[50px]">
              <div className="fields w-full float-left h-auto clear-both">
                <form
                  onSubmit={(e) => onSubmit(e)}
                  className="contact_form"
                  id="contact_form"
                >
                  <div
                    className="returnmessage"
                    data-success="Your message has been received, We will contact you soon."
                  />
                  <div
                    className={error ? "empty_notice" : "returnmessage"}
                    style={{ display: error == null ? "none" : "block" }}
                  >
                    <span>
                      {error
                        ? "Please Fill Required Fields"
                        : "Your message has been received, We will contact you soon."}
                    </span>
                  </div>
                  <div className="first w-full float-left">
                    <ul>
                      <li className="w-full mb-[25px] float-left">
                        <input
                          id="name"
                          type="text"
                          placeholder="Enter your name"
                          autoComplete="off"
                          name="name"
                          onChange={(e) => onChange(e)}
                          value={name}
                        />
                      </li>
                      <li className="w-full mb-[25px] float-left">
                        <input
                          id="email"
                          type="text"
                          placeholder="Your email"
                          autoComplete="off"
                          name="email"
                          onChange={(e) => onChange(e)}
                          value={email}
                        />
                      </li>
                    </ul>
                  </div>
                  <div className="last">
                    <textarea
                      id="message"
                      placeholder="Write something..."
                      name="message"
                      onChange={(e) => onChange(e)}
                      value={message}
                    />
                  </div>
                  <div className="elisc_tm_button">
                    <input type="submit" value="Submit now" />
                  </div>
                  {/* If you want change mail address to yours, just open "modal" folder >> contact.php and go to line 4 and change detail to yours.  */}
                </form>
              </div>
            </div>
          </div>
          {/* */}
          <div className="elisc_tm_map w-full float-left mt-[100px] mb-[120px]">
            <div className="mapouter">
              <div className="gmap_canvas">
                <iframe
                  width="100%"
                  height={375}
                  id="gmap_canvas"
                  src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d59509.94218848406!2d-2.788644698609306!3d54.093214279463844!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x487c9cfa26a9690d%3A0x762b2704918d121b!2sWindermere%20Rd%2C%20Bolton-le-Sands%2C%20Carnforth%20LA5%208LL!5e0!3m2!1sen!2suk!4v1695317285199!5m2!1sen!2suk"
                  frameBorder={0}
                  scrolling="no"
                  marginHeight={0}
                  marginWidth={0}
                />
                <a href="https://www.embedgooglemap.net/blog/divi-discount-code-elegant-themes-coupon" />
                <br />
                <style
                  dangerouslySetInnerHTML={{
                    __html:
                      ".mapouter{position:relative;text-align:right;height:375px;width:100%;}",
                  }}
                />
                <a href="https://www.embedgooglemap.net">
                  how to add google map
                </a>
                <style
                  dangerouslySetInnerHTML={{
                    __html:
                      ".gmap_canvas {overflow:hidden;background:none!important;height:375px;width:100%;}",
                  }}
                />
              </div>
            </div>
            {/* Get your API here https://www.embedgooglemap.net */}
          </div>
        </div>
      </div>
    </SectionContainer>
  );
};
export default Contact;
