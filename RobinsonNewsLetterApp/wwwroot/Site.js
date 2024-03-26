document.addEventListener('DOMContentLoaded', function () {
    var select = document.getElementById('rubrique-select');

    select.onfocus = function () {
        select.style.borderColor = '#34f458'; // Green border on focus
    };

    select.onblur = function () {
        select.style.borderColor = '#007bff'; // Back to blue on blur
    };
});