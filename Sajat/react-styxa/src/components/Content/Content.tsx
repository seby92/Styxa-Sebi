import { Outlet } from "react-router-dom";
import "./Content.scss";
import Logo from "../Logo/Logo";


const Content = () => {
  return (
    <div className="content">
      <Outlet />
    </div>
  );
};

export default Content;
