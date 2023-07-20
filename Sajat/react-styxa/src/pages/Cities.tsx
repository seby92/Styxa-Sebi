import { Link, useParams } from "react-router-dom";
import CityDetails from "../components/CityDetails/CityDetails";
import { useEffect, useState } from "react";
import { fetchWrapper } from "../services/fetchWrapper";

export interface City {
  id: number;
  name: string;
  description: string;
  googleMapsUrl : string;
}

const Cities = () => {
  const [cities, setCities] = useState<City[]>([]);
  const { cityId } = useParams();

  const getCitiesAll = async () => {
    await fetchWrapper.get("/cities").then((data) => {
      setCities(data);
    });
  };

  useEffect(() => {
    getCitiesAll();
  }, []);

  console.log({ cities });
  return cityId ? (
    <CityDetails />
  ) : (
    <div>
      <h1>My City list</h1>
      <ul>
        {cities.map(({ id, name }) => (
          <li key={id}>
            <Link to={`/cities/${id}`}>{name}</Link>
          </li>
        ))}
      </ul>
    </div>
  );
};

export default Cities;
