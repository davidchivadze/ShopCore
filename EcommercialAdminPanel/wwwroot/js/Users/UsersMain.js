function EditUser(id) {
    $.ajax({
        url: '/Users/GetUser',
        data: { userID: id },
        type: 'Get',
        success: function (result) {
            console.log(result);
            $('#UserID').val(result.id);
            $('#FirstName').val(result.firstName);
            $('#LastName').val(result.lastName);
            //$('#BirthDate').val(result.birthDate);
            document.getElementById('BirthDate').value = result.birthDate;
            $('#PIN').val(result.pin);
            $('#Address').val(result.address);
            $('#responsive-modal').modal('show');
        }
    });
}

function SaveUserChanges() {
    var data = {
        id: $('#UserID').val(),
        FirstName: $('#FirstName').val(),
        LastName: $('#LastName').val(),
        BirthDate: $('#BirthDate').val(),
        PIN: $('#PIN').val(),
        Address: $('#Address').val()
    };

    $.ajax({
        url: '/Users/UpdateUser',
        data: data,
        type: 'Post',
        success: function (result) {
            if (result.success) {
                window.location.reload();
            } else {
                alert(result.message);
            }
        }
    });
}