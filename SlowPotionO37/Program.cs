using System;
					
public class Program
{
	public static async Task Main()
	{
		await BrewPotion(); //tell it i want to wait for this to finish
        
	}

    static async Task BrewPotion()
        {
            Console.WriteLine("Starting potion brew...");
            await Task.Delay(3000);
            Console.WriteLine("Potion finished!");
        }
}