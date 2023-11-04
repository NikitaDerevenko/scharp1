﻿/*
"Задача 40: Напишите программу, которая принимает на вход три числа и
проверяет, может ли существовать треугольник со сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше и не равно сумме двух других сторон."
*/

using System;
Console.Clear();


string TakeEntCoordinate(string message)
{
    System.Console.WriteLine(message);
    string result = Convert.ToString(Console.ReadLine());
    return result;
}


int TakeEnteredNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


bool CheckTriangleCreation(int[] arr)
{
    if (arr[0] < arr[1] + arr[2] && arr[1] < arr[0] + arr[2] && arr[2] < arr[0] + arr[1]) return true;
    return false;
}

string triangleSidesInput = TakeEntCoordinate("Enter Coordinate of first point splited by space button (x y z):");
var triangleSidesStrings = triangleSidesInput.Split(' ');
int[] triangleSidesInts = Array.ConvertAll(triangleSidesStrings, s => int.Parse(s));


/*int userNumber1 = TakeEnteredNumber("Enter first number: ");
int userNumber2 = TakeEnteredNumber("Enter second number: ");
int userNumber3 = TakeEnteredNumber("Enter third number: ");
*/


System.Console.WriteLine(CheckTriangleCreation(triangleSidesInts));