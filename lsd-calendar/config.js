const fs = require('fs')
const { google } = require('googleapis');


const createEvent = async (resource) => {
    const { gCalender, calendarId } = config()
    const sampled = await gCalender.events.insert({
        calendarId,
        resource
    })
    const statusCode = sampled.status;
    return {
        statusCode,
        success: statusCode === 200 ? true : false,
        state: sampled.statusText, message: statusCode === 200 ?
            `Calendar event for employee has been Created` :
            "Could not create such an event"
    };
}
const getCalendarEvent = async () => {
    const { calendarId, gCalender } = config()
    const data = await gCalender.events.list({
        calendarId,
        timeMin: (new Date()).toISOString(),
        maxResults: 10,
        singleEvents: true,
        orderBy: 'startTime'
    })
    return {
        message: 'Data fetched', success: data.status === 200 ? true : false,
        response: data.data, status: { status: data.statusText, statusCode: data.status }
    }

}


/**
 * Configure Google calendar Authorization
 * @returns gCalender, authorizer, calendarId
 */
const config = () => {
    // Read credentials files
    const keyfile = fs.readFileSync('.calendar.json', { encoding: 'utf-8' })
    const settings = JSON.parse(fs.readFileSync('.settings.json', { encoding: 'utf-8' }))
    const clientEmail = JSON.parse(keyfile).CLIENT_EMAIL
    const authJWT = new google.auth.JWT(
        clientEmail,
        '.calendar.json',
        null,
        'https://www.googleapis.com/auth/calendar',


    )
    // initiate google calendar 
    const gCalender = new google.calendar({
        version: 'v3', project: settings.projectNumber, auth: authJWT

    })

    // Set Google Authorization
    const authorizer = new google.auth.GoogleAuth({
        key: keyfile,
        scopes: 'https://www.googleapis.com/auth/calendar',
    })
    // Set CalendarId
    const calendarId = settings.calendarID
    return { gCalender, authorizer, calendarId }
}


module.exports = { getCalendarEvent, createEvent }