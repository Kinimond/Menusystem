namespace Menusystem
{
    internal class Program
    {       static void Main(string[] args)
            {
                Menu mainMenu = new Menu("Min fantastiske menu");
                    

                // First menu item
                MenuItem mi = new MenuItem("1. Gør dit");
                mainMenu.AddMenuItem(mi.Title); 
          
                // Second menu item
                mi = new MenuItem("2. Gør dat");
                mainMenu.AddMenuItem(mi.Title);

                // Third menu item
                mi = new MenuItem("3. Gør noget");
                mainMenu.AddMenuItem(mi.Title);

                // Last menu item
                mi = new MenuItem("4. Få svaret på livet, universet og alting");
                mainMenu.AddMenuItem(mi.Title);

                mainMenu.Show();

                Console.ReadLine();
        }
    }
}