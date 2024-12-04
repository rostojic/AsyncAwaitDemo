using System;
using System.IO;
//Complexity chahnges if you use async proramming with no async/await
//Playing arround with Task nature
/* Snippet 1 */
//var lines = File.ReadAllLines("TextFile1.txt");

//foreach (var line in lines)
//{
//    Console.WriteLine(line);
//}

/* Snippet 2 */
//problematic code
//File.ReadAllLinesAsync("TextFile.txt")
//    .ContinueWith(t =>
//    {
//        if (t.IsFaulted)
//        {
//            Console.WriteLine(t.Exception.Message);
//            return;
//        }
//    foreach (var line in t.Result)
//    {
//        Console.WriteLine(line);
//    }

//  });

/* Snippet 3 */
//easy fix
async Task ReadFile()
{
    var lines = await File.ReadAllLinesAsync("TextFile1.txt");
    foreach (var line in lines)
    {
        Console.WriteLine(line);
    }
}

await ReadFile();

Console.ReadLine();

