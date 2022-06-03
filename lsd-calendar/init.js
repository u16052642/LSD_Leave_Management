const fs = require('fs')
const sampleData =
{
    settings: {
        
        "projectNumber": 1234, // this field should be a number
        "calendarID": "string"
    },
    // this information from your projectKey.json
    calendar: {
       
    },
    env: "PORT=6800"


}
if (!fs.existsSync('.calendar1.json')) {
    // Do something
    fs.writeFileSync('.calendar1.json',JSON.stringify( sampleData.calendar), { encoding: 'utf-8' })

}
if (!fs.existsSync('.env')) {
    // Do something
    fs.writeFileSync('.env','PORT=6800', { encoding: 'utf-8' })

}
if (!fs.existsSync('.settings1.json')) {
    fs.writeFileSync('.settings1.json', JSON.stringify(sampleData.settings), { encoding: 'utf-8' })
}
console.log(fs.readFileSync('.settings.json', { encoding: 'utf-8' }))
console.log(fs.readFileSync('.calendar.json', { encoding: 'utf-8' }))