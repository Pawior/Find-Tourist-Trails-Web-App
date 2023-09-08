import React from "react";
import { useEffect, useState } from "react";

function useFetch(url) {
  const [data, setData] = useState<any>(null);
  const [loading, setLoading] = useState<boolean>(false);
  const [error, setError] = useState<boolean>(null);
  useEffect(() => {
    setLoading(true);
    setError(null);
    fetch(url)
      .then((res) => res.json())
      .then(
        (result) => {
          setData(result);
          //   setLoading(false);
        },
        (error) => {
          setError(error);
          //   setLoading(false);
        }
      )
      .catch((error) => console.log(error))
      .finally(() => setLoading(false));
  }, [url]);

  return { data, loading, error };
}

export default useFetch;
