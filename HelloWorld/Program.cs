// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Is that dih good?, yes king!");
// Console.WriteLine("How good is that dih?, awesome!");
// Console.WriteLine("How good is that dih?, bitch!");
// Console.WriteLine("Amazing!!!");
// Console.WriteLine("Mmmmm, Aughhhh, Hmpphh!!!!");

// string name;
// Console.WriteLine("Bread is ready.");
// Console.WriteLine("Who is the bread for? ");
// name = Console.ReadLine();
// Console.WriteLine("Noted: " + name + " got bread");

// Console.WriteLine("What kind of thing are you talking about?");
// string a = Console.ReadLine(); // This is the variable for name of the chap's gadget. 
// Console.WriteLine("How would ou describe it? Big? Azure? Tattered?");
// string b = Console.ReadLine(); // The adjective used for said chap's gadget.
// string c = "of Doom"; // Sort of a modifier for, once again, said gadget.
// string d = "3000"; // Version control
// Console.WriteLine("The " + b + " " + a + " " + c + " " + d + " !");

// short aNumber = 7658;
// aNumber = 6475;
// Console.WriteLine(aNumber);

// int aRelativelyLargeNum = 734783445;
// aRelativelyLargeNum = 10963586;
// Console.WriteLine(aRelativelyLargeNum);

// long anEvenLargerNumber = 908753296248943;
// anEvenLargerNumber = 8256723853215664;
// Console.WriteLine(anEvenLargerNumber);

// byte aByte = 234;
// aByte = 255;
// Console.WriteLine(aByte);

// sbyte anSbyte = -128;
// anSbyte = 127;
// Console.WriteLine(anSbyte);

// ushort sixtyFourThousand = 64000;
// sixtyFourThousand = 64654;
// Console.WriteLine(sixtyFourThousand);

// uint aPositiveInteger = 574934738;
// aPositiveInteger = 437394649;
// Console.WriteLine(aPositiveInteger);

// ulong aClusterFuckOfNumbers = 3435749738292435U;
// aClusterFuckOfNumbers = 864294623648634296L;
// Console.WriteLine(aClusterFuckOfNumbers);

// string aWord = "Nigger";
// char aCharacter = '$';
// Console.WriteLine(aWord);
// Console.WriteLine(aCharacter);

// float number1 = 65.9397f;
// double number2 = 89473.5454;
// decimal number3 = 2652651.23952175m;
// Console.WriteLine(number1);
// Console.WriteLine(number2);
// Console.WriteLine(number3);

// bool iTried = true;
// iTried = false;
// Console.WriteLine(iTried);

// Console.Write("What is your favorite number?");
// string favoriteNumberText = Console.ReadLine();
// int favoriteNumber = Convert.ToInt32(favoriteNumberText);
// Console.Write(favoriteNumber + " is pretty cool!");

// Console.Write("Base? ");
// int baseOfTriangle;
// baseOfTriangle = int.Parse(Console.ReadLine());

// Console.Write("Height? ");
// int height;
// height = int.Parse(Console.ReadLine());

// int area;
// area = (baseOfTriangle * height) / 2;
// Console.WriteLine("Area: " + area);

// int aBigNumber = int.MaxValue;
// short anInfinetisimalNumber = short.MinValue;

// int a = 5; 
// int b = 2;
// int result = a / b;  
// Console.WriteLine(result);

// Console.Write("How many chocolate eggs were farmed today? ");
// int chocolateEggs = int.Parse(Console.ReadLine());
// int eachSisterGets;
// eachSisterGets = chocolateEggs / 4;
// int duckBearGets;
// duckBearGets = chocolateEggs % 4;
// Console.WriteLine("Each sister gets " + eachSisterGets + " chocolate eggs.");
// Console.WriteLine("Duckbear gets " + duckBearGets + " left over chocolate eggs.");


// Console.Write("How many estates do you own? ");
// int estatesOwned = int.Parse(Console.ReadLine());
// int pointsForEstates;
// pointsForEstates = estatesOwned * 1;
// Console.Write("How many duchies do you own? ");
// int duchiesOwned = int.Parse(Console.ReadLine());
// int pointForDuchies;
// pointForDuchies = duchiesOwned * 3;
// Console.Write("How many provinces do you own? ");
// int provincesOwned = int.Parse(Console.ReadLine());
// int pointsForProvinces;
// pointsForProvinces = provincesOwned * 6;
// int totalPoints;
// totalPoints = pointsForEstates + pointForDuchies + pointsForProvinces;
// Console.WriteLine("You have " + totalPoints + " points.");

// Console.WriteLine("Let's calculate the area of a circle.");
// Console.Write("Radius? ");
// double radius;
// radius = Convert.ToDouble(Console.ReadLine());
// double area;
// area = Math.PI * (radius * radius);
// Console.WriteLine("Area: " + area);

// Console.WriteLine("Square and Square Root CAlculator");
// Console.Write("Number? ");
// double number;
// number = Convert.ToDouble(Console.ReadLine());
// double square;
// square = Math.Pow(number, 2);
// double squareRoot;
// squareRoot = Math.Sqrt(number);
// Console.WriteLine("Square: " + square);
// Console.WriteLine("Square Root " + squareRoot);

// Console.BackgroundColor = ConsoleColor.DarkBlue;
// Console.ForegroundColor = ConsoleColor.White;
// Console.WriteLine("Trying out something new.");
// Console.WriteLine("Press any key to continue...");
// Console.ReadKey(true);
// Console.WriteLine("Welldone");

// Console.WriteLine("String Alignment and Interpolation");
// string name1 = Console.ReadLine();
// string name2 = Console.ReadLine();
// Console.WriteLine($"#1: {name1,20}");
// Console.WriteLine($"#2: {name2, 20}");

// Console.Title = "Defense of Consolas";

// Console.Write("Target Row? ");
// int targetRow = int.Parse(Console.ReadLine());

// Console.Write("Target Column? ");
// int targetColumn = int.Parse(Console.ReadLine());

// Console.WriteLine("Deploy to:");
// Console.WriteLine($"{targetRow}, {targetColumn - 1}");
// Console.WriteLine($"{targetRow - 1}, {targetColumn}");
// Console.WriteLine($"{targetRow}, {targetColumn + 1}");
// Console.WriteLine($"{targetRow + 1}, {targetColumn}");

// Console.Beep(465, 4765);

// Console.Write("Enter a number: ");
// int number;
// number = int.Parse(Console.ReadLine());
// if (number % 2 == 0)
// {
//     Console.WriteLine("Tick");
//     Console.Beep(546, 9576);
// }
// else
// {
//     Console.WriteLine("Tock");
//     Console.Beep(659, 9576);
// }

// Console.Write("X VAlue?: ");
// int xValue = int.Parse(Console.ReadLine());

// Console.Write("Y Value?: ");
// int yValue = int.Parse(Console.ReadLine());

// if (xValue < 0 && yValue > 0)
// {
//     Console.WriteLine("The enemy is to the North West.");
// }
// else if (xValue < 0 && yValue == 0)
// {
//     Console.WriteLine("The enemy is to the west.");
// }
// else if (xValue < 0 && yValue < 0)
// {
//     Console.WriteLine("The enemy is to the South West.");
// }
// else if (xValue == 0 && yValue > 0)
// {
//     Console.WriteLine("The emeny is to the North.");
// }
// else if (xValue == 0 && yValue == 0)
// {
//     Console.WriteLine("The emnemy is dead centre.");
// }
// else if (xValue == 0 && yValue < 0)
// {
//     Console.WriteLine("The enemy is to the South");
// }
// else if (xValue > 0 && yValue > 0)
// {
//     Console.WriteLine("The enemy is to the North East.");
// }
// else if (xValue > 0 && yValue == 0) {
//     Console.WriteLine("The enemy is to the East.");
// }
// else if (xValue > 0 && yValue < 0) {
//     Console.WriteLine("The enemy is to the South East.");
// }

// Console.Beep(389, 4321);

// Console.WriteLine("Avast, matey! What be yer desire?");
// Console.WriteLine("1 - Rest");
// Console.WriteLine("2 - Pillage the port");
// Console.WriteLine("3 - Set sail");
// Console.WriteLine("4 - Release the Kraken");
// Console.Write("What be the plan, captain? ");

// string response;
// int choice = int.Parse(Console.ReadLine());
// response = choice switch
// {
//     1 => "Ye rest and recover your health.",
//     2 => "Raiding th eport town get ye 50 gold doubloons.",
//     3 => "The wind is at your back: the open horizon ahead.",
//     4 => "'Tis but a baby Kraken, but still eat stoy boats.",
//     _ => "Apologies, I do not know that one.",
// };

// Console.WriteLine(response);

// int choice = int.Parse(Console.ReadLine());

// switch (choice)
// {
//     case 1:
//         Console.WriteLine("Ye rest and recover your health. ");
//         break;
//     case 2:
//         Console.WriteLine("Raiding the port town get ye 50 gold doubloons. ");
//         break;
//     case 3:
//         Console.WriteLine("The wind i sat your back: the open horizon ahead. ");
//         break;
//     case 4:
//         Console.WriteLine("'Tis but a baby kraken, but still eats toy boats.");
//         break;
//     default:
//         Console.WriteLine("Apologies, I do not know that one. ");
//         break;
// }

// Console.WriteLine("The following items are available: ");
// Console.WriteLine("1 - Rope");
// Console.WriteLine("2 - Torches");
// Console.WriteLine("3 - Climbing Equipment");
// Console.WriteLine("4 - Clean Water");
// Console.WriteLine("5 - Machete");
// Console.WriteLine("6 - Canoe");
// Console.WriteLine("7 - Food Supplies");
// Console.Write("What number do you want to see the price of? ");

// string itemChoice;
// int itemNumber = int.Parse(Console.ReadLine());

// itemChoice = itemNumber switch
// {
//     1 => "Rope",
//     2 => "Torches",
//     3 => "Climbing Equipment",
//     4 => "Clean Water",
//     5 => "Machetes",
//     6 => "Canoes",
//     7 => "Food Supplies",
//     _ => "Item not found.",
// };

// int price = itemChoice switch
// {
//     "Torches" => 15,
//     "Rope" => 10,
//     "Climbing Equipment" => 25,
//     "Clean Water" => 1,
//     "Machetes" => 20,
//     "Canoes" => 200,
//     "Food Supplies" => 1,
//     _ => 0, // Default case if item not found
// };

// Console.WriteLine("What is your name? ");
// string name = Console.ReadLine();

// if (name == "Maxwell")
//     price /= 2;

// Console.WriteLine($"{itemChoice} costs {price} gold pieces");

// while (true)
// {
//     Console.Write("Think of a number and type it here: ");
//     string input = Console.ReadLine();

//     if (input == "quit" || input == "exit")
//         break;

//     int number = int.Parse(input);

//     if (number == 23)
//     {
//         Console.WriteLine("I don't fancy that number. Run it back. ");
//         continue;
//     }

//     Console.WriteLine($"I like {number}, it's the one before {number + 1}");
// }

// int number;
// do
// {
//     Console.Write("User 1, enter a number between 0 and 100: ");
//     number = int.Parse(Console.ReadLine());
// }
// while (number < 0 || number > 100) ;

// Console.Clear();

// Console.WriteLine("User 2, gues the number.");

// while (true)
// {
//     Console.Write("What is your next guess? ");
//     int guess = int.Parse(Console.ReadLine());

//     if (guess < number) Console.WriteLine($"{guess} is too low.");
//     else if (guess > number) Console.WriteLine($"{guess} is too high.");
//     else break;
// }

// Console.WriteLine("You guessed the number!"); 

// for (int number = 1; number <= 100; number++)
// {
//     if (number % 3 == 0 && number % 5 == 0)
//     {
//         Console.ForegroundColor = ConsoleColor.Cyan;
//         Console.WriteLine($"{number}: Electric and Fire");
//     }
//     else if (number % 3 == 0)
//     {
//         Console.ForegroundColor = ConsoleColor.Red;
//         Console.WriteLine($"{number}: Fire");
//     }
//     else if (number % 5 == 0)
//     {
//         Console.ForegroundColor = ConsoleColor.Yellow;
//         Console.WriteLine($"{number}: Electric");
//     }
//     else
//     {
//         Console.ForegroundColor = ConsoleColor.Gray;
//         Console.WriteLine($"{number}: Normal");
//     }
// }

// int[] scores = new int[10];
// scores = new int[20];
// scores[0] = 99;

// int length = int.Parse(Console.ReadLine());
// int[] array = new int[length];

// for (int index = 0; index < array.Length; index++) array[index] = 1;

// int[] original = new int[5];

// for (int item = 0; item < 5; item++)
// {
//     Console.Write("Enter a number: ");
//     int number = int.Parse(Console.ReadLine());
//     original[item] = number;
// }

// int[] copy = new int[5];

// for (int index = 0; index < 5; index++)
//     copy[index] = original[index];

// for (int index = 0; index < 5; index++)
//     Console.WriteLine($"{original[index]} and {copy[index]}");

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int currentMinimum = int.MaxValue;

foreach (int value in array)
{
    if (value < currentMinimum)
        currentMinimum = value;
}

Console.WriteLine(currentMinimum);

int total = 0;

foreach (int value in array)
    total += value;

float average = (float)total / array.Length;
Console.WriteLine(average);