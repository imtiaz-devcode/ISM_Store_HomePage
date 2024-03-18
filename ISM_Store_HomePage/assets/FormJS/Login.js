
$(document).ready(function () {

    //$("#btnsubmit").click(function () {
    //    FormValidation();
    //});

});


//function FormValidation() {
//    var Error = 0;
//    var Msg = "";

//    var UserEmail = $("#UserEmail").val();
//    var UserPassword = $("#UserPassword").val();

//    if (UserEmail == "") {
//        Error = 1;
//        Msg = "Please enter your Email address.";
//    }
//    if (UserPassword == "") {
//        Error = 1;
//        Msg = "Please enter your Password.";
//    }

//    if (Error > 0) {
//        ShowAlert("Oops...", Msg, 'error');

//        return false;
//    } else {
//        return true;
//    }
//}


function ShowAlert(title, text, icon) {
    //Success = title = 'Hurrey', text = 'Your Data is successfully submitted', icon = 'success'
    //Error = title = 'Oops...', text = 'Something went wrong!', icon = 'error'
    Swal.fire({
        title: title,
        text: text,
        icon: icon
    });
}