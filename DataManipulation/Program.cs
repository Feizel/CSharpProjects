/*
Suppose you are a software developer on a team assigned to work with a logistics company. 
They have many needs for gathering and organizing their business data. 
Projects vary from tracking and reporting inventory, 
enabling specific data to be passed to and from business partners, and identifying possible fraudulent orders. 
Each project is different, but all require the processing of data. 
In these projects the applications will be performing data operations such as to add, 
delete, sort, combine, calculate, validate and format output.
*/

string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}