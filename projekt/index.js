import express from "express";
import mysql from "mysql2";
import cors from "cors";
import bodyParser from "body-parser";

const app = express();
app.use(cors());
let jsonparser = bodyParser.json();

const pizza = mysql.createPool({
    host: 'localhost',
    user: 'root',
    password: '',
    database: 'pizza',
}).promise();

app.get('/pizzak', async (req,res) => {
    console.log("ASD");
    const temp = await pizza.query('SELECT id, pizzanev, feltet, ar FROM pizza')
    const rows = temp[0];
    const field = temp[1];
    res.send(rows)
})
app.get('/pizzak/:pizzaid', async (req, res) => {
    console.log("asd");
    let pizzaId = parseInt(req.query.pizzaId);
    const [rows, fields] = await pizza.query('SELECT id, pizzanev, feltet, ar FROM pizza WHERE id = ?', [ pizzaId ]);
    if (rows.length == 1) {
        res.send(rows[0]);
    } else {
        res.status(404).send({error: 'pizza is not found'});
    }
});


app.listen(3000);