const connection = new signalR.HubConnectionBuilder()
    .withUrl("/emergency")
    .configureLogging(signalR.LogLevel.Trace)
    .withAutomaticReconnect([0, 10, 30, 60, 90, 150])
    .build();

async function start() {
    try {
        await connection.start();
        console.log("SignalR Connected.");
    } catch (err) {
        console.log(err);
        setTimeout(start, 5000);
    }
};

connection.onclose(async () => {
    await start();
});
//BUTTONS

//FROM HUB TO CLIENT [EVENTS]


// Start the connection.
start();


//FROM CLIENT TO HUB
