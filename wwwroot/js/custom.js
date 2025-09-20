// Add a fade-in effect to elements with the .fade-in class

const fadeInElements = document.querySelectorAll('.fade-in');

const fadeInObserver = new IntersectionObserver((entries, observer) => {
    entries.forEach(entry => {
        if (entry.isIntersecting) {
            entry.target.classList.add('is-visible');
            observer.unobserve(entry.target);
        }
    });
});

fadeInElements.forEach(element => {
    fadeInObserver.observe(element);
});
