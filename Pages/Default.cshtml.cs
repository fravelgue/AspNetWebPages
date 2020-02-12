using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
    }
}