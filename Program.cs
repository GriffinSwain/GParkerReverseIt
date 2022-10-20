//Griffin Parker
//September 17, 2022
//Mini Challenge #7 Remastered - Reverse it
//This program takes a user's input, displays it, and then writes out the same input but reversed
//Peer Reviewed by Arely Martinez
//On top of vaildating if the user wants to play again Griffin went above and beyond and vailated that the user enter more than a single character or if 
//the user just entered the space bar. On top of that yes theres more Giffin also added another feature where the resevered response is slowly typed out. 
//They not only hit every checkmark on the assignment Griffin also added some impresive features that werent demanded of him. 

string input;
string reverse = "";
int number = 1;
int repeat = 1;
string reverseBack = "";
string loop = "";
bool IsANumber = true;
bool whilst = true;



while(repeat == 1){
Console.Clear();
if(IsANumber == false){
    Console.WriteLine("Please input a string of characters longer than a single digit");
}else{
    Console.WriteLine("Give me a a set of numbers or letters");
}
input = Console.ReadLine();
number = input.Length;
reverseBack = "";
Console.WriteLine("Length" + number);
if(number < 2){
    IsANumber = false;
}else{
    IsANumber = true;
}
if (IsANumber == true){
//loops through the inputted string starting from the back and creates a new string that is the
//same as the inputted, but backwards
for(int i = input.Length - 1; i >= 0; i--) reverse = reverse + input[i];

Console.Clear();
for(int a = 0; a < reverse.Length; a++)
{
Console.Clear();
reverseBack += reverse[a];
Console.WriteLine();
Console.WriteLine(input + " reversed is " + reverseBack);
Thread.Sleep(200);
}
Console.WriteLine();
Console.WriteLine("Type \"yes\" to play again or \"no\" to quit.");
input = "";
reverse = "";
whilst = true; 
while( whilst == true){

loop = Console.ReadLine().ToLower();
if (loop == "yes") whilst = false;
if (loop == "no")
{
    repeat++;
    whilst = false;
}else Console.WriteLine("Please put 'yes' or 'no'");

}
}
}
