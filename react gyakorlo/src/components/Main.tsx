import { Picture } from './Picture'

export function Main() {
    return <div className='card' style={{ width: '300px' }}>
        <Picture imageUrl='../purr_maine_coon_img1.jpg' description='Maine Coon'/>
        <Picture imageUrl='../thumb_nagyragdoll-cica.jpg' description='Ragdoll'/>
        <Picture imageUrl='../british-shorthair-compressed.jpg' description='British Shorthair'/>
        <Picture imageUrl='../siamese-cat-couch.jpg' description='Siamese'/>
    </div>
}