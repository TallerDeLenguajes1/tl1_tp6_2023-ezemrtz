// See https://aka.ms/new-console-template for more information
    int opcion, num1, num2;
do
{
    Console.WriteLine("Ingrese la operacion a realizar: ");
    Console.WriteLine("1.Suma\n2.Resta\n3.Multiplicacion\n4.Division");
    opcion = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese dos numeros enteros: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    num2 = Convert.ToInt32(Console.ReadLine());
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



