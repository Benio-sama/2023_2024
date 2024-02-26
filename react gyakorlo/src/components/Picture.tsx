interface Props{
    imageUrl: string;
    description: string;
}

export function Picture(props: Props) {
    return <>
        <img className='card-img-top' src={props.imageUrl} alt={props.description} style={{ width: '300px' }}></img>
        <div className='card-body'>
            <p className='card-text'>{props.description}</p>
        </div>
    </>
    
}