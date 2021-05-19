using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CoreWebTest.ViewRenderer
{
    public static class CustomHtmlHelper
    {
        public static IHtmlContent CountryBasedLabelFor<TModelItem, TResult>(
                this IHtmlHelper<IEnumerable<TModelItem>> htmlHelper,
                Expression<Func<TModelItem, TResult>> expression,
                string country,
                string htmlFieldName)
        {            
            string v;
            if (country == "VN")
                v = Resources.GeneralResource.DisplayVN;
            else v = Resources.GeneralResource.DisplayMY;

            return new HtmlString($"<span name='{htmlFieldName}' id='{htmlFieldName}'>{v}</span>");
        }

        public static IHtmlContent CountryBasedLabel(this IHtmlHelper htmlHelper, string country)
        {
            string v;
            if (country == "VN")
                v = Resources.GeneralResource.DisplayVN;
            else v = Resources.GeneralResource.DisplayMY;

            return new HtmlString($"<span>{v}</span>");
        }
    }
}
