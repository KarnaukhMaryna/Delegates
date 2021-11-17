using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates.Classes
{
    class FileringMethods
    {
        public delegate IEnumerable<User> FilterDelegate(List<User> usersList);

        public static IEnumerable<User> Filter(FilterDelegate filter, List<User> usersList) => filter(usersList);

        public static IEnumerable<User> AgeFilter(List<User> usersList) => usersList.OrderBy(user => user.Age);

        public static IEnumerable<User> NameFilter(List<User> usersList) => usersList.OrderBy(user => user.Name);

        public static IEnumerable<User> GenderFilter(List<User> usersList) => usersList.OrderBy(user => user.Gender);

    }
}
