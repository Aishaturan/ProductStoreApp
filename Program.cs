using System; // Подключаем базовую библиотеку

namespace ProductStore // Пространство имён для проекта
{
    // Класс, описывающий товар в магазине
    public class Product
    {
        // Свойство: название товара
        public string Name { get; private set; } 

        // Свойство: цена товара
        public decimal Price { get; private set; }

        // Свойство: количество товара на складе
        public int Stock { get; private set; }

        // Конструктор, принимающий все параметры
        public Product(string name, decimal price, int stock)
        {
            Name = name; // Устанавливаем название
            Price = price; // Устанавливаем цену
            Stock = stock; // Устанавливаем количество на складе
        }

        // Конструктор, принимающий только название, цена и количество по умолчанию 0
        public Product(string name)
        {
            Name = name; // Устанавливаем название
            Price = 0; // Устанавливаем цену по умолчанию
            Stock = 0; // Устанавливаем количество по умолчанию
        }

        // Метод для обновления цены товара
        public void UpdatePrice(decimal newPrice)
        {
            Price = newPrice; // Обновляем цену
        }

        // Метод для пополнения запаса товара
        public void Restock(int quantity)
        {
            Stock += quantity; // Увеличиваем количество на складе
        }

        // Метод для продажи товара
        public void Sell(int quantity)
        {
            if (quantity <= Stock) // Проверяем, достаточно ли товара
            {
                Stock -= quantity; // Уменьшаем количество
            }
            else
            {
                Console.WriteLine("Недостаточно товара на складе."); // Выводим сообщение об ошибке
            }
        }

        // Метод для получения информации о товаре
        public string GetProductInfo()
        {
            return $"Название: {Name}, Цена: {Price}, Остаток на складе: {Stock}"; // Возвращаем строку с данными
        }
    }

    // Класс с точкой входа в программу
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект товара с полными параметрами
            Product product1 = new Product("Ноутбук", 50000, 10);
            
            // Создаем объект товара только с названием
            Product product2 = new Product("Мышь");

            // Обновляем цену товара
            product2.UpdatePrice(1200);

            // Пополняем запас
            product2.Restock(50);

            // Продаем 5 штук
            product2.Sell(5);

            // Выводим информацию о товаре
            Console.WriteLine(product1.GetProductInfo());
            Console.WriteLine(product2.GetProductInfo());
        }
    }
}
