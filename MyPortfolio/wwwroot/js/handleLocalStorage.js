function addToLocalStorage(key, value) {
    localStorage[key] = value;
}

function readLocalStorage(key) {
    return localStorage[key];
}