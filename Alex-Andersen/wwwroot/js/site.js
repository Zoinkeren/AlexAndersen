﻿//overlay: request trip button (in trips)
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


