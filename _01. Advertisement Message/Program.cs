using System;

namespace _01._Advertisement_Message {
    class Program {
        static void Main(string[] args) {
            int x = Convert.ToInt32(Console.ReadLine());
            while (x-- > 0)
                Console.WriteLine($"{Rand.Phrase()} {Rand.Event()} {Rand.Author()} - {Rand.City()}");
        }
    }

    static class Rand {
        private static Random random = new Random();

        public static String Phrase() {
            String[] phrase = new[] {
                "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product."
            };
            return phrase[random.Next(phrase.Length - 1)];
        }

        public static String Event() {
            String[] phrase = new[] {
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };
            return phrase[random.Next(phrase.Length - 1)];
        }

        public static String Author() {
            String[] phrase = new[] {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
            return phrase[random.Next(phrase.Length - 1)];
        }

        public static String City() {
            String[] phrase = new[] {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};
            return phrase[random.Next(phrase.Length - 1)];
        }
    }
}