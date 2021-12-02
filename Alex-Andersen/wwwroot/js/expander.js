// expander

document.querySelectorAll("expanderButton").forEach(button => {
    button.addEventListener('click', () => {
        const expander_Content = button.nextElementSibling;

        button.classList.toggle('expanderButton--active');

        if (button.classList.contains('expanderButton--active')) {
            expander_Content.style.maxHeight = expander_Content.scrollHeight + 'px';
        } else {
            expander_Content.style.maxHeight = 0;
        }
    });
});