// Crear lista de los numeros
using System.Reflection;

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

puntoDeRetorno:

Console.WriteLine("\nComo quieres ordenar la lista?\n" +
    "Si quieres hacerlo de mayor a menor pulsa: 1\n" +
    "Si quieres hacerlo de menor a mayor pulsa: 2");
string userInputOrden = Console.ReadLine();
int userInputOrdenS = Int32.Parse(userInputOrden);
int p = 0;


//Si selecciona 1

if (userInputOrdenS == 1)
{
    List<int> ListaNumerosO = new List<int>();
    p = 1;

    for (int i = -ListaNumeros.Count; i < ListaNumeros.Count; i++)
    {
        int x = 0;
        foreach (int numero in ListaNumeros)
        {
            if (numero > x)
            {
                x = numero;
            }
        }
        foreach (int numero in ListaNumeros)
        {
            if (numero == x)
            {
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
}

//Si selecciona 2
if (userInputOrdenS == 2)
{
    List<int> ListaNumerosO = new List<int>();
    p= 1;   

    for (int i = -ListaNumeros.Count; i < ListaNumeros.Count; i++)
    {
        int x = 100;
        foreach (int numero in ListaNumeros) {
            x = x + numero;
        }
        foreach (int numero in ListaNumeros)
        {
            if (numero < x)
            {
                x = numero;
            }
        }
        foreach (int numero in ListaNumeros)
        {
            if (numero == x)
            {
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
}
    else if(p == 0)
    {
    Console.WriteLine("\n Por favor selecciona una de las dos opciones:");
        goto puntoDeRetorno;
    }















