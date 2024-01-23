
interface Props {
    imageUrl: string;
    description: string;
}

export function Picture(props: Props) {
    return <div className="card">
        <img src={props.imageUrl} alt={props.description}></img>
        <div>{props.description}</div>
    </div>
}