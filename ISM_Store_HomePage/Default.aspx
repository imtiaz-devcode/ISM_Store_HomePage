<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ISM_Store_HomePage.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no" />
    <title>Imtiaz Home Page</title>
    <link rel="icon" href="assets/img/favicon/favicon.png" />
    <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=ABeeZee&amp;display=swap" />
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Abel&amp;display=swap" />
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Abhaya+Libre&amp;display=swap" />
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Aboreto&amp;display=swap" />
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Akronim&amp;display=swap" />
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Alatsi&amp;display=swap" />
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Alkalami&amp;display=swap" />
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Anybody&amp;display=swap" />
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Asul&amp;display=swap" />
    <link rel="stylesheet" href="assets/fonts/fontawesome-all.min.css" />
    <link rel="stylesheet" href="assets/css/animate.min.css" />
    <link rel="stylesheet" href="assets/css/Side-By-Side-Section-sideBySide.css" />
    <link rel="stylesheet" href="assets/css/-Filterable-Gallery-with-Lightbox-BS4--Filterable-Gallery.css" />
    <link rel="stylesheet" href="assets/css/Auto-Modal-Popup.css" />
    <link rel="stylesheet" href="assets/css/Background-motion1-Button-Outlines---Pretty.css" />
    <link rel="stylesheet" href="assets/css/Background-motion1-untitled.css" />
    <link rel="stylesheet" href="assets/css/Boostrap-Tabs.css" />
    <link rel="stylesheet" href="assets/css/Btn-Switch-Element-styles.css" />
    <link rel="stylesheet" href="assets/css/Btn-Switch-Element.css" />
    <link rel="stylesheet" href="assets/css/gradient-navbar-styles.css" />
    <link rel="stylesheet" href="assets/css/gradient-navbar.css" />
    <link rel="stylesheet" href="assets/css/Hover-Button-1.css" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/@fancyapps/ui@4.0/dist/fancybox.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/lightbox2/2.8.2/css/lightbox.min.css" />
    <link rel="stylesheet" href="assets/css/Media-Slider-Bootstrap-3-media.slider.css" />
    <link rel="stylesheet" href="assets/css/Media-Slider-Bootstrap-3.css" />
    <link rel="stylesheet" href="assets/css/Parallax-Scroll-Effect-Parallax-Scroll-Effect.css" />
    <link rel="stylesheet" href="assets/css/pointer.css" />
    <link rel="stylesheet" href="assets/css/Responsive-UI-Card.css" />
    <link rel="stylesheet" href="assets/css/Scrollspy.css" />
    <link rel="stylesheet" href="assets/css/Video-Responsive.css" />
    <link rel="stylesheet" href="assets/css/Video-Tooltip-Button.css" />

    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/bootstrap/js/bootstrap.min.js"></script>
    <script src="assets/js/bs-init.js"></script>
    <script src="assets/js/-Filterable-Gallery-with-Lightbox-BS4-.js"></script>
    <script src="assets/js/Auto-Modal-Popup.js"></script>
    <script src="assets/js/Bootstrap-4-jQuery-LIGHTBOX.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@fancyapps/ui@4.0/dist/fancybox.umd.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/lightbox2/2.8.2/js/lightbox.min.js"></script>
    <script src="assets/js/Media-Slider-Bootstrap-3.js"></script>
    <script src="assets/js/Video-Tooltip-Button.js"></script>

    <script type="text/javascript">
        $(document).ready(function () {

            $("#itmEsite").mouseleave(function () {

                if ($("#dvESite").hasClass("show")) {
                    $("#dvESite").removeClass("show");
                    $("#dvESite").removeAttr("style");
                }

            });

            $("#itmHRService").mouseleave(function () {

                if ($("#dvHRService").hasClass("show")) {
                    $("#dvHRService").removeClass("show");
                    $("#dvHRService").removeAttr("style");
                }

            });

            $("#itmITService").mouseleave(function () {

                if ($("#dvITService").hasClass("show")) {
                    $("#dvITService").removeClass("show");
                    $("#dvITService").removeAttr("style");
                }

            });

            $("#itmITService2").mouseleave(function () {

                if ($("#dvITService2").hasClass("show")) {
                    $("#dvITService2").removeClass("show");
                    $("#dvITService2").removeAttr("style");
                }

            });

        });
    </script>


</head>

<body style="background: var(--bs-link-color);">
    <div class="container-fluid mb-3" style="background: linear-gradient(rgb(5,35,79) 8%, var(--bs-blue) 100%), linear-gradient(rgba(255,110,5,0.98), #f49b09); height: 100vh; position: relative;">
        <div class="row g-0">
            <div class="col-2">
                <img class="img-fluid" src="assets/img/Logo/Logo.png" style="transform: scale(1.21);" />
            </div>
            <div class="col offset-xxl-1">
                <ul class="nav nav-tabs text-end d-xl-flex justify-content-xl-end align-items-xl-center mt-4 me-5" style="border-width: 0px; padding: 2px; font-size: 20px;">
                    <li class="nav-item" id="itmCurrentPromotion"><a class="nav-link" data-bss-hover-animate="pulse" href="#" style="color: var(--bs-yellow);">Current Promotions&nbsp;</a></li>
                    <li class="nav-item"></li>
                    <li class="nav-item"></li>
                    <li class="nav-item" id="itmEsite" style="color: var(--bs-nav-tabs-link-active-bg); margin-left: 0px; margin-right: 15px;">
                        <div class="nav-item dropdown border-1 border-success shadow" style="width: 98.219px;">
                            <button class="btn btn-primary dropdown-toggle d-xl-flex align-items-xl-center ms-2 me-4" aria-expanded="false" data-bs-toggle="dropdown" data-bs-auto-close="false" type="button" style="padding-right: 6px; padding-left: 10px; background: var(--bs-link-hover-color); border-width: 0px; border-color: var(--bs-nav-link-disabled-color);">E - Sites&nbsp;</button>
                            <div id="dvESite" runat="server" class="dropdown-menu" style="border-top-left-radius: 6px; border-top-right-radius: 6px; margin-top: 3px;">
                            </div>
                        </div>
                    </li>
                    <li class="nav-item" id="itmHRService" style="color: var(--bs-nav-tabs-link-active-bg); margin-left: 0px; margin-right: 15px;">
                        <div class="nav-item dropdown border-1 border-success shadow" style="width: 119.219px;">
                            <button class="btn btn-primary active dropdown-toggle d-xl-flex align-items-xl-center ms-2 me-4" aria-expanded="false" data-bs-toggle="dropdown" data-bs-auto-close="false" type="button" style="padding-right: 6px; padding-left: 10px; background: var(--bs-link-hover-color); border-width: 0px; border-color: var(--bs-nav-link-disabled-color); height: 35px;">HR Services&nbsp;</button>
                            <div id="dvHRService" runat="server" class="dropdown-menu" style="border-top-left-radius: 6px; border-top-right-radius: 6px; margin-top: 3px;">
                            </div>
                        </div>
                    </li>
                    <li class="nav-item" id="itmITService" style="color: var(--bs-nav-tabs-link-active-bg); margin-left: 0px; margin-right: 15px;">
                        <div class="nav-item dropdown border-1 border-success shadow" style="width: 119.219px;">
                            <button class="btn btn-primary dropdown-toggle ms-2 me-4" aria-expanded="false" data-bs-toggle="dropdown" data-bs-auto-close="false" type="button" style="padding-right: 9px; padding-left: 13px; background: var(--bs-link-hover-color); border-color: var(--bs-border-color-translucent);">IT Services&nbsp;</button>
                            <div id="dvITService" runat="server" class="dropdown-menu" style="border-top-left-radius: 6px; border-top-right-radius: 6px; margin-top: 3px;">
                            </div>
                        </div>
                    </li>

                    <li class="nav-item" id="itmITService2" style="color: var(--bs-nav-tabs-link-active-bg); margin-left: 0px; margin-right: 15px;">
                        <div class="nav-item dropdown border-1 border-success shadow" style="width: 119.219px;">
                            <button class="btn btn-primary dropdown-toggle ms-2 me-4" aria-expanded="false" data-bs-toggle="dropdown" data-bs-auto-close="false" type="button" style="padding-right: 9px; padding-left: 13px; background: var(--bs-link-hover-color); border-color: var(--bs-border-color-translucent);">IT Services Reports&nbsp;</button>
                            <div id="dvITService2" runat="server" class="dropdown-menu" style="border-top-left-radius: 6px; border-top-right-radius: 6px; margin-top: 3px;">
                            </div>
                        </div>
                    </li>
                </ul>
            </div>
        </div>
        <div>
            <div class="container mb-5">
                <div class="row d-flex d-xl-flex flex-row align-items-xl-start mt-5" style="margin-top: 0px; border-color: var(--bs-nav-tabs-link-active-color);">
                    <div class="col-8 col-sm-12 col-md-12 col-lg-8" style="text-align: center;">
                        <div class="shadow" style="padding: 0px; border-radius: 9px; border: 7px solid rgba(10,88,202,0.44);">
                            <div class="video-container" style="border-radius: 9px; border-width: 3px;">
                                <video style="width: 100%" autoplay loop muted>
                                    <source src="Video/Promotional/Promotional.mp4" type="video/mp4" />
                                </video>
                            </div>
                        </div>
                    </div>
                    <div class="col-4 col-sm-12 col-md-12 col-lg-4 align-self-baseline" style="text-align: center;">
                        <div id="dvAnnouncement" runat="server" class="shadow mb-3" style="text-align: left; border-radius: 6px; padding: 8px; background: #0747a3dc; border: 0px solid rgba(12,99,227,0.9);">
                            <%--<h2 class="ps-2 pt-2 pb-2" style="color: var(--bs-yellow);background: var(--bs-link-hover-color);border-radius: 1px;text-align: center;font-size: 24px;">&nbsp;Announcement</h2>
                            <div class="row" style="position: relative;">
                                <div class="col float-end mt-1"><label class="form-label" style="color: var(--bs-white);padding: 11px;background: var(--bs-link-hover-color);border-radius: 37px;height: 45px;padding-right: 18px;padding-left: 18px;font-weight: bold;transform: scale(0.85);">From: HR</label><label class="form-label float-end" style="color: var(--bs-white);padding: 11px;background: rgba(108,117,125,0.34);border-radius: 37px;height: 45px;padding-right: 18px;padding-left: 18px;font-weight: bold;font-size: 14px;transform: scale(0.80);width: 145.422px;text-align: center;"><i class="far fa-calendar-alt" style="font-size: 16px;"></i>&nbsp; 11-6-2022</label></div>
                            </div>
                            <div class="row mt-3">
                                <div class="col">
                                    <h2 class="mt-1 ms-2" style="color: var(--bs-white);font-size: 24px;font-weight: bold;">Subject</h2>
                                    <p class="mt-2 ms-2" style="color: var(--bs-white);font-size: 14px;">Habitasse at quisque elit, imperdiet nec donec imperdiet proin. Facilisis habitasse condimentum quisque class. Ultrices felis platea suspendisse, ante duis.<br>Habitasse at quisque elit, imperdiet nec donec imperdiet proin.&nbsp;<br><br></p>
                                </div>
                            </div>--%>
                        </div>
                        <div class="shadow mb-3" style="text-align: left; border-radius: 6px; padding: 8px; background: #0747a4e1; border: 0px solid rgba(12,99,227,0.9);">
                            <h2 class="ps-2 pt-2 pb-2" style="color: var(--bs-yellow); background: rgb(10,88,202); border-radius: 1px; text-align: center; font-size: 24px;">&nbsp;Upcoming Event</h2>
                            <div class="row" style="position: relative;">
                                <div class="col-12 float-end d-xl-flex justify-content-xl-center mt-1" style="text-align: center;">
                                    <div class="accordion" role="tablist" id="accordion_1" runat="server" style="width: 407.203px;">
                                        <%--<div class="accordion-item" style="background: var(--bs-accordion-bg);">
                                            <h2 class="accordion-header" role="tab" style="background: var(--bs-accordion-active-color);"><button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#accordion-1 .item-1" aria-expanded="false" aria-controls="accordion-1 .item-1" style="text-align: center;font-weight: bold;">Futsal - 17- 11-2023&nbsp;&nbsp;</button></h2>
                                            <div class="accordion-collapse collapse item-1" role="tabpanel" data-bs-parent="#accordion-1">
                                                <div class="accordion-body">
                                                    <p class="mb-0" style="text-align: left;">Nullam id dolor id nibh ultricies vehicula ut id elit. Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus.</p>
                                                </div>
                                            </div>
                                        </div>--%>
                                        <%--<div class="accordion-item">
                                            <h2 class="accordion-header" role="tab"><button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#accordion-1 .item-2" aria-expanded="false" aria-controls="accordion-1 .item-2" style="font-weight: bold;">Event date and title</button></h2>
                                            <div class="accordion-collapse collapse item-2" role="tabpanel" data-bs-parent="#accordion-1">
                                                <div class="accordion-body">
                                                    <p class="mb-0">Nullam id dolor id nibh ultricies vehicula ut id elit. Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus.</p>
                                                </div>
                                            </div>
                                        </div>--%>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row mb-3 mt-4">
                    <div class="col">
                        <div class="text-center mt-5">
                            <div class="row mb-3">
                                <div class="col">
                                    <h2 class="p-1" style="color: #f8f9fa; background: #0000000b; border-style: solid; border-top-width: 2px; border-right-width: 0px; border-bottom-width: 2px; border-bottom-color: rgb(255,255,255); border-left-width: 0px;">More Videos</h2>
                                    <div class="accordion" role="tablist" id="accordion-2">
                                        <div class="accordion-item" style="background: var(--bs-border-color-translucent);">
                                            <h2 class="accordion-header" role="tab">
                                                <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#accordion-2 .item-1" aria-expanded="false" aria-controls="accordion-2 .item-1" style="background: var(--bs-accordion-bg); font-weight: bold;">HR</button></h2>
                                            <div class="accordion-collapse collapse item-1" role="tabpanel" data-bs-parent="#accordion-2">
                                                <div class="accordion-body">
                                                    <a href="#" data-bs-target="#modal-HR-1" data-bs-toggle="modal">
                                                        <p data-bss-hover-animate="flash" class="mb-0" style="color: var(--bs-accordion-bg); text-align: left; font-weight: bold;">Video 1</p>
                                                    </a>
                                                    <a href="#" data-bs-target="#modal-HR-2" data-bs-toggle="modal">
                                                        <p data-bss-hover-animate="flash" class="mb-0" style="color: var(--bs-accordion-bg); text-align: left; font-weight: bold;">Video 2</p>
                                                    </a>
                                                    <a href="#" data-bs-target="#modal-HR-3" data-bs-toggle="modal">
                                                        <p class="flash animated mb-0" style="color: var(--bs-accordion-bg); text-align: left; font-weight: bold;">Video 3</p>
                                                    </a>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="accordion-item" style="background: var(--bs-border-color-translucent);">
                                            <h2 class="accordion-header" role="tab">
                                                <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#accordion-2 .item-2" aria-expanded="false" aria-controls="accordion-2 .item-2" style="background: var(--bs-accordion-bg); font-weight: bold;">IT</button></h2>
                                            <div class="accordion-collapse collapse item-2" role="tabpanel" data-bs-parent="#accordion-2">
                                                <div class="accordion-body">
                                                    <a href="#" data-bs-target="#modal-IT-1" data-bs-toggle="modal">
                                                        <p data-bss-hover-animate="flash" class="mb-0" style="color: var(--bs-accordion-bg); text-align: left; font-weight: bold;">Video 1</p>
                                                    </a>
                                                    <a href="#" data-bs-target="#modal-IT-2" data-bs-toggle="modal">
                                                        <p data-bss-hover-animate="flash" class="mb-0" style="color: var(--bs-accordion-bg); text-align: left; font-weight: bold;">Video 2</p>
                                                    </a>
                                                    <a href="#" data-bs-target="#modal-IT-3" data-bs-toggle="modal">
                                                        <p class="flash animated mb-0" style="color: var(--bs-accordion-bg); text-align: left; font-weight: bold;">Video 3</p>
                                                    </a>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="accordion-item" style="background: var(--bs-border-color-translucent);">
                                            <h2 class="accordion-header" role="tab">
                                                <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#accordion-2 .item-3" aria-expanded="false" aria-controls="accordion-2 .item-3" style="background: var(--bs-accordion-bg); font-weight: bold;">Marketing</button></h2>
                                            <div class="accordion-collapse collapse item-3" role="tabpanel" data-bs-parent="#accordion-2">
                                                <div class="accordion-body">
                                                    <a href="#" data-bs-target="#modal-MRK-1" data-bs-toggle="modal">
                                                        <p data-bss-hover-animate="flash" class="mb-0" style="color: var(--bs-accordion-bg); text-align: left; font-weight: bold;">Video 1</p>
                                                    </a>
                                                    <a href="#" data-bs-target="#modal-MRK-2" data-bs-toggle="modal">
                                                        <p data-bss-hover-animate="flash" class="mb-0" style="color: var(--bs-accordion-bg); text-align: left; font-weight: bold;">Video 2</p>
                                                    </a>
                                                    <a href="#" data-bs-target="#modal-MRK-3" data-bs-toggle="modal">
                                                        <p class="flash animated mb-0" style="color: var(--bs-accordion-bg); text-align: left; font-weight: bold;">Video 3</p>
                                                    </a>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div id="dvVideoDialogboxSec">
        <div id="dvHRVideoSec">
            <div class="modal fade" role="dialog" tabindex="-1" id="modal-HR-1">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-body" style="color: var(--bs-border-color-translucent);">
                            <p>Video Description</p>
                            <div class="video-container">
                                <video style="width: 100%" autoplay loop muted>
                                    <source src="Video/HR/HR_1.mp4" type="video/mp4" />
                                </video>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <button class="btn btn-light" type="button" data-bs-dismiss="modal">Close</button>
                        </div>
                    </div>
                </div>
            </div>

            <div class="modal fade" role="dialog" tabindex="-1" id="modal-HR-2">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-body" style="color: var(--bs-border-color-translucent);">
                            <p>Video Description</p>
                            <div class="video-container">
                                <video style="width: 100%" autoplay loop muted>
                                    <source src="Video/HR/HR_2.mp4" type="video/mp4" />
                                </video>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <button class="btn btn-light" type="button" data-bs-dismiss="modal">Close</button>
                        </div>
                    </div>
                </div>
            </div>

            <div class="modal fade" role="dialog" tabindex="-1" id="modal-HR-3">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-body" style="color: var(--bs-border-color-translucent);">
                            <p>Video Description</p>
                            <div class="video-container">
                                <video style="width: 100%" autoplay loop muted>
                                    <source src="Video/HR/HR_1.mp4" type="video/mp4" />
                                </video>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <button class="btn btn-light" type="button" data-bs-dismiss="modal">Close</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div id="dvITVideoSec">
            <div class="modal fade" role="dialog" tabindex="-1" id="modal-IT-1">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-body" style="color: var(--bs-border-color-translucent);">
                            <p>Video Description</p>
                            <div class="video-container">
                                <video style="width: 100%" autoplay loop muted>
                                    <source src="Video/IT1/IT_1.mp4" type="video/mp4" />
                                </video>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <button class="btn btn-light" type="button" data-bs-dismiss="modal">Close</button>
                        </div>
                    </div>
                </div>
            </div>

            <div class="modal fade" role="dialog" tabindex="-1" id="modal-IT-2">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-body" style="color: var(--bs-border-color-translucent);">
                            <p>Video Description</p>
                            <div class="video-container">
                                <video style="width: 100%" autoplay loop muted>
                                    <source src="Video/IT1/IT_2.mp4" type="video/mp4" />
                                </video>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <button class="btn btn-light" type="button" data-bs-dismiss="modal">Close</button>
                        </div>
                    </div>
                </div>
            </div>

            <div class="modal fade" role="dialog" tabindex="-1" id="modal-IT-3">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-body" style="color: var(--bs-border-color-translucent);">
                            <p>Video Description</p>
                            <div class="video-container">
                                <video style="width: 100%" autoplay loop muted>
                                    <source src="Video/IT1/IT_2.mp4" type="video/mp4" />
                                </video>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <button class="btn btn-light" type="button" data-bs-dismiss="modal">Close</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div id="dvMRKVideoSec">
            <div class="modal fade" role="dialog" tabindex="-1" id="modal-MRK-1">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-body" style="color: var(--bs-border-color-translucent);">
                            <p>Video Description</p>
                            <div class="video-container">
                                <video style="width: 100%" autoplay loop muted>
                                    <source src="Video/Marketing/MRK_1.mp4" type="video/mp4" />
                                </video>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <button class="btn btn-light" type="button" data-bs-dismiss="modal">Close</button>
                        </div>
                    </div>
                </div>
            </div>

            <div class="modal fade" role="dialog" tabindex="-1" id="modal-MRK-2">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-body" style="color: var(--bs-border-color-translucent);">
                            <p>Video Description</p>
                            <div class="video-container">
                                <video style="width: 100%" autoplay loop muted>
                                    <source src="Video/Marketing/MRK_2.mp4" type="video/mp4" />
                                </video>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <button class="btn btn-light" type="button" data-bs-dismiss="modal">Close</button>
                        </div>
                    </div>
                </div>
            </div>

            <div class="modal fade" role="dialog" tabindex="-1" id="modal-MRK-3">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-body" style="color: var(--bs-border-color-translucent);">
                            <p>Video Description</p>
                            <div class="video-container">
                                <video style="width: 100%" autoplay loop muted>
                                    <source src="Video/Marketing/MRK_1.mp4" type="video/mp4" />
                                </video>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <button class="btn btn-light" type="button" data-bs-dismiss="modal">Close</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>


</body>

</html>
