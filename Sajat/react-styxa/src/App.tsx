import { BrowserRouter, Route, Routes } from "react-router-dom";

import "./App.css";

import Home from "./pages/Home";
import Contact from "./pages/Contact";
import Cities from "./pages/Cities";
import Layout from "./components/Layout/Layout";
// import Guard from "./framework/Guard";
// import { useState } from "react";
// import Button from "./components/Button/Button";
import Login from "./pages/Login";
import Guard from "./framework/Guard";

const App = () => {
  // const [isAuth, setIsAuth] = useState<boolean>(false);

  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Layout />}>
          <Route path="/" element={<Home />} />
          <Route
            path="/cities/:cityId?"
            element={
              // <Guard isAuth={isAuth}>
              <Cities />
              // </Guard>
            }
          />
          <Route path="/contact" element={<Contact />} />
          <Route path="/login" element={<Login />} />
        </Route>
      </Routes>
    </BrowserRouter>
  );
};

export default App;
