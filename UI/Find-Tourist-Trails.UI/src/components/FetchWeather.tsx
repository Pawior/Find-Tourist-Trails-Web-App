// //console.log("Hello World!")
// import React, { useState, useEffect } from "react"

// const RankItems = () => {

// }
import React, { useEffect, useState } from "react";

interface ResponseValue {
  date: string;
  temperatureC: number;
  summary: string;
}

export const FetchWeather = () => {
  const [weather, setWeather] = useState<ResponseValue[]>([]);
  const [loadingResponse, setLoadingResponse] = useState(true);

  async function getWeather() {
    try {
      await new Promise((r) => setTimeout(r, 800)); // Test loading useState
      const response = await fetch("https://localhost:7129/WeatherForecast");
      if (!response.ok) {
        throw new Error(
          `This is an HTTP error: The status is ${response.status}`
        );
      }
      const actualData = await response.json();
      console.log(actualData);
      setWeather(actualData);
    } catch (err) {
      console.error(err);
    } finally {
      setLoadingResponse(false);
    }
  }
  useEffect(() => {
    getWeather();
    console.log(weather);
  }, []);

  return (
    <div>
      {" "}
      FetchWeather
      {loadingResponse && <div> A moment please... </div>}
      {weather &&
        weather.map((weather: ResponseValue) => {
          return (
            <p>
              {" "}
              {weather.date}, {weather.temperatureC}, {weather.summary}{" "}
            </p>
          );
        })}{" "}
    </div>
  );
};
