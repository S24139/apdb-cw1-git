using System;

int[] numbers = { 2, 4, 6 };
//int[] numbers2 = {-8, -3, -5};

Console.WriteLine(Greeting.GetMessage());
Console.WriteLine($"Sum: {StatisticsHelper.CalculateSum(numbers)}");
Console.WriteLine($"Average: {StatisticsHelper.CalculateAverage(numbers)}");
Console.WriteLine($"Count: {numbers.Length}");
Console.WriteLine($"Max: {StatisticsHelper.CalculateMax(numbers)}");
//Console.WriteLine($"Max: {StatisticsHelper.CalculateMax(numbers2)}");