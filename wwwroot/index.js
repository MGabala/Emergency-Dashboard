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

connection.on("changeAgencyState", (idRow, id, color,value) => {
    console.log("testy");
    document.getElementById(idRow + "-liveCadSingleRow").style.backgroundColor = color.toString();
    document.getElementById(idRow + "-liveCadSingleRow").style.color = "black";
    document.getElementById(id + "-stat").innerText = value;
});

connection.on("changeReportState", (value) => {
    reportstate.innerText = value.toString();
});

connection.on("updateReportTable", (name, address, city, type, date, status) => {
    var table = document.getElementById("reportTable");
    var row = table.insertRow(0);
    var cell1 = row.insertCell(0);
    var cell2 = row.insertCell(1);
    var cell3 = row.insertCell(2);
    var cell4 = row.insertCell(3);
    var cell5 = row.insertCell(4);
    var cell6 = row.insertCell(5);
    cell1.innerHTML = name.toString();
    cell2.innerHTML = address.toString();
    cell3.innerHTML = city.toString();
    cell4.innerHTML = type.toString();
    cell5.innerHTML = date.toString();
    cell6.innerHTML = status.toString();
})

// Start the connection.
start();


//FROM CLIENT TO HUB
