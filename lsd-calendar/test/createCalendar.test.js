const {createEvent} = require("../config")

test("Create An Event", async () => {
    const events = {
        "summary": "Leave Request for Employee",
        "location": "Johannesburg,South Africa",
        "description": "Leave Requested !",
        "start": {
          "dateTime": "2022-09-12T09:00:00-07:00",
          "timeZone": "Africa/Johannesburg",
        },
        "end": {
          "dateTime": "2023-09-14T17:00:00-07:00",
          "timeZone": "Africa/Johannesburg",
        },
    }
    const data = await createEvent(events)
    expect(data.success).toBe(true)
})
