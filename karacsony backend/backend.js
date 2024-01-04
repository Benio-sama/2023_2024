import express from 'express';
import { fileURLToPath } from 'url';
import { dirname } from 'path';
import path from 'path';
import mysql from 'mysql2';

const _filename = fileURLToPath(import.meta.url);
const __dirname = dirname(_filename);
const app = express();
app.use(express.static('public'));
app.use(express.json());

app.get('/', (req, res) => {
    res.sendFile(path.join(__dirname, 'index.html'));
})

const db = mysql.createPool({
    host: 'localhost',
    user: 'root',
    password: "",
    database: 'ajandekok',
}).promise();

app.get('/ajandekok', async(req, res) => {
    try {
        const [rows, fields] = await db.query('SELECT id, nev, ar, kaphatoe FROM ajandekok');
        res.status(200).send(rows);
    } catch (error) {
        res.status(503).json({ error: 'service unavailable' });
    }
});

app.get('/ajandekok/:ajandekId', async(req, res) => {
    try {
        const ajandekId = req.params.ajandekId;
        if (typeof ajandekId === 'number') {
            const [rows, fields] = await db.query('SELECT id, nev, ar FROM ajandekok WHERE id = ?', [ ajandekId ])
            res.send(rows);
            if (rows.length === 0) {
                res.status(404).json({error: 'cannot find ajandek'});
            } else {
                res.status(302).json(rows);
            } 
        } else {
            res.status(400).json({error: 'id has to be a number'});
        }
    } catch (error) {
        res.status(503).json({ error: 'service unavailable' });
    }
});

app.get('/ajandekok_on', async (req, res) => {
    try {
        const [rows, fields] = await db.query('SELECT id, nev, ar, kaphatoe FROM ajandekok WHERE kaphatoe = 1');
        res.status(200).send(rows);
    } catch (error) {
        res.status(503).json({ error: 'service unavailable' });
    }
});

app.get('/ajandekok_off', async (req, res) => {
    try {
        const [rows, fields] = await db.query('SELECT id, nev, ar, kaphatoe FROM ajandekok WHERE kaphatoe = 0');
        res.status(200).send(rows);
    } catch (error) {
        res.status(503).json({ error: 'service unavailable' });
    }
});

app.put('/ajandekok/on/:ajandekId', async (req, res) => {
    try {
        const ajandekId = req.params.ajandekId;
        if (typeof ajandekId === 'number') {
            await db.query('UPDATE ajandekok SET kaphatoe = 1 WHERE id = ?', [ajandekId]);
            res.status(200).json(); 
        } else {
            res.status(400).json({error: 'id has to be a number'});
        }
    } catch (error) {
        res.status(503).json({ error: 'service unavailable' });
    }
});

app.put('/ajandekok/off/:ajandekId', async (req, res) => {
    try {
        const ajandekId = req.params.ajandekId;
        if (typeof ajandekId === 'number') {
            await db.query('UPDATE ajandekok SET kaphatoe = 0 WHERE id = ?', [ajandekId]);
            res.status(200).json(); 
        } else {
            res.status(400).json({error: 'id has to be a number'});
        }
    } catch (error) {
        res.status(503).json({ error: 'service unavailable' });
    }
});

app.post('/ajandekok', async(req, res)  => {
    try {
        const nev = req.body.nev;
        const ar = req.body.ar;
        if (nev.length < 1 || !nev) {
            return res.status(400).json({error: 'nev has to be longer than 0 character'});
        }
        if (ar < 1 || !ar) {
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
        res.status(503).json({ error: 'service unavailable' });
    }
});

app.delete('/ajandekok/:ajandekId', async (req, res) => {
    try {
        const ajandekId = req.params.ajandekId;
        if (typeof ajandekId === 'number') {
            await db.query('DELETE FROM ajandekok WHERE id = ?', [ajandekId]);
            res.status(200).json();
        } else {
            res.status(400).json({error: 'id has to be a number'});
        }
    } catch (error) {
        res.status(503).json({ error: 'service unavailable' });
    }
});

app.put('/ajandekok/:ajandekId', async (req, res) => {
    try {
        const ajandekId = req.params.ajandekId;
        if (typeof ajandekId === 'number') {
            const nev = req.body.nev;
            const ar = req.body.ar;
            if (nev.length < 1 || !nev) {
                return res.status(400).json({error: 'nev has ro be longer than 0 character'});
            }
            if (ar.length < 1 || !ar) {
                return res.status(400).json({error: 'ar has to be greater than 0'});
            }
            await db.query('UPDATE ajandekok SET nev = ?, ar = ? WHERE id = ?', [nev, ar, ajandekId]);
            res.status(200).json(); 
        } else {
            res.status(400).json({error: 'id has to be a number'});
        }
    } catch (error) {
        res.status(503).json({ error: 'service unavailable' });
    }
});

app.listen(3000);