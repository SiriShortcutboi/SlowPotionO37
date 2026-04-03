using System;
					
public class Program
{
	public static async Task Main()
	{
		await BrewPotion(); //tell it i want to wait for this to finish
        //because it's a main youre still just starting it up and running
        //other methods through it. 
	}

    static async Task BrewPotion()
        {
            Console.WriteLine("Starting potion brew...");
            await Task.Delay(3000);
            Console.WriteLine("Potion finished!");
        }
}

//we got void main, task main, no main, 
        //Ghost main up in this c sharp joint