<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Announcement_Event_Data.aspx.cs" Inherits="ISM_Store_HomePage.Announcement_Event_Data" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <script src="assets/FormJS/Announcement_Event_Data.js"></script>

    <div class="container-fluid">
                    <div class="d-sm-flex justify-content-between align-items-center mb-4" style="font-family: Poppins, sans-serif;font-weight: bold;color: var(--bs-link-hover-color);">
                        <h3 class="mb-0" style="color: var(--bs-link-color);font-weight: bold;">Reports</h3><a class="btn btn-primary btn-sm d-none d-sm-inline-block" role="button" href="#"><i class="fas fa-download fa-sm text-white-50"></i>&nbsp;Generate Report</a>
                    </div>
                    <div class="card shadow">
                        <div class="card-header py-3">
                            <p class="text-primary m-0 fw-bold">Announcement &amp; Events</p>
                        </div>
                        <div class="card-body">
                            <div class="row">
                                <div class="col-md-6 text-nowrap">
                                    <div id="dataTable_length" class="dataTables_length" aria-controls="dataTable"><label class="form-label">Page Size &nbsp;
                                        <select class="d-inline-block form-select form-select-sm " id="ddlPageSize">
                                                <option value="10" selected="">10</option>
                                                <option value="25">25</option>
                                                <option value="50">50</option>
                                                <option value="100">100</option>
                                            </select>&nbsp;</label></div>
                                </div>
                                <div class="col-md-6">
                                    <div class="text-md-end dataTables_filter" id="dataTable_filter"><label class="form-label"><input type="search" class="form-control form-control-sm" aria-controls="dataTable" placeholder="Search"></label></div>
                                </div>
                            </div>
                            <div class="table-responsive table mt-2" id="dvdataTable" role="grid" aria-describedby="dataTable_info">
                                <table class="table my-0" id="dataTable">
                                    <thead>
                                        <tr>
                                            <th>S.No</th>
                                            <th>Name</th>
                                            <th>Title</th>
                                            <th>Description/Message</th>
                                            <th>Post By</th>
                                            <th>Post Date</th>
                                            <th>Status</th>
                                            <th>Order #</th>
                                        </tr>
                                    </thead>
                                    <tbody id="tBody_Announcement_EventData">
                                        <%--<tr>
                                            <td>Announcement</td>
                                            <td>Kashmir day</td>
                                            <td>Pellentesque aenean velit cras condimentum eleifend</td>
                                            <td>
                                                <img class="rounded-circle me-2" width="30" height="30" src="assets/img/Material/profile.png">
                                                Saqib Hussain
                                            </td>
                                            <td>23-12-2023</td>
                                            <td>Active</td>
                                            <td>2</td>
                                        </tr>--%>                                        
                                    </tbody>
                                </table>
                            </div>
                            <div class="row">
                                <div class="col-md-6 align-self-center">
                                    <p id="dataTable_Record_info" class="dataTables_info" role="status" aria-live="polite">Showing 1 to 10 of 5</p>
                                </div>
                                <div class="col-md-6">
                                    <nav class="d-lg-flex justify-content-lg-end dataTables_paginate paging_simple_numbers">
                                        <ul class="pagination" id="ulPagination">
                                            <%--<li class="page-item disabled"><a class="page-link" aria-label="Previous" href="#"><span aria-hidden="true">«</span></a></li>
                                            <li class="page-item active"><a class="page-link" href="#">1</a></li>
                                            <li class="page-item"><a class="page-link" href="#">2</a></li>
                                            <li class="page-item"><a class="page-link" href="#">3</a></li>
                                            <li class="page-item"><a class="page-link" aria-label="Next" href="#"><span aria-hidden="true">»</span></a></li>--%>
                                        </ul>
                                    </nav>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

</asp:Content>
