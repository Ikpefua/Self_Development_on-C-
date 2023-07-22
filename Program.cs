// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.Write("Enter your username: ");
string username = Console.ReadLine();
Console.WriteLine("Hello " + username + " Welcome to our website");

// Basic calculator, On how to get numbers from user input.

Console.Write("Enter a number: ");
double num_1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter anoher number: ");
double num_2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(num_1 + num_2);

//Mad lib game using C#
string color, proNoun, religion;
Console.Write("Enter a color: ");
color = Console.ReadLine();

Console.Write("Enter any pronoun: ");
proNoun = Console.ReadLine();

Console.Write("Enter your religion: ");
religion = Console.ReadLine();

Console.WriteLine("Rose are " + color);
Console.WriteLine(proNoun + " are blue");
Console.WriteLine("I love " + religion);

// Arrays


int[] evenNumber = new int[4];
evenNumber[0] = 0;
evenNumber[1] = 2;
evenNumber[2] = 4;
evenNumber[3] = 6;
int[] luckyNumbers = { 1, 3, 5, 7, 9 };

Console.WriteLine(evenNumber[3] + luckyNumbers[0]);
Console.WriteLine(evenNumber.Length + luckyNumbers.Length); //9

string[] favList = new string[4];
favList[0] = "Daily manner";
favList[1] = "Pray";
favList[2] = "Code";
favList[3] = "Chill";

Console.Write("What do you do daily?: ");
string toDos = Console.ReadLine();
string text = $"Every morning I study {favList[0]}, and then {favList[1]}, after that, I {favList[2]} 6 hours, and {favList[3]} afterwoards";
Console.WriteLine(text);

//Method
//namespace tutoria
//{
//    class program
//    {
//        static void Main(string[] args)
//        {
//            cube(5);
//            Console.WriteLine();
//        }


//    }
//    static int cube(int num)
//        int result = num * num * num;
//    Return result;
//}

//IF statement;
bool isMale = true;
bool isTall = false;
if (isMale && isTall)
{
    Console.WriteLine("You are a tall male");
}
else if (!isMale && isTall)
{
    Console.WriteLine("You are not male, but tall");
}
else if (isMale && !isTall)
{
    Console.WriteLine("You are a short male");
}
else
{
    Console.WriteLine("You are neither male, or tall");
}
//FOR loop
/* Print out even numbers between 0-10*/;
int i;
for (i = 0; i <= 10; i += 2)
{
    Console.WriteLine(i);
}

//NESTED loop
//outer loop;
for (int f = 1; f <= 3; ++f)
{
    Console.WriteLine("What I Do Daily!!: " + f);
    for (int d = 1; d <= 4; d++)
    {
        Console.WriteLine(" I Code with C# " + d);
    }
}
//BREAK & CONTINUE
for (int q = 1; q < 10; q++)
{
    if (q <= 4)
        Console.WriteLine("Fist loop " + q);

}
//Write a loop that will skip the num 8, and stop counting when the value it is < 10;
int j = 0;
while (j < 10)
{
    if (j == 6)
    {
        j++;
        continue;
    }
    Console.WriteLine("Second loop " + j);
    j++;

}

// Write a loop, that will stop executing when it is equals 7
int k = 1;
while (k < 10)
{
    Console.WriteLine("Third loop " + k);
    k++;
    if (k == 7)
    {
        break;
    }
}
// nested loop;
for (int a = 1; a <= 2; ++a)
{
    Console.WriteLine("Outer: " + a);
    {
        for (int s = 1; s <= 3; s++)
        {
            Console.WriteLine(" inner: " + s);
        }
    }
}

//Looping through an array;
string[] todos = { "Brush teeth", "Clean room", "Study C#", "Sleep", "Repeat" };
// Foreach loop 
foreach (string t in todos)
{
    Console.WriteLine(i);
}
for (int n = 0; n < todos.Length; n++)
{
    Console.WriteLine(n + ": " + todos[n]);

}


string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
foreach (string s in cars)
{
    Console.WriteLine(s);
}
// use for loop,to list out the cars in he arrays;

for(int a = 0; a<cars.Length; a++)
{
    Console.WriteLine(cars[a] + " Is in my favorite car list");
}

string[] relCourse = { "\'Rel 210\'", "\'Rel 304\'", "\'Rel 405\'" };
//List the course in the array
int b = 0;
for (int u = 0; u < relCourse.Length; u++)
{
    Console.WriteLine(u + " My list of course include " + relCourse[u]);
}
// choose out your fav course
int x = 0;
while(x < relCourse.Length)
{
    x++;
    if (x == 3)
    {
        break;
    }
    Console.WriteLine("1: My favorite course is " + relCourse[x]);
    x++;
    Console.WriteLine("The length of my course is " + relCourse.Length);
}

string[] favPerson = { "Esther", "Emmanuel", "Rosie", "Tosin", "Osereme" };
// List the names in the array
int y = 0;
do
{
    Console.WriteLine(y + ": " + favPerson[y]);
        y++;
}
while(y < favPerson.Length);

//Call out your favourite person name
for (int c = 0; c < favPerson.Length; c++)
{
    if (c == 2)
    {
        Console.WriteLine("My favourite person is " + favPerson[c] + " by name."); 
    }
}

int z = 0;
while(z < favPerson.Length)
{
    if(z == 1)
    {
        z++;
        continue;
    }
    Console.WriteLine("I skipped the name \"Emmanuel\", " + favPerson[z]);
    z++;
}
// Using FOR loop, skipp the name 'Rosie'
for(int m=0; m < favPerson.Length; m++)
{
    if(m==2)
    {
        continue;
    }
    Console.WriteLine("I skipped the name \'Rosie\', " + favPerson[m]);
}

//int z = 0;
//while(z < favPerson.Length)
//{
//    z++;
//    if (z == 3)
//    {
//        break;
//    }
//    Console.WriteLine("1 " + favPerson[z]);
//    z++;

//}

//Skip Emmanuel and continue the list;




