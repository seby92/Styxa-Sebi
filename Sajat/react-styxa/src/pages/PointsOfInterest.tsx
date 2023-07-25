import { Link, useParams } from "react-router-dom";
import { useEffect, useState } from "react";
import { fetchWrapper } from "../services/fetchWrapper";

export interface PointsOfInterestinterface {
    id: number;
    cityId: number;
    name: string;
    description: string;
    googleMapsUrl: string;
}

const PointsOfInterest = () => {
    const [pointsOfInterest, setPointsOfInterest] = useState<PointsOfInterestinterface[]>([]);
    const { cityId } = useParams();

    const getPointsOfInterest = async () => {
        await fetchWrapper.get(`/cities/${cityId}/pointsofinterest`).then((data) => {
            setPointsOfInterest(data);
        });
    };
    useEffect(() => {
        getPointsOfInterest();
    }, []);

// console.log({ pointsOfInterest });
    return cityId ? (
        pointsOfInterest.map(poi => {
            return (
                <>
                    <ul>
                    <h1>{poi.name}</h1>
                    <p>{poi.description}</p>
                        <a href={poi.googleMapsUrl}>Location</a>
                    </ul>
                </>
            )
        })
    ) : (
    <div>
        <h1>My points of interest</h1>
        <ul>
                {pointsOfInterest.map(({ id, name, description, googleMapsUrl }) => (
                <li key={id}>
                        <Link to={`/cities/${cityId}/pointsofinterest`}>{name}</Link>
                        <p>{name}, {description}, {googleMapsUrl}</p>
                </li>
            ))}
        </ul>
    </div>
);
};

export default PointsOfInterest;