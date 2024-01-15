document.addEventListener('DOMContentLoaded', () => {
    LoadContent();
    document.getElementById('hozzaad').addEventListener('click', async e => {
        e.preventDefault();

        const nev = document.getElementById('nev').value;
        const ar = document.getElementById('ar').valueAsNumber;
        const ajandek = {
            nev: nev,
            ar: ar
        };
        const response = await fetch('http://localhost:3000/ajandekok', {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(ajandek)
        });
        const data = await response.json();
        const table = document.getElementById('ajandektablazat');
        table.appendChild(CreateTR(data));
        ClearInput('nev');
        ClearInput('ar');
    });
});

async function LoadContent() {
    try {
        const response = await fetch('http://localhost:3000/ajandekok');
        const data = await response.json();
        const table = document.getElementById('ajandektablazat');
        data.forEach(element => {
            table.appendChild(CreateTR(element));
        });

    } catch (error) {
        console.error('Fetch error:', error);
    }
}

function ClearInput(id) {
    document.getElementById(id).value = '';
}

function CreateTR(data) {
    const tr = document.createElement('tr');
    tr.id = data.id;

    const td_id = document.createElement('td');
    td_id.textContent = data.id;

    const td_nev = document.createElement('td');
    td_nev.textContent = data.nev;

    const td_ar = document.createElement('td');
    td_ar.textContent = data.ar;

    const td_delete = document.createElement('td');
    const deletebutton = document.createElement('button');
    deletebutton.textContent = 'Delete';
    td_delete.appendChild(deletebutton);

    const td_kaphatoe = document.createElement('td');

    const label = document.createElement('label');
    label.className = 'switch';

    const input = document.createElement('input');
    input.type = 'checkbox';

    const span = document.createElement('span');
    span.className = 'slider round';

    if (data.kaphatoe == 1) {
        input.checked = true;
    }
    label.appendChild(input);
    label.appendChild(span);
    td_kaphatoe.append(label);

    tr.appendChild(td_id);
    tr.appendChild(td_nev);
    tr.appendChild(td_ar);
    tr.appendChild(td_delete);
    tr.appendChild(td_kaphatoe);

    input.addEventListener('change', async () => {
        try {
            if (input.checked) {
                const response = await fetch('http://localhost:3000/ajandekok/on/' + data.id, {
                    method: 'PUT',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify({})
                })
            } else {
                const response = await fetch('http://localhost:3000/ajandekok/off/' + data.id, {
                    method: 'PUT',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify({})
                })
            }
        } catch (error) {
            console.log(error.message);
        }
    });
    deletebutton.addEventListener('click', async () => {
        const response = await fetch('http://localhost:3000/ajandekok/' + data.id, {
            method: 'DELETE'
        });
        document.getElementById(data.id).remove();
    });

    return tr;
}


