using System;
using System.Collections.Generic;
using System.Linq;

namespace Prisjakt
{
    [Serializable()]
    public class Database
    {
        private Dictionary<string, List<Article>> articles;
        private int nrArticles;
        private string lastUpdated;

        public Database()
        {
            articles = new Dictionary<string, List<Article>>();
            nrArticles = 0;
        }

        public void AddArticle(string group, int ID, long categoryID, string name, int rank)
        {
            if (!articles.ContainsKey(group))           
                articles.Add(group, new List<Article>());

            articles[group].Add(new Article(ID, categoryID, name, rank));
            nrArticles++;
        }

        public void RemoveArticle(string group, string name)
        {
            Article article = GetArticle(group, name);

            if (article != null)
            {
                articles[group].Remove(article);
                nrArticles--;

                if (articles[group].Count == 0)
                    articles.Remove(group);
            }
        }

        public ICollection<string> GetGroups()
        {
            return articles.Keys;
        }

        public Article GetArticle(string group, string name)
        {
            foreach (Article article in articles[group])
                if (article.GetName().Equals(name))
                    return article;

            return null;
        }

        public ICollection<Article> GetArticles(string group)
        {
            return articles[group].OrderBy(c => c.GetName()).ToList();
        }

        public int GetNrArticles()
        {
            return nrArticles;
        }

        public string GetLastUpdated()
        {
            return lastUpdated;
        }

        public void SetLastUpdated(string lastUpdated)
        {
            this.lastUpdated = lastUpdated;
        }
    }
}
