using System;
using System.Globalization;

// Define the default culture as CultureInfo.InvariantCulture
CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

// Solve the specified problem
new Problem17().Solve();

Console.WriteLine("\n\nPress any key to kit");
Console.ReadKey();