﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HangFire.Web.Pages
{
    
    #line 2 "..\..\Pages\LayoutPage.cshtml"
    using System;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    
    #line 3 "..\..\Pages\LayoutPage.cshtml"
    using System.Diagnostics;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Pages\LayoutPage.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 5 "..\..\Pages\LayoutPage.cshtml"
    using HangFire.Storage;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Pages\LayoutPage.cshtml"
    using Storage.Monitoring;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class LayoutPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");







WriteLiteral("<!DOCTYPE html>\r\n\r\n<html lang=\"ru\">\r\n<head>\r\n    <title>");


            
            #line 12 "..\..\Pages\LayoutPage.cshtml"
      Write(Title);

            
            #line default
            #line hidden
WriteLiteral(" - HangFire</title>\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" cont" +
"ent=\"width=device-width, initial-scale=1.0\">\r\n    <link rel=\"stylesheet\" href=\"");


            
            #line 15 "..\..\Pages\LayoutPage.cshtml"
                            Write(Request.LinkTo("/css/styles.css"));

            
            #line default
            #line hidden
WriteLiteral(@""" />
</head>
    <body>
        <!-- Wrap all page content here -->
        <div id=""wrap"">

            <!-- Fixed navbar -->
            <div class=""navbar navbar-default navbar-static-top"">
                <div class=""container"">
                    <div class=""navbar-header"">
                        <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".navbar-collapse"">
                            <span class=""icon-bar""></span>
                            <span class=""icon-bar""></span>
                            <span class=""icon-bar""></span>
                        </button>
                        <a class=""navbar-brand"" href=""");


            
            #line 30 "..\..\Pages\LayoutPage.cshtml"
                                                 Write(Request.LinkTo("/"));

            
            #line default
            #line hidden
WriteLiteral(@""">HangFire Monitor</a>
                    </div>
                    <div class=""collapse navbar-collapse"">
                        <ul class=""nav navbar-nav navbar-right"">
                            <li>
                                <a href=""/"">
                                    <span class=""glyphicon glyphicon-log-out""></span>
                                    Back to site
                                </a>
                            </li>
                        </ul>
                    </div>
                    <!--/.nav-collapse -->
                </div>
            </div>

            <!-- Begin page content -->

            <div class=""container"">
                <div class=""col-md-3"">
");


            
            #line 50 "..\..\Pages\LayoutPage.cshtml"
                      
                        var monitor = JobStorage.Current.GetMonitoringApi();
                        StatisticsDto statistics = monitor.GetStatistics();
                    

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div id=\"stats\" class=\"list-group\">\r\n                      " +
"  <a class=\"list-group-item ");


            
            #line 56 "..\..\Pages\LayoutPage.cshtml"
                                              Write(Request.PathInfo.Equals("/") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                           href=\"");


            
            #line 57 "..\..\Pages\LayoutPage.cshtml"
                            Write(Request.LinkTo("/"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            <span class=\"glyphicon glyphicon-dashboard\"></spa" +
"n>\r\n                            Dashboard\r\n                        </a>\r\n\r\n     " +
"                   <a class=\"list-group-item ");


            
            #line 62 "..\..\Pages\LayoutPage.cshtml"
                                              Write(Request.PathInfo.Equals("/servers") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                           href=\"");


            
            #line 63 "..\..\Pages\LayoutPage.cshtml"
                            Write(Request.LinkTo("/servers"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            <span class=\"label label-default pull-right\">");


            
            #line 64 "..\..\Pages\LayoutPage.cshtml"
                                                                    Write(statistics.Servers);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                            <span class=\"glyphicon glyphicon-hdd\"></span" +
">\r\n                            Servers\r\n                        </a>\r\n          " +
"              \r\n                        <a class=\"list-group-item ");


            
            #line 69 "..\..\Pages\LayoutPage.cshtml"
                                              Write(Request.PathInfo.Equals("/recurring") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                           href=\"");


            
            #line 70 "..\..\Pages\LayoutPage.cshtml"
                            Write(Request.LinkTo("/recurring"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            <span id=\"stats-recurring\" class=\"label label-def" +
"ault pull-right\">\r\n                                ");


            
            #line 72 "..\..\Pages\LayoutPage.cshtml"
                           Write(statistics.Recurring);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n\r\n                            <span class=" +
"\"glyphicon glyphicon-time\"></span>\r\n                            Recurring jobs\r\n" +
"                        </a>\r\n\r\n                        <a class=\"list-group-ite" +
"m ");


            
            #line 79 "..\..\Pages\LayoutPage.cshtml"
                                              Write(Request.PathInfo.StartsWith("/queues") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\" \r\n                           href=\"");


            
            #line 80 "..\..\Pages\LayoutPage.cshtml"
                            Write(Request.LinkTo("/queues"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            <span class=\"label label-default pull-right\">\r\n  " +
"                              <span id=\"stats-enqueued\" title=\"Enqueued jobs cou" +
"nt\">\r\n                                    ");


            
            #line 83 "..\..\Pages\LayoutPage.cshtml"
                               Write(statistics.Enqueued);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </span>\r\n                                / \r\n  " +
"                              <span id=\"stats-queues\" title=\"Queues count\">\r\n   " +
"                                 ");


            
            #line 87 "..\..\Pages\LayoutPage.cshtml"
                               Write(statistics.Queues);

            
            #line default
            #line hidden
WriteLiteral(@"
                                </span>
                            </span>
                            <span class=""glyphicon glyphicon-inbox""></span>
                            Queues
                        </a>
                        <a class=""list-group-item stats-indent ");


            
            #line 93 "..\..\Pages\LayoutPage.cshtml"
                                                           Write(Request.PathInfo.Equals("/scheduled") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\" \r\n                           href=\"");


            
            #line 94 "..\..\Pages\LayoutPage.cshtml"
                            Write(Request.LinkTo("/scheduled"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            <span id=\"stats-scheduled\" class=\"label label-inf" +
"o pull-right\">\r\n                                ");


            
            #line 96 "..\..\Pages\LayoutPage.cshtml"
                           Write(statistics.Scheduled);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n                            Scheduled\r\n   " +
"                     </a>\r\n                        <a class=\"list-group-item sta" +
"ts-indent ");


            
            #line 100 "..\..\Pages\LayoutPage.cshtml"
                                                           Write(Request.PathInfo.Equals("/processing") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\" \r\n                           href=\"");


            
            #line 101 "..\..\Pages\LayoutPage.cshtml"
                            Write(Request.LinkTo("/processing"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            <span id=\"stats-processing\" class=\"label label-wa" +
"rning pull-right\">\r\n                                ");


            
            #line 103 "..\..\Pages\LayoutPage.cshtml"
                           Write(statistics.Processing);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n                            Processing\r\n  " +
"                      </a>\r\n                        <a class=\"list-group-item st" +
"ats-indent ");


            
            #line 107 "..\..\Pages\LayoutPage.cshtml"
                                                           Write(Request.PathInfo.Equals("/succeeded") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\" \r\n                           href=\"");


            
            #line 108 "..\..\Pages\LayoutPage.cshtml"
                            Write(Request.LinkTo("/succeeded"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            <span id=\"stats-succeeded\" class=\"label label-suc" +
"cess pull-right\">\r\n                                ");


            
            #line 110 "..\..\Pages\LayoutPage.cshtml"
                           Write(statistics.Succeeded);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n                            Succeeded\r\n   " +
"                     </a>\r\n                        <a class=\"list-group-item sta" +
"ts-indent ");


            
            #line 114 "..\..\Pages\LayoutPage.cshtml"
                                                           Write(Request.PathInfo.Equals("/failed") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\" \r\n                           href=\"");


            
            #line 115 "..\..\Pages\LayoutPage.cshtml"
                            Write(Request.LinkTo("/failed"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            <span id=\"stats-failed\" class=\"label label-danger" +
" pull-right\">\r\n                                ");


            
            #line 117 "..\..\Pages\LayoutPage.cshtml"
                           Write(statistics.Failed);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n                            Failed\r\n      " +
"                  </a>\r\n                        <a class=\"list-group-item stats-" +
"indent ");


            
            #line 121 "..\..\Pages\LayoutPage.cshtml"
                                                           Write(Request.PathInfo.Equals("/deleted") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                           href=\"");


            
            #line 122 "..\..\Pages\LayoutPage.cshtml"
                            Write(Request.LinkTo("/deleted"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            <span id=\"stats-deleted\" class=\"label label-defau" +
"lt pull-right\">\r\n                                ");


            
            #line 124 "..\..\Pages\LayoutPage.cshtml"
                           Write(statistics.Deleted);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n                            Deleted\r\n     " +
"                   </a>\r\n                    </div>\r\n                </div>\r\n   " +
"             <div class=\"col-md-9\">\r\n");


            
            #line 131 "..\..\Pages\LayoutPage.cshtml"
                     if (Breadcrumbs != null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <ol class=\"breadcrumb\">\r\n                            <li>" +
"<a href=\"");


            
            #line 134 "..\..\Pages\LayoutPage.cshtml"
                                    Write(Request.LinkTo("/"));

            
            #line default
            #line hidden
WriteLiteral("\"><span class=\"glyphicon glyphicon-home\"></span></a></li>\r\n");


            
            #line 135 "..\..\Pages\LayoutPage.cshtml"
                             foreach (var breadcrumb in Breadcrumbs)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li><a href=\"");


            
            #line 137 "..\..\Pages\LayoutPage.cshtml"
                                        Write(breadcrumb.Value);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 137 "..\..\Pages\LayoutPage.cshtml"
                                                           Write(breadcrumb.Key);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");


            
            #line 138 "..\..\Pages\LayoutPage.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                            <li class=\"active\">");


            
            #line 139 "..\..\Pages\LayoutPage.cshtml"
                                           Write(BreadcrumbsTitle ?? Title);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                        </ol>\r\n");


            
            #line 141 "..\..\Pages\LayoutPage.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <h1 class=\"page-header\">\r\n                        ");


            
            #line 144 "..\..\Pages\LayoutPage.cshtml"
                   Write(Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 145 "..\..\Pages\LayoutPage.cshtml"
                         if (!String.IsNullOrEmpty(Subtitle))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <small>");


            
            #line 147 "..\..\Pages\LayoutPage.cshtml"
                              Write(Subtitle);

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n");


            
            #line 148 "..\..\Pages\LayoutPage.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </h1>\r\n                    ");


            
            #line 150 "..\..\Pages\LayoutPage.cshtml"
               Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral(@"
                </div>
            </div>
        </div>

        <div id=""footer"">
            <div class=""container"">
                <ul class=""list-inline credit"">
                    <li>
                        <a href=""http://hangfire.io/"" target=""_blank"">HangFire 
                            ");


            
            #line 160 "..\..\Pages\LayoutPage.cshtml"
                       Write(FileVersionInfo.GetVersionInfo(GetType().Assembly.Location).ProductVersion);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </a>\r\n                    </li>\r\n                    <l" +
"i>");


            
            #line 163 "..\..\Pages\LayoutPage.cshtml"
                   Write(JobStorage.Current);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                    <li>Time: ");


            
            #line 164 "..\..\Pages\LayoutPage.cshtml"
                         Write(DateTime.UtcNow);

            
            #line default
            #line hidden
WriteLiteral(" GMT\r\n                    </li>\r\n                    <li>Generated in [");


            
            #line 166 "..\..\Pages\LayoutPage.cshtml"
                                  Write((DateTime.UtcNow - (DateTime)Context.Items["GenerationStartedAt"]).Milliseconds);

            
            #line default
            #line hidden
WriteLiteral(@" ms]
                    </li>
                </ul>
            </div>
        </div>
        
        <script>
            (function (hangFire) {
                hangFire.config = {
                    pollInterval: 2000,
                    pollUrl: '");


            
            #line 176 "..\..\Pages\LayoutPage.cshtml"
                          Write(Request.LinkTo("/stats"));

            
            #line default
            #line hidden
WriteLiteral("\'\r\n                };\r\n            })(window.HangFire = window.HangFire || {});\r\n" +
"        </script>\r\n        <script src=\"");


            
            #line 180 "..\..\Pages\LayoutPage.cshtml"
                Write(Request.LinkTo("/js/scripts.js"));

            
            #line default
            #line hidden
WriteLiteral("\"></script>\r\n    </body>\r\n</html>\r\n");


        }
    }
}
#pragma warning restore 1591
