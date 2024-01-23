interface KonyvProps {
  cim: string;
  szerzo: string;
}

export function Konyv(props: KonyvProps) {
  const cim = props.cim;
  return <li className="konyv" style={{
    color: props.szerzo == "ismeretlen" ? 'black' : 'pink',
    fontStyle: 'italic',
  }}>
    {props.szerzo}: {cim}</li>;
}
