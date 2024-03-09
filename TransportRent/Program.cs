//Name Type
//Caterpillar bulldozer Heavy
//Kamaz truck Regular
//Komatsu crane Heavy
//Volvo steamroller Regular
//Bosch jackhammer Specialized

//There are three different fees:
//One - time rental fee - 100 EUR
//Premium daily fee - 60 EUR/day
//Regular daily fee - 40EUR/day



//interface Transport
//{  }

class Client
{
    public int loyalityPoint = 0;
    public double Purchase(string productType, int days)//Product product
    {

        double premiumPrice = 60;
        double regularPrice = 40;
        double finalprice = 0;
        double oneTimerental = 100;
        if (productType == "Heavy") //product.productType == "Heavy"
        {
            finalprice = oneTimerental + (premiumPrice * days);
            loyalityPoint += 2;
        }
        else if (productType == "Regular")
        {
            if (days > 3)
            {
                finalprice = oneTimerental + (premiumPrice * 2) + (regularPrice * (days - 2));
            }
            else if (days <= 3)
            {
                finalprice = oneTimerental + (premiumPrice * days);
            }

            loyalityPoint += 1;
        }
        else if (productType == "Specialized")
        {
            if (days > 3)
            {
                finalprice = (premiumPrice * 3) + (regularPrice * (days - 3));
            }
            else if (days <= 3)
            {
                finalprice = premiumPrice * days;
            }
            loyalityPoint += 1;
        }




        return finalprice;
    }
}




abstract class Product
{



    private string? productType;

    public string ProductType
    {
        get { return productType; }
        set { productType = value; }
    }


}
class Bulldozer : Product
{

    private string? productType = "Heavy";



}
class Truck
{ }

class Crane
{ }

class Steamroller
{ }

class Jackhammer
{ }


class Program
{
    public static void Main(string[] args)
    {
        Client client = new Client();

        Console.WriteLine(client.Purchase("Heavy", 3));
        Console.WriteLine(client.Purchase("Regular", 5));
        Console.WriteLine(client.Purchase("Specialized", 5));
        Console.WriteLine(client.loyalityPoint);//4
    }
}