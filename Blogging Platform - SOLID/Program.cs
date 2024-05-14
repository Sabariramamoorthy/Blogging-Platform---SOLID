using System;

namespace Blogging_Platform___SOLID
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                // Demonstrating Liskov Substitution Principle (LSP) where
                // derived classes can be used through base class references.
                Manager _manager1 = new PostManager(); // Using base class reference to a derived class instance
                PostManager _postManager = new PostManager(); // Direct instantiation of PostManager

                // Calling methods on the base class references and derived class instances to showcase LSP.
                Console.WriteLine(_manager1.Add("UniqueId")); // Add method called through base class reference
                Console.WriteLine(_manager1.Update("UniqueId")); // Update method called through base class reference
                Console.WriteLine(_manager1.Remove("UniqueId")); // Remove method called through base class reference

                Console.WriteLine(_postManager.Add("UniqueId")); // Direct call to Add method of PostManager
                Console.WriteLine(_postManager.Update("UniqueId")); // Direct call to Update method of PostManager
                Console.WriteLine(_postManager.Remove("UniqueId")); // Direct call to Remove method of PostManager

                // Single Responsibility Principle (SRP) is demonstrated with UserManager, PostManager, and CommentManager classes.
                // Each class has a single responsibility of managing users, posts, and comments respectively.
                Manager _userManager = new UserManager();
                UserManager _manager2 = new UserManager();

                Console.WriteLine(_manager2.Add("UniqueId")); // Add method called through UserManager instance
                Console.WriteLine(_manager2.Update("UniqueId")); // Update method called through UserManager instance
                Console.WriteLine(_manager2.Remove("UniqueId")); // Remove method called through UserManager instance

                Console.WriteLine(_userManager.Add("UniqueId")); // Add method called through base class reference
                Console.WriteLine(_userManager.Update("UniqueId")); // Update method called through base class reference
                Console.WriteLine(_userManager.Remove("UniqueId")); // Remove method called through base class reference

                Manager _manager3 = new CommentManager();
                CommentManager _commentManager = new CommentManager();

                Console.WriteLine(_manager3.Add("UniqueId")); // Add method called through base class reference
                Console.WriteLine(_manager3.Update("UniqueId")); // Update method called through base class reference
                Console.WriteLine(_manager3.Remove("UniqueId")); // Remove method called through base class reference

                Console.WriteLine(_commentManager.Add("UniqueId")); // Direct call to Add method of CommentManager
                Console.WriteLine(_commentManager.Update("UniqueId")); // Direct call to Update method of CommentManager
                Console.WriteLine(_commentManager.Remove("UniqueId")); // Direct call to Remove method of CommentManager

                // Demonstrating Interface Segregation Principle (ISP) with the 'Action' class.
                Action _action = new Action();
                // The 'Action' class implements specific interfaces (ICommentable, ILikeable, IShareable),
                // ensuring that it only contains methods necessary for its functionality.
                Console.WriteLine(_action.SharePost()); // Calling SharePost method
                Console.WriteLine(_action.AddComment("Comment")); // Calling AddComment method with a comment
                Console.WriteLine(_action.LikePost()); // Calling LikePost method

                // Dependency Inversion Principle (DIP) is implemented with the Notification class.
                // It depends on the abstraction INotificationService rather than concrete implementations,
                // allowing for flexibility and extensibility in the notification system.
                EmailNotificationService emailNotificationService = new EmailNotificationService();
                Notification _notification = new Notification(emailNotificationService);

                SMSNotificationService sMSNotificationService = new SMSNotificationService();
                Notification _notification1 = new Notification(sMSNotificationService);

                PushNotificationService pushNotificationService = new PushNotificationService();
                Notification _notification2 = new Notification(pushNotificationService);

                // Publishing notifications for different posts and displaying the return values.
                Console.WriteLine(_notification.Publish(new Post { Id = "id", Title = "Title" }));
                Console.WriteLine(_notification1.Publish(new Post { Id = "id", Title = "Title" }));
                Console.WriteLine(_notification2.Publish(new Post { Id = "id", Title = "Title" }));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }

            Console.WriteLine("Shutting down");
            Console.WriteLine("Press any key to exit...");
        }
    }
}
