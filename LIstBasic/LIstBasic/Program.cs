//List<string> firstName = new List<string>();


//firstName.Add("Bill");
//firstName.Add("Bob");
//firstName.Add("Jim");

//Console.WriteLine(firstName.Count);
////wywolanie elementu
//Console.WriteLine(firstName[0]);//1 element
//Console.WriteLine(firstName[firstName.Count - 1]);//osteni element

////wydrukowanie elementow
//for (int i = 0; i < firstName.Count; i++) 
//{
//    Console.WriteLine($"{i + 1} {firstName[i]}");
//}

List<int> numbers = new List<int> { 6,32,4,3,-1,0,3,4,21,-1,-5,4,-6 };

foreach (var number in numbers)
{
    Console.Write(number + ", ");
}
Console.WriteLine();


//1 Remove()

List<int> numbers1 = new List<int> { 6, 32, 4, 3, -1, 0, 3, 4, 21, -1, -5, 4, -6 };

numbers1.Remove(6);//usuwa pierwsza napotkana wartosc, ktora kazemy mu usunac

foreach (var number in numbers1)
{
    Console.Write(number + ", ");
}
Console.WriteLine();


//2 RemoveAt()

List<int> numbers2 = new List<int> { 6, 32, 4, 3, -1, 0, 3, 4, 21, -1, -5, 4, -6 };

numbers2.RemoveAt(3);//usuwa dany index

foreach (var number in numbers2)
{
    Console.Write(number + ", ");
}
Console.WriteLine();

//3 RemoveRange()

List<int> numbers3 = new List<int> { 6, 32, 4, 3, -1, 0, 3, 4, 21, -1, -5, 4, -6 };

numbers3.RemoveRange(0,4);//usuwa zakres od index x do y nastepnych

foreach (var number in numbers3)
{
    Console.Write(number + ", ");
}
Console.WriteLine();

//4 RemoveAll()

List<int> numbers4 = new List<int> { 6, 32, 4, 3, -1, 0, 3, 4, 21, -1, -5, 4, -6 };

numbers4.RemoveAll(x => x < 0 || x%2==0);//usuwa elementy x, ktore spelniaja warunek/warunki

foreach (var number in numbers4)
{
    Console.Write(number + ", ");
}
Console.WriteLine();

//5 Clear()
List<int> numbers5 = new List<int> { 6, 32, 4, 3, -1, 0, 3, 4, 21, -1, -5, 4, -6 };

numbers5.Clear();

foreach (var number in numbers5)
{
    Console.Write(number + ", ");
}
Console.WriteLine();