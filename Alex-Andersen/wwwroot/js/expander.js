// expander
document.querySelectorAll('.accordionButtonTrips, .accordionButtonOverview').forEach(button => {
    button.addEventListener('click', function() {

        const expander_Content = button.nextElementSibling;
        const accordionButtonTrips = document.querySelector('.accordionButtonTrips');
    



        button.classList.toggle('accordionButton--active');

        if (button.classList.contains('accordionButton--active')) {
            expander_Content.style.maxHeight = expander_Content.scrollHeight + 'px';
            accordionButtonTrips.style.borderRadius = "10px 10px 0 0";

        } else {
            expander_Content.style.maxHeight = 0;
            accordionButtonTrips.style.borderRadius = null;
            accordionButtonOverview.style.borderRadius = null;
        }


        //arrow up and down motion
        if (button.classList.contains('accordionButton--active')) {
            var t = this.children;
            e = t[2];
            e = e.children;
            e[0].style.transform = "rotate(180deg)";
        }
        else {
            e[0].style.transform = "rotate(0deg)";
        }
    });
});


