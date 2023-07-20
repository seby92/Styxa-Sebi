import { styled } from "styled-components";
import { FC, useContext, useEffect, useState } from "react";
import { UserContext } from "../../context/UserContext";

import "./TextField.scss";

const FieldWrapper = styled("div")`
  display: flex;
  align-items: center;
  // background-color: green;
`;

interface TextFieldProps {
  value?: string | number;
  label: string;
  onChange?: (value: string) => void;
}

const TextField: FC<TextFieldProps> = ({ label, onChange, value = "" }) => {
  const [inputText, setInputText] = useState<string | number>();

  const { loggedIn } = useContext(UserContext);

  const handleTextChange = (text: string) => {
    setInputText(text);
    onChange?.(text);
  };

  useEffect(() => {
    setInputText(value);
  }, [value]);

  // console.log("ittt", loggedIn);

  return (
    <FieldWrapper>
      <label htmlFor="my-input">{label}: </label>
      <input
        id="my-input"
        className="text-field"
        onChange={(event) => handleTextChange(event.target.value)}
        value={inputText}
      />
    </FieldWrapper>
  );
};

export default TextField;
