
let txtBaseURL = "#baseURL";
let PageSize = "#ddlPageSize";
let PaginationNum = "#ulPagination";

$(document).ready(function () {

    BaseURL = $(txtBaseURL).val();

    GetAll_Announcement_Event_Data(1);

    $(PageSize).change(function () {
        GetAll_Announcement_Event_Data(1);
    });

});

function GetAll_Announcement_Event_Data(PageNumber) {

    let obj = {
        Announcement_Event_DataRequest: {
            pagesize: $(PageSize).val(),
            pagenum: PageNumber
        }
    };

    postRequest(BaseURL + "ISM_Store_HomePage_WebService.asmx/GetAll_Announcement_Event_Data", obj, function (res) {
        if (res.d.Message != "") {
            if (!res.d.Status) {
                ShowErrorAlert("Oops...", res.d.Message + " !", 'error');
            }
            else if (res.d.Status) {
                if (res.d.TableData != "") {
                    $("#tBody_Announcement_EventData").html(res.d.TableData);
                }

                if (res.d.Message != "") {
                    $("#dataTable_Record_info").text(res.d.Message);
                }

                if (res.d.Pagination != "") {
                    $(PaginationNum).html(res.d.Pagination);
                }
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