interface Props {
    onChange: (searchTerm: string) => void;
}

export function Search(props: Props) {
    return <input type='text' placeholder='kereses' onChange={e => props.onChange(e.currentTarget.value)}></input>
}