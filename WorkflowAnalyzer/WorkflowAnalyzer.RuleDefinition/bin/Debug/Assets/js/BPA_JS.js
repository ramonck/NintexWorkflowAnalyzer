
$(document).ready(function () {
    $('.Name', '.PassedCheck').click(function () {
        $('.Parameters', '.PassedCheck').toggle("show");
        $('.Url', '.PassedCheck').toggle("show");
        $('.Description', '.PassedCheck').toggle("show");
    });

    $('.Name', '.FailedCheck').click(function () {
        $('.Parameters', '.FailedCheck').toggle("hide");
        $('.Url', '.FailedCheck').toggle("show");
        $('.Description', '.FailedCheck').toggle("show");
    });
});