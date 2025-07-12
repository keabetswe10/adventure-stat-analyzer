Console.WriteLine("Enter character name: ");
string characterName = Console.ReadLine();

Console.WriteLine("Enter level: ");
int level = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

//now we asking the user the points they scored in three missions
Console.WriteLine("Enter score from mission 1: ");
int mission1Score = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Enter score from mission 2: ");
int mission2Score = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Enter score from mission 3: ");
int mission3Score = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

//now we calculate the average with Math.Round
double averageScore = Math.Round((mission1Score + mission2Score + mission3Score) / 3.0);
Console.WriteLine("Your average score is: " + averageScore);
Console.WriteLine();

Random random = new Random();
int randomNumber = random.Next(1, 50);
Console.WriteLine("Your bonus item value is: " + randomNumber);
Console.WriteLine();

Console.WriteLine("Enter base of the triangle: ");
double baseOfTriangle = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Enter height of the triangle: ");
double heightOfTriangle = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
double sideC = Math.Sqrt((baseOfTriangle * baseOfTriangle) + (heightOfTriangle * heightOfTriangle));
Console.WriteLine("The magic gate length is: " + sideC);
Console.WriteLine();

Console.WriteLine("SUMMARY:");
Console.WriteLine();

characterName = characterName.ToUpper();
Console.WriteLine("Welcome, " + characterName + "!");


Console.WriteLine("Level: " + level);

characterName = characterName.ToLower();
characterName = characterName.Substring(0, 3);
Console.WriteLine("Top mission start: " + characterName);

Console.WriteLine("You're a real warrior!");