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
        Console.WriteLine("La longitud de la cadena es: {0}", cadena1.Length);

        Console.WriteLine("Ingrese una segunda cadena de caracteres: ");
        cadena2 = Console.ReadLine();
        Console.WriteLine("La cadena concatenada es: {0}", string.Concat(cadena1, cadena2));

        Console.WriteLine("Ingrese un numero < {0}: ", cadena1.Length);
        if(int.TryParse(Console.ReadLine(), out int indice)){
            Console.WriteLine("La subcadena obtenida es: {0}", cadena1.Substring(indice));
        }else{
            Console.WriteLine("Error al convertir a int");
        }

        int num1, num2;
        Console.WriteLine("Ingrese numero 1: ");
        int.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("Ingrese numero 2: ");
        int.TryParse(Console.ReadLine(), out num2);
        Console.WriteLine("La suma de {0} y {1} es igual a: {2}", num1, num2, num1+num2);

        int ind = 1;
        foreach (char letra in cadena1){
            Console.WriteLine("Letra {0}: {1}",ind , letra);
            ind++;
        }

        Console.WriteLine("Ingrese una palabra a buscar en la cadena 1: ");
        cadena2 = Console.ReadLine();
        if(cadena1.Contains(cadena2)){
            Console.WriteLine("La palabra se encuentra en la cadena.");
            Console.WriteLine("La palabra '{0}' se encuentra en la posicion {1} de la cadena 1", cadena2, cadena1.IndexOf(cadena2)+1);
        }else{
            Console.WriteLine("No se encontro la palabra.");
        }

        Console.WriteLine("Cadena en mayusculas: {0}", cadena1.ToUpper());
        Console.WriteLine("Cadena en minusculas: {0}", cadena1.ToLower());

        Console.WriteLine("Ingrese una cadena separada por '.':");
        cadena1 = Console.ReadLine();
        string[] cadenaSeparada = cadena1.Split(".");
        for (int i = 0; i < cadenaSeparada.Length; i++){
            Console.WriteLine("Elemento {0}: {1}", i, cadenaSeparada[i]);
        }

        Console.WriteLine("Ingrese una expresion de una suma: ");
        cadena1 = Console.ReadLine();
        cadenaSeparada = cadena1.Split("+");
        int suma = 0, aux2;
        foreach (string item in cadenaSeparada){
            int.TryParse(item.Trim(), out aux2);
            suma += aux2;
        }
        Console.WriteLine("El resultado de la expresion ingresada es: {0}", suma);

    break;

    default:
    break;
}
