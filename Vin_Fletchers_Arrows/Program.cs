// This is challenge work for the "C# Players Guide"
// Level 18 the Vin Fletcher's Arrows Challenge
// This challenge requires a new arrow class with fields for arrowhead type, fletching type, and length
// A user should be able to pick the arrowhead, fletching type, and length
// Once those items are selected a new arrows instance should be created
// Add a get cost method that returns its cost as a float based on the arrow attributes selected by the user

//Main


(Arrowhead _Arrowhead, Fletching _Fletching, float Length) CustomArrow = BuildArrow();
//Pass CustomArrow to  Arrow Class
//Arrow a = new Arrow(ArrowHead, Fletching, .005f);
Arrow b = new Arrow(CustomArrow._Arrowhead, CustomArrow._Fletching, CustomArrow.Length);

Console.WriteLine($"{b._length}, {b._Fletching}, {b._ArrowHead}");

//Methods
(Arrowhead, Fletching, float Length) BuildArrow()
    
{
    //Get user info for Arrowhead
    string arrow_info = "null";
    while (arrow_info != "steel" && arrow_info != "wood" && arrow_info != "obsidian")
    {
        Console.WriteLine("Please enter the Arrowhead type that you would like to use on your custom arrows:  Steel,Wood, or Obsidian");
        arrow_info = Console.ReadLine().ToLower();
    }
    Arrowhead _Arrowhead = arrow_info switch
    {
        "steel" => Arrowhead.Steel,
        "wood" => Arrowhead.Wood,
        "obsidian" => Arrowhead.Obsidian,
    };
 
    // Get user info for Fletching type
    string fletching_info = "null";
    while (fletching_info != "plastic" && fletching_info != "turkey feathers" && fletching_info != "goose feathers")
    {
        Console.WriteLine("Please enter the Fletching type you would like to use on your custom arrows: Plastic, Turkey Feathers, or Goose Feathers");
        fletching_info = Console.ReadLine().ToLower();
    }
    Fletching _Fletching = fletching_info switch
    {
        "plastic" => Fletching.Plastic,
        "turkey feathers" => Fletching.TurkeyFeathers,
        "goose feathers" => Fletching.GooseFeathers,
    };

    //Get user info for Arrow Length
    float _Length;
    do
    {
        Console.WriteLine("Please enter the length that would like your custom arrows to be:  Between 60 and 100 cm");
        _Length = Convert.ToSingle(Console.ReadLine());
    }
    while (_Length < 60 || _Length > 100);
    return (_Arrowhead, _Fletching, _Length); 


}

//Class
class Arrow
{
    public Arrowhead _ArrowHead;
    public Fletching _Fletching;
    public float _length;

    public Arrow(Arrowhead ArrowHead, Fletching Fletching, float Length)
    {
        _ArrowHead = ArrowHead;
        _Fletching = Fletching;
        _length = Length;
    }
}

//Enumerations
enum Arrowhead { Steel, Wood, Obsidian }
enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }