
    async Task  Main()
    {
    await MakeTeaAsync();
    Console.ReadKey();
}
    async Task MakeTeaAsync()
    {
        var water = await BoilWaterAsync();
        Console.WriteLine("Take the cups out");
        Console.WriteLine("Put tea bags in cups");
        var tea = $"Pour {water} in cups";
        Console.WriteLine(tea);
        // return tea;
    }

    async Task<string> BoilWaterAsync()
    {
        Console.WriteLine("Start the kettle");
        Console.WriteLine("Waiting for the kettle");
        await Task.Delay(5000);
        Console.WriteLine("Kettle finished boiling");

        return "hot water";
    }
    
 

