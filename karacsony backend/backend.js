import express from 'express';
import mysql from 'mysql2';

const app = express();
app.use(express.json());

const db = mysql.createPool({
    host: 'localhost',
    user: 'root',
    password: "",
    database: 'ajandekok',
}).promise();

app.get('/ajandekok', async(req, res) => {
    try {
        const [rows, fields] = await db.query('SELECT id, nev, ar FROM ajandekok');
        res.status(200).send(rows);
    } catch (error) {
        res.status(500).json({ error: 'internal server error' });
    }
});

app.get('/ajandekok/:ajandekId', async(req, res) => {
    const ajandekId = req.params.ajandekId;
    try {
        const [rows, fields] = await db.query('SELECT id, nev, ar FROM ajandekok WHERE id = ?', [ ajandekId ])
        if (rows.length === 0) {
            res.status(404).json({error: 'cannot find ajandek'});
        } else {
            res.status(302).json(rows);
        }
    } catch (error) {
        res.status(500).json({error: 'internal server error'});
    }
});

app.post('/ajandekok', async(req, res)  => {
    try {
        const nev = req.body.nev;
        const ar = req.body.ar;
        if (nev.length < 1) {
            return res.status(400).json({error: 'nev has to be longer than 0 character'});
        }
        if (ar < 1) {
            return res.status(400).json({error: 'ar has to be greater than 0'});
        }
        const [data, fields] = await db.query('INSERT INTO ajandekok (nev, ar) VALUES(?, ?)', [nev, ar]);
            res.status(201).json({
            nev: nev,
            ar: ar,
            id: data.insertId
        });
    } catch (error) {
        console.error(error);
        res.status(500).json({error: 'internal server error'});
    }
});

app.delete('/ajandekok/:ajandekId', async (req, res) => {
    const ajandekId = req.params.ajandekId;
    await db.query('DELETE FROM ajandekok WHERE id = ?', [ajandekId]);
    res.status(200).json();
});

app.put('/ajandekok/:ajandekId', async (req, res) => {
    try {
        const ajandekId = req.params.ajandekId;
        const nev = req.body.nev;
        const ar = req.body.ar;
        if (nev.length < 1) {
            return res.status(400).json({error: 'nev has ro be longer than 0 character'});
        }
        if (ar.length < 1) {
            return res.status(400).json({error: 'ar has ro be greater than 0'});
        }
        await db.query('UPDATE ajandekok SET nev = ?, ar = ? WHERE id = ?', [nev, ar, ajandekId]);
        res.status(200).json();
    } catch (error) {
        res.status(500).json({error: 'internal server error'});
    }
});

app.listen(3000);