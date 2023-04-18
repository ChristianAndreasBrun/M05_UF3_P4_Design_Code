using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Code
{
    public abstract class Product
    {
        public int id;
        public bool visibility;
        public string name;
        public string brand;
        public string description;
        public float basePrice;
        public float discount;

        public List<Media> media;
        public List<Review> review;
        public bool Buy(int user)
        {
            return true;
        }
    }

    public abstract class Category : Product
    {
        private bool Update()
        {
            return true;
        }
    }

    public class Label : Product
    {
        public string labelName;
    }


    public class High : Category
    {
        public string categoryName;
        public string categoryDescription;
    }

    public class Medium : Category
    {
        public string categoryName;
        public string categoryDescription;
    }

    public class Low : Category
    {
        public string categoryName;
        public string categoryDescription;
    }
}
