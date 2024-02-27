interface Props {
    image: string;
}

export function Picture(props: Props) {
    return <div className="card">
        <img src={props.image} style={{width: "50%"}}></img>
    </div>
}