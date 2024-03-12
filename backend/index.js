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
    database: 'commissions',
}).promise();

app.get('/commissions', async (req, res) => {
    const [rows, fields] = await db.query('SELECT id, description, price FROM commission');
    res.send(rows);
});

app.post('/commissions', async (req, res) => {
    console.log(req.body);
    const [data, fields] = await db.query('INSERT INTO commission (description, price) VALUES(?, ?)', [ req.body.description, req.body.price ]);
    res.status(200).send({
        description: req.body.description,
        price: req.body.price,
        id: data.insertId
    });
});

app.listen(3000, () => {
    console.log("szerver fut a 3000es porton");
});