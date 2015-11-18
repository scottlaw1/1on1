namespace _1on1.Migrations
{
    using Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<SiteDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SiteDataContext context)
        {
            context.Notifications.AddOrUpdate(notification => notification.Title,
            new Notification
            {
                Title = "John Smith was added to the system.",
                NotificationType = NotificationType.Registration
            },
            new Notification
            {
                Title = "Susan Peters was added to the system.",
                NotificationType = NotificationType.Registration
            },
            new Notification
            {
                Title = "Just an FYI on Thursday's meeting",
                NotificationType = NotificationType.Email
            });

        }
    }
}
