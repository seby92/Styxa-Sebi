import { Link, useParams } from "react-router-dom";
import CityDetails from "../components/CityDetails/CityDetails";
import { useEffect, useState } from "react";
import { fetchWrapper } from "../services/fetchWrapper";
import { Paper, Table, TableBody, TableCell, TableContainer, TableHead, TableRow, Typography } from '@mui/material';

export interface City {
  id: number;
  name: string;
  description: string;
  googleMapsUrl: string;
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
        {cities.map(({ id, name, description, googleMapsUrl }) => (
          <li key={id}>
            {/* <Link to={`/cities/${id}`}></Link> */}
            <TableContainer component={Paper}>
              <Table sx={{ minWidth: 650 }} size="small">
                <TableHead>
                  <TableRow>
                    <TableCell><Typography variant="h5">Name</Typography></TableCell>
                    <TableCell align="right"><Typography variant="h5">Description</Typography></TableCell>
                    <TableCell align="right"><Typography variant="h5">Google Maps</Typography></TableCell>
                    <TableCell align="right"><Typography variant="h5">POI</Typography></TableCell>
                  </TableRow>
                </TableHead>
                <TableBody>
                  <TableRow>
                    <TableCell><Link to={`/cities/${id}`}>{name}</Link></TableCell>
                    <TableCell>{description}</TableCell>
                    <TableCell><Link to={googleMapsUrl}>Location</Link></TableCell>
                    <TableCell><Link to={`/cities/${id}/pointsofinterest`}>POI</Link></TableCell>
                  </TableRow>
                </TableBody>
              </Table>
            </TableContainer>
          </li>

        ))}
      </ul>
    </div>

  );
};

export default Cities;
