using System.Collections.Generic;
using Ucu.Poo.Restaurant;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
    /// restaurante.
    /// </summary>
    public class Menu
    {
        private List<Dish> dishes = new List<Dish>();
        // Agregar un platillo a la lista de platillos del menú.
        public void AddDish(Dish dish)
        {
            dishes.Add(dish);
        }

// Eliminar un platillo de la lista del menú.
        public void RemoveDish(Dish dish)
        {
            dishes.Remove(dish);
        }

// Buscar y devolver un platillo específico del menú basado en su nombre; retorna null si no encuentra en platillo.
        public Dish GetDishByName(string name)
        {
            foreach (Dish dish in dishes)
            {
                if (dish.name == name)
                    return dish;
            }

            return null;
        }
    }
}

