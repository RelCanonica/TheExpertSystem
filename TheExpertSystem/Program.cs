using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheExpertSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // -=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-
            // Application:     The Expert System
            // Author:          Witt, Stephanie
            // Description:     A mini role-playing game simulator
            // Date Created:    1/24/2021
            // Date Revised:    2/5/2021
            // -=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-

            //
            // window size and screen colors
            // 

            ConsoleColor openingScreenBackground = ConsoleColor.Gray;
            ConsoleColor openingScreenForeground = ConsoleColor.DarkRed;
            ConsoleColor generalScreenBackground = ConsoleColor.Gray;
            ConsoleColor generalScreenForeground = ConsoleColor.Black;
            ConsoleColor arenaScreenBackground = ConsoleColor.Gray;
            ConsoleColor arenaScreenForeground = ConsoleColor.DarkBlue;
            ConsoleColor shopScreenBackground = ConsoleColor.Gray;
            ConsoleColor shopScreenForeground = ConsoleColor.DarkGreen;
            ConsoleColor closingScreenBackground = ConsoleColor.Gray;
            ConsoleColor closingScreenForeground = ConsoleColor.DarkMagenta;

            //
            // constants
            //

            const double ORC_STRENGTH = 4;
            const double HUMAN_STRENGTH = 2;
            const double ELF_STRENGTH = 1;
            const double HOBBIT_STRENGTH = .5;

            //
            // variables
            //

            string userName;
            string raceChoice;
            string userResponse;
            string favoriteTea;

            double relativeStrength;
            double baseStrength;
            double saleCost;
            double currentHealth = 100;
            double totalMoney;
            double potionCost;
            double antidoteCost;
            int potionsPurchased;
            int antidotesPurchased;
            int timesAttack;

            bool validResponse;

            //
            // opening screen
            //

            Console.BackgroundColor = openingScreenBackground;
            Console.ForegroundColor = openingScreenForeground;
            Console.SetWindowSize(100, 30);
            Console.Clear();
            Console.WriteLine("\t                          )      \\    /      (");
            Console.WriteLine("\t                         /|\\      )\\_/(     /|\\");
            Console.WriteLine("\t*                       / | \\    (/\\|/\\)   / | \\                      *");
            Console.WriteLine("\t|`.____________________/__|__o____\\`|'/___o__|__\\___________________.'|");
            Console.WriteLine("\t|                           '^`    \\|/   '^`                          |");
            Console.WriteLine("\t|                                   V                                 |");
            Console.WriteLine("\t|                                                                     |");
            Console.WriteLine("\t|                      Role-Playing Game Simulator                    |");
            Console.WriteLine("\t|                                                                     |");
            Console.WriteLine("\t|                                                                     |");
            Console.WriteLine("\t| ._________________________________________________________________. |");
            Console.WriteLine("\t|'               l    /\\ /        \\\\         \\ /\\   l                `|");
            Console.WriteLine("\t*                l  /   V          ))         V   \\ l                 *");
            Console.WriteLine("\t                 l/               //               \\I");
            Console.WriteLine("\t                                  V");
            Console.WriteLine("\t");
            Console.WriteLine("\tPress any key to continue -->");
            Console.ReadKey();
            Console.Clear();

            //
            // setting the introduction background
            //

            Console.BackgroundColor = generalScreenBackground;
            Console.ForegroundColor = generalScreenForeground;
            Console.Clear();

            //
            // getting the user's name
            //

            Console.WriteLine("Hello! I hope you're ready to start an adventure. I'm here to help you get started.");
            Console.WriteLine();
            Console.Write("First, please enter your name: ");
            userName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Hello, {userName}! My name is Chadley, and I hope we get to know each other better.");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue -->");
            Console.ReadKey();
            Console.Clear();

            //
            // asking for participation
            //

            Console.WriteLine($"So, {userName}, would you like to participate in a small simluation we're conducting?");
            Console.WriteLine("I promise, unlike other simluations you may have seen, there will be no maiming. (:");
            Console.WriteLine();
            Console.Write("Would you like to participate [yes/no]? ");
            userResponse = Console.ReadLine().ToLower();

            if (userResponse == "yes")
            {
                Console.WriteLine();
                Console.WriteLine("Great! We'll have a lot of fun.");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue -->");
                Console.ReadKey();
                Console.Clear();

                do
                {
                    validResponse = true;

                    //
                    // choosing your race
                    //

                    Console.WriteLine("First of all, we have to choose your race for the simulation. This determines your base strength.");
                    Console.WriteLine("Would you like to be an Orc, a Human, an Elf, or a Hobbit?");
                    Console.WriteLine();
                    Console.Write("Choose a race: ");
                    raceChoice = Console.ReadLine().ToLower();

                    //
                    // not choosing one of the four
                    //

                    if (raceChoice != "orc" && raceChoice != "human" && raceChoice != "elf" && raceChoice != "hobbit")
                    {
                        validResponse = false;

                        Console.WriteLine();
                        Console.WriteLine("Unfortunately, we don't have that in the simulator yet. Hopefully it's coming soon.");
                        Console.WriteLine("Please choose another race.");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue -->");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (!validResponse);

                //
                // commenting on the user's choice
                //

                switch (raceChoice)
                {
                    case "orc":
                        Console.WriteLine();
                        Console.WriteLine("Ooooh, I see you're a fan of strength. You are now an orc!");
                        break;

                    case "human":
                        Console.WriteLine();
                        Console.WriteLine("Sometimes the basic choice is the best choice. You shall remain a human!");
                        break;

                    case "elf":
                        Console.WriteLine();
                        Console.WriteLine("Ah, the elf. Great for magic, a bit low on the strength.");
                        break;

                    case "hobbit":
                        Console.WriteLine();
                        Console.WriteLine("Hobbits are quick as they come. They need it!");
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("That's not a race I recognize, so I can't evaluate it!");
                        break;
                }

                Console.WriteLine("Let's head over to the arena. I hope you're excited.");
                Console.WriteLine("I promise that no injuries shall come your way.");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue -->");
                Console.ReadKey();

                //
                // arena opening screen
                //

                Console.BackgroundColor = arenaScreenBackground;
                Console.ForegroundColor = arenaScreenForeground;
                Console.Clear();

                Console.WriteLine("\t    J:L    (\"\"\")");
                Console.WriteLine("\t    |:|     III");
                Console.WriteLine("\t    |:|     III");
                Console.WriteLine("\t    |:|     III");
                Console.WriteLine("\t    |:|   __III__");
                Console.WriteLine("\t    |:| /:-.___,-:\\");
                Console.WriteLine("\t    |:| \\]  |:|  [/");
                Console.WriteLine("\t    |:|     |:|");
                Console.WriteLine("\t    |:|     |:|");
                Console.WriteLine("\t    |:|     |:|");
                Console.WriteLine("\t/]  |:|  [\\ |:|");
                Console.WriteLine("\t\\:-'\"\"\"`-:/ |:| ");
                Console.WriteLine("\t  \"\"III\"\"   |:|");
                Console.WriteLine("\t    III     |:|");
                Console.WriteLine("\t    III     |:|");
                Console.WriteLine("\t    III     |:|");
                Console.WriteLine("\t   (___)    |:|");
                Console.WriteLine("\t             \"");

                Console.WriteLine();
                Console.WriteLine("Welcome to the Arena!");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue -->");
                Console.ReadKey();
                Console.Clear();

                //
                // setting your strength
                //

                Console.WriteLine("Welcome to the arena! I hope you find it satisfactory.");
                Console.WriteLine("After all, it is only limited by the bounds of your imagination.");
                Console.WriteLine();
                Console.WriteLine("Today, we're going to fight a monster. Don't worry, it's just a simulation.");
                Console.WriteLine("Everything will be safe and sound. I've learned well from previous simulations.");

                Console.WriteLine();
                Console.WriteLine("Press any key to continue -->");
                Console.ReadKey();
                Console.Clear();

                //
                // getting user's relative strength
                //

                do
                {
                    validResponse = true;

                    Console.WriteLine("First, how would you rank your strength, 10 being the strongest, and 1 being the weakest?");
                    Console.WriteLine("After all, even a {0} can be extra strong or weak!", raceChoice);
                    Console.WriteLine();
                    Console.Write("What do you think your strength is relative to others? ");
                    userResponse = Console.ReadLine();

                    if (!double.TryParse(userResponse, out relativeStrength))
                    {
                        Console.WriteLine();
                        Console.WriteLine("I don't understand that. Can you repeat? My circuitry is not so good.");
                        Console.WriteLine();
                        Console.WriteLine("I'll try to ask again so we can get a number out of you.");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue -->");
                        Console.ReadKey();
                        Console.Clear();

                        validResponse = false;
                    }

                    else
                    {
                        if (relativeStrength <= 0 || relativeStrength > 10)
                        {
                            Console.WriteLine();
                            Console.WriteLine("I SAID between one and ten. Thank you! (:");
                            Console.WriteLine("Please try to give me a correct answer, my research relies on it!");
                            Console.WriteLine();
                            Console.WriteLine("Press any key to continue -->");
                            Console.ReadKey();
                            Console.Clear();

                            validResponse = false;
                        }
                    }
                } while (!validResponse);

                //
                // commentary on correct strength
                //

                Console.WriteLine();
                Console.WriteLine($"Thank you for your submission! I've entered your relative strength in as...{relativeStrength}.");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue -->");
                Console.ReadKey();
                Console.Clear();

                //
                // Set strength modifier based on race
                //

                switch (raceChoice)
                {
                    case "orc":
                        baseStrength = ORC_STRENGTH;
                        break;

                    case "human":
                        baseStrength = HUMAN_STRENGTH;
                        break;

                    case "elf":
                        baseStrength = ELF_STRENGTH;
                        break;

                    case "hobbit":
                        baseStrength = HOBBIT_STRENGTH;
                        break;

                    default:
                        baseStrength = 0;
                        break;
                }
                if (baseStrength != 0.0)
                {
                    //
                    // calculate damage
                    //

                    Console.WriteLine("Because you chose a {1} as your race, your base strength is {0}.", baseStrength, raceChoice);

                    double totalStrength = baseStrength + relativeStrength;

                    Console.WriteLine("We'll add your base strength to your reported strength.");
                    Console.WriteLine("That's what we'll enter into the simulation.");
                    Console.WriteLine();
                    Console.WriteLine($"That means that your total strength is {totalStrength}.");
                }

                //
                // commentary on total strength
                //

                if (relativeStrength > 7 && baseStrength >= 4)
                {
                    Console.WriteLine("Oh, I can see that you're a strong orc. What a surprise...");
                }
                else if (relativeStrength > 7 && baseStrength < 4)
                {
                    Console.WriteLine("It's nice to see someone who's strong even though they're not an orc!");
                }
                else if (relativeStrength < 5 && baseStrength >= 4)
                {
                    Console.WriteLine("Intriguing. It seems that not all who chose orc have bloated egos.");
                }
                else if (relativeStrength < 2 && baseStrength < 2)
                {
                    Console.WriteLine("...You may have trouble killing the monster.");
                    Console.WriteLine("It's probably good this is a simulation.");
                }
                else if (relativeStrength < 4 && baseStrength < 2)
                {
                    Console.WriteLine("It's okay to not be strong! Elves and hobbits are better with magic!");
                }
                else // none of the above
                {
                    Console.WriteLine("Let's move onto the next step!");
                    Console.WriteLine("Some of this will make more sense then.");
                }

                Console.WriteLine();
                Console.WriteLine("Press any key to continue -->");
                Console.ReadKey();
                Console.Clear();

                //
                // choosing times to attack
                //

                do
                {
                    validResponse = true;

                    Console.WriteLine("Next, how many times do you want to attack?");
                    Console.WriteLine("The monster has 100 health points, so based on your attack, you can decide what's enough to kill it.");
                    Console.WriteLine();
                    Console.WriteLine("You can also decide not to kill it, but you'll earn some money for each time you attack.");
                    Console.WriteLine("I recommend between 2 and 20 times.");
                    Console.WriteLine();
                    Console.Write("How many times do you want to attack the monster? ");
                    userResponse = Console.ReadLine();

                    if (!int.TryParse(userResponse, out timesAttack))
                    {
                        Console.WriteLine();
                        Console.WriteLine("I don't understand that. Can you repeat? My circuitry is not so good.");
                        Console.WriteLine("I need a number, in numeric, numbery, digit-y form.");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue -->");
                        Console.ReadKey();
                        Console.Clear();

                        validResponse = false;
                    }
                    else
                    {
                        if (timesAttack <= 1 || timesAttack > 20)
                        {
                            Console.WriteLine();
                            Console.WriteLine("I need something between 2 and 20 for the simulation.");
                            Console.WriteLine("I understand numbers are hard for organic creatures, but please try.");
                            Console.WriteLine();
                            Console.WriteLine("Press any key to continue -->");
                            Console.ReadKey();
                            Console.Clear();

                            validResponse = false;
                        }
                    }
                } while (!validResponse);

                Console.WriteLine();
                Console.WriteLine($"Alright! I'll enter {timesAttack} hits into the simulation. Let's see what comes out!");
                Console.WriteLine();

                //
                // display table headers for damage output
                //

                Console.WriteLine(
                "Turn".PadLeft(5) +
                "Enemy's Current HP".PadLeft(20) +
                "Damage Done".PadLeft(15) +
                "Enemy's HP Remaining".PadLeft(25) +
                "Money Earned".PadLeft(15) +
                "Total Money".PadLeft(15)
                );

                //
                // run the arena simulation
                //

                for (int hits = 1; hits <= timesAttack; hits++)
                {
                    double moneyEarned = 300;
                    double totalStrength = baseStrength + relativeStrength;
                    double remainingHealth = currentHealth - totalStrength;
                    totalMoney = hits * 300;

                    Console.WriteLine(
                        hits.ToString().PadLeft(5) +
                        currentHealth.ToString().PadLeft(20) +
                        totalStrength.ToString().PadLeft(15) +
                        remainingHealth.ToString().PadLeft(25) +
                        moneyEarned.ToString("C2").PadLeft(15) +
                        totalMoney.ToString("C2").PadLeft(15));
                    
                    currentHealth = remainingHealth;
                }

                totalMoney = timesAttack * 300;
                double enemyDeath = 100 - (timesAttack * (baseStrength + relativeStrength));

                //
                // comment on if the enemy died or not
                //

                if (enemyDeath <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("It appears you've killed the monster and didn't need every turn.");
                    Console.WriteLine("Good job! You earned some money by fighting.");
                }
                else if (enemyDeath > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Oh, it looks like you didn't kill the enemy. That's okay, you still earned money for each turn.");
                }

                Console.WriteLine();
                Console.WriteLine("Press any key to continue -->");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("I hope that simulation was fun! As you can see, it was pretty boring, but no maiming occurred!");
                Console.WriteLine("In a real situation, you might have gotten hurt, so we need to simulate a remedy to that.");

                Console.WriteLine();
                Console.WriteLine("Press any key to continue -->");
                Console.ReadKey();
                Console.Clear();

                //
                // chadley tries to have a conversation [yes/no validation]
                //

                Console.BackgroundColor = generalScreenBackground;
                Console.ForegroundColor = generalScreenForeground;
                Console.Clear();

                Console.WriteLine("Next, we're going to go to the item shop.");
                Console.WriteLine("Before we go though, I've been programmed to ask you a transitional question.");
                Console.WriteLine();

                do
                {
                    validResponse = true;

                    Console.Write($"{userName}, what is your favorite tea? ");
                    favoriteTea = Console.ReadLine();
                    Console.WriteLine();

                    if (favoriteTea != "chai")
                    {
                        
                        Console.WriteLine("I'm sorry, I was only programmed to accept \"chai\" as an answer.");
                        Console.WriteLine("It appears my programmer has very...extreme taste.");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue -->");
                        Console.ReadKey();
                        Console.Clear();

                        validResponse = false;
                    }
                } while (!validResponse);

                Console.WriteLine("An excellent choice. I'm glad we had this interesting conversation.");
                Console.WriteLine();
                
                do
                {
                    validResponse = true;

                    Console.Write("Secondly, are you having fun? ");
                    userResponse = Console.ReadLine().ToLower();
                    Console.WriteLine();

                    if (userResponse == "yes")
                    {
                        Console.WriteLine("Excellent! I have nothing to add. My apologies.");
                    }
                    else if (userResponse == "no")
                    {
                        Console.WriteLine("Really?! But I didn't maim you! That was the problem the other participants had...");
                    }
                    if (userResponse != "yes" && userResponse != "no")
                    {
                        Console.WriteLine("I can only accept a yes or no answer. This is an experiment after all.");
                        Console.WriteLine("Open-ended questions are for the human scientists!");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue -->");
                        Console.ReadKey();
                        Console.Clear();

                        validResponse = false;
                    }
                } while (!validResponse);

                Console.WriteLine();
                Console.WriteLine("Now, onto the item shop.");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue -->");
                Console.ReadKey();
                Console.Clear();

                //
                // buying an item opening screen
                //

                Console.BackgroundColor = shopScreenBackground;
                Console.ForegroundColor = shopScreenForeground;
                Console.Clear();

                Console.WriteLine("\t   ___");
                Console.WriteLine("\t   )_(                                            _");
                Console.WriteLine("\t   | |                                           [_ ]");
                Console.WriteLine("\t .-'-'-.       _                               .-'. '-.");
                Console.WriteLine("\t/-::_..-\\    _[_]_                            /:;/ _.-'\\");
                Console.WriteLine("\t)_     _(   /_   _\\      [-]                  |:._   .-|");
                Console.WriteLine("\t|;::    |   )_``'_(    .-'-'-.       (-)      |:._     |");
                Console.WriteLine("\t|;::    |   |;:   |    :-...-:     .-'-'-.    |:._     |");
                Console.WriteLine("\t|;::    |   |;:   |    |;:   |     |-...-|    |:._     |");
                Console.WriteLine("\t|;::-.._|   |;:.._|    |;:.._|     |;:.._|    |:._     |");
                Console.WriteLine("\t`-.._..-'   `-...-'    `-...-'     `-...-'    `-.____.-'");
                Console.WriteLine();
                Console.WriteLine("\tWelcome to the item shop!");
                Console.WriteLine();
                Console.WriteLine("\tPress any key to continue -->");
                Console.ReadKey();
                Console.Clear();

                //
                // introduction to the cost of items
                //

                Console.WriteLine("Stocking up on items can be fun and satisfying...for some people.");
                Console.WriteLine("Perhaps for others, they are merely bag carriers, but I will assume you're not in that group.");
                Console.WriteLine();
                Console.WriteLine("There are two basic items that we'll start with, potions and antidotes.");
                Console.WriteLine("Potions heal you, and antidotes cure you of poison.");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue -->");
                Console.ReadKey();
                Console.Clear();

                //
                // reiterating amount of money user has
                //

                Console.WriteLine("Unfortunately, such valuable items don't come free.");
                Console.WriteLine();
                Console.WriteLine($"You have {totalMoney:c} to spend.");

                //
                // validate potion cost
                //

                do
                {
                    validResponse = true;

                    Console.WriteLine("First, you get to decide how much potions cost.");
                    Console.WriteLine();
                    Console.Write("How much do you think? ");
                    userResponse = Console.ReadLine();
                    Console.WriteLine();

                    if (!double.TryParse(userResponse, out potionCost))
                    {
                        Console.WriteLine("I let you set the cost of your potions, and this is what you tell me?");
                        Console.WriteLine("Please give me a real number.");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue -->");
                        Console.ReadKey();
                        Console.Clear();
                        validResponse = false;
                    }
                    else if (potionCost > totalMoney)  
                        {
                            Console.WriteLine($"You probably shouldn't set your prices for more money than you have.");
                            Console.WriteLine();
                            Console.WriteLine("Press any key to continue -->");
                            Console.ReadKey();
                            Console.Clear();
                            validResponse = false;
                        }
                    else
                    { if (potionCost <= 0)
                        {
                            Console.WriteLine($"They have to cost something, {userName}. I need funding for my research!");
                            Console.WriteLine("Press any key to continue -->");
                            Console.ReadKey();
                            Console.Clear();
                            validResponse = false;
                        }
                    }
                } while (!validResponse);

                Console.WriteLine($"Alright, {potionCost:c} it is.");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue -->");
                Console.ReadKey();
                Console.Clear();

                //
                // validate potions purchase
                //

                do
                {
                    validResponse = true;

                    Console.WriteLine("Okay, we have our prices. Now time for the fun part. Buying them!");
                    Console.WriteLine();
                    Console.Write("How many potions would you like to buy? ");
                    userResponse = Console.ReadLine();
                    Console.WriteLine();

                    if (!int.TryParse(userResponse, out potionsPurchased))
                    {
                        Console.WriteLine("We're here to buy a NUMBER of potions. I swear.");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue -->");
                        Console.ReadKey();
                        Console.Clear();
                        validResponse = false;
                    }
                    else if (potionsPurchased * potionCost > totalMoney)
                    {
                        
                        {
                            Console.WriteLine($"You don't have enough money to buy {potionsPurchased} potions.");
                            Console.WriteLine();
                            Console.WriteLine("Press any key to continue -->");
                            Console.ReadKey();
                            Console.Clear();
                            validResponse = false;
                        }
                     }       
                    else
                    {
                        if (potionsPurchased < 0)
                        {
                            Console.WriteLine("You can't buy negative potions. You can buy 0!");
                            Console.WriteLine("Press any key to continue -->");
                            Console.ReadKey();
                            Console.Clear();
                            validResponse = false;
                        }
                    }

                    
                } while (!validResponse);

                //
                // validate antidote cost
                //

                double remainingMoney = totalMoney - potionsPurchased * potionCost;

                Console.WriteLine("Press any key to continue -->");
                Console.ReadKey();
                Console.Clear();

                do
                {
                    validResponse = true;

                    Console.WriteLine("Alright! You have {0:c} left to spend on antidotes.", remainingMoney);
                    Console.WriteLine("You get to decide how much antidotes cost.");
                    Console.WriteLine();
                    Console.Write("How much do you think? ");
                    userResponse = Console.ReadLine();
                    Console.WriteLine();

                    if (!double.TryParse(userResponse, out antidoteCost))
                    {
                        Console.WriteLine("I let you set your own price, and you give me a nonsense answer.");
                        Console.WriteLine("Please give me a real number");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue -->");
                        Console.ReadKey();
                        Console.Clear();
                        validResponse = false;
                    }
                    else if (antidoteCost > remainingMoney)
                    {
                        Console.WriteLine($"You probably shouldn't set your prices for more money than you have.");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue -->");
                        Console.ReadKey();
                        Console.Clear();
                        validResponse = false;
                    }
                    else
                    {
                        if (antidoteCost < 0)
                        {
                            Console.WriteLine($"Well, you can't set a negative price! If you bought too many potions, you can set it as zero.");
                            validResponse = false;
                        }
                    }
                } while (!validResponse);

                Console.WriteLine($"Alright, {antidoteCost:c} is the cost.");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue -->");
                Console.ReadKey();
                Console.Clear();

                //
                // validate antidotes purchased
                //

                do
                {
                    validResponse = true;

                    Console.Write("Next, how many antidotes would you like to buy? ");
                    userResponse = Console.ReadLine();

                    if (!int.TryParse(userResponse, out antidotesPurchased))
                    {
                        Console.WriteLine();
                        Console.WriteLine("We're here to buy a NUMBER of antidotes. I swear.");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue -->");
                        Console.ReadKey();
                        Console.Clear();
                        validResponse = false;
                    }
                    else if (antidotesPurchased * antidoteCost > remainingMoney)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"You don't have enough money to buy {antidotesPurchased} antidotes.");
                        Console.WriteLine("You spent too much on potions.");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue -->");
                        Console.ReadKey();
                        Console.Clear();
                        validResponse = false;
                     }
                     else
                     {
                          if (potionsPurchased < 0)
                          {
                            Console.WriteLine("You can't buy negative potions. You can buy 0!");
                            Console.WriteLine();
                            Console.WriteLine("Press any key to continue -->");
                            Console.ReadKey();
                            Console.Clear();
                            validResponse = false;
                          }
                     }
                } while (!validResponse);

                double totalCost = (antidotesPurchased * antidoteCost) + (potionsPurchased * potionCost);

                //
                // calculating total cost and commentary on how much spent
                //

                Console.WriteLine();
                Console.Write($"Your total cost is {totalCost:c}. ");

                Console.WriteLine("Here's a breakdown of what you bought:");
                Console.WriteLine();

                //
                // display inventory header
                //

                Console.WriteLine(
                "Item" +
                "Inventory".PadLeft(15) +
                "Cost Per Item".PadLeft(15) +
                "Total".PadLeft(15)
                );

                //
                // potions
                //

                Console.WriteLine();
                Console.WriteLine(
                "Potions  ".PadLeft(5) +
                potionsPurchased.ToString().PadLeft(10) +
                potionCost.ToString("C2").PadLeft(15) +
                (potionsPurchased * potionCost).ToString("C2").PadLeft(15)
                );

                //
                // antidotes
                //

                Console.WriteLine(
                "Antidotes".PadLeft(5) +
                antidotesPurchased.ToString().PadLeft(10) +
                antidoteCost.ToString("C2").PadLeft(15) +
                (antidotesPurchased * antidoteCost).ToString("C2").PadLeft(15)
                );

                //
                // grand total
                //

                Console.WriteLine();
                Console.WriteLine(
                "GRAND TOTAL".PadLeft(5) +
                totalCost.ToString("C2").PadLeft(45));
                Console.WriteLine();
               
                if (totalCost < 250)
                {
                    Console.WriteLine("You should probably buy something.");
                    Console.WriteLine("Don't worry, you'll make more money later on.");
                }
                else if (totalCost > 3000)
                {
                    Console.WriteLine("Woah, you sure know how to spend a lot of your money");
                    Console.WriteLine("It's a good thing that this is a simulation.");
                }
                else if (totalCost >= 250)
                {
                    Console.WriteLine("I think that's enough to get started. Great job!");
                }
                else
                {
                    Console.WriteLine("We're buying potions here, not doing calculus. I'd let you do it again, but my circuitry is wearing thin.");
                }

                Console.WriteLine();
                Console.WriteLine("Press any key to continue -->");
                Console.ReadKey();
                Console.Clear();

                //
                // xx% off sale
                //

                Console.WriteLine("Well, now this is exciting! It appears that the store is having a sale!");
                Console.WriteLine("After all, as this is a simulation, we can have as many sales as we want.");
                Console.WriteLine();
                Console.WriteLine($"So, {userName}, what percentage off would you like your items to be? Be reasonable!");
                Console.WriteLine();

                do
                {
                    validResponse = true;

                    Console.Write("How much, percentage-wise (0-100), do you want off your items? "); 
                    userResponse = Console.ReadLine();

                    if (!double.TryParse(userResponse, out saleCost))
                    {
                        Console.WriteLine("Uh, do you not want a sale? What does that mean?");
                        Console.WriteLine("Give me a sale number please");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue -->");
                        Console.ReadKey();
                        Console.Clear();

                        validResponse = false;
                    }
                    else
                    {
                        if (saleCost <= 0 || saleCost > 100)
                        {
                            Console.WriteLine("Percentages don't come in numbers outside of 0-100");
                            Console.WriteLine("I didn't need to conduct research to know that!");
                            Console.WriteLine();
                            Console.WriteLine("Press any key to continue -->");
                            Console.ReadKey();
                            Console.Clear();

                            validResponse = false;
                        }
                    }
                } while (!validResponse);

                totalCost *= (1 - (saleCost / 100));

                Console.WriteLine();
                Console.WriteLine($"Because you took {saleCost}% off, your new total is {totalCost:c}");

                Console.WriteLine();
                Console.WriteLine("Press any key to continue -->");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine($"Well, {userName}, I hope you learned something in this little simulation.");
                Console.WriteLine("I know that I've collected valuable data for my research.");
                Console.WriteLine("I hope that you'll participate again soon. That's something my other subjects couldn't do!");

                Console.WriteLine();
                Console.WriteLine("Press any key to continue -->");
                Console.ReadKey();
                Console.Clear();

                //
                // thank you for playing screen
                //

                Console.BackgroundColor = closingScreenBackground;
                Console.ForegroundColor = closingScreenForeground;
                Console.Clear();

                Console.WriteLine("\t                          )      \\    /      (");
                Console.WriteLine("\t                         /|\\      )\\_/(     /|\\");
                Console.WriteLine("\t*                       / | \\    (/\\|/\\)   / | \\                      *");
                Console.WriteLine("\t|`.____________________/__|__o____\\`|'/___o__|__\\___________________.'|");
                Console.WriteLine("\t|                           '^`    \\|/   '^`                          |");
                Console.WriteLine("\t|                                   V                                 |");
                Console.WriteLine("\t|                                                                     |");
                Console.WriteLine("\t|                      Thank You for Participating!                   |");
                Console.WriteLine("\t|                                                                     |");
                Console.WriteLine("\t|                                                                     |");
                Console.WriteLine("\t| ._________________________________________________________________. |");
                Console.WriteLine("\t|'               l    /\\ /        \\\\         \\ /\\   l                `|");
                Console.WriteLine("\t*                l  /   V          ))         V   \\ l                 *");
                Console.WriteLine("\t                 l/               //               \\I");
                Console.WriteLine("\t                                  V");
                Console.WriteLine("\t");
                Console.WriteLine("\tPress any key to end the simulation.");
                Console.ReadKey();
            }

            else if (userResponse == "no")
            { 

                //
                // response to "no"
                //

                Console.BackgroundColor = closingScreenBackground;
                Console.ForegroundColor = closingScreenForeground;
                Console.Clear();

                Console.WriteLine("Oh, you don't want to participate?");
                Console.WriteLine("Hmm, maybe the \"no maiming\" idea wasn't such a good idea after all.");
                Console.WriteLine("I will merely collect more data with the next subject.");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue -->");
                Console.ReadKey();
                Console.Clear();

                //
                // closing screen
                //

                Console.WriteLine();
                Console.WriteLine("\t    \\_\\");
                Console.WriteLine("\t   (_**)");
                Console.WriteLine("\t  __) #_");
                Console.WriteLine("\t ( )...()");
                Console.WriteLine("\t || | |I|");
                Console.WriteLine("\t || | |()__/");
                Console.WriteLine("\t /\\(___)");
                Console.WriteLine("\t_-\"\"\"\"\"\"\" - _\"\" - _");
                Console.WriteLine("\t-,,,,,,,,- ,,");
                Console.WriteLine();
                Console.WriteLine("\tThank you for not participating!");
                Console.WriteLine();
                Console.WriteLine("\tPress any key to end.");
                Console.ReadKey();
            }
            else
            {
                //
                // any other response
                //

                Console.WriteLine();
                Console.WriteLine("Uhh, it appears we may have communicated in error.");
                Console.WriteLine("My programmer told me not to talk to strange people.");
                Console.WriteLine("Oh look, there's a nice man with a big sword over there. I'll go talk to him.");
                Console.WriteLine();
                Console.WriteLine("Press any key to end.");
                Console.ReadKey();
            }
        }
    }
}