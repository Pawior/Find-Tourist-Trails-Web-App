import React from "react";
import { Link } from "react-router-dom";
import Button from "react-bootstrap/Button";

function TrailDifficultyPicker() {
  return (
    <div>
      {" "}
      <div className="flex-center">
        <h2> Wybierz poziom trudności szlaku</h2>
      </div>
      <div className="flex-center">
        <Link
          to="/api/Trails?filterOn=difficulty&filterQuery=easy"
          className="btn-difficulty"
        >
          <Button variant="outline-success">Łatwe szlaki</Button>
        </Link>
        <Link
          to="/api/Trails?filterOn=difficulty&filterQuery=medium"
          className="btn-difficulty"
        >
          <Button variant="outline-success">Umiarkowane szlaki</Button>
        </Link>
        <Link
          to="/api/Trails?filterOn=difficulty&filterQuery=hard"
          className="btn-difficulty"
        >
          <Button variant="outline-success">Trudne szlaki</Button>
        </Link>
      </div>
    </div>
  );
}

export default TrailDifficultyPicker;
