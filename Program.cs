using System.Collections.Generic;
using System.Text;


Console.Write("Enter the Era name, like in the project view (e.g.: SteampunkVenice): ");

string? eraName = Console.ReadLine();
if (String.IsNullOrEmpty(eraName))
{
    Environment.Exit(0);
}

string contentPath = $"cm-client{Path.DirectorySeparatorChar}CM-Unity{Path.DirectorySeparatorChar}Assets{Path.DirectorySeparatorChar}CoinMaster{Path.DirectorySeparatorChar}App{Path.DirectorySeparatorChar}Content";

FormatOutput(SearchAllPngs(EraPart.SlotMachine), EraPart.SlotMachine);
FormatOutput(SearchAllPngs(EraPart.Village), EraPart.Village);

IEnumerable<string> SearchAllPngs(EraPart eraPart)
{
    try
    {
        string currentDirectory = Directory.GetCurrentDirectory();

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
    catch (System.IO.DirectoryNotFoundException)
    {
        Console.WriteLine("Cannot find such directories.");
        Console.ReadKey();
        Environment.Exit(0);
        throw;
    }
   
    
}

void FormatOutput(IEnumerable<string> pngList, EraPart eraPart)
{
    Console.WriteLine($"{eraPart}{Path.DirectorySeparatorChar}{eraName}{Path.DirectorySeparatorChar}");
    foreach (var file in pngList)
    {
        StringBuilder pathStringBuilder = new StringBuilder();
        string[] filePathArray = file.Split($"{Path.DirectorySeparatorChar}");
        for (int i=filePathArray.Length-1; i>0; i--)
        {
            if (filePathArray[i] == eraName)
                break;
            pathStringBuilder.Insert(0, filePathArray[i]);
            pathStringBuilder.Insert(0, $"{Path.DirectorySeparatorChar}"); 
        }
        
        
        Console.WriteLine(pathStringBuilder.ToString());
    }
}

public enum EraPart
{
    SlotMachine,
    Village
}