
$(function () {
    console.log("document is loaded with jquery!");
    $('#FormData').submit(function (data) {
        data.preventDefault();
        $.ajax({
            type: 'POST',
            url: "Home/Test",
            data: $('#FormData').serialize(),
            success: function (response) {
                console.log("success");
                console.log(response);
            },
            error: function (response) {
                console.log("error")
                console.log(response);
            }
        });
    });
});
















