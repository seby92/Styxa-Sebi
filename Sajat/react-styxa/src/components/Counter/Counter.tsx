import { useState } from "react";
import Button from "../Button/Button";
import TextField from "../TextField/TextField";

const Counter = () => {
  const [count, setCount] = useState<number>(0);

  const increase = () => {
    setCount(count + 1);
  };
  const decrease = () => {
    setCount(count - 1);
  };

  return (
    <>
      <TextField label="Count" value={count} />
      <Button onClick={increase}>+</Button>
      <Button onClick={decrease}>-</Button>
    </>
  );
};

export default Counter;
