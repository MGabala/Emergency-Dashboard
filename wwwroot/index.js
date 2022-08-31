const connection = new signalR.HubConnectionBuilder()
    .withUrl("/emergency")
    .configureLogging(signalR.LogLevel.Debug)
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

//PAGE ELEMENTS
var counter = document.getElementById("viewCounter");
var st = document.getElementById("teststat");

//FROM HUB TO CLIENT [EVENTS]
connection.on("ViewCountUpdate", (viewCount) => {
    counter.innerHTML = viewCount;
});

connection.on("ChangeStateTest", (value) => {
    st.innerText = value.toString();
});


// Start the connection.
start();


//FROM CLIENT TO HUB
