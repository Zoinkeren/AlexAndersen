// expander

document.querySelectorAll('.accordionButton').forEach(button => {
    button.addEventListener('click', () => {
        const expander_Content = button.nextElementSibling;

        button.classList.toggle('accordionButton--active');

        if (button.classList.contains('accordionButton--active')) {
            expander_Content.style.maxHeight = expander_Content.scrollHeight + 'px';
        } else {
            expander_Content.style.maxHeight = 0;
        }
    });
});