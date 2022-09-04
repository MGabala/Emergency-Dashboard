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
var reportstate = document.getElementById("testreportstate");
var page = document.getElementById("main");

//FROM HUB TO CLIENT [EVENTS]
connection.on("ViewCountUpdate", (viewCount) => {
    counter.innerHTML = viewCount;
});

connection.on("changeAgencyState", (idRow, id, value) => {
    console.log("testy");
  
    document.getElementById(id + "-stat").style.color = "red";
    document.getElementById(idRow + "-liveCadSingleRow").style.backgroundColor = "green";
    document.getElementById(idRow + "-liveCadSingleRow").style.color = "black";
    document.getElementById(id + "-stat").innerText = value;
});

connection.on("changeReportState", (value) => {
    reportstate.innerText = value.toString();
});

// Start the connection.
start();


//FROM CLIENT TO HUB
