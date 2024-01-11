using System;
using System.Globalization;

// Define the default culture as CultureInfo.InvariantCulture
CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

// Resolve the specified problem
Problem14 x = new Problem14();
x.Resolve();

Console.WriteLine("\n\nPress any key to kit");
Console.ReadKey();