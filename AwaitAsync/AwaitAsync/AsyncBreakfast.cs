using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AwaitAsync
{
    public class AsyncBreakfast
    {
        public async Task PrepareBreakfastAsync()
        {
            Console.WriteLine("Let's prepare Breakfast");
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");


            var eggsTask = FryEggsAsync(2);
            //Egg eggs = await eggsTask;
            //Console.WriteLine("eggs are ready");

            // Toast toast = ToastBread(2);
            var toastTask = ToastBreadAsync(2);           
            Toast toast = await toastTask;
            Console.WriteLine("Toasting is completed");

            ApplyButter(toast);

            Juice juice = PourOj();
            Console.WriteLine("juice is ready");

            await Task.WhenAll(eggsTask, toastTask);
            Console.WriteLine("eggs are ready");
            Console.WriteLine("Breakfast is ready!");

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



        private static async Task<Toast> ToastBreadAsync(int s)
        {
            for (int i = 0; i < s; i++)
                Console.WriteLine("Putting a slica of bread in the toaster");
            Console.WriteLine("Start Toasting");
            await Task.Delay(4000);
            Console.WriteLine("Remove toast from toaster");
            return new Toast();
        }

        private static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring Coffee");
            return new Coffee();
        }
        private static async Task<Egg> FryEggsAsync(int n)
        {
            Console.WriteLine("Egg Task started -- warming the egg pan");
            //Task.Delay(3000).Wait();
            await Task.Delay(6000);
            Console.WriteLine($"cracking {n} eggs");
            Console.WriteLine("Cooking the eggs...");
            //Task.Delay(3000).Wait();
            await Task.Delay(4000);
            Console.WriteLine("Put eggs on plate");
            return new Egg();
        }

    }
}
