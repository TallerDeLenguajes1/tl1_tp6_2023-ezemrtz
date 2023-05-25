// See https://aka.ms/new-console-template for more information
int opcion = 0;
bool anda = false;
Console.WriteLine("Que ejercicio quiere realizar: ");
Console.WriteLine("1- Ejercicio 1 ");
Console.WriteLine("2- Ejercicio 4");
while(!anda){
    Console.WriteLine("Ingrese un numero:");
    anda = int.TryParse(Console.ReadLine(), out opcion);
    if(!anda){
        Console.WriteLine("No es un numero valido.");
    }
}
switch (opcion)
{
    case 1:
        //Ejercicio 1
        int num = 0;
        string? numString = "", numInvS = "";
        anda = false;
        while(!anda){
            Console.WriteLine("Ingrese un numero:");
            numString = Console.ReadLine();
            anda = int.TryParse(numString, out num);
            if(!anda){
                Console.WriteLine(numString + " no es un numero valido.");
            }
        }
        if(num > 0){
            int aux;
            while (num != 0){
                aux = num % 10;
                num /= 10;
                numInvS = numInvS + aux;
            }
            Console.WriteLine(numInvS);
        }
    break;

    case 2:
        // Ejercicio 4
        string? cadena1, cadena2;
        Console.WriteLine("Ingrese un cadena de caracteres: ");
        cadena1 = Console.ReadLine();

        Console.WriteLine("La longitud de la cadena es: "+ cadena1.Length);
        Console.WriteLine("Ingrese una segunda cadena de caracteres: ");
        cadena2 = Console.ReadLine();

        Console.WriteLine("La cadena concatenada es: "+ cadena1 + cadena2);
    break;

    default:
    break;
}
