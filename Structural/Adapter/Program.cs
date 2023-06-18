using Adapter;

INotificationSender sender = new EmailSender();

sender.SendNotification(1, new Notification { Title = "test", Body = "body" });

sender = new SmsSenderAdapter();

sender.SendNotification(1, new Notification { Title = "test", Body = "body" });