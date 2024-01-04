document.addEventListener('DOMContentLoaded', () => {
  console.log('asd');
  LoadContent();
  console.log('asdf'); 
});
    
async function LoadContent(){
  try {
    console.log('as');
    const response = await fetch('http://localhost:3000/ajandekok');
    const data = await response.json();
    console.log(data);
    const table = document.getElementById('ajandektablazat');
    data.forEach(element => {
      console.log(element);
      const tr = document.createElement('tr');

      const td_id = document.createElement('td');
      td_id.textContent = element.id;
      console.log(element.id);

      const td_nev = document.createElement('td');
      td_nev.textContent = element.nev;
      console.log(element.nev);

      const td_ar = document.createElement('td');
      td_ar.textContent = element.ar;
      console.log(element.ar);

      const td_kaphatoe = document.createElement('td');

      const label = document.createElement('label');
      label.className = 'switch';

      const input = document.createElement('input');
      input.type = 'checkbox';

      const span = document.createElement('span');
      span.className = 'slider round';
      label.appendChild(input);
      label.appendChild(span);
      td_kaphatoe.append(label);
      console.log(element.kaphatoe);

      tr.appendChild(td_id);
      tr.appendChild(td_nev);
      tr.appendChild(td_ar);  
      tr.appendChild(td_kaphatoe);

      table.appendChild(tr);
    });
    
  } catch (error) {
    console.error('Fetch error:', error); 
  }
}
