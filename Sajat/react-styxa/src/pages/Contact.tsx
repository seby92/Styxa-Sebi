import { Call, Email } from "@mui/icons-material";
import { Link } from "react-router-dom";

const Contact = () => {
  return <div>
    Sebestyen Attila
    <br />
    <Email /><Link to="seby922@gmail.com">seby922@gmail.com</Link> <br />
    <Call /><Link to="tel:+40771443437">+40771443437</Link>
    
  </div>;
};

export default Contact;