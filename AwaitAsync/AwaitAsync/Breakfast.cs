using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AwaitAsync
{
    public class Breakfast
    {
        public Breakfast()
        {
            Console.WriteLine("Let's prepare Breakfast");
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            Egg eggs =  FryEggs(2);
            Console.WriteLine("eggs are ready");

            Toast toast = ToastBread(2);
            Console.WriteLine("Toasting is completed");

            ApplyButter(toast);

            Juice juice = PourOj();
            Console.WriteLine("juice is ready");

            Console.WriteLine("Breakfast is ready");
        }

        private Juice PourOj()
        {
            Console.WriteLine("Pouring Orange Juice");
            return new Juice();
        }

        private static void ApplyButter(Toast toast)
        {
            Console.WriteLine("Putting butter on the toast");
        }

        private static Toast ToastBread(int s)
        {
            for (int i = 0; i < s; i++)
                Console.WriteLine("Putting a slica of bread in the toaster");
            Console.WriteLine("Start Toasting");
            Task.Delay(3000).Wait();
            Console.WriteLine("Remove toast from toaster");
            return new Toast();
        }

        private static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring Coffee");
            return new Coffee();
        }
        private static Egg FryEggs(int n)
        {
            Console.WriteLine("warming the egg pan");
            Task.Delay(3000).Wait();
            Console.WriteLine($"cracking {n} eggs");
            Console.WriteLine("Cooking the eggs...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put eggs on plate");
            return new Egg();
        }
    }
}
