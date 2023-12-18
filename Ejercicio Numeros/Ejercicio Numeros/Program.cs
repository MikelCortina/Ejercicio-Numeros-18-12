// Crear lista de los numeros
List<int> ListaNumeros = new List<int>();

// Ask the user to add new elements to the lists

Console.WriteLine("Cuantos numeros quieres introducir?");
string userInputTamaino1 = Console.ReadLine();
int userInputTamaino2 = Int32.Parse(userInputTamaino1);

for(int i = 0; i < userInputTamaino2; i++)
{
    Console.WriteLine("Introduce el numero que quieres ordenar en la lista:");
    string userInputLista = Console.ReadLine();
    int numero = Int32.Parse(userInputLista);
    ListaNumeros.Add(numero);
}
Console.WriteLine("\n Los numeros que quieres ordenar son:");
foreach (var numero in ListaNumeros) {
    Console.WriteLine(numero);
}


List<int> ListaNumerosO = new List<int>();

for (int i = -ListaNumeros.Count; i < ListaNumeros.Count; i++)
{
    int x = 0;
    foreach (int numero in ListaNumeros)
    {
        if(numero > x)
        {
            x = numero;
        }
    }
    foreach (int numero in ListaNumeros)
    {
        if (numero == x) { 
        ListaNumeros.Remove(numero);
        ListaNumerosO.Add(numero);
            break;
        }
    }

}

Console.WriteLine("\n La lista ordenada es:");
foreach (int numero in ListaNumerosO)
{
   
    Console.WriteLine(numero);
}















/*
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
           
            break;
        }
    }
}

Console.WriteLine("\t Product \t\t\t | \t Prices");
for (int i = 0; i < orderedProductPrices.Count; i++)
{
    Console.WriteLine("\t " + orderedProductNames[i] + " \t\t\t | \t " + orderedProductPrices[i]);
}
 */
