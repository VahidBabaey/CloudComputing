#pragma checksum "D:\projects\web3Cloud\Shop\Views\Error\Generalerror.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7f85df47d062a7c5c890bf16e929fdc473553457ba829c6d85d92e044b31415a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Error_Generalerror), @"mvc.1.0.view", @"/Views/Error/Generalerror.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Error/Generalerror.cshtml", typeof(AspNetCore.Views_Error_Generalerror))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"7f85df47d062a7c5c890bf16e929fdc473553457ba829c6d85d92e044b31415a", @"/Views/Error/Generalerror.cshtml")]
    public class Views_Error_Generalerror : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int?>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\projects\web3Cloud\Shop\Views\Error\Generalerror.cshtml"
   
    var ErrorMessage = " Error - Please Call Support Team";
    if (Model == 404)
    {
        ErrorMessage = " The URL Address is not Valid ";
    }
    if (Model == 401 || Model==403)
    {
        ErrorMessage = " YOu don't have this permission ";
    }
    if (Model >= 500)
    {
        ErrorMessage = " Server Error - Please Call Support Team";

    }


#line default
#line hidden
            BeginContext(397, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 20 "D:\projects\web3Cloud\Shop\Views\Error\Generalerror.cshtml"
  
    Layout = "~/Views/Shared/_ColumnOne.cshtml";


#line default
#line hidden
            BeginContext(458, 54, true);
            WriteLiteral("<div class=\"jumbotron h4 text-center text-danger\">\r\n  ");
            EndContext();
            BeginContext(513, 12, false);
#line 25 "D:\projects\web3Cloud\Shop\Views\Error\Generalerror.cshtml"
Write(ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(525, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int?> Html { get; private set; }
    }
}
#pragma warning restore 1591