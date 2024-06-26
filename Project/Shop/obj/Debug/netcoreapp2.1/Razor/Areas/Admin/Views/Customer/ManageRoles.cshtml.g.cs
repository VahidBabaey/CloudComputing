#pragma checksum "D:\projects\web3Cloud\Shop\Areas\Admin\Views\Customer\ManageRoles.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0baf5eb5df5b28aaf7c701aa31993feb0c611f190eaf44ffdabae6c1c35d85c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Customer_ManageRoles), @"mvc.1.0.view", @"/Areas/Admin/Views/Customer/ManageRoles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Customer/ManageRoles.cshtml", typeof(AspNetCore.Areas_Admin_Views_Customer_ManageRoles))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"0baf5eb5df5b28aaf7c701aa31993feb0c611f190eaf44ffdabae6c1c35d85c3", @"/Areas/Admin/Views/Customer/ManageRoles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a46888cb42a82d07d75c7520398bd210110a0938ab259c9b479e1f839545b4f8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Customer_ManageRoles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Admin.Models.ManageCustomeRoleModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Shop.TagHelpers.CaptionViewTagHelper __Shop_TagHelpers_CaptionViewTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\projects\web3Cloud\Shop\Areas\Admin\Views\Customer\ManageRoles.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_layout.cshtml";

#line default
#line hidden
            BeginContext(110, 9, true);
            WriteLiteral("\r\n<div>\r\n");
            EndContext();
#line 7 "D:\projects\web3Cloud\Shop\Areas\Admin\Views\Customer\ManageRoles.cshtml"
       var des = "Role Management" + " " + Model.fullName;

#line default
#line hidden
            BeginContext(180, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(184, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("caption-view", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0baf5eb5df5b28aaf7c701aa31993feb0c611f190eaf44ffdabae6c1c35d85c33633", async() => {
            }
            );
            __Shop_TagHelpers_CaptionViewTagHelper = CreateTagHelper<global::Shop.TagHelpers.CaptionViewTagHelper>();
            __tagHelperExecutionContext.Add(__Shop_TagHelpers_CaptionViewTagHelper);
            BeginWriteTagHelperAttribute();
#line 8 "D:\projects\web3Cloud\Shop\Areas\Admin\Views\Customer\ManageRoles.cshtml"
                 WriteLiteral(des);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Shop_TagHelpers_CaptionViewTagHelper.TitleAttribute = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-title", __Shop_TagHelpers_CaptionViewTagHelper.TitleAttribute, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(230, 45, true);
            WriteLiteral("\r\n    <div id=\"divrole\" class=\"form-group\">\r\n");
            EndContext();
#line 10 "D:\projects\web3Cloud\Shop\Areas\Admin\Views\Customer\ManageRoles.cshtml"
         foreach (var item in Model.ListRoles)
        {

#line default
#line hidden
            BeginContext(334, 99, true);
            WriteLiteral("            <div class=\"form-group form-check\">\r\n                <label class=\"form-check-label\">\r\n");
            EndContext();
#line 14 "D:\projects\web3Cloud\Shop\Areas\Admin\Views\Customer\ManageRoles.cshtml"
                     if (Model.AssignedRoles.Contains(item))
                    {

#line default
#line hidden
            BeginContext(518, 55, true);
            WriteLiteral("                        <input class=\"form-check-input\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 573, "\"", 586, 1);
#line 16 "D:\projects\web3Cloud\Shop\Areas\Admin\Views\Customer\ManageRoles.cshtml"
WriteAttributeValue("", 578, item.Id, 578, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(587, 36, true);
            WriteLiteral(" type=\"checkbox\" checked=\"checked\"> ");
            EndContext();
            BeginContext(624, 9, false);
#line 16 "D:\projects\web3Cloud\Shop\Areas\Admin\Views\Customer\ManageRoles.cshtml"
                                                                                                    Write(item.Name);

#line default
#line hidden
            EndContext();
#line 16 "D:\projects\web3Cloud\Shop\Areas\Admin\Views\Customer\ManageRoles.cshtml"
                                                                                                                   

                    }
                    else
                    {

#line default
#line hidden
            BeginContext(709, 55, true);
            WriteLiteral("                        <input class=\"form-check-input\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 764, "\"", 777, 1);
#line 21 "D:\projects\web3Cloud\Shop\Areas\Admin\Views\Customer\ManageRoles.cshtml"
WriteAttributeValue("", 769, item.Id, 769, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(778, 18, true);
            WriteLiteral(" type=\"checkbox\"> ");
            EndContext();
            BeginContext(797, 9, false);
#line 21 "D:\projects\web3Cloud\Shop\Areas\Admin\Views\Customer\ManageRoles.cshtml"
                                                                                  Write(item.Name);

#line default
#line hidden
            EndContext();
#line 21 "D:\projects\web3Cloud\Shop\Areas\Admin\Views\Customer\ManageRoles.cshtml"
                                                                                                 
                    }

#line default
#line hidden
            BeginContext(831, 46, true);
            WriteLiteral("                </label>\r\n            </div>\r\n");
            EndContext();
#line 25 "D:\projects\web3Cloud\Shop\Areas\Admin\Views\Customer\ManageRoles.cshtml"
        }

#line default
#line hidden
            BeginContext(888, 479, true);
            WriteLiteral(@"        <button onclick=""saveroleuser()"" class=""btn btn-dark""><i class=""fa fa-save"" ></i>Save</button>
    </div>

</div>
<script>
    function saveroleuser() {
  
        var roleids = """";
        $(""#divrole input[type='checkbox']"").each(function () {
            if ($(this).is("":checked"")) {
                roleids += $(this).attr(""id"")+"";"";
            }
        
        });

       
        AJX.post(""/Admin/Customer/SaveRole"", { roleids: roleids, userid:");
            EndContext();
            BeginContext(1368, 8, false);
#line 42 "D:\projects\web3Cloud\Shop\Areas\Admin\Views\Customer\ManageRoles.cshtml"
                                                                   Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1376, 101, true);
            WriteLiteral(" }, function () { \r\n\r\n            alert(\"Information was recorded\");\r\n        });\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Admin.Models.ManageCustomeRoleModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
