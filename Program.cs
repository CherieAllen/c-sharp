﻿// See https://aka.ms/new-console-template for more information
string stranger = "Another One";
int one = 1;

Console.WriteLine($"Hello, {stranger} {one}");

Console.WriteLine(stranger.IndexOf("t"));

int a = 10,b=20, c=40;

int sum = a+b+c;

double d = 5.0, e = 2.5;

double div = d/ e;
int max = int.MaxValue;
int maxIsh = max + 3;

Console.WriteLine($"The sum is {sum}");
Console.WriteLine($"The sum is {sum}");
Console.WriteLine($"What is 70/3 {div}");
Console.WriteLine($"What is the maxish {maxIsh}");


Console.WriteLine("-------------Array---------");

// var firstArr= new int[10];
var firstArr= new int[5] {-69,46,10,1,100};
int [] arr2 = new int[10];

// firstarr[0]=100;

for (var i = 0; i< firstArr.Length; i++)
{
    Console.WriteLine($"The value at {i} is {firstArr[i]}");
}


Console.WriteLine("-------------List---------");

List <int> list = new List<int>();

list.AddRange(firstArr);
list.Add(1000);
list.Add(1001);
list.Add(1002);

foreach(var el in list)
{
    Console.WriteLine($"The value is {el}");
}

Console.WriteLine ($"The first element is {list[0]}");