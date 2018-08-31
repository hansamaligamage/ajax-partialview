
$(function () {
    GetStudents();
});


$('#btnSearch').on('click', function (e) {
    var filters = {
        student: $('#student').val(),
        courseId: $('#course').val()
    };
    GetStudents(filters);
});

function GetStudents(filters) {
    $.ajax({
        url: '/Home/Students',
        type: 'POST',
        cache: false,
        async: true,
        dataType: "html",
        data : filters
    })
        .done(function (result) {
            $('#students').html(result);
        }).fail(function (xhr) {
            console.log('error : ' + xhr.status + ' - '
            + xhr.statusText + ' - ' + xhr.responseText);
        });
}