<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MKTIndex.aspx.cs" Inherits="ISM_HomePage.MKTIndex" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <script src="assets/FormJS/MKTIndex.js"></script>

    <div class="container-fluid">
        <div class="d-sm-flex justify-content-between align-items-center mb-4" style="font-family: Poppins, sans-serif; font-weight: bold; color: var(--bs-link-hover-color);">
            <h3 class="mb-0" style="color: var(--bs-link-color); font-weight: bold;">Marketing</h3>
        </div>
        <div class="row">
            <div class="col-md-6 col-xl-3 mb-4">
                <a data-bs-target="#modal-2" data-bs-toggle="modal" style="color: var(--bs-yellow);">
                    <div class="card shadow border-start-primary py-2" data-bs-toggle="tooltip" data-bss-tooltip="" data-bss-hover-animate="pulse" style="background: radial-gradient(#6486ea 0%, #4e73df 100%), #f88916;" title="Upload Announcement">
                        <div class="card-body" data-bss-hover-animate="pulse">
                            <div class="row align-items-center no-gutters">
                                <div class="col me-2">
                                    <div class="text-uppercase text-primary fw-bold text-xs mb-2"><span style="border-top-color: var(--bs-card-bg); color: var(--bs-card-bg);">Imtiaz Home Page</span></div>
                                    <div class="text-dark fw-bold h5 mb-0">
                                        <span style="font-family: Poppins, sans-serif; font-size: 18px;">
                                            <svg xmlns="http://www.w3.org/2000/svg" width="1em" height="1em" fill="currentColor" viewBox="0 0 16 16" class="bi bi-arrow-up border rounded-circle shadow-lg swing animated" style="font-size: 18px; padding: 5px; background: var(--bs-card-bg); width: 26px; height: 26px; border-radius: 4px; color: var(--bs-link-hover-color); border-width: 12px; font-weight: bold; transform: scale(1);">
                                                <path fill-rule="evenodd" d="M8 15a.5.5 0 0 0 .5-.5V2.707l3.146 3.147a.5.5 0 0 0 .708-.708l-4-4a.5.5 0 0 0-.708 0l-4 4a.5.5 0 1 0 .708.708L7.5 2.707V14.5a.5.5 0 0 0 .5.5z"></path>
                                            </svg>&nbsp;&nbsp;<span style="color: var(--bs-gray-100);">Current Promotion</span></span>
                                    </div>
                                </div>
                                <div class="col-auto">
                                    <svg xmlns="http://www.w3.org/2000/svg" width="1em" height="1em" fill="currentColor" viewBox="0 0 16 16" class="bi bi-file-pdf fa-2x" style="color: #96adef; transform: scale(1.15);">
                                        <path d="M4 0a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h8a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2H4zm0 1h8a1 1 0 0 1 1 1v12a1 1 0 0 1-1 1H4a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1z"></path>
                                        <path d="M4.603 12.087a.81.81 0 0 1-.438-.42c-.195-.388-.13-.776.08-1.102.198-.307.526-.568.897-.787a7.68 7.68 0 0 1 1.482-.645 19.701 19.701 0 0 0 1.062-2.227 7.269 7.269 0 0 1-.43-1.295c-.086-.4-.119-.796-.046-1.136.075-.354.274-.672.65-.823.192-.077.4-.12.602-.077a.7.7 0 0 1 .477.365c.088.164.12.356.127.538.007.187-.012.395-.047.614-.084.51-.27 1.134-.52 1.794a10.954 10.954 0 0 0 .98 1.686 5.753 5.753 0 0 1 1.334.05c.364.065.734.195.96.465.12.144.193.32.2.518.007.192-.047.382-.138.563a1.04 1.04 0 0 1-.354.416.856.856 0 0 1-.51.138c-.331-.014-.654-.196-.933-.417a5.716 5.716 0 0 1-.911-.95 11.642 11.642 0 0 0-1.997.406 11.311 11.311 0 0 1-1.021 1.51c-.29.35-.608.655-.926.787a.793.793 0 0 1-.58.029zm1.379-1.901c-.166.076-.32.156-.459.238-.328.194-.541.383-.647.547-.094.145-.096.25-.04.361.01.022.02.036.026.044a.27.27 0 0 0 .035-.012c.137-.056.355-.235.635-.572a8.18 8.18 0 0 0 .45-.606zm1.64-1.33a12.647 12.647 0 0 1 1.01-.193 11.666 11.666 0 0 1-.51-.858 20.741 20.741 0 0 1-.5 1.05zm2.446.45c.15.162.296.3.435.41.24.19.407.253.498.256a.107.107 0 0 0 .07-.015.307.307 0 0 0 .094-.125.436.436 0 0 0 .059-.2.095.095 0 0 0-.026-.063c-.052-.062-.2-.152-.518-.209a3.881 3.881 0 0 0-.612-.053zM8.078 5.8a6.7 6.7 0 0 0 .2-.828c.031-.188.043-.343.038-.465a.613.613 0 0 0-.032-.198.517.517 0 0 0-.145.04c-.087.035-.158.106-.196.283-.04.192-.03.469.046.822.024.111.054.227.09.346z"></path>
                                    </svg>
                                </div>
                            </div>
                        </div>
                    </div>
                </a>
            </div>
            <div class="col-md-6 col-xl-3 mb-4">
                <a data-bs-target="#modal-1" data-bs-toggle="modal">
                    <div class="card shadow border-start-primary py-2" data-bss-hover-animate="pulse" style="background: radial-gradient(#e3692e 18%, #c35405 168%); color: #f1e1bf;">
                        <div class="card-body" data-bss-hover-animate="pulse">
                            <div class="row align-items-center no-gutters">
                                <div class="col me-2">
                                    <div class="text-uppercase text-primary fw-bold text-xs mb-2"><span style="color: var(--bs-card-bg);">Imtiaz Home Page</span></div>
                                    <div class="text-dark fw-bold h5 mb-0">
                                        <span style="font-family: Poppins, sans-serif; font-size: 18px;">
                                            <svg xmlns="http://www.w3.org/2000/svg" width="1em" height="1em" fill="currentColor" viewBox="0 0 16 16" class="bi bi-arrow-up border rounded-circle shadow-lg swing animated" style="font-size: 18px; padding: 5px; background: var(--bs-card-bg); width: 26px; height: 26px; border-radius: 4px; color: var(--bs-link-hover-color); border-width: 12px; font-weight: bold; transform: scale(1);">
                                                <path fill-rule="evenodd" d="M8 15a.5.5 0 0 0 .5-.5V2.707l3.146 3.147a.5.5 0 0 0 .708-.708l-4-4a.5.5 0 0 0-.708 0l-4 4a.5.5 0 1 0 .708.708L7.5 2.707V14.5a.5.5 0 0 0 .5.5z"></path>
                                            </svg>&nbsp;&nbsp;<span style="color: var(--bs-gray-100); font-family: Poppins, sans-serif;">Promotional Video</span></span>
                                    </div>
                                </div>
                                <div class="col-auto">
                                    <svg xmlns="http://www.w3.org/2000/svg" width="1em" height="1em" fill="currentColor" viewBox="0 0 16 16" class="bi bi-camera-video fa-2x" style="color: rgb(239,161,150); transform: scale(1.15);">
                                        <path fill-rule="evenodd" d="M0 5a2 2 0 0 1 2-2h7.5a2 2 0 0 1 1.983 1.738l3.11-1.382A1 1 0 0 1 16 4.269v7.462a1 1 0 0 1-1.406.913l-3.111-1.382A2 2 0 0 1 9.5 13H2a2 2 0 0 1-2-2V5zm11.5 5.175 3.5 1.556V4.269l-3.5 1.556v4.35zM2 4a1 1 0 0 0-1 1v6a1 1 0 0 0 1 1h7.5a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H2z"></path>
                                    </svg>
                                </div>
                            </div>
                        </div>
                    </div>
                </a>
            </div>
        </div>
    </div>

    <div class="modal fade" role="dialog" tabindex="-1" id="modal-1">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title" style="color: var(--bs-dark); font-weight: bold;">Promotion Video</h4>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body" style="height: 444px;">
                    <div>
                        <form class="user mt-4">
                            <div class="row mb-3">
                                <div class="col-sm-6 mb-3 mb-sm-0">
                                    <label class="form-label">Date</label>
                                    <input class="form-control" type="date" id="txtPromotionalVideoDate">
                                </div>
                            </div>
                            <div class="row mb-3">
                                <div class="col-sm-6 mb-3 mb-sm-0">
                                    <label class="form-label">Video Title</label>
                                    <input class="form-control" type="text" id="txtPromotionalVideoTitle" style="width: 469px;">
                                </div>
                            </div>
                        </form>
                    </div>
                    <div class="files color form-group mb-3" style="border-radius: 8px; background: var(--bs-modal-bg); border-style: solid; border-color: rgb(255,255,255);">
                        <input type="file" multiple="" id="txtPromotionalVideoFile" name="files" style="border-radius: 15px; border-color: var(--bs-blue); background: var(--bs-gray-100);">
                    </div>
                </div>
                <div class="modal-footer">
                    <button class="btn btn-light" type="button" data-bs-dismiss="modal">Close</button>
                    <button class="btn btn-primary" type="button" id="btnUploadVideo">Upload Video</button>
                </div>
            </div>
        </div>
    </div>
    <div class="modal fade" role="dialog" tabindex="-1" id="modal-2">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title" style="color: var(--bs-dark); font-weight: bold;">Current Promotion</h4>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body" style="height: 444px;">
                    <div>
                        <form class="user mt-4">
                            <div class="row mb-3">
                                <div class="col-sm-6 mb-3 mb-sm-0">
                                    <label class="form-label">Date</label>
                                    <input class="form-control" type="date" id="txtPromotionalPDFDate">
                                </div>
                            </div>
                            <div class="row mb-3">
                                <div class="col-sm-6 mb-3 mb-sm-0">
                                    <label class="form-label">Title</label>
                                    <input class="form-control" type="text" id="txtPromotionalPDFTitle" style="width: 469px;">
                                </div>
                            </div>
                        </form>
                    </div>
                    <div class="files color form-group mb-3" style="border-radius: 8px; background: var(--bs-modal-bg); border-style: solid; border-color: rgb(255,255,255);">
                        <input type="file" id="txtPromotionalPDFFile" data-bs-toggle="tooltip" data-bss-tooltip="" multiple="" name="files" style="border-radius: 15px; border-color: var(--bs-blue); background: var(--bs-gray-100);" title="Select PDF File">
                    </div>
                </div>
                <div class="modal-footer">
                    <button class="btn btn-light" type="button" data-bs-dismiss="modal">Close</button>
                    <button class="btn btn-primary" type="button" id="btnUploadPDFFile">Upload File</button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
