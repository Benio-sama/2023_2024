interface Props {
    id?: number,
    name: string,
    weight: number,
    waterproof: number
}

export function SpeakerPost(props: Props) {
    return <tr>
        <td>{props.id}</td>
        <td>{props.name}</td>
        <td>{props.weight}</td>
        <td>{props.waterproof == 0 ? "no" : "yes"}</td>
    </tr>
}