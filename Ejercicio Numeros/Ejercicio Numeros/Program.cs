// Create product names list (productNames) and add elements
List<string> productNames = new List<string>();
/*
productNames.Add("Plátano​");
productNames.Add("Patatas jamón jamón​");
productNames.Add("Coliflor​");
productNames.Add("Broccoli​");
productNames.Add("Pizza barbacoa​");
productNames.Add("Helado de chocolate​");
productNames.Add("Zumo de naranja");
*/

// Create product prices (productPrices) list and add elements
List<int> productPrices = new List<int>();
/*
productPrices.Add(58);
productPrices.Add(463);
productPrices.Add(2);
productPrices.Add(14);
productPrices.Add(879);
productPrices.Add(540);
productPrices.Add(333);
*/

// Ask the user to add new elements to the lists
bool cont = false;
while (cont == false)
{
    Console.WriteLine("Introduce el nombre de un producto:");
    string nombreProducto = Console.ReadLine();
    productNames.Add(nombreProducto);

    Console.WriteLine("Y ahora la cantidad que deseas comprar:");
    string userInput = Console.ReadLine();
    int cantidadProducto = Int32.Parse(userInput);
    productPrices.Add(cantidadProducto);

    Console.WriteLine("Quieres seguir comprando?:");
    string userInput2 = Console.ReadLine();
    userInput2.ToLower();

    if (userInput2 == "no")
    {
        cont = true;
    }
}



// Create ordered product names (orderedProductNames) list
List<string> orderedProductNames = new List<string>();

// Create ordered product prices (orderedProductPrices) list
List<int> orderedProductPrices = new List<int>();

// Iterate productPrices and call the iterator "x"
for (int x = 0; x < productPrices.Count; x++)
{
    // Iterate orderedProductPrices and call the iterator "y"
    for (int y = 0; y <= orderedProductPrices.Count; y++)
    {
        // Check if y == orderedProductPrices.Count
        if (y == orderedProductPrices.Count)
        {
            orderedProductNames.Add(productNames[x]);
            orderedProductPrices.Add(productPrices[x]);
            break;
        }

        // Check if orderedProductPrices[y] > productPrices[x]
        if (orderedProductPrices[y] > productPrices[x])
        {
            orderedProductNames.Insert(y, productNames[x]);
            orderedProductPrices.Insert(y, productPrices[x]);

            /* Manual insert code
            // Add last element to the end of the list
            orderedProductNames.Add(orderedProductNames[orderedProductNames.Count - 1]);
            orderedProductPrices.Add(orderedProductPrices[orderedProductPrices.Count - 1]);

            // Move all elements 1 position to the right
            for (int z = orderedProductPrices.Count - 2; z > y; z--)
            {
                orderedProductNames[z] = orderedProductNames[z - 1];
                orderedProductPrices[z] = orderedProductPrices[z - 1];
            }

            // Add element productPrices[x] at y
            orderedProductNames[y] = productNames[x];
            orderedProductPrices[y] = productPrices[x];
            */
            break;
        }
    }
}

Console.WriteLine("\t Product \t\t\t | \t Prices");
for (int i = 0; i < orderedProductPrices.Count; i++)
{
    Console.WriteLine("\t " + orderedProductNames[i] + " \t\t\t | \t " + orderedProductPrices[i]);
}
