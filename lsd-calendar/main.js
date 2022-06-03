const express = require('express');
const {createEvent,getCalendarEvent} = require('./config')
const bodyParser = require('body-parser')
const app = express();
const dotenv = require('dotenv');
dotenv.config()
app.use(bodyParser.json());
const env = process.env
const PORT = env.PORT || 5200
// Set sevent rout
app.post('/add', (req, res)=> {
    console.log('Got body:', req.body);
    res.sendStatus(200);
})

app.get('/',  async (req,res)=> {
    // console.log(getCalendarEvent())
    const ev =  await getCalendarEvent()
    res.send(JSON.stringify(ev))
})

app.post('/create', async (req, res)=> {
    const event = req.body
    const addEvent = await createEvent(event)
    res.send(addEvent)
})
app.listen(PORT, ()=> {console.log(`[SERVER]: rnning on localhost:${PORT}`)})