// This is challenge work for the "C# Players Guide"
// Level 18 the Vin Fletcher's Arrows Challenge
// This challenge requires a new arrow class with fields for arrowhead type, fletching type, and length
// A user should be able to pick the arrowhead, fletching type, and length
// Once those items are selected a new arrows instance should be created
// Add a get cost method that returns its cost as a float based on the arrow attributes selected by the user

//Main
string arrowHead = "Steel";
string fletching = "Plastic";
Arrow a = new Arrow(ArrowHead, Fletching, .005f);

Console.WriteLine(a._ArrowHead);
 Console.ReadKey();

//Method



//Get user info for Arrowhead
Console.WriteLine("Please enter the Arrowhead type that you would like to use on your custom arrows: ");


// Get user info for Fletching type
Console.WriteLine("Please enter the Fletching type you would like to use on your custom arrows: ");


//Get user info for Arrow Length


//Class
class Arrow
{
    public string _ArrowHead;
    public string _Fletching;
    public float _length;

    public Arrow(string ArrowHead, string Fletching, float Length)
    {
        _ArrowHead = ArrowHead;
        _Fletching = Fletching;
        _length = Length;
    }
}

//Enumerations
enum Arrowhead { Steel, Wood, Obsidian }
enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }