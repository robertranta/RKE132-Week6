string[] snacks = { "sushi", "pizza", "burger", "chicken wings", "asian takeaway" };

Random rnd = new Random();
int randomIndex  = rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonigh we are having {snacks[randomIndex]}.");

