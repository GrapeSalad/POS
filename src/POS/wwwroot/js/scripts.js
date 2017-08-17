$(document).ready(function () {
    $('.addTableForm').click(function () {
        $.ajax({
            type: 'GET',
            url: '/Sales/AddTableForm',
            success: function (result) {
                var divToShow = $(result).find('.form').html();
                $('#addTableResult').html(divToShow);
            }
        });
    });
    $('.table').submit(function (event) {
        event.preventDefault;
        $.ajax({
            url: '/Sales/AddTable',
            type: 'POST',
            dataType: 'json',
            data: $(this).serialize(),
            success: function (result) {
                var resultMessage = "Success dood";
                $('#successMessage').html(resultMessage);
            }
        })
    })
});