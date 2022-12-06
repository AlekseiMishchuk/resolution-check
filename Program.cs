Console.Write("Enter the Era name, like in the project view (e.g.: SteampunkVenice): ");
string? eraName = Console.ReadLine();

string villageDirectoryPath = $"{Path.DirectorySeparatorChar}cm-client{Path.DirectorySeparatorChar}CM-Unity{Path.DirectorySeparatorChar}Assets{Path.DirectorySeparatorChar}CoinMaster{Path.DirectorySeparatorChar}App{Path.DirectorySeparatorChar}Content{Path.DirectorySeparatorChar}Villages";
string slotmachineDirectoryPath = $"{Path.DirectorySeparatorChar}cm-client{Path.DirectorySeparatorChar}CM-Unity{Path.DirectorySeparatorChar}Assets{Path.DirectorySeparatorChar}CoinMaster{Path.DirectorySeparatorChar}App{Path.DirectorySeparatorChar}Content{Path.DirectorySeparatorChar}SlotMachines";

string villagePath = Path.Combine(Directory.GetCurrentDirectory(), villageDirectoryPath, eraName);
string slotmachinePath = Path.Combine(Directory.GetCurrentDirectory(), slotmachineDirectoryPath, eraName);