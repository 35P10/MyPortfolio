function getElementSize(id) {
    var elemento = document.getElementById(id);
    var ancho = elemento.offsetWidth;
    var alto = elemento.offsetHeight;
    return { ancho: ancho, alto: alto };
}