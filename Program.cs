// See https://aka.ms/new-console-template for more information
int[] numbers = { 2, 6, 7, 5, 3, 9 };

void StampaArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++){
        Console.WriteLine($"elemento {i+ 1}: {array[i]}");
    }
    Console.WriteLine();
};

StampaArray(numbers);

int Quadrato(int number) 
{
    return number * number;
};

Console.WriteLine($"Qudrato: {Quadrato(9)} \n");


int sommaElementiArray(int[] array) 
{
    int sum = 0;

    foreach (int number in array) {
        sum += number;
    }

    return sum;
};

Console.WriteLine($"Somma di tutti i numeri: {sommaElementiArray(numbers)}");

int[] arrayPows(int[] array)
{
    var arrayClone = (int[])array.Clone();
    for (int i = 0; i < arrayClone.Length; i++)
    {
        arrayClone[i] = arrayClone[i] * arrayClone[i];
    }
    return arrayClone; 
}

var clone = arrayPows(numbers);

int sommaQuadrati = sommaElementiArray(clone);

Console.WriteLine($"Somma quadrati: {sommaQuadrati}"); 