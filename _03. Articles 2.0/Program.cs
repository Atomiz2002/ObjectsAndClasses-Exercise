using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0 {
    class Program {
        static void Main(string[] args) {
            int articlesCount = Convert.ToInt32(Console.ReadLine());
            Article[] articles = new Article[articlesCount];

            while (articlesCount-- > 0)
                articles[articlesCount] = new Article(Console.ReadLine().Split(", "));

            string criteria = Console.ReadLine();

            foreach (Article article in articles.OrderBy(article => article.Get(criteria)))
                article.ToString();
        }
    }

    class Article {
        string title;
        string content;
        string author;

        public Article(string[] input) {
            title = input[0];
            content = input[1];
            author = input[2];
        }

        public string Get(string value) {
            switch (value) {
                case "title": return title;
                case "content": return content;
                case "author": return author;
            }
            return null;
        }

        public override string ToString() {
            Console.WriteLine($"{title} - {content}: {author}");
            return "";
        }
    }
}