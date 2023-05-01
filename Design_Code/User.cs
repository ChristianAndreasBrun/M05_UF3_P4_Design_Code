using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Code
{
    public class User
    {
        public string name;
        public string surname;
        public string email;
        public string password;
        protected string telephone;
        private string Address;
        private string DNI;

        public List<WishList> wishList;
        public List<Address> addressList;

        public bool Payment(int product)
        {
            return true;
        }
    }

    public abstract class WishList
    {
        public Product productList;
    }
}
