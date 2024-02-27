interface Props {
    title: string
}

export function Title(props: Props) {
    return <header>
        <h1>{props.title}</h1>
    </header>
}