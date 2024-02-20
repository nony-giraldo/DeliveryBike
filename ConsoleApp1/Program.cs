using ConsoleApp1;

int[] packageWeights = [5, 3, 2, 5, 6, 1, 4, 7, 9];
int N = 10;

int bicycles = DeliveryBikes.NumberOfBicycles(packageWeights, N);
Console.WriteLine($"Number of bicycles : {bicycles}");

