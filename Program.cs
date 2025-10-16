//list of strings
string[] anime = {"one_piece", "black_clover", "sword_art_online", "to_your_eternity", "demon_slayer", "charlotte", "solo_leveling", "attack_on_titans", "chainsaw_man", "bleach" };
string[] games = {"minecraft", "fortnite", "call_of_duty", "silk_song", "terraria", "Halo", "block_blast","rust", "cyberpunk", "repo" };
string[] devices = { "computer", "phone", "xbox", "playstation", "appleiphone", "tablet", "printer", "game_boy", "wii", "desktop" };

//sets variables to use in the code.
int guess = 1;
int subject = 0;
int score = 0;
int index;
int number;
int amount = 1;
int guessed = 0;
bool title = false;
bool correct = true;
bool won = false;
string catagory = "";
string word = "";
string answer = "";

//gets random number to pick the word.
Random random = new Random();
subject = random.Next(0, 10);

 //main menu
    Console.WriteLine("Hello please pick a catagory!");
Console.WriteLine("anime");
Console.WriteLine("Games");
Console.WriteLine("Devices");
    Console.Write(">>=");
catagory = Console.ReadLine() + "";

//repeats game tell the guess is correct or they run out of tries.
do
{
    do
    {
        //gets word from catagory they pick.
        switch (catagory)
        {
            case "anime":
                Console.WriteLine("You have selected anime!");
                word = anime[subject];
                guess = 0;
                correct = true;
                break;

                case "devices":
                Console.WriteLine("You have selected anime!");
                word = devices[subject];
                guess = 0;
                correct = true;
                break;

                case "games":
                Console.WriteLine("You have selected anime!");
                word = games[subject];
                guess = 0;
                correct = true;
                break;

            default:
                Console.WriteLine("Sorry I need you to pick a catagory");
                break;
        }
    } while (guess == 1 && correct == false);

    //guess menu
    number = word.Length;
    Console.WriteLine($"Your word has {guessed} out of {number} of letters");
    Console.WriteLine("Hello please make your guess");
    Console.Write(">>=");
    answer = Console.ReadLine() + "".ToLower();
    correct = true;
    guess = 1;

        //checks if guess is right
        if (answer == word)
    {
        //if the player won it will take them to win menu
        won = true;
        title = true;
            guess = 0;
            correct = true;
        }

        if (answer.Length == 1)
        {
            index = word.IndexOf(answer);

            if (index >= 0)
        {
            //tells player there guess is apart of the word.
                Console.WriteLine($"{answer} is a letter!!");
            }
            else
        {
            if (score == 6)
            {
                title = true;
            }
            //tells the player how many tries they have left.
            amount = 6 - score;
            //tells the player that there guess is wrong.
            Console.WriteLine($"Sorry {answer} isnt a letter in the word!");
            Console.WriteLine($"You have {amount} left");
                score++;
            }
        }

} while (title == false);

if (title == true && won ==true)
{
    //win menu
    Console.WriteLine("Congradulations you found the word!!!!");
}
else
{
    //amount of tries succeded 
    Console.WriteLine("Sorry you have ran out of tries.");
}