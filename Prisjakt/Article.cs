using System;

namespace Prisjakt
{
    [Serializable()]
    public class Article
    {
        private int ID;
        private long categoryID;
        private string name;
        private int price;
        private int previousPrice;
        private int rank;

        public Article(int ID, long categoryID, string name, int rank)
        {
            this.ID = ID;
            this.categoryID = categoryID;
            this.name = name;
            this.rank = rank;
        }

        public int GetID()
        {
            return ID;
        }

        public long GetCategoryID()
        {
            return categoryID;
        }

        public string GetName()
        {
            return name;
        }

        public int GetPrice()
        {
            return price;
        }

        public int GetPreviousPrice()
        {
            return previousPrice;
        }

        public int GetRank()
        {
            return rank;
        }

        public void UpdatePrice(int price)
        {
            previousPrice = this.price;
            this.price = price;
        }

        public void EditArticle(int ID, long categoryID, string name, int rank)
        {
            this.ID = ID;
            this.categoryID = categoryID;
            this.name = name;
            this.rank = rank;
        }
    }
}
