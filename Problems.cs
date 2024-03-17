using System;
using System.Collections.Generic;
using System.Globalization;

// Define the default culture as CultureInfo.InvariantCulture
CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

// Solve the specified problem
new Problem70().Solve();

// Quit
Console.WriteLine("\nType any key to quit...");
Console.ReadLine();