//Install-Package Microsoft.jQuery.Unobtrusive.Ajax -Version 3.2.5 
$(function () {
    console.log("document is loaded with jquery!");
    $('#FormData').submit(function (data) {
        data.preventDefault();
        $.validator.unobtrusive.parse($('#FormData'));
        if ($('#FormData').valid())
        {
            $.ajax({
                type: 'POST',
                url: "Home/Create",
                data: $('#FormData').serialize(),
                success: function (response) {
                    console.log("success");
                    console.log(response);
                    $('#FormData')[0].reset();
                },
                error: function (response) {
                    console.log("error");
                    console.log(response);
                }
            });
        }
        return false;
    });
});
















