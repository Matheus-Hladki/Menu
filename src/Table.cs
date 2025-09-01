using System;
using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        private List<Dish> order = new List<Dish>();
        private bool IsOccupied;
        public bool isOccupied
        {
            get { return IsOccupied; } 
        }
        private int Number;
        public int number
        {
            get { return Number; } 
        }
        
        public void Occupy()
        {
            this.IsOccupied = true;
        }

        public void Free()
        {
            this.IsOccupied = false;
            order.Clear();
        }

        public void AddToOrder(Dish dish)
        {
            order.Add(dish);
            Console.WriteLine("Order Added Successfully");
        }
        public bool HasOrders()
        {
            return this.order.Count > 0;
        }

        public Table(int number)
        {
            this.Number = number;
        }
    }
}