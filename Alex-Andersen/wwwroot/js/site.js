//overlay: request trip button (in trips)
//POP-UPS//

//Request trip POP-UP

document.querySelectorAll('.registrerTripButton').forEach(button => {

    button.addEventListener('click', function () {

        document.querySelector('.popUpTripRequest').style.display = "block";
    });
})

document.querySelectorAll('.popUpClose, .popUpTripRequest').forEach(button => {

    button.addEventListener('click', function () {

        document.querySelector('.popUpTripRequest').style.display = "none";
    });
})

//´Cancel trip POP-UP

document.querySelectorAll('.cancelTripButton').forEach(button => {

    button.addEventListener('click', function () {

        document.querySelector('.popUpCancelTrip').style.display = "block";
    });
})

document.querySelectorAll('.popUpClose, .popUpCancelTrip').forEach(button => {

    button.addEventListener('click', function () {

        document.querySelector('.popUpCancelTrip').style.display = "none";
    });
})

//Mail POP-UP

document.querySelectorAll('.tripMail').forEach(button => {

    button.addEventListener('click', function () {

        document.querySelector('.popUpMail').style.display = "block";
    });
});

document.querySelectorAll('.popUpClose, .popUpMail').forEach(button => {

    button.addEventListener('click', function () {

        document.querySelector('.popUpMail').style.display = "none";
    });
});

//call POP-UP

document.querySelectorAll('.tripCall').forEach(button => {

    button.addEventListener('click', function () {

        document.querySelector('.popUpCall').style.display = "block";
       
    });
});

document.querySelectorAll('.popUpClose, .popUpCall').forEach(button => {

    button.addEventListener('click', function () {

        document.querySelector('.popUpCall').style.display = "none";
    });
});

//Message POP-UP

document.querySelectorAll('.messageBox').forEach(button => {

    button.addEventListener('click', function () {

       document.querySelector('.popUpMessage').style.display = "block";
    });
});

document.querySelectorAll('.popUpClose, .popUpMessage').forEach(button => {

    button.addEventListener('click', function () {

        document.querySelector('.popUpMessage').style.display = "none";
    });
});

if (document.URL.indexOf("Index") >= 0) {
    document.querySelector(".NavButtonIndex").style.backgroundColor = "#e8f2e7";
}

if (document.URL.indexOf("Trips") >= 0) {
    document.querySelector(".NavButtonTrips").style.backgroundColor = "#e8f2e7";
}

if (document.URL.indexOf("Availability") >= 0) {
    document.querySelector(".NavButtonAvailability").style.backgroundColor = "#e8f2e7";
}

if (document.URL.indexOf("Messages") >= 0) {
    document.querySelector(".NavButtonMessages").style.backgroundColor = "#e8f2e7";
}

if (document.URL.indexOf("Profile") >= 0) {
    document.querySelector(".NavButtonProfile").style.backgroundColor = "#e8f2e7";
}