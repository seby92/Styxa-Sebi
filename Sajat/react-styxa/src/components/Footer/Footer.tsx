import { Link } from "react-router-dom";
import "./Footer.scss";

const Footer = () => {
  return (
    <div className="footer">
      <Link to="/">Home </Link>
      <Link to="/cities">City list </Link>
      <Link to="/contact">Contact </Link>
    </div>
  );
};

export default Footer;