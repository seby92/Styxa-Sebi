import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import { fetchWrapper } from "../../services/fetchWrapper";
import { PointOfInterest } from "../../pages/PointsOfInterest";


const PointOfInterestDetails = () => {
    const [pointOfInterest, setpointOfInterest] = useState<PointOfInterest>({} as PointOfInterest);
    const { cityId } = useParams();

    const getPointOfInterest = async () => {
        await fetchWrapper.get(`/cities/${cityId}/pointsofinterest`).then((data) => {
            setpointOfInterest(data);
        });
    };

    useEffect(() => {
        getPointOfInterest();
    }, []);

    return (
        <div>
            <h1>{pointOfInterest.name}</h1>
        </div>
    );
};

export default PointOfInterestDetails;