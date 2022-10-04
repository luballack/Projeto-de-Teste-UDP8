$(document).ready(function () {
    $('#myTable').DataTable({
        "scrollY": "450px",
        "scrollCollapse": true,
        fixedHeader: {
            header: false,
            footer: true
        },
        "paging": true,
        language: {
            url: '//cdn.datatables.net/plug-ins/1.12.1/i18n/pt-BR.json'
        },
        "columnDefs": [{
            "targets": [6,7],
            "orderable": false
        }]
    });
})

$(function () {
    $('[type="date"]').prop('max', function () {
        return new Date().toJSON().split('T')[0];
    });
});
