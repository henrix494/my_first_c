// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

// תחילת התכונה שמחברת את המספרים

int times100;
int times10;
int normalNum;

Console.WriteLine("Enter the first number its will be times 100\n");
times100 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the 2nd nubmer it will be times 10\n");
times10 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the 3rd number it will be normal\n");
normalNum = Convert.ToInt32(Console.ReadLine());
int fullNumber = times100 * 100 + times10 * 10 + normalNum;
Console.WriteLine("the number is  {0}", fullNumber);

// סוך התוכנה שמחברת את המספרים


int numOne;
int numTwo;
int numThree;

Console.WriteLine("Enter the first number for the calc\n");
numOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 2nd number for the cals\n");
numTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 3rd number for the calc\n");
numThree = Convert.ToInt32(Console.ReadLine());
int sum = numOne + numTwo + numThree;
Console.WriteLine("the cals is for :  {0}+{1}+{2} = {3}",numOne , numTwo,numThree,sum);
