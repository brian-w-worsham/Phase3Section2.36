using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Phase3Section3._36.Views.Home
{
    public static class CustomHelper
    {
        public static IHtmlContent File(this IHtmlHelper htmlHelper, string id)
        {
            var tb = new TagBuilder("input");
            tb.Attributes.Add("type", "file");
            tb.Attributes.Add("id", id);

            return tb;
        }
    }
}
