using DirectSearch;

Console.WriteLine("Enter Limit:");
int limit = Convert.ToInt32(Console.ReadLine());
int exponent = 5;
DirectSearcher.Run(limit, exponent);
