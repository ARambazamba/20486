$(document).ready(function() {
    initDatePicker();
});

function initDatePicker() {

    $('#dpDate').datepicker({
        format: "dd.mm.yyyy",
        weekStart: 1,
        startDate: "01.01.2013",
        endDate: "01.01.2050",
        todayBtn: "linked",
        clearBtn: true,
        calendarWeeks: true,
        autoclose: true,
        toggleActive: true
    });
    $('#dpDate').datepicker('setStartDate');
}

function setDetail(id) {
    var vds = data.Details.filter(function (el) {
        return el.ID == id;
    });

    if (vds.length > 0) {
        $("#txtDetailsID").val(vds[0].ID);
        $("#txtDetailsText").val(vds[0].Text);
        $("#txtDetailsAmount").val(vds[0].Amount);
        $("#ddAccount").val(vds[0].Account.ID);
        $("#txtComment").val(vds[0].Comment);
    }
}

function newDetail() {
    $("#txtDetailsID").val(0);
    $("#txtDetailsText").val("");
    $("#txtDetailsAmount").val("");
    $("#ddAccount").val("");
    $("#txtComment").val("");
}