using System.Reflection;

namespace Blogging_Platform___SOLID
{
    // ISP: Interface Segregation Principle
    // The principle states that no client should be forced to depend on methods it does not use.
    // Hence, we create small, specific interfaces.

    public interface ICommentable
    {
        // Allows an object to have commenting capability.
        string AddComment(string comment);
    }

    public interface ILikeable
    {
        // Allows an object to have liking capability.
        string LikePost();
    }

    public interface IShareable
    {
        // Allows an object to have sharing capability.
        string SharePost();
    }

    // 'Action' class implements the segregated interfaces, adhering to ISP.
    // It only implements the functionalities that are relevant to it.
    public class Action : ICommentable, ILikeable, IShareable
    {
        // Implements adding a comment to a post.
        public string AddComment(string comment)
        {
            return $"{this.GetType().Name}.{MethodBase.GetCurrentMethod()?.Name}";
        }

        // Implements sharing a post.
        public string SharePost()
        {
            return $"{this.GetType().Name}.{MethodBase.GetCurrentMethod()?.Name}";
        }

        // Implements liking a post.
        public string LikePost()
        {
            return $"{this.GetType().Name}.{MethodBase.GetCurrentMethod()?.Name}";
        }
    }
}
