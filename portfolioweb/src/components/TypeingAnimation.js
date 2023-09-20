import { useEffect, useState } from "react";

const TypeingAnimation = () => {
  const skills = ["CTO", "Software engineer", "Solutions architect"];
  const [text, setText] = useState(0);
  useEffect(() => {
    const interval = setInterval(() => {
      setText(text < skills.length - 1 ? text + 1 : 0);
    }, 5000);
    return () => clearInterval(interval);
  });
  return (
    <span className="cd-words-wrapper">
      {skills.map((skill, i) => (
        <b key={i} className={text === i ? "is-visible" : "is-hidden"}>
          {skill}
        </b>
      ))}
    </span>
  );
};
export default TypeingAnimation;
