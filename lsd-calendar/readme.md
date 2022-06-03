# Google Calendar API

## Prerequisites

To run this app please make sure you have the following modules installed on your machine.

1. Nodejs v14+
2. yarn or npm (yarn prefered)
3. pm2 - optional if you will not run this API in a production environment
   
## How to run the API

1. navigate to the root folder of the API then run  `yarn` or `npm install`
2. run yarn init to initialize required files (.calendar.json, .settings.json )for the app to run. make sure to fill in all required fields in the generated files
3. Replace content inside `.calendar.js` with your `CLIENT_KEY.json` file downloded from google cloud console.
4. replace all values inside `.settings.json` file
   

## Asample Post data 
    POST http://localhost:6900/create
    {
            "summary": "Leave Request for Employee - [Employee Name]",
            "location": "Johannesburg,South Africa",
            "description": "Leave Request from - [Employee Name]!",
            "start": {
            "dateTime": "2022-09-12T09:00:00-07:00",
            "timeZone": "Africa/Johannesburg"
        },
            "end": {
            "dateTime": "2023-09-14T17:00:00-07:00",
            "timeZone": "Africa/Johannesburg"
        }
    }
