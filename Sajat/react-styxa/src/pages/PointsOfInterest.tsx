import { Link, useParams } from "react-router-dom";
import { useEffect, useState } from "react";
import { fetchWrapper } from "../services/fetchWrapper";
import PointOfInterestDetails from "../components/PointOfInterestDetails/PointOfInterestDetails";

export interface PointOfInterest {
    id: number;
    name: string;
    description: string;
    googleMapsUrl: string;
}

const PointsOfInterest = () => {
    const [pointsOfInterest, setPointsOfInterest] = useState<PointOfInterest[]>([]);
    const { cityId } = useParams();

    const getPointsOfInterest = async () => {
        await fetchWrapper.get(`/cities/${cityId}/pointsofinterest`).then((data) => {
            setPointsOfInterest(data);
            console.log(data);
        });
    };
    useEffect(() => {
        getPointsOfInterest();
    }, []);

console.log({ pointsOfInterest });
return cityId ? (
    <PointOfInterestDetails />
) : (
    <div>
        <h1>My points of interest</h1>
        <ul>
                {pointsOfInterest.map(({ id, name }) => (
                <li key={id}>
                        <Link to={`/cities/${id}/pointsofinterest`}>{name}</Link>
                </li>
            ))}
        </ul>
    </div>
);
};

export default PointsOfInterest;
