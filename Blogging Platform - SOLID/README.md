# Blogging Platform - SOLID Principles

This project demonstrates the implementation of SOLID principles in a blogging platform context.


## SOLID Principles

### Single Responsibility Principle (SRP)
The Single Responsibility Principle (SRP) states that a class should have only one reason to change. In the provided codebase, this principle is adhered to by the `UserManager`, `PostManager`, and `CommentManager` classes. Each class has a single responsibility of managing users, posts, and comments respectively. By following SRP, the codebase becomes more modular, easier to understand, and less prone to bugs.

### Open/Closed Principle (OCP)
The Open/Closed Principle (OCP) states that a class should be open for extension but closed for modification. In the codebase, this principle is demonstrated by the abstract base class `Manager`. New manager types (e.g., for managing tags or categories) can be added without altering the existing code structure. This promotes code reuse and minimizes the risk of introducing bugs when extending functionality.

### Liskov Substitution Principle (LSP)
The Liskov Substitution Principle (LSP) states that objects of a superclass should be replaceable with objects of its subclasses without affecting the correctness of the program. This principle is demonstrated in the codebase by using derived classes (`UserManager`, `PostManager`, `CommentManager`) through references to their base class (`Manager`). This allows for polymorphic behavior and promotes code flexibility.

### Interface Segregation Principle (ISP)
The Interface Segregation Principle (ISP) states that clients should not be forced to depend on interfaces they do not use. This principle is demonstrated in the `Action` class, which implements three different interfaces: `ICommentable`, `ILikeable`, and `IShareable`. By segregating interfaces based on specific functionalities, the `Action` class ensures that it only contains methods necessary for its functionality.

### Dependency Inversion Principle (DIP)
The Dependency Inversion Principle (DIP) states that high-level modules should not depend on low-level modules but should depend on abstractions. In the provided codebase, DIP is implemented with the `Notification` class. Instead of depending on concrete implementations of notification services (`EmailNotificationService`, `SMSNotificationService`, `PushNotificationService`), the `Notification` class depends on the abstraction `INotificationService`. This promotes loose coupling and allows for easier extensibility and maintenance.


## Usage

To run the program, simply execute the `Program.Main` method. It will demonstrate the instantiation of different manager types and handle any exceptions that may occur during execution.

## Conclusion

The application of SOLID principles leads to a more maintainable and scalable codebase, making it easier to extend and modify the blogging platform in the future.
