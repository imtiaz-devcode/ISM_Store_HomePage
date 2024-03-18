<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HRIndex.aspx.cs" Inherits="ISM_HomePage.HRIndex" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <script src="assets/FormJS/HRIndex.js"></script>

    <div class="container-fluid">
                    <div class="d-sm-flex justify-content-between align-items-center mb-4" style="font-family: Poppins, sans-serif;font-weight: bold;color: var(--bs-link-hover-color);">
                        <h3 class="mb-0" style="color: var(--bs-link-color);font-weight: bold;">Human Resource</h3>
                    </div>
                    <div class="row">
                        <div class="col-md-6 col-xl-3 mb-4"><a data-bs-target="#modal-1" data-bs-toggle="modal" style="color: var(--bs-yellow);">
                                <div class="card shadow border-start-primary py-2" data-bs-toggle="tooltip" data-bss-tooltip="" data-bss-hover-animate="pulse" style="background: radial-gradient(#6486ea 0%, #4e73df 100%), #f88916;" title="Upload Announcement">
                                    <div class="card-body" data-bss-hover-animate="pulse">
                                        <div class="row align-items-center no-gutters">
                                            <div class="col me-2">
                                                <div class="text-uppercase text-primary fw-bold text-xs mb-2"><span style="border-top-color: var(--bs-card-bg);color: var(--bs-card-bg);">Imtiaz Home Page</span></div>
                                                <div class="text-dark fw-bold h5 mb-0"><span style="font-family: Poppins, sans-serif;font-size: 18px;"><svg xmlns="http://www.w3.org/2000/svg" width="1em" height="1em" fill="currentColor" viewBox="0 0 16 16" class="bi bi-arrow-up border rounded-circle shadow-lg swing animated" style="font-size: 18px;padding: 5px;background: var(--bs-card-bg);width: 26px;height: 26px;border-radius: 4px;color: var(--bs-link-hover-color);border-width: 12px;font-weight: bold;transform: scale(1);">
                                                            <path fill-rule="evenodd" d="M8 15a.5.5 0 0 0 .5-.5V2.707l3.146 3.147a.5.5 0 0 0 .708-.708l-4-4a.5.5 0 0 0-.708 0l-4 4a.5.5 0 1 0 .708.708L7.5 2.707V14.5a.5.5 0 0 0 .5.5z"></path>
                                                        </svg>&nbsp;&nbsp;<span style="color: var(--bs-gray-100);">Announcement</span></span></div>
                                            </div>
                                            <div class="col-auto" style="color: rgb(148,171,236);"><svg xmlns="http://www.w3.org/2000/svg" width="1em" height="1em" fill="currentColor" viewBox="0 0 16 16" class="bi bi-megaphone fa-2x" style="/*color: rgb(239,161,150);*/border-color: rgb(148,171,236);">
                                                    <path d="M13 2.5a1.5 1.5 0 0 1 3 0v11a1.5 1.5 0 0 1-3 0v-.214c-2.162-1.241-4.49-1.843-6.912-2.083l.405 2.712A1 1 0 0 1 5.51 15.1h-.548a1 1 0 0 1-.916-.599l-1.85-3.49a68.14 68.14 0 0 0-.202-.003A2.014 2.014 0 0 1 0 9V7a2.02 2.02 0 0 1 1.992-2.013 74.663 74.663 0 0 0 2.483-.075c3.043-.154 6.148-.849 8.525-2.199V2.5zm1 0v11a.5.5 0 0 0 1 0v-11a.5.5 0 0 0-1 0zm-1 1.35c-2.344 1.205-5.209 1.842-8 2.033v4.233c.18.01.359.022.537.036 2.568.189 5.093.744 7.463 1.993V3.85zm-9 6.215v-4.13a95.09 95.09 0 0 1-1.992.052A1.02 1.02 0 0 0 1 7v2c0 .55.448 1.002 1.006 1.009A60.49 60.49 0 0 1 4 10.065zm-.657.975 1.609 3.037.01.024h.548l-.002-.014-.443-2.966a68.019 68.019 0 0 0-1.722-.082z"></path>
                                                </svg></div>
                                        </div>
                                    </div>
                                </div>
                            </a></div>
                        <div class="col-md-6 col-xl-3 mb-4"><a data-bs-target="#modal-2" data-bs-toggle="modal">
                                <div class="card shadow border-start-primary py-2" data-bss-hover-animate="pulse" style="background: radial-gradient(#e3692e 18%, #c35405 168%);color: #f1e1bf;">
                                    <div class="card-body" data-bss-hover-animate="pulse">
                                        <div class="row align-items-center no-gutters">
                                            <div class="col me-2">
                                                <div class="text-uppercase text-primary fw-bold text-xs mb-2"><span style="color: var(--bs-card-bg);">Imtiaz Home Page</span></div>
                                                <div class="text-dark fw-bold h5 mb-0"><span style="font-family: Poppins, sans-serif;font-size: 18px;"><svg xmlns="http://www.w3.org/2000/svg" width="1em" height="1em" fill="currentColor" viewBox="0 0 16 16" class="bi bi-arrow-up border rounded-circle shadow-lg swing animated" style="font-size: 18px;padding: 5px;background: var(--bs-card-bg);width: 26px;height: 26px;border-radius: 4px;color: var(--bs-link-hover-color);border-width: 12px;font-weight: bold;transform: scale(1);">
                                                            <path fill-rule="evenodd" d="M8 15a.5.5 0 0 0 .5-.5V2.707l3.146 3.147a.5.5 0 0 0 .708-.708l-4-4a.5.5 0 0 0-.708 0l-4 4a.5.5 0 1 0 .708.708L7.5 2.707V14.5a.5.5 0 0 0 .5.5z"></path>
                                                        </svg>&nbsp;&nbsp;<span style="color: var(--bs-gray-100);font-family: Poppins, sans-serif;">Event</span></span></div>
                                            </div>
                                            <div class="col-auto"><svg xmlns="http://www.w3.org/2000/svg" width="1em" height="1em" fill="currentColor" viewBox="0 0 16 16" class="bi bi-calendar4-event fa-2x" style="color: #eba5a7;">
                                                    <path d="M3.5 0a.5.5 0 0 1 .5.5V1h8V.5a.5.5 0 0 1 1 0V1h1a2 2 0 0 1 2 2v11a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V3a2 2 0 0 1 2-2h1V.5a.5.5 0 0 1 .5-.5zM2 2a1 1 0 0 0-1 1v1h14V3a1 1 0 0 0-1-1H2zm13 3H1v9a1 1 0 0 0 1 1h12a1 1 0 0 0 1-1V5z"></path>
                                                    <path d="M11 7.5a.5.5 0 0 1 .5-.5h1a.5.5 0 0 1 .5.5v1a.5.5 0 0 1-.5.5h-1a.5.5 0 0 1-.5-.5v-1z"></path>
                                                </svg></div>
                                        </div>
                                    </div>
                                </div>
                            </a></div>
                    </div>
                </div>

    <div class="modal fade" role="dialog" tabindex="-1" id="modal-1">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title" style="color: var(--bs-dark);font-weight: bold;">Announcement</h4><button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body text-break">
                    <div>
                        <form class="user mt-4">
                            <div class="row mb-3">
                                <div class="col-sm-6 mb-3 mb-sm-0"><label class="form-label">Date</label><input class="form-control" type="date" id="txtAnnouncementDate"></div>
                            </div>
                            <div class="mb-3"><label class="form-label">Subject</label><input class="form-control" type="text" id="txtSubject"></div>
                            <div class="mb-3"><label class="form-label">Message</label><textarea class="form-control" id="txtBody"></textarea></div>
                            <div class="mb-3"><label class="form-label">Is Publish</label><select class="form-select" id="ddlIsAnnouncementActive"><option value="1">Yes</option><option value="0">No</option></select></div>
                        </form>
                    </div>
                </div>
                <div class="modal-footer">
                    <button class="btn btn-light" type="button" data-bs-dismiss="modal">Close</button>
                    <button class="btn btn-primary" type="button" id="btnSaveAnnouncement">Save</button></div>
            </div>
        </div>
    </div>
    <div class="modal fade" role="dialog" tabindex="-1" id="modal-2">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title" style="color: var(--bs-dark);font-weight: bold;">Event</h4>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body text-break">
                    <div>
                        <form class="user mt-4">
                            <div class="row mb-3">
                                <div class="col-sm-6 mb-3 mb-sm-0"><label class="form-label">Event Date</label><input class="form-control" type="date" id="txtEventDate"></div>
                            </div>
                            <div class="mb-3"><label class="form-label">Title</label><input class="form-control" type="text" id="txtEventTitle"></div>
                            <div class="mb-3"><label class="form-label">Description</label><textarea class="form-control" id="txtEventLocation"></textarea></div>
                            <div class="mb-3"><label class="form-label">Is Publish</label><select class="form-select" id="ddlIsUpComingEventActive"><option value="1">Yes</option><option value="0">No</option></select></div>
                        </form>
                    </div>
                </div>
                <div class="modal-footer">
                    <button class="btn btn-light" type="button" data-bs-dismiss="modal">Close</button>
                    <button class="btn btn-primary" type="button" id="btnSaveEvent">Save</button></div>
            </div>
        </div>
    </div>
</asp:Content>
