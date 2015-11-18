using _1on1.Models;
using System.Linq;
using System.Web.Mvc;

namespace _1on1.Filter
{
    public class NotificationFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var context = new SiteDataContext();

            var notifications = context.Notifications
                .GroupBy(n => n.NotificationType)
                .Select(g => new NotificationViewModel
                {
                    Count = g.Count(),
                    NotificationType = g.Key.ToString(),
                    BadgeClass = NotificationType.Email == g.Key
                        ? "success"
                        : "info"
                });

            filterContext.Controller.ViewBag.Notifications = notifications;

        }
    }
}