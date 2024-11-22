Console.Write("Please provide your price in USD: $");

string input = Console.ReadLine();

int vndPrice;
bool isNumber = int.TryParse(input, out vndPrice);

if (isNumber){
    vndPrice *= 23000;
    Console.WriteLine("It is equivalent to " + vndPrice + " VND.");
} else {
    Console.WriteLine("You provide an invalid input.");
}