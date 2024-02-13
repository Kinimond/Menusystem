using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Menusystem
{
    internal class Menu
    {

        public string Title;
        private MenuItem[] MenuItems = new MenuItem[10]; 
        private int ItemCount = 0;

        public Menu(string title)
        {
            this.Title = title;
        }
        public void Show() {
            Console.WriteLine("Min fantastiske menu \n");
            for (int i = 0; i < MenuItems.Length; i++)
            {
                if (MenuItems[i] != null)
                {
                    Console.WriteLine(MenuItems[i].Title);
                }
            } 
        }
        public void AddMenuItem(string menuTitle)
        {
            MenuItem mi = new MenuItem(menuTitle);
            MenuItems[ItemCount] = mi;
            ItemCount++;
        }
        public int SelectMenuItem(int selectedMenuItem) {
            while(selectedMenuItem = )
            {
                int id = int.Parse(Console.ReadLine());
            }

            return id;
        }
    }
}