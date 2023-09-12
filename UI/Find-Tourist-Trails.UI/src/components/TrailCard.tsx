import React from "react";
import Card from "react-bootstrap/Card";

function TrailCard({ cardData }) {
  return (
    <Card className="container-list-card">
      <Card.Img variant="top" src={cardData.walkImageUrl} />
      <Card.Body>
        <Card.Title>{cardData.name}</Card.Title>
        {/* <Card.Text>{item.description}</Card.Text> */}
        <Card.Text>Trudność trasy: {cardData.difficulty}</Card.Text>
        <Card.Text>Zobacz na mapie: {cardData.mapLink}</Card.Text>
        <Card.Text>Region: {cardData.region}</Card.Text>
      </Card.Body>
      <Card.Footer>
        <small className="text-muted">
          Długość trasy {cardData.lengthInKm}
        </small>
      </Card.Footer>
    </Card>
  );
}

export default TrailCard;
