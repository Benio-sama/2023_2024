interface Props {
    id?: number;
    description: string;
    price: number;
}

export function CommissionPost(props: Props) {
    return <tr>
        <td>{props.id}</td>
        <td>{props.description}</td>
        <td>{props.price}</td>
    </tr>
}