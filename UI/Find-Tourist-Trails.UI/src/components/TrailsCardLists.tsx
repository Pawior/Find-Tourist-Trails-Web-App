import React from "react";
import Card from "react-bootstrap/Card";
import Col from "react-bootstrap/Col";
import Row from "react-bootstrap/Row";
import { LazyLoadImage } from "react-lazy-load-image-component";
import useFetch from "../Hooks/useFetch.tsx";
import "../App.css";
import TrailCard from "./TrailCard.tsx";

function TrailsCardLists({ data }) {
  //   const { data, isLoading, isError } = useFetch(
  //     "https://localhost:7129/api/Trails"
  //   );

  console.log(data[0]);
  console.log(data);
  return (
    <div className="container-list">
      {data.map((item, index) => {
        return (
          <TrailCard cardData={item}></TrailCard>
          //   <Card className="container-list-card">
          //     <Card.Img variant="top" src={item.walkImageUrl} />
          //     <Card.Body>
          //       <Card.Title>{item.name}</Card.Title>
          //       {/* <Card.Text>{item.description}</Card.Text> */}
          //       <Card.Text>Trudność trasy: {item.difficulty}</Card.Text>
          //       <Card.Text>Zobacz na mapie: {item.mapLink}</Card.Text>
          //       <Card.Text>Region: {item.region}</Card.Text>
          //     </Card.Body>
          //     <Card.Footer>
          //       <small className="text-muted">
          //         Długość trasy {item.lengthInKm}
          //       </small>
          //     </Card.Footer>
          //   </Card>
        );
      })}
      {/* <Card className="container-list-card">
        <Card.Img variant="top" src="" />
        <Card.Body>
          <Card.Title>Card title</Card.Title>
          <Card.Text>
            This is a wider card with supporting text below as a natural lead-in
            to additional content. This content is a little bit longer.
          </Card.Text>
        </Card.Body>
        <Card.Footer>
          <small className="text-muted">Last updated 3 mins ago</small>
        </Card.Footer>
      </Card> */}
    </div>
  );
}

export default TrailsCardLists;
