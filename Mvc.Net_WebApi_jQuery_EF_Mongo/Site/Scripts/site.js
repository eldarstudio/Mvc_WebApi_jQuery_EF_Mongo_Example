


$('#addUserBtn').click(function () {

    if ($('form').valid()) {

    var user = {
        firstName: $('#FirstName').val(),
        lastName: $('#LastName').val(),
        email: $('#Email').val(),

        }
        $('.loader').show();
        $(this).hide();
        $.post('/api/data/addUser', user, function (res) {
            $(".alert-success").show();
            $(".alert-success").fadeTo(2000, 500).slideUp(500, function () {
                $(".alert-success").slideUp(500);
            });
            $('.loader').hide()
            $('#addUserBtn').show();
        }), function (res) {
            $(".alert-danger").hide();
            $(".alert-danger").fadeTo(2000, 500).slideUp(500, function () {
                $(".alert-danger").slideUp(500);
            });
            $('#addUserBtn').show();
            $('.loader').hide()
            }
    }
    return false;
});




