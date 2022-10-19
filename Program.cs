//Jeremy Lapham
//10-18-22
//Odd or Even
//This program will ask the user to input a number and it will tell them if that number is odd or even
//Peer Review:



bool repeat = true;

while(repeat)
{
string userIn;

bool isConvert = false;
bool isNumber;
int validNum = 0;

while(!isConvert)
{
    Console.WriteLine("We are going to play a game to find weather or not yor number is odd or even. Please enter a whole number");
    userIn = Console.ReadLine();
    isNumber = Int32.TryParse(userIn, out validNum);

    if(isNumber == true)
    {
        isConvert = true;
        Console.WriteLine("You entered a valid number");
    }
    else
    {
        Console.WriteLine("Invalid entry, please enter a valid number");
    }
}
    int remain = validNum % 2;
    if(remain == 1)
    {
        Console.WriteLine("Your number is odd!");
    }
    else
    {
        Console.WriteLine("Your number is Even!");
    }

Console.WriteLine("Would you like to play again? Type anything or nothing to play again. Type end if you are done");
string doneSo = Console.ReadLine().ToLower();
if( doneSo == "end")
{
    repeat = false;
}
}
Console.WriteLine("Thank you for playing!");