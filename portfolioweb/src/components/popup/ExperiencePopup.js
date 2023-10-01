import { context } from "@/src/context";
import { useContext } from "react";
import ModalContainer from "./ModalContainer";

const ExperiencePopup = () => {
  const { experienceModal, setexperienceModal } = useContext(context);
  return (
    <ModalContainer nullValue={setexperienceModal}>
      <div className="descriptions">
        <div className="infos">
          <div className="year">
            <span>{experienceModal.timeFrame}</span>
          </div>
          <div className="job">
            <span>{experienceModal.company}</span>
            <h3>{experienceModal.jobTitle}</h3>
            <h6 className="pt-[20px]">{experienceModal.synopsis}</h6>
          </div>
        </div>
        <div className="blog-content" dangerouslySetInnerHTML={{__html: experienceModal.content}} />
      </div>
    </ModalContainer>
  );
};
export default ExperiencePopup;
