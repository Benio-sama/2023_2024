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
    database: 'rest_users',
}).promise();

app.get('/users', async (req, res) => {
    const [rows, fields] = await db.query('SELECT id, full_name, age FROM users');
    res.send(rows);
});
app.delete('/users/:userId', async (req, res) => {
    const userId = req.params.userId;
    db.query('DELETE FROM users WHERE id = ?', [ userId ]);
    res.status(204).send();
});
app.post('/users', async (req, res) => {
    console.log(req.body);
    const [data, fields] = await db.query('INSERT INTO users (full_name, age) VALUES (?, ?)', [ req.body.full_name, req.body.age ]);
    res.status(201).send({
        full_name: req.body.full_name,
        age: req.body.age,
        id: data.insertId
    });

});

app.listen(3000);