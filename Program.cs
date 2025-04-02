using System;
using System.Security.Cryptography.X509Certificates;


internal class Program
{

    public static void Main(string[] args)
    {
        //string address = "Peshkov str 75";
        //double distans = 500;
        //double weight = 10;
        string[,] arreyCourier = new string[1,4];
        string[,] arreyOrder;

        AddCourier(ref arreyCourier,"Piter","Foot",5);
        AddCourier(ref arreyCourier, "Alex", "Car", 4);




        bool exitDo = true;
        do
        {
            Console.WriteLine("Выберите действие\n1. работа с заказами\n2. работа с курьерами\n3. завершение работы");
            double ans = CheckNum("Выберите действие",false);
            if (ans == 1)
            {
                Console.WriteLine("Работа с заказами");
                viewOrder();
            }
            else if (ans==2)
            {
                Console.WriteLine("Работа с курьерами");
                viewСourier(arreyCourier);
            }
            else if (ans == 3)
            {
                Console.WriteLine("Работа завершена");
                exitDo = false;
            }
            else
            {
                Console.WriteLine("Error");

            }


        } while (exitDo);

    }

    private static void viewOrder()     
    {


        bool exitDo = true;
        do
        {
            Console.WriteLine("Выберите действие\n1. Список активных заказов\n2. Список завершенных заказов\n3. Список отказов\n4. Добавить заказ\n5. Удалить заказ\n6. Завершить заказ\n7. Возврат");
            double ans = CheckNum("Выберите действие", false);
            if (ans == 1)
            {
                
            }
            else if (ans == 2)
            {

            }
            else if (ans == 3)
            {
                
            }
            else if (ans == 4)
            {

            }
            else if (ans == 5)
            {

            }
            else if (ans == 6)
            {

            }
            else if (ans == 7)
            {
                exitDo = false;
                Console.WriteLine("Возврат");
            }
            else
            {
                Console.WriteLine("Error");

            }


        } while (exitDo);

    }

    static void viewСourier(string[,] arreyCourier)
    {


        bool exitDo = true;
        do
        {
            Console.WriteLine("Выберите действие\n1. Список курьров\n2. Добавить пешего\n3. Добавить вело\n4. Добавить авто\n5. Добавить грузо\n6. Удалить\n7. Возврат");
            double ans = CheckNum("Выберите действие", false);
            if (ans == 1)
            {
                showArrey(arreyCourier);
            }
            else if (ans == 2)
            {
                СourierFoot courierFoot = new СourierFoot();
            }
            else if (ans == 3)
            {
                СourierFoot courierFoot = new СourierFoot();
            }
            else if (ans == 4)
            {

            }
            else if (ans == 5)
            {

            }
            else if (ans == 6)
            {

            }
            else if (ans == 7)
            {
                exitDo = false;
                Console.WriteLine("Возврат");
            }
            else
            {
                Console.WriteLine("Error");

            }


        } while (exitDo);

    }

    //abstract class Delivery
    //{
    //    public string Address
    //    {
    //        get 
    //        { 
    //            return Address;
    //        }
    //        set 
    //        {
    //            Address = CheckStr("введите адрес");

    //        }

    //    }

    //    public double Distans 
    //    {
    //        get 
    //        {
    //            return Distans;
    //        }
    //        set 
    //        {
    //            Distans = CheckNum("введите растояние",false);

    //        }
    //    }

    //    public double Weight
    //    {
    //        get
    //        {
    //            return Weight;
    //        }
    //        set
    //        {
    //            Distans = CheckNum("введите вес", false);

    //        }
    //    }

    //}

    //class HomeDelivery : Delivery
    //{
    //    public HomeDelivery(string address, double distans, double weight)
    //    {
    //        Address= address;
    //        Distans= distans;
    //        Weight= weight;

    //    } 
    //    public void DisplayParam

    //}

    //class PickPointDelivery : Delivery
    //{
    //    public PickPointDelivery(string address, double distans, double weight)
    //    {
    //        Address = address;
    //        Distans = distans;
    //        Weight = weight;

    //    }
    //}

    //class ShopDelivery : Delivery
    //{
    //    public ShopDelivery(string address, double distans, double weight)
    //    {
    //        Address = address;
    //        Distans = distans;
    //        Weight = weight;

    //    }
    //}

    abstract class Сourier
    {
        public string Name;
        public void Courier(string name) 
        {
            Name = CheckStr("Введите имя");
        }
    }

    //class Сourieres : Сourier
    //{   
    //    protected string ID;
    //    public string[,] arreyСourier;

    //}

    class СourierFoot : Сourier
    {
        protected double maxDistans = 1000;
        protected double minWeght = 10;
        protected double Velosity = 8;
        

    }

    class СourierBicycle : Сourier
    {
        protected double maxDistans = 5000;
        protected double minWeght = 20;
        protected double Velosity = 16;


    }

    class СourierCar : Сourier
    {
        protected double maxDistans = 100000;
        protected double minWeght = 100;
        protected double Velosity = 120;


    }

    class СourierTruck : Сourier
    {
        protected double maxDistans = 100000;
        protected double minWeght = 10000;
        protected double Velosity = 80;


    }




    //class Order<TDelivery,
    //TStruct> where TDelivery : Delivery
    //{
    //    public TDelivery Delivery;

    //    public int Number;

    //    public string Description;

    //    public void DisplayAddress()
    //    {
    //        Console.WriteLine(Delivery.Address);
    //    }

    //    // ... Другие поля
    //}

    public static double CheckNum(string msg, bool checkZero)
    {
        //Console.WriteLine(msg);
        string str;
        bool exitDo = true;
        double inum = 0;
        do
        {
            str = Console.ReadLine();

            if (double.TryParse(str, out double num))
            {
                if (num == 0 && checkZero == true)
                {
                    Console.WriteLine("Error " + msg);
                }
                else
                {
                    exitDo = false;
                    inum = num;

                }
            }
            else
            {
                Console.WriteLine("Error " + msg);

            }


        } while (exitDo);
        return inum;


    }
    static string CheckStr(string msg)
    {
        Console.WriteLine(msg);
        string str;
        bool exitDo = true;
        do
        {

            str = Console.ReadLine();
            if (int.TryParse(str, out int Num) || str == "")
            {
                Console.WriteLine("Error " + msg);
            }
            else
            {
                
                exitDo = false;
            }


        } while (exitDo);

        return str;
    }

    static void AddCourier(ref string[,] arreyCourier, string Name, string Type, int Rating)
    {
        //Console.WriteLine(arreyCourier.GetUpperBound(0));
        //Console.WriteLine(arreyCourier.GetUpperBound(1));
        if (arreyCourier[arreyCourier.GetUpperBound(0), 0] !=null)
        {
            
        
            string[,] arreyTemp = new string[arreyCourier.GetUpperBound(0) + 2, 4];
            for (int i = 0; i <= arreyCourier.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arreyCourier.GetUpperBound(1); j++)
                {
                    arreyTemp[i, j] = arreyCourier[i, j];

                }

            }
            arreyCourier = arreyTemp;
        }
        arreyCourier[arreyCourier.GetUpperBound(0), 0] = "CR" + (arreyCourier.GetUpperBound(0) + 1).ToString("0000");
        arreyCourier[arreyCourier.GetUpperBound(0), 1] = Name;
        arreyCourier[arreyCourier.GetUpperBound(0), 2] = Type;
        arreyCourier[arreyCourier.GetUpperBound(0), 3] = Rating.ToString();

        //showArrey(arreyCourier);


    }

    static void showArrey(string[,] Arrey)
    {


        Console.WriteLine("\nСписок");
        for (int i = 0; i <= Arrey.GetUpperBound(0); i++)
        {
            string str = (i + 1).ToString() + ". ";
                
                
            for (int j = 0; j <= Arrey.GetUpperBound(1); j++)
            {

                
                str += Arrey[i, j]+" ";
                

            }
            Console.WriteLine(str);
        }

        Console.WriteLine();

    }






}