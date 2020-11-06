using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.WebPages;

namespace AspNetWebPages.Pages
{
    //http://www.compiledthoughts.com/2011/01/aspnet-mvc3-creating-razor-view-engine.html
    //Nesting files manualmente:
    //<Compile Include="Pages\Default.cshtml.cs">
    //  <DependentUpon>Default.cshtml</DependentUpon>
    //</Compile>
    // o https://marketplace.visualstudio.com/items?itemName=MadsKristensen.FileNesting

    public abstract class DefaultPage : WebPage
    {
        public string Name { get { return "from code-behind"; } }

        protected override void InitializePage()
        {   // Before .cshtml code            
            base.InitializePage();

            //RegisterPageExecutor(new Action());
        }
                        
        public override HelperResult RenderPage(string path, params object[] data) // Borrar
        {
            return base.RenderPage(path, data);
        }

        public override void ExecutePageHierarchy() // Borrar
        {
            base.ExecutePageHierarchy();
        }
    }

    public class Action : IWebPageRequestExecutor
    {
        // An executor is a class that can take over the execution of a WebPage. This can be used to
        // implement features like AJAX callback methods on the page (like WebForms Page Methods)
        public bool Execute(WebPage page)
        {
            string s = "";
            return true;
        }
    }
}