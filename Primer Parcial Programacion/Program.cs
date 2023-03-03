Console.WriteLine("HOLAAA..  :)");


//1.Almacenando la variable 

int factorial = 1;


//2.Numero enterro positivo  divisibles en 3
int num2 = 1, nd2;
Console.WriteLine("Ingrese un numero entero positivo: ");
nd2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Los numeros menores a " + nd2 + " que se dividen en 3 son: ");

while (num2 <= nd2)
{
    if (num2 % 3 == 0)
    {
        Console.Write(num2 + " ");
    }
    num2++;
}

Console.WriteLine(" Siguiente ->");

//3.Numero enterro positivo  divisibles en 5
int num3 = 1, nd3;
Console.WriteLine("Ingrese un numero entero positivo: ");
nd3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Los numeros menores a " + nd3 + " que se dividen en 5 son: ");

while (num3 <= nd3)
{
    if (num3 % 5 == 0)
    {
        Console.Write(num3 + " ");
    }
    num3++;
}

Console.WriteLine(" Siguiente ->");

//4.Secuencia del N de 1 y 2

int ns = 1, secuencia;

Console.WriteLine("Inserte un numero para la secuencia:  ");
secuencia = Convert.ToInt32(Console.ReadLine());
Console.Write("El resultado de la " + secuencia + " es: ");

do
{
    ns += 2;
    Console.Write(ns + " ");
}
while (ns < secuencia);

Console.Write(ns + " ");

Console.WriteLine("Siguente ->");

//5.Resultado factorial
int num = 0, i;

Console.Write("Ingrese el numero que desee factorizar: ");
num = Convert.ToInt32(Console.ReadLine());
for (i = 1; i <= num; i++)
{
    factorial = factorial * i;
}
Console.WriteLine("El factorial de " + num + " es:" + factorial);

Console.ReadKey();

