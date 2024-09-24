using System.Runtime.InteropServices;

namespace Gambeling_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int sum2 = 0;
            int money = 10; //←←←←← Change the money you start with here 
            int abigale = 60000000;
            while (abigale == 60000000)
            {
                Console.WriteLine("You have " + money + " moneys. Do you want to go gambeling or mining? (or maybe even quit the game?)");
                string place = Console.ReadLine();
                if (place == "Gambeling" && money != 0 || place == "gambeling" && money != 0 || place == "g" && money != 0 || place == "G" && money != 0) //just to get you where you are going
                {//the start of gambling inc
                    Console.WriteLine("You walk over to a run down shack where the town gambeling rink is. You walk over to the dice jack table and nod to the dealer.");
                    Console.WriteLine("How much do you want to bet? You have " + money + " money");

                    int bet = int.Parse(Console.ReadLine());//the bet

                    if (bet <= money && bet != 0) //is it a reasonable bet?
                    {
                        money = money - bet;
                        Console.WriteLine("You place your bet on the table and take the dice ready to roll.");
                        for (int i = 0; i < 1;)
                        {
                            Random rand = new Random();
                            int r = rand.Next(1, 7);
                            sum += r;
                            if (sum > 21)
                            {
                                Console.WriteLine("You roll and you get " + r + ". Your total is " + sum + ". You went bust and lost your bet.");
                                Console.WriteLine();
                                Console.WriteLine();
                                i++;
                            }
                            else
                            {
                                Console.WriteLine("You roll and you get " + r + ". Your total is " + sum + ". Do you want to hit or stay?");
                                string hitstay = Console.ReadLine(); //bad name for the varieble i know
                                if (hitstay == "stay" || hitstay == "s" || hitstay == "S")
                                {
                                    i++; //end loop (basicaly making it a while loop)
                                }
                            }
                        }


                        //Dealer thingy.
                        if (sum <= 21) //if player didnt bust
                        {
                            for (int i = 0; i < 1;)
                            {
                                //dealers dice
                                Random rand = new Random();
                                int r = rand.Next(1, 7);
                                sum2 += r;
                                Console.WriteLine("Dealer rolled " + r + ". The dealer has " + sum2 + ".");
                                if (sum2 >= sum && sum2 <= 21) //if the dealer tied or got more than player and didnt bust
                                {
                                    if (sum2 == sum) //if player and dealer tie
                                    {
                                        Console.WriteLine("You tie and the you take back your original bet.");
                                        money = money + bet;
                                        i++;
                                    }
                                    if (sum2 > sum) //if dealer wins
                                    {
                                        Console.WriteLine("Dealer wins and you loose your bet.");
                                        i++;
                                    }
                                }
                                if (sum2 > 21) //if dealer busts
                                {
                                    Console.WriteLine("The dealer went bust. You double your bet.");
                                    i++;
                                    money = bet * 2 + money;
                                }
                            }
                        }//end of dealer thingy


                        // zeroing the sum of the dice rolles.
                        sum = 0;
                        sum2 = 0;

                    }
                    else //if player tries to bet more than they have.
                    {
                        Console.WriteLine("You are too broke to place such a high bet and you are thrown out since you are a disgusting poor");
                        Console.WriteLine(); //these three are only here for spacing
                        Console.WriteLine();
                        Console.WriteLine();
                        place = "outside";
                    }
                }


                else if (place == "Gambeling" && money == 0 || place == "gambeling" && money == 0 || place == "g" && money == 0 || place == "G" && money == 0)
                {
                    Console.WriteLine("As you aproch the door a bouncer smells the poor exuding from you"/* lol */ + " and stops you from entering. Swearing at him you go back. You should probebly try to work for some money.");
                }


                else if (place == "q" || place == "Q" || place == "s" || place == "S")
                {
                    Console.WriteLine("Write out the whole word you lazy bum"); //just for shits and giggles.
                }

                else if (place == "Stop" || place == "stop" || place == "Quit" || place == "quit")
                {
                    abigale--; //stoping the while loop.
                }

                else if (place == "mine" || place == "Mine" || place == "m" || place == "M") //The children yearn for the mines.
                {
                    Console.WriteLine("You enter into the dark and dingy mine that smells of sweat as you see your cowerkers mining their lives away. You decide to join them.");
                    Console.WriteLine("");
                    Console.WriteLine("To get oney you have to break the word rocks and get the pronounciore you must spell the given word corectly (in all lowercase) and when you feel satisfied just type stopp");
                    //MINIGAME TIME!!!!!!!!!!!!!!
                    for (int i = 0; i < 1;)
                    {
                        Random rand = new Random();
                        int r = rand.Next(1, 102);


                        if (r == 1)
                        {
                            Console.WriteLine("anthropomorphize");
                            string x = Console.ReadLine();
                            if (x == "anthropomorphize")
                            {
                                Console.WriteLine("You got one pronounciore and sell it for one coin");
                                money = money + 1;
                            }
                            else if
                                (x == "stop")
                            {
                                i++;
                            }
                            else
                            {
                                Console.WriteLine("You spelled that wrong");
                            }
                        } //its this again about onehundred more times just condenced so it doesnt take too mutch space in the document and you get scared

                        if (r == 2) { Console.WriteLine("simplification"); string x = Console.ReadLine(); if (x == "simplification") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 3) { Console.WriteLine("questionnaire"); string x = Console.ReadLine(); if (x == "questionnaire") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 4) { Console.WriteLine("mathematizing"); string x = Console.ReadLine(); if (x == "mathematizing") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 5) { Console.WriteLine("representatives"); string x = Console.ReadLine(); if (x == "representatives") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 6) { Console.WriteLine("satisfactorily"); string x = Console.ReadLine(); if (x == "satisfactorily") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 7) { Console.WriteLine("hubristically"); string x = Console.ReadLine(); if (x == "hubristically") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 8) { Console.WriteLine("incandescence"); string x = Console.ReadLine(); if (x == "incandescence") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 9) { Console.WriteLine("cardiopulmonary"); string x = Console.ReadLine(); if (x == "cardiopulmonary") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 10) { Console.WriteLine("insurmountable"); string x = Console.ReadLine(); if (x == "insurmountable") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 11) { Console.WriteLine("huckleberries"); string x = Console.ReadLine(); if (x == "huckleberries") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 12) { Console.WriteLine("confederation"); string x = Console.ReadLine(); if (x == "confederation") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 13) { Console.WriteLine("personification"); string x = Console.ReadLine(); if (x == "personification") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 14) { Console.WriteLine("accreditation"); string x = Console.ReadLine(); if (x == "accreditation") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 15) { Console.WriteLine("contingencies"); string x = Console.ReadLine(); if (x == "contingencies") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 16) { Console.WriteLine("suffrutescent"); string x = Console.ReadLine(); if (x == "suffrutescent") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 17) { Console.WriteLine("constitutional"); string x = Console.ReadLine(); if (x == "constitutional") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 18) { Console.WriteLine("justification"); string x = Console.ReadLine(); if (x == "justification") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 19) { Console.WriteLine("insectivorous"); string x = Console.ReadLine(); if (x == "insectivorous") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 20) { Console.WriteLine("autocephalous"); string x = Console.ReadLine(); if (x == "autocephalous") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 21) { Console.WriteLine("qualifications"); string x = Console.ReadLine(); if (x == "qualifications") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 22) { Console.WriteLine("baccalaureate"); string x = Console.ReadLine(); if (x == "baccalaureate") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 23) { Console.WriteLine("encouragement"); string x = Console.ReadLine(); if (x == "encouragement") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 24) { Console.WriteLine("exceptionally"); string x = Console.ReadLine(); if (x == "exceptionally") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 25) { Console.WriteLine("accomplishment"); string x = Console.ReadLine(); if (x == "accomplishment") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 26) { Console.WriteLine("parenthetical"); string x = Console.ReadLine(); if (x == "parenthetical") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 27) { Console.WriteLine("mathematician"); string x = Console.ReadLine(); if (x == "mathematician") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 28) { Console.WriteLine("uncomfortable"); string x = Console.ReadLine(); if (x == "uncomfortable") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 29) { Console.WriteLine("absorbefacient"); string x = Console.ReadLine(); if (x == "absorbefacient") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 30) { Console.WriteLine("automatically"); string x = Console.ReadLine(); if (x == "automatically") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 31) { Console.WriteLine("infinitesimal"); string x = Console.ReadLine(); if (x == "infinitesimal") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 32) { Console.WriteLine("unforeseeable"); string x = Console.ReadLine(); if (x == "unforeseeable") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 33) { Console.WriteLine("extemporaneous"); string x = Console.ReadLine(); if (x == "extemporaneous") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 34) { Console.WriteLine("inconsiderate"); string x = Console.ReadLine(); if (x == "inconsiderate") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 35) { Console.WriteLine("antihistamine"); string x = Console.ReadLine(); if (x == "antihistamine") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 36) { Console.WriteLine("parliamentary"); string x = Console.ReadLine(); if (x == "parliamentary") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 37) { Console.WriteLine("affectionately"); string x = Console.ReadLine(); if (x == "affectionately") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 38) { Console.WriteLine("inexpressible"); string x = Console.ReadLine(); if (x == "inexpressible") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 39) { Console.WriteLine("ichthyosaurus"); string x = Console.ReadLine(); if (x == "ichthyosaurus") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 40) { Console.WriteLine("knowledgeable"); string x = Console.ReadLine(); if (x == "knowledgeable") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 41) { Console.WriteLine("unconscionable"); string x = Console.ReadLine(); if (x == "unconscionable") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 42) { Console.WriteLine("zoopraxiscope"); string x = Console.ReadLine(); if (x == "zoopraxiscope") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 43) { Console.WriteLine("establishment"); string x = Console.ReadLine(); if (x == "establishment") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 44) { Console.WriteLine("perfectionism"); string x = Console.ReadLine(); if (x == "perfectionism") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 45) { Console.WriteLine("septuagenarian"); string x = Console.ReadLine(); if (x == "septuagenarian") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 46) { Console.WriteLine("incarceration"); string x = Console.ReadLine(); if (x == "incarceration") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 47) { Console.WriteLine("quadrilateral"); string x = Console.ReadLine(); if (x == "quadrilateral") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 48) { Console.WriteLine("comparatively"); string x = Console.ReadLine(); if (x == "comparatively") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 49) { Console.WriteLine("correspondence"); string x = Console.ReadLine(); if (x == "correspondence") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 50) { Console.WriteLine("consciousness"); string x = Console.ReadLine(); if (x == "consciousness") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 51) { Console.WriteLine("thermodynamic"); string x = Console.ReadLine(); if (x == "thermodynamic") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 52) { Console.WriteLine("approximately"); string x = Console.ReadLine(); if (x == "approximately") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 53) { Console.WriteLine("circumnavigate"); string x = Console.ReadLine(); if (x == "circumnavigate") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 54) { Console.WriteLine("indescribable"); string x = Console.ReadLine(); if (x == "indescribable") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 55) { Console.WriteLine("entertainment"); string x = Console.ReadLine(); if (x == "entertainment") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 56) { Console.WriteLine("concatenation"); string x = Console.ReadLine(); if (x == "concatenation") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 57) { Console.WriteLine("reconciliation"); string x = Console.ReadLine(); if (x == "reconciliation") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 58) { Console.WriteLine("indefatigable"); string x = Console.ReadLine(); if (x == "indefatigable") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 59) { Console.WriteLine("animadversion"); string x = Console.ReadLine(); if (x == "animadversion") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 60) { Console.WriteLine("gravitational"); string x = Console.ReadLine(); if (x == "gravitational") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 61) { Console.WriteLine("transportation"); string x = Console.ReadLine(); if (x == "transportation") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 62) { Console.WriteLine("circumference"); string x = Console.ReadLine(); if (x == "circumference") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 63) { Console.WriteLine("uncooperative"); string x = Console.ReadLine(); if (x == "uncooperative") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 64) { Console.WriteLine("hieroglyphics"); string x = Console.ReadLine(); if (x == "hieroglyphics") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 65) { Console.WriteLine("ichthyophagist"); string x = Console.ReadLine(); if (x == "ichthyophagist") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 66) { Console.WriteLine("preternatural"); string x = Console.ReadLine(); if (x == "preternatural") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 67) { Console.WriteLine("impulsiveness"); string x = Console.ReadLine(); if (x == "impulsiveness") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 68) { Console.WriteLine("ventriloquist"); string x = Console.ReadLine(); if (x == "ventriloquist") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 69) { Console.WriteLine("sanctification"); string x = Console.ReadLine(); if (x == "sanctification") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 70) { Console.WriteLine("paraphernalia"); string x = Console.ReadLine(); if (x == "paraphernalia") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 71) { Console.WriteLine("assassination"); string x = Console.ReadLine(); if (x == "assassination") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 72) { Console.WriteLine("Mediterranean"); string x = Console.ReadLine(); if (x == "Mediterranean") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 73) { Console.WriteLine("superintendent"); string x = Console.ReadLine(); if (x == "superintendent") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 74) { Console.WriteLine("daguerreotype"); string x = Console.ReadLine(); if (x == "daguerreotype") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 75) { Console.WriteLine("scintillation"); string x = Console.ReadLine(); if (x == "scintillation") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 76) { Console.WriteLine("circumstances"); string x = Console.ReadLine(); if (x == "circumstances") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 77) { Console.WriteLine("responsibility"); string x = Console.ReadLine(); if (x == "responsibility") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 78) { Console.WriteLine("horripilation"); string x = Console.ReadLine(); if (x == "horripilation") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 79) { Console.WriteLine("pusillanimous"); string x = Console.ReadLine(); if (x == "pusillanimous") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 80) { Console.WriteLine("accoutrements"); string x = Console.ReadLine(); if (x == "accoutrements") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 81) { Console.WriteLine("manageability"); string x = Console.ReadLine(); if (x == "manageability") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 82) { Console.WriteLine("administrator"); string x = Console.ReadLine(); if (x == "administrator") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 83) { Console.WriteLine("recrimination"); string x = Console.ReadLine(); if (x == "recrimination") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 84) { Console.WriteLine("amelioration"); string x = Console.ReadLine(); if (x == "amelioration") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 85) { Console.WriteLine("efflorescence"); string x = Console.ReadLine(); if (x == "efflorescence") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 86) { Console.WriteLine("dischargeable"); string x = Console.ReadLine(); if (x == "dischargeable") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 87) { Console.WriteLine("international"); string x = Console.ReadLine(); if (x == "international") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 88) { Console.WriteLine("inefficiency"); string x = Console.ReadLine(); if (x == "inefficiency") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 89) { Console.WriteLine("perspicacious"); string x = Console.ReadLine(); if (x == "perspicacious") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 90) { Console.WriteLine("contradictory"); string x = Console.ReadLine(); if (x == "contradictory") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 91) { Console.WriteLine("procrastinate"); string x = Console.ReadLine(); if (x == "procrastinate") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 92) { Console.WriteLine("suspiciously"); string x = Console.ReadLine(); if (x == "suspiciously") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 93) { Console.WriteLine("multitudinous"); string x = Console.ReadLine(); if (x == "multitudinous") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 94) { Console.WriteLine("configuration"); string x = Console.ReadLine(); if (x == "configuration") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 95) { Console.WriteLine("comprehensive"); string x = Console.ReadLine(); if (x == "comprehensive") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 96) { Console.WriteLine("imponderable"); string x = Console.ReadLine(); if (x == "imponderable") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 97) { Console.WriteLine("inexperienced"); string x = Console.ReadLine(); if (x == "inexperienced") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 98) { Console.WriteLine("petrochemical"); string x = Console.ReadLine(); if (x == "petrochemical") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 99) { Console.WriteLine("transference"); string x = Console.ReadLine(); if (x == "transference") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 100) { Console.WriteLine("coincidental"); string x = Console.ReadLine(); if (x == "coincidental") { Console.WriteLine("You got one pronounciore and sell it for one coin"); money = money + 1; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        if (r == 101) { Console.WriteLine("it"); string x = Console.ReadLine(); if (x == "it") { Console.WriteLine("You got three pronounciore and sell it for three coins"); money = money + 3; } else if (x == "stop") { i++; } else { Console.WriteLine("You spelled that wrong"); } }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
