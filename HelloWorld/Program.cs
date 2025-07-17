// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Is that game good?, yes king!");
// Console.WriteLine("How good is that game?, awesome!");
// Console.WriteLine("How good is that game?, bro!");
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

// string aWord = "Frudean";
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

Console.Write("How many estates do you own? ");
int estatesOwned = int.Parse(Console.ReadLine());
int pointsForEstates;
pointsForEstates = estatesOwned * 1;
Console.Write("How many duchies do you own? ");
int duchiesOwned = int.Parse(Console.ReadLine());
int pointForDuchies;
pointForDuchies = duchiesOwned * 3;
Console.Write("How many provinces do you own? ");
int provincesOwned = int.Parse(Console.ReadLine());
int pointsForProvinces;
pointsForProvinces = provincesOwned * 6;
int totalPoints;
totalPoints = pointsForEstates + pointForDuchies + pointsForProvinces;
Console.WriteLine("You have " + totalPoints + " points.");
