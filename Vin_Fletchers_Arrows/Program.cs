﻿// This is challenge work for the "C# Players Guide"
// Level 18 the Vin Fletcher's Arrows Challenge
// This challenge requires a new arrow class with fields for arrowhead type, fletching type, and length
// A user should be able to pick the arrowhead, fletching type, and length
// Once those items are selected a new arrows instance should be created
// Add a get cost method that returns its cost as a float based on the arrow attributes selected by the user

//Main
Console.WriteLine("Welcome to Vin Fleatcher's High End Arrows");
Console.WriteLine("Fabulous Arrows for Fabulous Rangers!");
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Press any key to build the Arrow of your dream");
Console.ReadKey();
Console.Clear();


// Call Arrow Factory, this allows more than one instance of arrow to be created or added later
Arrow ArrowOne = ArrowFactory();
Console.WriteLine($"test : {ArrowOne._ArrowHead}");


//Methods

// ArrowFactory Method (Method of methods) to return new arrow:
// This is needed so that main can call as many arrows as is needed (if needed)
Arrow ArrowFactory()
{
    Console.WriteLine(" Arrow Factory 3000: Ready to take your order!");
    Arrowhead ArrowHead = BuildArrowHead(); //must be set to Arrowhead because of the enum
    Fletchingmaterial FletchingMaterial = BuildFletchingMaterial(); //must be set to Fletchingmaterial because of the enum
    float TotalLength = BuildTotalLength();
    return new Arrow(ArrowHead, FletchingMaterial, TotalLength);
}


//must be set to Arrowhead because of the enum
Arrowhead BuildArrowHead() 
{
    //Get user info for Arrowhead
    string arrow_info = "null";
    while (arrow_info != "steel" && arrow_info != "wood" && arrow_info != "obsidian")
    {
        Console.WriteLine("Please enter the Arrowhead type that you would like to use on your custom arrows:  Steel,Wood, or Obsidian");
        arrow_info = Console.ReadLine().ToLower();
    }
    Arrowhead head = arrow_info switch //must be set to Arrowhead because of the enum
    {
        //standardized input using enum
        "steel" => Arrowhead.Steel,
        "wood" => Arrowhead.Wood,
        "obsidian" => Arrowhead.Obsidian,
    };
    return head;
}

Fletchingmaterial BuildFletchingMaterial() //must be set to Fletchingmaterial because of the enum
{
    // Get user info for Fletching type
    string fletching_info = "null";
    while (fletching_info != "plastic" && fletching_info != "turkey feathers" && fletching_info != "goose feathers")
    {
        Console.WriteLine("Please enter the Fletching type you would like to use on your custom arrows: Plastic, Turkey Feathers, or Goose Feathers");
        fletching_info = Console.ReadLine().ToLower();
    }
    Fletchingmaterial fletch = fletching_info switch  //must be set to Fletchingmaterial because of the enum
    {
        //standardized input using enum
        "plastic" => Fletchingmaterial.Plastic,
        "turkey feathers" => Fletchingmaterial.TurkeyFeathers,
        "goose feathers" => Fletchingmaterial.GooseFeathers,
    };
    return fletch;
}

float BuildTotalLength()
{
    //Get user info for Arrow Length
    float Length;
    do
    {
        Console.WriteLine("Please enter the length that would like your custom arrows to be:  Between 60 and 100 cm");
        Length = Convert.ToSingle(Console.ReadLine());
    }
    while (Length < 60 || Length > 100);
    return Length;
}


class Arrow
{
    //must be set to Arrowhead because of the enum
    //must be set to Fletchingmaterial because of enum 
    public Arrowhead _ArrowHead; 
    public Fletchingmaterial _FletchingMaterial; 
    public float _TotalLength;

    //must be set to Arrowhead because of the enum
    //must be set to Fletchingmaterial because of enum 
    public Arrow(Arrowhead ArrowHead, Fletchingmaterial FletchingMaterial, float TotalLength)
    {
        _ArrowHead = ArrowHead;
        _FletchingMaterial = FletchingMaterial;
        _TotalLength = TotalLength;
    }
//Method for total price
}

//Enum
enum Arrowhead { Steel, Wood, Obsidian }
enum Fletchingmaterial { Plastic, TurkeyFeathers, GooseFeathers }
