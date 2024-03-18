/*Promotional Video Related Variables*/
let VideoTitle = "#txtPromotionalVideoTitle";
let VideoDate = "#txtPromotionalVideoDate";
let VideoFile = "#txtPromotionalVideoFile";
let btnUploadVideo = "#btnUploadVideo";

/*Promotional PDF File Related Variables*/
let PDFTitle = "#txtPromotionalPDFTitle";
let PDFDate = "#txtPromotionalPDFDate";
let PDFFile = "#txtPromotionalPDFFile";
let btnUploadPDFFile = "#btnUploadPDFFile";

let CreatedBy = "#hdnUserLoginID";
let txtBaseURL = "#baseURL";

var BaseURL = "";

$(document).ready(function () {

    BaseURL = $(txtBaseURL).val();

    $(btnUploadVideo).click(function () {
        var ValidateForm = PromotionalVideoFormValidation();
        if (ValidateForm != "") {
            ShowErrorAlert("Oops...", ValidateForm + " !", 'error');
        }
        else {
            SavePromotionalVideo();
        }
    });


    $(btnUploadPDFFile).click(function () {
        var ValidateForm = PromotionalPDFFormValidation();
        if (ValidateForm != "") {
            ShowErrorAlert("Oops...", ValidateForm + " !", 'error');
        }
        else {
            SavePromotionalPDF();
        }
    });

});

function SavePromotionalVideo() {

    var formData = new FormData();
    formData.append('VideoTitle', $(VideoTitle).val());
    formData.append('VideoDate', $(VideoDate).val());
    formData.append('CreatedBy', $(CreatedBy).val());
    formData.append('VideoFile', $(VideoFile)[0].files[0]);

    postRequest_File(BaseURL + "ISM_Store_HomePage_WebService.asmx/SavePromotionalVideo", formData, function (res) {
        var xmlString = new XMLSerializer().serializeToString(res);
        var $xml = $($.parseXML(xmlString));
        var Message = $($xml[0].all[1]).text();
        var Status = $($xml[0].all[2]).text();

        if (Message != "") {
            if (Status == "false") {
                ShowErrorAlert("Oops...", Message + " !", 'error');
            }
            else if (Status == "true") {
                ShowAlert("Hurrey", Message, 'success');
            }
        }
    });
}

function SavePromotionalPDF() {

    var formData = new FormData();
    formData.append('PDFTitle', $(PDFTitle).val());
    formData.append('PDFDate', $(PDFDate).val());
    formData.append('CreatedBy', $(CreatedBy).val());
    formData.append('PDFFile', $(PDFFile)[0].files[0]);

    postRequest_File(BaseURL + "ISM_Store_HomePage_WebService.asmx/SavePromotionalPDF", formData, function (res) {
        var xmlString = new XMLSerializer().serializeToString(res);
        var $xml = $($.parseXML(xmlString));
        var Message = $($xml[0].all[1]).text();
        var Status = $($xml[0].all[2]).text();

        if (Message != "") {
            if (Status == "false") {
                ShowErrorAlert("Oops...", Message + " !", 'error');
            }
            else if (Status == "true") {
                ShowAlert("Hurrey", Message, 'success');
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

function postRequest_File(url, requestData, handledata) {
    $.ajax({
        url: url,
        type: 'POST',
        data: requestData,
        contentType: false,
        processData: false,
        success: function (data, textStatus, xhr) {
            handledata(data);
        },
        error: function (xhr, textStatus, errorThrown) {
            ShowErrorAlert("Oops...", 'Something went wrong!', 'error');
        }
    });
}


function PromotionalVideoFormValidation() {
    var txt_VideoTitle = $(VideoTitle).val();
    var txt_VideoDate = $(VideoDate).val();
    var txt_VideoFile = $(VideoFile)[0].files[0];

    error = 0;
    Msg = "";

    if (txt_VideoTitle == "") {
        error += 1;
        Msg = "Plesae Enter Video Title.";
    }
    else if (txt_VideoFile == undefined) {
        error += 1;
        Msg = "Plesae Upload Promotional Video File.";
    }
    else if (txt_VideoFile.name != "") {
        var fileExtension = txt_VideoFile.name.split('.').pop().toLowerCase();

        if (fileExtension != "mp4" && fileExtension != "mpg" && fileExtension != "mpeg") {
            error += 1;
            Msg = "Plesae Upload Promotional Video File with these Extension (mp4, mpg, mpeg).";
        }
    }

    return Msg;
}

function PromotionalPDFFormValidation() {
    var txt_PDFTitle = $(PDFTitle).val();
    var txt_PDFDate = $(PDFDate).val();
    var txt_PDFFile = $(PDFFile)[0].files[0];

    error = 0;
    Msg = "";

    if (txt_PDFTitle == "") {
        error += 1;
        Msg = "Plesae Enter PDF File Title.";
    }
    else if (txt_PDFFile == undefined) {
        error += 1;
        Msg = "Plesae Upload PDF File.";
    }
    else if (txt_PDFFile.name != "") {
        var fileExtension = txt_PDFFile.name.split('.').pop().toLowerCase();

        if (fileExtension != "pdf") {
            error += 1;
            Msg = "Plesae Upload PDF File.";
        }
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