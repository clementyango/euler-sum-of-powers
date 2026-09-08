using DirectSearch;

Console.WriteLine("Enter Limit:");
int limit = Convert.ToInt32(Console.ReadLine());

DirectSearcher.Run(limit);
