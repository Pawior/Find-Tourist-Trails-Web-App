import React, { useState } from "react";
import reactLogo from "../assets/react.svg";
import viteLogo from "../../public/vite.svg";
import { Link } from "react-router-dom";

function Home({ count, setCount }) {
  return (
    <div>
      <div>
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
      <p> Get All weather forecast</p>
      <div>
        <Link to="/api/Trails"> Click to Get Trails</Link>
        {/* {" "}
        <FetchWeather />{" "} */}
      </div>
    </div>
  );
}

export default Home;