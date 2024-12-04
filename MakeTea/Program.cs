//let's make this async together ...

//MakeTea();
await MakeTeaAsync();
Console.ReadLine();



//string MakeTea()
//{
//    var water = BoilWater();
//    Console.WriteLine("Take the cups out");
//    Console.WriteLine("Put tea bags in cups");
//    var tea = $"Pour {water} in cups";
//    Console.WriteLine(tea);
//    return tea;
//}

//string BoilWater()
//{
//    Console.WriteLine("Start the kettle");
//    Console.WriteLine("Waiting for the kettle");
//    Task.Delay(2000).GetAwaiter().GetResult();
//    Console.WriteLine("Kettle finished boiling");

//    return "hot water";
//}

async Task<string> MakeTeaAsync()
{
    var boilingwater = BoilWaterAsync();
    Console.WriteLine("Take the cups out");
    Console.WriteLine("Put tea bags in cups");
    var water = await boilingwater;
    var tea = $"Pour {water} in cups";
    Console.WriteLine(tea);
    return tea;
}

async Task<string> BoilWaterAsync()
{
    Console.WriteLine("Start the kettle");
    Console.WriteLine("Waiting for the kettle");
    await Task.Delay(2000);
    Console.WriteLine("Kettle finished boiling");

    return "hot water";
}


