
$(function () {
    // Handler for .ready() called.


    console.log("document is loaded with jquery!");

    $('#FormData').submit(function (data) {
        data.preventDefault();
        $.ajax({
            type: 'POST',
            url: data.action,
            data: $('#FormData').serialize(),
            success: function (response) {
                console.log("success");
                console.log(response);
            },
            error: function (response) {
                console.log(response);
            }

        });


    });


});
















