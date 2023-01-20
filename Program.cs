using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using SkiaSharp;


Console.Write("Enter the Era name, like in the project view (e.g.: SteampunkVenice): ");

string? eraName = Console.ReadLine();
if (String.IsNullOrEmpty(eraName))
{
    Environment.Exit(0);
}

string contentPath = $"cm-client{Path.DirectorySeparatorChar}CM-Unity{Path.DirectorySeparatorChar}Assets{Path.DirectorySeparatorChar}CoinMaster{Path.DirectorySeparatorChar}App{Path.DirectorySeparatorChar}Content";

Console.WriteLine($"SlotMachines{Path.DirectorySeparatorChar}");
ResolutionCheck(SearchAllPngs(EraPart.SlotMachine));
Console.WriteLine($"\nVillages{Path.DirectorySeparatorChar}");
ResolutionCheck(SearchAllPngs(EraPart.Village));
Console.ReadKey();


IEnumerable<string> SearchAllPngs(EraPart eraPart)
{
    try
    {
        string currentDirectory = AppContext.BaseDirectory;
        ArgumentNullException.ThrowIfNull(currentDirectory);

        if (eraPart == EraPart.SlotMachine)
        {
            string directoryPath = Path.Combine(currentDirectory, contentPath, "SlotMachines", eraName);
            IEnumerable<string> allPngs = Directory.EnumerateFiles(directoryPath, "*.png", SearchOption.AllDirectories);
            return allPngs;
        }
        else
        {
            string directoryPath = Path.Combine(currentDirectory, contentPath, "Villages", eraName);
            IEnumerable<string> allPngs = Directory.EnumerateFiles(directoryPath, "*.png", SearchOption.AllDirectories);
            return allPngs;
        }
    }
    catch (DirectoryNotFoundException)
    {
        Console.WriteLine("Cannot find such directories.");
        Console.ReadKey();
        Environment.Exit(0);
        throw;
    }
}

void ResolutionCheck(IEnumerable<string> pngList)
{
    foreach (var file in pngList)
    {
        var img = SKImage.FromEncodedData(file);
        int imgHeight = img.Height;
        int imgWidth = img.Width;
        FormatOutput(file, imgHeight, imgWidth);
    }
}

void FormatOutput(string filePath, int imgHeight, int imgWidth)
{
    string resolution = imgHeight + "x" + imgWidth;
    string lastPartPath = PathSplit(filePath);
    if (imgHeight%4 == 0 && imgWidth%4 == 0)
    {
        Console.WriteLine("{0,-80}{1}", lastPartPath, resolution);
    }
    else
    {
        Console.Write(lastPartPath);
        for(int i = 0; i < (80 - lastPartPath.Length); i++)
            Console.Write("-");
        Console.WriteLine(resolution);
    }
}

string PathSplit (string filePath)
{
    StringBuilder pathStringBuilder = new StringBuilder();
    string[] filePathArray = filePath.Split($"{Path.DirectorySeparatorChar}");
    for (int i = filePathArray.Length-1; i > 0; i--)
    {
        if (filePathArray[i] == eraName)
            break;
        pathStringBuilder.Insert(0, filePathArray[i]);
        pathStringBuilder.Insert(0, $"{Path.DirectorySeparatorChar}"); 
    }
    return pathStringBuilder.ToString();
}

public enum EraPart
{
    SlotMachine,
    Village
}