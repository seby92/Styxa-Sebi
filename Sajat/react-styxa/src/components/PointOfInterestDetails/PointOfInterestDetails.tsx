import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import { fetchWrapper } from "../../services/fetchWrapper";
import { PointsOfInterestinterface } from "../../pages/PointsOfInterest";


const PointOfInterestDetails = () => {
    const [pointsOfInterest, setPointsOfInterest] = useState<PointsOfInterestinterface[]>([])
    const { cityId } = useParams();

    const getPointOfInterest = async () => {
        await fetchWrapper.get(`/cities/${cityId}/pointsofinterest`).then((data) => {
            setPointsOfInterest(data);
            // console.log("poidata", data);
        });

    };

    useEffect(() => {
        getPointOfInterest();
    }, []);

    return (
        pointsOfInterest.map(poi => {
            return (
                <>
                    <h1>{poi.name}</h1>
                    <p>{poi.description}</p>
                    <a href={poi.googleMapsUrl}>Location</a>
                </>
            )
        })
    )
};

export default PointOfInterestDetails;