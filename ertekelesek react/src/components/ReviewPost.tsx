interface Props {
    reviewer: string
    rating: number
    date: string
    review: string
}

function whichPic(rating: number) {
    if (rating < 6) {
        return "../thumbDown.svg"
    }
    else {
        return "../thumbUp.svg"
    }
}

export function ReviewPost(props: Props) {
    return <div>
        <img src={whichPic(props.rating)} style={{width: '200px'}}></img>
        <h3>{props.review}</h3>
        <p>{props.reviewer} - {props.date}</p>
    </div>
}