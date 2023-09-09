import React, { useState } from "react";
import reactLogo from "../assets/react.svg";
import viteLogo from "../../public/vite.svg";
import { Link } from "react-router-dom";
import Container from "react-bootstrap/Container";
import Nav from "react-bootstrap/Nav";
import Navbar from "react-bootstrap/Navbar";
import NavDropdown from "react-bootstrap/NavDropdown";
import Navigation from "./Navigation";
import "../App.css";

function Home({ count, setCount }) {
  return (
    <>
      <Navigation />
      <div className="home-page_banner">
        <Link to="/api/Trails"> Click to Get Trails</Link>
        {/* {" "}
        <FetchWeather />{" "} */}
        {/* <div>
        <a href="https://vitejs.dev" target="_blank">
          <img src={viteLogo} className="logo" alt="Vite logo" />
        </a>
        <a href="https://react.dev" target="_blank">
          <img src={reactLogo} className="logo react" alt="React logo" />
        </a>
      </div>
      <h1>Vite + React</h1>
      <div className="card">
        <button onClick={() => setCount((count: number) => count + 1)}>
          count is {count}
        </button>
        <p>
          Edit <code>src/App.tsx</code> and save to test HMR
        </p>
      </div>
      <p className="read-the-docs">
        Click on the Vite and React logos to learn more
      </p>
      <p> Get All weather forecast</p> */}
      </div>
      <div className="home-page_trails-picker">
        <div>
          <h2> Wybierz poziom trudności szlaku</h2>
        </div>
        <div>
          <Link
            to="/api/Trails?filterOn=difficulty&filterQuery=easy"
            className="btn-difficulty"
          >
            <button className="button" type="button">
              Łatwe szlaki
            </button>
          </Link>
          <Link
            to="/api/Trails?filterOn=difficulty&filterQuery=medium"
            className="btn-difficulty"
          >
            <button className="button" type="button">
              Umiarkowane szlaki
            </button>
          </Link>
          <Link
            to="/api/Trails?filterOn=difficulty&filterQuery=hard"
            className="btn-difficulty"
          >
            <button className="button" type="button">
              Trudne szlaki
            </button>
          </Link>
        </div>
      </div>
    </>
  );
}

export default Home;
