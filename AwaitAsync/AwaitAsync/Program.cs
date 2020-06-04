using System;
using System.Threading.Tasks;

namespace AwaitAsync
{
    class Program
    {
        static async Task Main(string[] args)
        {

            //Breakfast Breakfast = new Breakfast();
            AsyncBreakfast b = new AsyncBreakfast();
            await b.PrepareBreakfastAsync();


        }
        //static async Task MainAsync(string[] args)
        //{
        //    Task.run(async () => new )
        //}

 
    }
    public class Coffee    {   }
    public class Egg { }
    public class Toast { }
    public class Juice { }
}
