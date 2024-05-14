using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Blogging_Platform___SOLID
{
    // Abstract base class 'Manager' following the Open/Closed Principle (OCP)
    // It is open for extension by subclasses but closed for modification.
    public abstract class Manager
    {
        public string? uniqueId { get; set; }

        // Abstract methods enforce subclasses to provide their own implementations
        // without changing the base class structure.
        public abstract string Add(string uniqueId);
        public abstract string Remove(string uniqueId);
        public abstract string Update(string uniqueId);
    }

    // 'UserManager' class is responsible for user-related operations,
    // adhering to the Single Responsibility Principle (SRP).
    public class UserManager : Manager
    {
        // Each method in this class has a single reason to change,
        // which aligns with the SRP.
        public override string Add(string uniqueId)
        {
            // Using reflection to get the current method name for demonstration purposes.
            return $"{this.GetType().Name}.{MethodBase.GetCurrentMethod()?.Name}";
        }

        public override string Remove(string uniqueId)
        {
            return $"{this.GetType().Name}.{MethodBase.GetCurrentMethod()?.Name}";
        }

        public override string Update(string uniqueId)
        {
            return $"{this.GetType().Name}.{MethodBase.GetCurrentMethod()?.Name}";
        }
    }

    // 'PostManager' class is responsible for post-related operations,
    // following the SRP as well.
    public class PostManager : Manager
    {
        public override string Add(string uniqueId)
        {
            return $"{this.GetType().Name}.{MethodBase.GetCurrentMethod()?.Name}";
        }

        public override string Remove(string uniqueId)
        {
            return $"{this.GetType().Name}.{MethodBase.GetCurrentMethod()?.Name}";
        }

        public override string Update(string uniqueId)
        {
            return $"{this.GetType().Name}.{MethodBase.GetCurrentMethod()?.Name}";
        }
    }

     // 'CommentManager' class is responsible for comment-related operations,
    // also adhering to the SRP.
    public class CommentManager : Manager
    {
        public override string Add(string uniqueId)
        {
            return $"{this.GetType().Name}.{MethodBase.GetCurrentMethod()?.Name}";
        }

        public override string Remove(string uniqueId)
        {
            return $"{this.GetType().Name}.{MethodBase.GetCurrentMethod()?.Name}";
        }

        public override string Update(string uniqueId)
        {
            return $"{this.GetType().Name}.{MethodBase.GetCurrentMethod()?.Name}";
        }
    }
}