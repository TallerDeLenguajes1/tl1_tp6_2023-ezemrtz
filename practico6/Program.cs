// CALCULADORA V1
int opcion, num1, num2;
bool anda;
do
{
    do{
        Console.WriteLine("Ingrese la operacion a realizar: ");
        Console.WriteLine("1.Suma\n2.Resta\n3.Multiplicacion\n4.Division");
        anda = int.TryParse(Console.ReadLine(), out opcion);
    }while (!anda);
    Console.WriteLine("Ingrese dos numeros enteros: ");
    do{
        Console.WriteLine("Numero 1: ");
        anda = int.TryParse(Console.ReadLine(), out num1);
    }while (!anda);
    do{
        Console.WriteLine("Numero 2: ");
        anda = int.TryParse(Console.ReadLine(), out num2);
    }while (!anda);
   
    switch (opcion)
    {
        case 1: 
            Console.WriteLine(num1+num2);
            break;
        case 2: 
            Console.WriteLine(num1-num2);
            break;
        case 3: 
            Console.WriteLine(num1*num2);
            break;
        case 4: 
            if(num2 == 0){
                Console.WriteLine("No es posible dividir en 0.");
            }else{
                Console.WriteLine(num1/num2);
            }
            break;
        default:
        break;
    }
    Console.WriteLine("Desea realizar otra operacion (1.SI / 0.NO):");
    opcion = Convert.ToInt32(Console.ReadLine());
} while (opcion != 0);

// CALCULADORA V2
float num3, num4;
do{
    Console.WriteLine("Ingrese un numero: ");
    anda = float.TryParse(Console.ReadLine(), out num3);
}while (!anda);


Console.WriteLine("Valor absoluto: "+ Math.Abs(num3));
Console.WriteLine("Cuadrado: "+ Math.Pow(num3, 2));
Console.WriteLine("Raiz Cuadrada: "+ Math.Sqrt(num3));
Console.WriteLine("Seno: "+ Math.Sin(num3));
Console.WriteLine("Coseno: "+ Math.Cos(num3));
string num3str = num3.ToString();
string[] textSplit = num3str.Split(",");
Console.WriteLine("Parte entera: "+ textSplit[0]);

Console.WriteLine("Ingrese dos numeros: ");
do{
    Console.WriteLine("Primer numero: ");
    anda = float.TryParse(Console.ReadLine(), out num3);
}while (!anda);
do{
    Console.WriteLine("Segundo numero: ");
    anda = float.TryParse(Console.ReadLine(), out num4);
}while (!anda);

if (num3 > num4){
    Console.WriteLine("El maximo es: "+ num3);
    Console.WriteLine("El minimo es: "+ num4);
}else{
    Console.WriteLine("El maximo es: "+ num4);
    Console.WriteLine("El minimo es: "+ num3);
}

