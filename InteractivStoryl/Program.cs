string eng;
string dir1;
string answer;
string jump;


Console.WriteLine("to start, go right or left?");

 dir1 = Console.ReadLine();

if (dir1 == "right" || dir1 == "Right"){
    Console.WriteLine($"You turn to your {dir1} to find a car coming towards you at 100 km/h, will you jump to the right or to the left?");
     jump = Console.ReadLine();
         if (jump == "right" || jump == "Right")
         {
         Console.WriteLine("you died!");
         }
         else
         {
            Console.WriteLine("You survived! A man steps out of the car and walks up to you and tells you to give him your money, do you comply or do you attack?");
             answer = Console.ReadLine();
                if (answer == "attack" || answer == "Attack")
                 {
                 Console.WriteLine($"you {answer} and he shoots you and now you die");
                 }
                 else
                 {
                Console.WriteLine($"you {answer} and he then left you alone");
                 }
         }

}
else 
{
    Console.WriteLine($"you turned {dir1} and saw a nice lemonade stand, will you engage, yes or no?");
     eng = Console.ReadLine();
        if (eng == "yes" || eng == "Yes")
        {
            Console.WriteLine($"you chose to {eng}, you bought a glass of lemonade and went home");
        }
        else
        {
            Console.WriteLine($"You chose to {eng} and as you walked past the stand, the owner got mad and shot you and you died");
        }
}
Console.ReadLine();
