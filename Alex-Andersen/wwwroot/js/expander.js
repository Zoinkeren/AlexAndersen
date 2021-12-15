// expander
document.querySelectorAll('.accordionButtonTrips, .accordionButtonOverview').forEach(button => {
    button.addEventListener('click', function() {

        const expander_Content = button.nextElementSibling;

        button.classList.toggle('accordionButton--active');

        if (button.classList.contains('accordionButton--active')) {
            expander_Content.style.maxHeight = expander_Content.scrollHeight + 'px';
        } else {
            expander_Content.style.maxHeight = 0;
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


