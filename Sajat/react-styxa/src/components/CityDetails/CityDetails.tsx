import { useEffect, useState } from "react";
import { City } from "../../pages/Cities";
import { useParams } from "react-router-dom";
import { fetchWrapper } from "../../services/fetchWrapper";

const CityDetails = () => {
  const [city, setCity] = useState<City>({} as City);
  const { cityId } = useParams();

  const getCity = async () => {
    await fetchWrapper.get(`/cities/${cityId}`).then((data) => {
      setCity(data);
    });
  };

  useEffect(() => {
    getCity();
  }, []);

  return (
    <div>
      <h1>{city.name}</h1>
      <p>{city.description}</p>
      <a href={city.googleMapsUrl}>Location</a>
    </div>
  );
};

export default CityDetails;
