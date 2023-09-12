import React from "react";
import useFetch from "../Hooks/useFetch.tsx";
import TrailsCardLists from "./TrailsCardLists.tsx";

function GetTrailsByDifficulty() {
  const { data, isLoading, isError } = useFetch(
    "https://localhost:7129/api/Trails"
  );

  return (
    <div>
      GetTrailsByDifficulty
      {isLoading && <p>Loading...</p>}
      {isError && <p>Error... {isError}</p>}
      {data && <p>Data: {JSON.stringify(data)}</p>}
      {data && <TrailsCardLists data={data} />}
    </div>
  );
}

export default GetTrailsByDifficulty;
