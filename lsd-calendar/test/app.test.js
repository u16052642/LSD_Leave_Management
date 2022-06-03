const {getCalendarEvent} = require("../config")

test("Fetch Calendar events to return no error", async ()=>{
    const cale = await getCalendarEvent()
    expect(cale.success).toBe(true)
});
