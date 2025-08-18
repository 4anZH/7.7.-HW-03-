using System;

namespace DeliveryService
{
    // Абстрактный базовый класс для курьеров
    public abstract class Courier
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public abstract string Type { get; }
        public abstract double MaxDistance { get; }
        public abstract double AverageSpeed { get; }
        public abstract double CarryingCapacity { get; }

        public Courier(string name)
        {
            _name = name;
        }

        public virtual double? CalculateDeliveryTime(double distance)
        {
            if (distance <= MaxDistance)
            {
                return distance / AverageSpeed;
            }
            return null;
        }

        public override string ToString()
        {
            return $"{Type} {Name} (Макс. расстояние: {MaxDistance} км, Скорость: {AverageSpeed} км/ч, Грузоподъемность: {CarryingCapacity} кг)";
        }
    }

    // Конкретные типы курьеров
    public class WalkingCourier : Courier
    {
        public override string Type { get { return "Пеший курьер"; } }
        public override double MaxDistance { get { return 5; } }
        public override double AverageSpeed { get { return 5; } }
        public override double CarryingCapacity { get { return 5; } }

        public WalkingCourier(string name) : base(name) { }
    }

    public class BicycleCourier : Courier
    {
        public override string Type { get { return "Велокурьер"; } }
        public override double MaxDistance { get { return 20; } }
        public override double AverageSpeed { get { return 15; } }
        public override double CarryingCapacity { get { return 15; } }

        public BicycleCourier(string name) : base(name) { }
    }

    public class CarCourier : Courier
    {
        public override string Type { get { return "Автокурьер"; } }
        public override double MaxDistance { get { return 500; } }
        public override double AverageSpeed { get { return 60; } }
        public override double CarryingCapacity { get { return 50; } }

        public CarCourier(string name) : base(name) { }
    }

    public class TruckCourier : Courier
    {
        public override string Type { get { return "Грузовой курьер"; } }
        public override double MaxDistance { get { return 1000; } }
        public override double AverageSpeed { get { return 80; } }
        public override double CarryingCapacity { get { return 2000; } }

        public TruckCourier(string name) : base(name) { }
    }



    // Служба доставки
    public class DeliveryService
    {
        private Courier[] _couriers;
        private int _courierCount;
        private int _orderCount;

        public DeliveryService(int maxCouriers, int maxOrders)
        {
            _couriers = new Courier[maxCouriers];
            _courierCount = 0;
            _orderCount = 0;
        }

        public bool AddCourier(Courier courier)
        {
            if (_courierCount >= _couriers.Length)
            {
                Console.WriteLine("Достигнуто максимальное количество курьеров!");
                return false;
            }

            _couriers[_courierCount++] = courier;
            Console.WriteLine($"Добавлен курьер: {courier}");
            return true;
        }

        public void ShowAllCouriers()
        {
            Console.WriteLine("\nСписок всех курьеров:");
            for (int i = 0; i < _courierCount; i++)
            {
                Console.WriteLine(_couriers[i]);
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var service = new DeliveryService(10, 50);

            // Добавляем курьеров по умолчанию
            service.AddCourier(new WalkingCourier("WC"));
            service.AddCourier(new BicycleCourier("BC"));
            service.AddCourier(new CarCourier("CC"));
            service.AddCourier(new TruckCourier("TC"));

            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Добавить курьера");
                //Console.WriteLine("2. Создать заказ");
                Console.WriteLine("3. Показать всех курьеров");
                //Console.WriteLine("4. Показать все заказы");
                Console.WriteLine("5. Выход");

                Console.Write("Выберите действие: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNewCourier(service);
                        break;
                    case "2":
                        break;
                    case "3":
                        service.ShowAllCouriers();
                        break;
                    case "4":
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор!");
                        break;
                }
            }
        }

        static void AddNewCourier(DeliveryService service)
        {
            Console.WriteLine("\nДобавление нового курьера:");
            Console.WriteLine("1. Пеший курьер");
            Console.WriteLine("2. Велокурьер");
            Console.WriteLine("3. Автокурьер");
            Console.WriteLine("4. Грузовой курьер");

            Console.Write("Выберите тип курьера: ");
            string typeChoice = Console.ReadLine();

            Console.Write("Введите имя курьера: ");
            string name = Console.ReadLine();

            Courier courier = null;
            switch (typeChoice)
            {
                case "1":
                    courier = new WalkingCourier(name);
                    break;
                case "2":
                    courier = new BicycleCourier(name);
                    break;
                case "3":
                    courier = new CarCourier(name);
                    break;
                case "4":
                    courier = new TruckCourier(name);
                    break;
                default:
                    Console.WriteLine("Неверный выбор типа курьера!");
                    return;
            }

            service.AddCourier(courier);
        }
    }
}