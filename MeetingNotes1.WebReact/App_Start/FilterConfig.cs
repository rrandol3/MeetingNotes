using System.Web;
using System.Web.Mvc;

namespace MeetingNotes1.WebReact
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
