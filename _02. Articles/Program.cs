using System;
using System.ComponentModel.DataAnnotations;

namespace _02._Articles {
    class Program {
        static void Main(string[] args) {
            Article article = new Article(Console.ReadLine().Split(", "));
            int lines = Convert.ToInt32(Console.ReadLine());
            
            while (lines-- > 0) {
                string[] input = Console.ReadLine().Split(": ");
                string command = input[0];
                string content = input[1];
                switch (command) {
                    case "Edit":
                        article.Edit(content);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(content);
                        break;
                    case "Rename":
                        article.Rename(content);
                        break;
                }
            }

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

        public void Edit(string content) {
            this.content = content;
        }

        public void ChangeAuthor(string author) {
            this.author = author;
        }

        public void Rename(string title) {
            this.title = title;
        }

        public override string ToString() {
            Console.WriteLine($"{title} - {content}: {author}");
            return "";
        }
    }
}