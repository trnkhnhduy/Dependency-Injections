using System;
namespace DependencyInjectionDe
{
    public interface INotificationService
    {
        void Send(string message);
    }
    public class EmailNotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email: {message}");
        }
    }
    public class SMSNotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS message: {message}");
        }
    }
    public class PushNotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Push {message}");
        }
    }
    public class NotificationManager
    {
        private INotificationService _notificationService;
        public NotificationManager(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        public void Notify(string message)
        {
            _notificationService.Send(message);
        }
    }
    class Proram
    {
        static void Main(string[] args)
        {
            var service = new ServiceCollection();
            // service.AddSingleton<INotificationService, EmailNotificationService>();
            service.AddSingleton<INotificationService, SMSNotificationService>();
            // service.AddSingleton<INotificationService, PushNotificationService>();
            service.AddSingleton<NotificationManager>();
            var provider = service.BuildServiceProvider();
            var manager = provider.GetService<NotificationManager>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(manager.GetHashCode());
            }
            manager.Notify("Xin chao");
        }
    }
}
