using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.UI.WebControls;
namespace MVCDemo.TokenField.BLL
{
    public static class TokenField
    {
        public static MvcHtmlString TextBoxTokenField(this HtmlHelper helper, List<string> autocomplete)
        {
            string source = "[";
            foreach (string word in autocomplete)
            {
                source += "'" + word + "',";
            }
            source += "]";
            string control = "<input type=\"text\" class=\"form - control\" id=\"tokenfield\" /> <script> " +
                                " window.onload = function () { " +
                                    "function addCssFile(hreff) { " +
                                        " var link = document.createElement(\"link\"); " +
                                        " link.type = \"text/css\"; " +
                                        " link.rel = \"stylesheet\"; " +
                                        " link.href = hreff; " +
                                        " link.media =\"screen,print\"; " +
                                        " document.getElementsByTagName(\"head\")[0].appendChild(link); }" +
                                    "function addJsFile(hreff) { " +
                                        " var link = document.createElement(\"script\");" +
                                        " link.type =\"text/javascript\";" +
                                        " link.src = hreff;" +
                                        " document.getElementsByTagName(\"body\")[0].appendChild(link); }" +
                                    "\n addCssFile(\"https://code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css\")" +
                                    "\n addCssFile(\"https://cdnjs.cloudflare.com/ajax/libs/bootstrap-tokenfield/0.12.0/css/bootstrap-tokenfield.min.css\") " +
                                    "\n addCssFile(\"https://cdnjs.cloudflare.com/ajax/libs/bootstrap-tokenfield/0.12.0/css/tokenfield-typeahead.min.css\") " +
                                    "\n addJsFile(\"https://code.jquery.com/ui/1.12.1/jquery-ui.min.js\") " +
                                    "\n addJsFile(\"https://cdnjs.cloudflare.com/ajax/libs/bootstrap-tokenfield/0.12.0/bootstrap-tokenfield.min.js\") " +
                                    "\n setTimeout(() => {  $('#tokenfield').tokenfield({ autocomplete: { source: " + source + ", delay: 100 }, showAutocompleteOnFocus: true }) }, 1000); }" +
                                    " </script> ";
            return MvcHtmlString.Create(control);
        }
    }
}