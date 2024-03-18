
/*Announcement Related Variables*/
let Subject = "#txtSubject";
let Body = "#txtBody";
let AnnouncementDate = "#txtAnnouncementDate";
let IsAnnouncementActive = "#ddlIsAnnouncementActive";
let btnSaveAnnouncement = "#btnSaveAnnouncement";

/*Upcoming Event Related Variables*/
let EventTitle = "#txtEventTitle";
let EventDate = "#txtEventDate";
let EventLocation = "#txtEventLocation";
let IsUpcomingEventActive = "#ddlIsUpComingEventActive";
let btnSaveEvent = "#btnSaveEvent";

let CreatedBy = "#hdnUserLoginID";
let txtBaseURL = "#baseURL";

var BaseURL = "";


$(document).ready(function () {

    BaseURL = $(txtBaseURL).val();

    $(btnSaveAnnouncement).click(function () {
        var ValidateForm = AnnouncementFormValidation();
        if (ValidateForm != "") {
            ShowErrorAlert("Oops...", ValidateForm + " !", 'error');
        }
        else {
            SaveAnnouncement();
        }
    });


    $(btnSaveEvent).click(function () {
        var ValidateForm = UpComingEventFormValidation();
        if (ValidateForm != "") {
            ShowErrorAlert("Oops...", ValidateForm + " !", 'error');
        }
        else {
            SaveUpComingEvent();
        }
    });

});

function SaveAnnouncement() {

    let obj = {
        announcementRequest:
        {
            Subject: $(Subject).val(),
            Body: $(Body).val(),
            AnnouncementDate: $(AnnouncementDate).val(),
            IsActive: $(IsAnnouncementActive).val(),
            CreatedBy: $(CreatedBy).val()
        }
    };

    postRequest(BaseURL + "ISM_HomePage_WebService.asmx/SaveAnnouncement", obj, function (res) {
        if (res.d.Message != "") {
            if (!res.d.Status) {
                ShowErrorAlert("Oops...", res.d.Message + " !", 'error');
            }
            else if (res.d.Status) {
                ShowAlert("Hurrey", res.d.Message, 'success');
            }
        }
    });
}

function SaveUpComingEvent() {

    let obj = {
        upcommingEventRequest: {
            EventTitle: $(EventTitle).val(),
            EventLocation: $(EventLocation).val(),
            EventDate: $(EventDate).val(),
            IsActive: $(IsUpcomingEventActive).val(),
            CreatedBy: $(CreatedBy).val()
        }
    };

    postRequest(BaseURL + "ISM_HomePage_WebService.asmx/SaveUpcomingEvent", obj, function (res) {
        if (res.d.Message != "") {
            if (!res.d.Status) {
                ShowErrorAlert("Oops...", res.d.Message + " !", 'error');
            }
            else if (res.d.Status) {
                ShowAlert("Hurrey", res.d.Message, 'success');
            }
        }
    });
}

function postRequest(url, requestData, handledata) {
    $.ajax({
        type: 'POST',
        contentType: 'application/json;charset=utf-8',
        dataType: "json",
        url: url,
        data: JSON.stringify(requestData),
        success: function (data, textStatus, xhr) {
            handledata(data);
        },
        error: function (xhr, textStatus, errorThrown) {
            ShowErrorAlert("Oops...", 'Something went wrong!', 'error');
        }
    });
}


function AnnouncementFormValidation() {
    var txt_Subject = $(Subject).val();
    var txt_Body = $(Body).val();
    var txt_AnnouncementDate = $(AnnouncementDate).val();

    error = 0;
    Msg = "";

    if (txt_Subject == "") {
        error += 1;
        Msg = "Plesae Enter Announcement Subject.";
    }
    else if (txt_Body == "") {
        error += 1;
        Msg = "Plesae Enter Announcement Message.";
    }

    return Msg;
}


function UpComingEventFormValidation() {
    var txt_EventTitle = $(EventTitle).val();
    var txt_EventLocation = $(EventLocation).val();
    var txt_EventDate = $(EventDate).val();

    error = 0;
    Msg = "";

    if (txt_EventTitle == "") {
        error += 1;
        Msg = "Plesae Enter Event Title.";
    }
    else if (txt_EventLocation == "") {
        error += 1;
        Msg = "Plesae Enter Event Description.";
    }

    return Msg;
}

function ShowErrorAlert(title, text, icon) {
    //Success = title = 'Hurrey', text = 'Your Data is successfully submitted', icon = 'success'
    //Error = title = 'Oops...', text = 'Something went wrong!', icon = 'error'
    Swal.fire({
        title: title,
        text: text,
        icon: icon
    });
}


function ShowAlert(title, text, icon) {
    //Success = title = 'Hurrey', text = 'Your Data is successfully submitted', icon = 'success'
    //Error = title = 'Oops...', text = 'Something went wrong!', icon = 'error'
    Swal.fire({
        title: title,
        text: text,
        icon: icon,
        confirmButtonText: "Ok"
    }).then((result) => {
        if (result.isConfirmed) {
            window.location.href = BaseURL + "Default.aspx";
        }
    });
}
