import React from 'react';
import logo from "./logo_transparent.png";
import logoBig from "./logo.png";
import { AutoAwesome } from '@mui/icons-material';

function Logo() {
    return <img src={logo} width={100} height={100} alt="Logo" />;
}
export default Logo;

function LogoBig() {
    return <img src={logoBig} style={{ width: "50%" }} alt="Logo" />;
}
export { LogoBig };