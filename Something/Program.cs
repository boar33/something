namespace Something
{
    internal class Program
    {
        public const string Equal = "equal";
        public const string Rectangular = "rectangular";
        public const string Circular = "circular";

        static void Main(string[] args)
        {
            // var book1 = new Book();
            // book1.Author = "New Writer";
            // book1.Title = "First Book";
            // book1.Publisher = "Publisher 1";

            // var book2 = new Book();
            // book2.Author = "New Writer";
            // book2.Title = "Second Book";
            // book2.Publisher = "Publisher 2";
            // book2.Description = "Interesting read";

            // Console.WriteLine(BookDetails(book1));
            // Console.WriteLine(BookDetails(book2));
            // string compare1 = Solve([], []);
            // string compare2 = Solve([new Rectangle(1, 5)], []);
            // string compare3 = Solve([], [new Circle(1)]);
            // string compare4 = Solve(
            //     [new Rectangle(5.0, 2.1), new Rectangle(3, 3)],
            //     [new Circle(1), new Circle(10)]
            // );
            // Console.WriteLine($"compare1 is {compare1}");
            // Console.WriteLine($"compare2 is {compare2}");
            // Console.WriteLine($"compare3 is {compare3}");
            // Console.WriteLine($"compare4 is {compare4}");
            // var isEnough1 = IsEnough(0, []);
            // var isEnough2 = IsEnough(1, [new Rectangle(1, 1)]);
            // var isEnough3 = IsEnough(100, [new Circle(5)]);
            // var isEnough4 = IsEnough(
            //     5,
            //     [new Rectangle(1, 1), new Circle(1), new Rectangle(1.4, 1)]
            // );
            // Console.WriteLine($"Is Enough1: {isEnough1}");
            // Console.WriteLine($"Is Enough2: {isEnough2}");
            // Console.WriteLine($"Is Enough3: {isEnough3}");
            // Console.WriteLine($"Is Enough4: {isEnough4}");

            var bankAccount = new BankAccount(10_000);
            var user = new User(1000, bankAccount.Balance);
            bankAccount.OnBalanceDecreased += user.ReduceFunds;
            bankAccount.DecreaseBalance(100);

            Console.WriteLine($"Balance: {bankAccount.Balance}");
            Console.WriteLine($"User funds {user.Funds}");

            Console.WriteLine("Press any key to exit program.");
            Console.ReadKey();
        }

        private static string BookDetails(Book book)
        {
            var author = $"Author: {book.Author}\n";
            var title = $"Title: {book.Title}\n";
            var publisher = $"Publisher: {book.Publisher}\n";
            var description = $"Description: {book.Description}\n";
            return author + title + publisher + description;
        }

        public static string Solve(Rectangle[] rectangularSection, Circle[] circularSection)
        {
            var totalAreaOfRectangles = CalculateTotalAreaOfRectangles(rectangularSection);
            var totalAreaOfCircles = CalculateTotalAreaOfCircles(circularSection);
            return GetBigger(totalAreaOfRectangles, totalAreaOfCircles);
        }

        private static string GetBigger(double totalAreaOfRectangles, double totalAreaOfCircles)
        {
            const double margin = 0.01;
            bool areAlmostEqual = Math.Abs(totalAreaOfRectangles - totalAreaOfCircles) <= margin;
            if (areAlmostEqual)
            {
                return Equal;
            }
            else if (totalAreaOfRectangles > totalAreaOfCircles)
            {
                return Rectangular;
            }
            else
            {
                return Circular;
            }
        }

        private static double CalculateTotalAreaOfCircles(Circle[] circularSection)
        {
            double total = 0;
            foreach (var c in circularSection)
            {
                total += c.Area;
            }

            return total;
        }

        private static double CalculateTotalAreaOfRectangles(Rectangle[] rectangularSection)
        {
            double total = 0;
            foreach (var r in rectangularSection)
            {
                total += r.Area;
            }

            return total;
        }

        private static bool IsEnough(double mosaicArea, IShape[] tiles)
        {
            double total = 0;
            foreach (var t in tiles)
            {
                total += t.Area;
            }
            const double tolerance = 0.0001;
            return total - mosaicArea >= -tolerance;
        }
    }
}
