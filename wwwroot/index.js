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
var agencystate = document.getElementById("teststat");
var reportstate = document.getElementById("testreportstate");
var page = document.getElementById("main");
var test1 = document.getElementById("test1");
var test2 = document.getElementById("test2");
var test3 = document.getElementById("test3");
var test4 = document.getElementById("test4");
var test5 = document.getElementById("test5");
var test6 = document.getElementById("test6");
var test7 = document.getElementById("test7");
var test8 = document.getElementById("test8");
var test9 = document.getElementById("test9");
var test10 = document.getElementById("test10");
var test11 = document.getElementById("test11");
var test12 = document.getElementById("test12");

//FROM HUB TO CLIENT [EVENTS]
connection.on("ViewCountUpdate", (viewCount) => {
    counter.innerHTML = viewCount;
});

connection.on("changeAgencyState", (id, value) => {
    const tr = document.getElementById(id.value + "-tr");
   tr.
    agencystate.innerText = value.toString();
});

connection.on("changeFirst", (value) => {
    test1.innerText = value.toString();
});
connection.on("changeSecond", (value) => {
    test2.innerText = value.toString();
});
connection.on("changeThird", (value) => {
    test3.innerText = value.toString();
});
connection.on("changeFourth", (value) => {
    test4.innerText = value.toString();
});
connection.on("changeFifth", (value) => {
    test5.innerText = value.toString();
});
connection.on("changeSixth", (value) => {
    test6.innerText = value.toString();
});
connection.on("changeSeventh", (value) => {
    test7.innerText = value.toString();
});
connection.on("changeEight", (value) => {
    test8.innerText = value.toString();
});
connection.on("changeNinth", (value) => {
    test9.innerText = value.toString();
});
connection.on("changeTenth", (value) => {
    test10.innerText = value.toString();
});
connection.on("changeEleventh", (value) => {
    test11.innerText = value.toString();
});
connection.on("changeTwelth", (value) => {
    test12.innerText = value.toString();
});



connection.on("changeReportState", (value) => {
    reportstate.innerText = value.toString();
});




// Start the connection.
start();


//FROM CLIENT TO HUB
