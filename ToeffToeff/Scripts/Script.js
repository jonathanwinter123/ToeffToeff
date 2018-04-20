function Countdown() {
    var element = document.getElementById("countdown");
    var seconds = 5;

    setInterval(function () {
            if (seconds <= 0) {
                redirect("/Home/Index");              
            } else {
                seconds--;  
            }

            element.textContent = seconds;

        },
        1000);
}

function redirect(destination) {
    window.location.href = destination;
}