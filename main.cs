using System;

/*
Author: J-Zach Loke
Class: CMPS-378
Due Date: 09/23/2021
Description:
    This program calculates the cost of an order put in at Baldi's Kitchen depending on the menu
    item to be ordered, the size of the party ordering, and whether or not they want cheesecake
    for dessert.
*/

namespace Quiz2
{
    /* Handles input, output, and processing for orders made at Baldi's Kitchen
    */
    class BaldisKitchen
    {
        // prices
        const double CHICKEN_PRICE = 20;
        const double PIZZA_PRICE = 25;
        const double SPAGHETTI_PRICE = 15;
        const double STEAK_PRICE = 35;
        const double CHEESECAKE_PRICE = 10;

        // attributes
        char menu {get; set;}
        int qty {get; set;}
        char cheesecake {get; set;}
        double total {get; set;}
        string menuItemName {get; set;}

        public void PrintMenu()
        {
            /* Prints the menu
            */
            Console.WriteLine("---------Welcome to Baldi's Kitchen-----------");
            Console.WriteLine("Chicken\t\tPizza\t\tSpaghetti\tSteak");
            Console.WriteLine($"${CHICKEN_PRICE}\t\t${PIZZA_PRICE}\t\t${SPAGHETTI_PRICE}\t\t${STEAK_PRICE}");
        }

        public void CollectOrder()
        {
            /* Collects user input and saves them in the appropriate class attributes
            */
            Console.Write("Select your meal (C - Chicken, P - Pizza, S - Spaghetti, T- Steak): ");
            menu = Convert.ToChar(Console.ReadLine());
            Console.Write("How many people in your party: ");
            qty = Convert.ToInt32(Console.ReadLine());
            Console.Write("Would you like to try out Baldi's Homemade Cheesecake for $10 per party: ");
            cheesecake = Convert.ToChar(Console.ReadLine());
        }

        public void CalculateTotal()
        {
            /* Based on the user input, calculates the total of the bill
            */
            if (menu == 'C') {
                total = qty * CHICKEN_PRICE;
                menuItemName = "Chicken";
            }
            else if (menu == 'P') {
                total = qty * PIZZA_PRICE;
                menuItemName = "Pizza";
            }
            else if (menu == 'S') {
                total = qty * SPAGHETTI_PRICE;
                menuItemName = "Spaghetti";
            }
            else if (menu == 'T') {
                total = qty * STEAK_PRICE;
                menuItemName = "Steak";
            }

            if (cheesecake == 'Y') {
                total += qty * CHEESECAKE_PRICE;
            }
        }

        public void DisplayOrder()
        {
            /* Prints the order confirmation with total.
            */
            Console.WriteLine($"\nYour total is ${total}\nYour order was {menuItemName} for the party of {qty}. Cheesecake Included: {cheesecake}");
        }
    }



    class MainClass
    {
        /* Purely a driver class to call logic in BaldisKitchen class
        */
        static void Main(string[] args)
        {
            BaldisKitchen waiter = new BaldisKitchen();
            waiter.PrintMenu();
            waiter.CollectOrder();
            waiter.CalculateTotal();
            waiter.DisplayOrder();

            Console.ReadKey();
        }
    }
}