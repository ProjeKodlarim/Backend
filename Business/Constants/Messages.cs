using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string CategoryAdded;
        public static string CategoryDeleted;
        public static string CategoryListed;
        public static string CategoryUpdated;
        public static string ProductListed;
        public static string CategoryIdinProductListed;
        public static string ProductUpdated;
        public static string userNotFound;
        internal static string ProductNameAlreadyExists;
        internal static string ProductDeleted;
        internal static string UserRegistered;
        internal static string UserNotFound;
        internal static string PasswordError;
        internal static string SuccessfulLogin;
        internal static string UserAlreadyExists;
        internal static string AccessTokenCreated;
        internal static string cartItemAdded;
        internal static string cartItemsUpdated;
    }
}
