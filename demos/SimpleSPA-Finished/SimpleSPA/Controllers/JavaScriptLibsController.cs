using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleSPA.Controllers
{
    public class JavaScriptLibsController : ApiController
    {
        public List<JavaScriptLib> GetJavaScriptLibs()
        {
            return new List<JavaScriptLib>
            {
                new JavaScriptLib{Id="1", Name="require.js", Purpose="Dependency Injection, modularization"},
                new JavaScriptLib{Id="2", Name="knockout.js", Purpose="Data binding"},
                new JavaScriptLib{Id="3", Name="jQuery", Purpose="DOM Manipulation"},
                new JavaScriptLib{Id="4", Name="breeze.js", Purpose="entity management on the client"},
                new JavaScriptLib{Id="5", Name="underscore", Purpose="LINQ-like operations in JS"},
                new JavaScriptLib{Id="6", Name="Durandal", Purpose="Brings it all together - application framework"},
                new JavaScriptLib{Id="7", Name="AngularJS", Purpose="Another great SPA option"},
                new JavaScriptLib{Id="8", Name="Toastr", Purpose="Toast pop-ups"},
                new JavaScriptLib{Id="9", Name="SignalR", Purpose="real-time pub-sub communication"},
                new JavaScriptLib{Id="10", Name="Q", Purpose="Promises"},
            };
        }

        public JavaScriptLib CeaterJavaScriptLib(JavaScriptLib lib)
        {
            lib.Id = Guid.NewGuid().ToString();
            return lib;
        }
    }

    public class JavaScriptLib
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Purpose { get; set; }
    }
}
