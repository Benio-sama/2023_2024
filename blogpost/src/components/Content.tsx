interface Props {
    content: string;
}
export function Content(props: Props) {
    return <div>
        <p>{props.content}</p>
    </div>
}