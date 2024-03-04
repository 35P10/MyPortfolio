function scrollToSection(sectionId) {
    var section = document.getElementById(sectionId);
    var offset = 94;
    var sectionPosition = section.offsetTop - offset;
    window.scrollTo({
        top: sectionPosition,
        behavior: 'smooth'
    });
}
