import React from "react";
import { useEffect, useState } from "react";

function useFetch(url) {
  const [data, setData] = useState<any>(null);
  const [isLoading, setIsLoading] = useState<boolean>(false);
  const [isError, setIsError] = useState<boolean>(null);
  useEffect(() => {
    setIsLoading(true);
    setIsError(null);
    fetch(url)
      .then((res) => res.json())
      .then(
        (result) => {
          setData(result);
          //   setLoading(false);
        },
        (error) => {
          setIsError(error);
          //   setLoading(false);
        }
      )
      .catch((error) => console.log(error))
      .finally(() => setIsLoading(false));
  }, [url]);

  return { data, isLoading, isError };
}

export default useFetch;
