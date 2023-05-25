// See https://aka.ms/new-console-template for more information

//Ejercicio 1

int num = 0;
string? numString = "", numInvS = "";
bool anda = false;

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

// Ejercicio 4
