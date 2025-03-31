internal class Program
{
    private static void Main(string[] args)
    {
        //string address = "Peshkov str 75";
        //double distans = 500;
        //double weight = 10;

        

    }

    abstract class Delivery
    {
        public string Address
        {
            get 
            { 
                return Address;
            }
            set 
            {
                Address = CheckStr("введите адрес");
                
            }
        
        }

        public double Distans 
        {
            get 
            {
                return Distans;
            }
            set 
            {
            
            }
        }

        public double Weight
        {
            get
            {
                return Weight;
            }
            set
            {
                Distans = CheckNum("введите вес", false);

            }
        }

    }

    class HomeDelivery : Delivery
    {
        public HomeDelivery(string address, double distans, double weight)
        {
            Address= address;
            Distans= distans;
            Weight= weight;
       
        } 
        public void DisplayParam

    }

    class PickPointDelivery : Delivery
    {
        public PickPointDelivery(string address, double distans, double weight)
        {
            Address = address;
            Distans = distans;
            Weight = weight;

        }
    }

    class ShopDelivery : Delivery
    {
        public ShopDelivery(string address, double distans, double weight)
        {
            Address = address;
            Distans = distans;
            Weight = weight;

        }
    }

    //abstract class TypeDelivery
    //{


    //}

    //class Сourier : TypeDelivery
    //{ 



    //}

    //class Bicycle : TypeDelivery
    //{



    //}

    //class Car : TypeDelivery
    //{



    //}

    //class Truck : TypeDelivery
    //{



    //}




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

    static double CheckNum(string msg, bool checkZero)
    {
        Console.WriteLine(msg);
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









}