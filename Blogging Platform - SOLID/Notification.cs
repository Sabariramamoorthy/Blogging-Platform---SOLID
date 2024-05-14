using System.Reflection;

namespace Blogging_Platform___SOLID;

public class Notification
{
private readonly INotificationService _notificationService;
    public Notification(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }
    public string Publish(Post post)
    {
        return _notificationService.SendNotification();
    }

}

public class Post
{
public string? Id { get; set; }
public string? Title { get; set; }
}
public interface INotificationService
{
    string SendNotification();
}

public class EmailNotificationService : INotificationService
{
    public string SendNotification()
    {
        return $"{this.GetType().Name}.{MethodBase.GetCurrentMethod()?.Name}";

    }
}

public class SMSNotificationService : INotificationService
{
    public string SendNotification()
    {
        return $"{this.GetType().Name}.{MethodBase.GetCurrentMethod()?.Name}";
    }
}

public class PushNotificationService : INotificationService
{
    public string SendNotification()
    {
        return $"{this.GetType().Name}.{MethodBase.GetCurrentMethod()?.Name}";
    }
}