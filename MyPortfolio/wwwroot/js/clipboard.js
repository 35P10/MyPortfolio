window.copyToClipboard = function (text) {
    navigator.clipboard.writeText(text)
        .then(() => {
            console.log('Texto copiado al portapapeles: ', text);
        })
        .catch(err => {
            console.error('Error al copiar el texto: ', err);
        });
}
