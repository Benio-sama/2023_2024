import express from 'express';
import mysql from 'mysql2';
import cors from 'cors';

const app = express();
app.use(cors());
app.use(express.json());

const db = mysql.createPool ({
    host: 'localhost', 
    user: 'root',
    password: "" ,
    database: 'speakers',
}).promise();

app.get('/speakers', async (req, res) => {
    const [rows, fields] = await db.query('SELECT id, name, weight, waterproof FROM speakers');
    res.send(rows);
});

app.post('/speakers', async (req, res) => {
    console.log(req.body);
    const [data, fields] = await db.query('INSERT INTO speakers (name, weight, waterproof) VALUES(?, ?, ?)', [ req.body.name, req.body.weight, req.body.waterproof ]);
    res.status(200).send({
        name: req.body.name,
        weight: req.body.weight,
        waterproof: req.body.waterproof,
        id: data.insertId
    });
});

app.listen(3000, () => {
    console.log("szerver fut a 3000es porton");
});