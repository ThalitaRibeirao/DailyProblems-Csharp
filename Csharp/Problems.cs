using System;
using System.Globalization;

// Define the default culture as CultureInfo.InvariantCulture
CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

// Resolve the specified problem
Problem12 x = new Problem12();
x.Resolve();

Console.WriteLine("\n\nPress any key to kit");
Console.ReadKey();