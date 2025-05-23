using Microsoft.AspNetCore.Mvc;
using NotificationDemo.Services;

namespace NotificationDemo.Controllers
{
    public class NotificationController : Controller
    {
        private readonly EmailNotificationService _emailService;
        private readonly SMSNotificationService _smsService;
        private readonly PushNotificationService _pushService;

        public NotificationController(
            EmailNotificationService emailService,
            SMSNotificationService smsService,
            PushNotificationService pushService)
        {
            _emailService = emailService;
            _smsService = smsService;
            _pushService = pushService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Send(string message, string type)
        {
            switch (type)
            {
                case "Email":
                    _emailService.Send(message);
                    break;
                case "SMS":
                    _smsService.Send(message);
                    break;
                case "Push":
                    _pushService.Send(message);
                    break;
                default:
                    break;
            }

            ViewBag.Result = "Đã gửi thông báo thành công!";
            return View("Index");
        }
    }
}
