var interval;
document.getElementById("frmTime").addEventListener("submit", function (e) {
    e.preventDefault();
    interval =
        setInterval(
            startTimer
        , 1000);
   
    return false;
});

function startTimer() {
    fetch('https://localhost:44354/api/CountdownModels/' + document.getElementById('number').value)
        .then(response => {
            response.json().then(function (response) {
                if (response.time >= 0) { document.getElementById("timeMissing").innerText = response.time;}
                console.log(response.time);
                if (response.time == 0) {
                    endTimer();
                }
            });
        })
        .then(data => console.log(data));
}

function endTimer() {
    clearInterval(interval);
}