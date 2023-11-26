// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//*************************************************
//pageSize change start
$('.pageSizeChange').on('change', function () {
    $(".employeePageSize").submit();
});
//pageSize chnage end
//*************************************************


//*************************************************
//close modal start
$(".close").on("click", function () {
    $('.modal').modal('hide');
});

///close modal end
//*************************************************

//*************************************************
//highlight salary
$("#highlightSalary").click(function () {
    $(".salary").css("color", "#008000");
});

///highlight salary end
//*************************************************

///highlight name
//*************************************************
$("#highlightName").click(function () {
    $(".name").css("color", "#0000FF");
});
///highlight name end
//*************************************************