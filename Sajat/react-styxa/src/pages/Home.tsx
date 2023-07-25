import { Box, Button, Link } from "@mui/material";
import Logo, { LogoBig } from "../components/Logo/Logo";

const Home = () => {
  return (
    <Box textAlign="center">
      <LogoBig />
      <Link>http://styxa.ro</Link>
    </Box>
  );
};

export default Home;
