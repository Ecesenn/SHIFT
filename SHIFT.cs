using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int round; int n11 = 1; int n12 = 1; int n13 = 1; int n21 = 1; int n22 = 1; int n23 = 1; int n31 = 1; int n32 = 1; int n33 = 1;
            int boardSerie = 0;
            int turn; string whoseTurn;
            bool flag = false;
            bool flag1 = false;
            bool flag2 = false;
            bool flag3 = false;
            bool flag_move = false;
            int playerGameSeries = 0;
            int playerStartSerie = 0;
            string which_move;
            string end = "End of Round";
            string cont = "Command : ";
            int boardScore;
            int playerScore;
            int computerScore;
            boardScore = 0;
            playerScore = 0;
            computerScore = 0;
            int move;
            int temp;
            bool flag_game = false;
            for (round = 1; round <= 5; round++)
            {
                while (!flag_game)
                {

                    if (round == 1)
                    {

                        Console.WriteLine("     4  5  6 ");
                        Console.WriteLine("   + -  -  - +");
                        Console.WriteLine(" 1 |         |");
                        Console.WriteLine(" 2 |         |");
                        Console.WriteLine(" 3 |         |");
                        Console.WriteLine("   + -  -  - + ");


                        string num;
                        bool flag_num = false;
                        while (!flag_num)
                        {
                            Console.WriteLine("Please enter number between 1,9");
                            num = Console.ReadLine();
                            if ((num.Length == 1) && (num[0] <= '9') && (num[0] >= '1'))
                            {
                                flag_num = true;
                                n11 = Convert.ToInt32(num);
                            }
                            else
                                Console.WriteLine("wrong character");
                        }

                        Console.Clear();

                        Console.WriteLine("     4  5  6 ");
                        Console.WriteLine("   + -  -  - +");
                        Console.WriteLine(" 1 | " + n11 + "       |");
                        Console.WriteLine(" 2 |         |");
                        Console.WriteLine(" 3 |         |");
                        Console.WriteLine("   + -  -  - + ");


                        flag_num = false;
                        while (!flag_num)
                        {
                            Console.WriteLine("Please enter number between 1,9");
                            num = Console.ReadLine();
                            if ((num.Length == 1) && (num[0] <= '9') && (num[0] >= '1'))
                            {
                                flag_num = true;
                                n12 = Convert.ToInt32(num);
                            }
                            if (n11 == n12)
                            {
                                flag_num = false;
                                Console.WriteLine("Please enter another number from others.");
                            }
                            else
                                Console.WriteLine("wrong character");
                        }

                        Console.Clear();

                        Console.WriteLine("     4  5  6 ");
                        Console.WriteLine("   + -  -  - +");
                        Console.WriteLine(" 1 | " + n11 + "  " + n12 + "    |");
                        Console.WriteLine(" 2 |         |");
                        Console.WriteLine(" 3 |         |");
                        Console.WriteLine("   + -  -  - + ");


                        flag_num = false;
                        while (!flag_num)
                        {
                            Console.WriteLine("Please enter number between 1,9");
                            num = Console.ReadLine();
                            if ((num.Length == 1) && (num[0] <= '9') && (num[0] >= '1'))
                            {
                                flag_num = true;
                                n13 = Convert.ToInt32(num);
                            }
                            if ((n11 == n13) || (n12 == n13))
                            {
                                flag_num = false;
                                Console.WriteLine("Please enter another number from others.");
                            }
                            else
                                Console.WriteLine("wrong character");
                        }

                        Console.Clear();

                        Console.WriteLine("     4  5  6 ");
                        Console.WriteLine("   + -  -  - +");
                        Console.WriteLine(" 1 | " + n11 + "  " + n12 + "  " + n13 + " |");
                        Console.WriteLine(" 2 |         |");
                        Console.WriteLine(" 3 |         |");
                        Console.WriteLine("   + -  -  - + ");


                        flag_num = false;
                        while (!flag_num)
                        {
                            Console.WriteLine("Please enter number between 1,9");
                            num = Console.ReadLine();
                            if ((num.Length == 1) && (num[0] <= '9') && (num[0] >= '1'))
                            {
                                flag_num = true;
                                n21 = Convert.ToInt32(num);
                            }
                            if ((n21 == n11) || (n21 == n12) || (n21 == n13))
                            {
                                flag_num = false;
                                Console.WriteLine("Please enter another number from others.");
                            }

                            else
                                Console.WriteLine("wrong character");
                        }

                        Console.Clear();

                        Console.WriteLine("     4  5  6 ");
                        Console.WriteLine("   + -  -  - +");
                        Console.WriteLine(" 1 | " + n11 + "  " + n12 + "  " + n13 + " |");
                        Console.WriteLine(" 2 | " + n21 + "       |");
                        Console.WriteLine(" 3 |         |");
                        Console.WriteLine("   + -  -  - + ");


                        flag_num = false;
                        while (!flag_num)
                        {
                            Console.WriteLine("Please enter number between 1,9");
                            num = Console.ReadLine();
                            if ((num.Length == 1) && (num[0] <= '9') && (num[0] >= '1'))
                            {
                                flag_num = true;
                                n22 = Convert.ToInt32(num);
                            }
                            if ((n11 == n22) || (n12 == n22) || (n13 == n22) || (n21 == n22))
                            {
                                flag_num = false;
                                Console.WriteLine("Please enter another number from others.");
                            }
                            else
                                Console.WriteLine("wrong character");
                        }

                        Console.Clear();

                        Console.WriteLine("     4  5  6 ");
                        Console.WriteLine("   + -  -  - +");
                        Console.WriteLine(" 1 | " + n11 + "  " + n12 + "  " + n13 + " |");
                        Console.WriteLine(" 2 | " + n21 + "  " + n22 + "    |");
                        Console.WriteLine(" 3 |         |");
                        Console.WriteLine("   + -  -  - + ");


                        flag_num = false;
                        while (!flag_num)
                        {
                            Console.WriteLine("Please enter number between 1,9");
                            num = Console.ReadLine();
                            if ((num.Length == 1) && (num[0] <= '9') && (num[0] >= '1'))
                            {
                                flag_num = true;
                                n23 = Convert.ToInt32(num);
                            }
                            if ((n11 == n23) || (n12 == n23) || (n13 == n23) || (n21 == n23) || (n22 == n23))
                            {
                                flag_num = false;
                                Console.WriteLine("Please enter another number from others.");
                            }
                            else
                                Console.WriteLine("wrong character");
                        }

                        Console.Clear();

                        Console.WriteLine("     4  5  6 ");
                        Console.WriteLine("   + -  -  - +");
                        Console.WriteLine(" 1 | " + n11 + "  " + n12 + "  " + n13 + " |");
                        Console.WriteLine(" 2 | " + n21 + "  " + n22 + "  " + n23 + " |");
                        Console.WriteLine(" 3 |         |");
                        Console.WriteLine("   + -  -  - + ");


                        flag_num = false;
                        while (!flag_num)
                        {
                            Console.WriteLine("Please enter number between 1,9");
                            num = Console.ReadLine();
                            if ((num.Length == 1) && (num[0] <= '9') && (num[0] >= '1'))
                            {
                                flag_num = true;
                                n31 = Convert.ToInt32(num);
                            }
                            if ((n11 == n31) || (n12 == n31) || (n13 == n31) || (n21 == n31) || (n22 == n31) || (n23 == n31))
                            {
                                flag_num = false;
                                Console.WriteLine("Please enter another number from others.");
                            }
                            else
                                Console.WriteLine("wrong character");
                        }

                        Console.Clear();

                        Console.WriteLine("     4  5  6 ");
                        Console.WriteLine("   + -  -  - +");
                        Console.WriteLine(" 1 | " + n11 + "  " + n12 + "  " + n13 + " |");
                        Console.WriteLine(" 2 | " + n21 + "  " + n22 + "  " + n23 + " |");
                        Console.WriteLine(" 3 | " + n31 + "       |");
                        Console.WriteLine("   + -  -  - + ");


                        flag_num = false;
                        while (!flag_num)
                        {
                            Console.WriteLine("Please enter number between 1,9");
                            num = Console.ReadLine();
                            if ((num.Length == 1) && (num[0] <= '9') && (num[0] >= '1'))
                            {
                                flag_num = true;
                                n32 = Convert.ToInt32(num);
                            }
                            if ((n11 == n32) || (n12 == n32) || (n13 == n32) || (n21 == n32) || (n22 == n32) || (n23 == n32) || (n31 == n32))
                            {
                                flag_num = false;
                                Console.WriteLine("Please enter another number from others.");
                            }
                            else
                                Console.WriteLine("wrong character");
                        }

                        Console.Clear();

                        Console.WriteLine("     4  5  6 ");
                        Console.WriteLine("   + -  -  - +");
                        Console.WriteLine(" 1 | " + n11 + "  " + n12 + "  " + n13 + " |");
                        Console.WriteLine(" 2 | " + n21 + "  " + n22 + "  " + n23 + " |");
                        Console.WriteLine(" 3 | " + n31 + "  " + n32 + "    |");
                        Console.WriteLine("   + -  -  - + ");

                        flag_num = false;
                        while (!flag_num)
                        {
                            Console.WriteLine("Please enter number between 1,9");
                            num = Console.ReadLine();
                            if ((num.Length == 1) && (num[0] <= '9') && (num[0] >= '1'))
                            {
                                flag_num = true;
                                n33 = Convert.ToInt32(num);
                            }
                            if ((n11 == n33) || (n12 == n33) || (n13 == n33) || (n21 == n33) || (n22 == n33) || (n23 == n33) || (n31 == n33) || (n32 == n33))
                            {
                                flag_num = false;
                                Console.WriteLine("Please enter another number from others.");
                            }
                            else
                                Console.WriteLine("wrong character");
                        }
                        Console.Clear();
                    }

                    else
                    {
                        Random random = new Random();

                        n11 = random.Next(1, 10);
                        n12 = random.Next(1, 10);
                        while (n11 == n12)
                        {
                            n12 = random.Next(1, 10);
                        }
                        n13 = random.Next(1, 10);
                        while ((n11 == n13) || (n12 == n13))
                        {
                            n13 = random.Next(1, 10);
                        }
                        n21 = random.Next(1, 10);
                        while ((n11 == n21) || (n12 == n21) || (n13 == n21))
                        {
                            n21 = random.Next(1, 10);
                        }
                        n22 = random.Next(1, 10);
                        while ((n11 == n22) || (n12 == n22) || (n13 == n22) || (n21 == n22))
                        {
                            n22 = random.Next(1, 10);
                        }
                        n23 = random.Next(1, 10);
                        while ((n11 == n23) || (n12 == n23) || (n13 == n23) || (n21 == n23) || (n22 == n23))
                        {
                            n23 = random.Next(1, 10);
                        }
                        n31 = random.Next(1, 10);
                        while ((n11 == n31) || (n12 == n31) || (n13 == n31) || (n21 == n31) || (n22 == n31) || (n23 == n31))
                        {
                            n31 = random.Next(1, 10);
                        }
                        n32 = random.Next(1, 10);
                        while ((n11 == n32) || (n12 == n32) || (n13 == n32) || (n21 == n32) || (n22 == n32) || (n23 == n32) || (n31 == n32))
                        {
                            n32 = random.Next(1, 10);
                        }
                        n33 = random.Next(1, 10);
                        while ((n11 == n33) || (n12 == n33) || (n13 == n33) || (n21 == n33) || (n22 == n33) || (n23 == n33) || (n31 == n33) || (n32 == n33))
                        {
                            n33 = random.Next(1, 10);
                        }
                    }
                    turn = 1;


                    if (turn % 2 == 0)
                        whoseTurn = "Computer";
                    else
                        whoseTurn = "Player";

                    flag = false;
                    flag1 = false;


                    boardSerie = 0;
                    playerStartSerie = 0;

                    if ((n12 == n11 + 1) & (n12 == n13 - 1) | (n12 == n11 - 1) & (n12 == n13 + 1))
                        boardSerie++;
                    if ((n22 == n21 + 1) & (n22 == n23 - 1) | (n22 == n21 - 1) & (n22 == n23 + 1))
                        boardSerie++;
                    if ((n32 == n31 + 1) & (n32 == n33 - 1) | (n32 == n31 - 1) & (n32 == n33 + 1))
                        boardSerie++;
                    if ((n21 == n11 + 1) & (n21 == n31 - 1) | (n21 == n11 - 1) & (n21 == n31 + 1))
                        boardSerie++;
                    if ((n22 == n12 + 1) & (n22 == n32 - 1) | (n22 == n12 - 1) & (n22 == n32 + 1))
                        boardSerie++;
                    if ((n23 == n13 + 1) & (n23 == n33 - 1) | (n23 == n13 - 1) & (n23 == n33 + 1))
                        boardSerie++;
                    if ((n22 == n11 + 1) & (n22 == n33 - 1) | (n22 == n11 - 1) & (n22 == n33 + 1))
                        boardSerie++;
                    if ((n22 == n13 + 1) & (n22 == n31 - 1) | (n22 == n13 - 1) & (n22 == n31 + 1))
                        boardSerie++;

                    if (boardSerie == 3)
                        boardScore = 9;
                    else if (boardSerie == 2)
                        boardScore = 4;
                    else if (boardSerie == 1)
                        boardScore = 1;
                    else if (boardSerie == 0)
                    {
                        boardScore = 0;
                        flag = true;
                    }



                    while (!flag)
                    {
                        Console.WriteLine("--------------------- Round " + round + " --------------------");
                        Console.WriteLine(); //"\n"
                        Console.WriteLine("     4  5  6                 Turn  : " + turn + "  /  " + whoseTurn);
                        Console.WriteLine("   + -  -  - +");
                        Console.WriteLine(" 1 | " + n11 + "  " + n12 + "  " + n13 + " |               Board Score     : " + boardScore);
                        Console.WriteLine(" 2 | " + n21 + "  " + n22 + "  " + n23 + " |");
                        Console.WriteLine(" 3 | " + n31 + "  " + n32 + "  " + n33 + " |               Player Score    : " + playerScore);
                        Console.WriteLine("   + -  -  - +               Computer Score  : " + computerScore);
                        Console.WriteLine();
                        move = 0;
                        flag_move = false;
                        while (!flag_move)

                        {
                            Console.Write("Command:");
                            which_move = Console.ReadLine();
                            if ((which_move.Length == 1) && (which_move[0] <= '6') && (which_move[0] >= '1'))
                            {
                                flag_move = true;
                                move = Convert.ToInt32(which_move);
                            }
                            else
                            {
                                Console.WriteLine("wrong character");
                            }
                        }

                        Console.Clear();
                        if (move == 1)
                        {
                            temp = 0;
                            temp = n12;
                            n12 = n11;
                            n11 = n13;
                            n13 = temp;
                        }
                        else if (move == 2)
                        {
                            temp = 0;
                            temp = n22;
                            n22 = n21;
                            n21 = n23;
                            n23 = temp;
                        }
                        else if (move == 3)
                        {
                            temp = 0;
                            temp = n32;
                            n32 = n31;
                            n31 = n33;
                            n33 = temp;
                        }
                        else if (move == 4)
                        {
                            temp = 0;
                            temp = n21;
                            n21 = n11;
                            n11 = n31;
                            n31 = temp;
                        }
                        else if (move == 5)
                        {
                            temp = 0;
                            temp = n22;
                            n22 = n12;
                            n12 = n32;
                            n32 = temp;
                        }
                        else if (move == 6)
                        {
                            temp = 0;
                            temp = n23;
                            n23 = n13;
                            n13 = n33;
                            n33 = temp;
                        }

                        if ((n12 == n11 + 1) & (n12 == n13 - 1) | (n12 == n11 - 1) & (n12 == n13 + 1))
                            playerStartSerie++;
                        if ((n22 == n21 + 1) & (n22 == n23 - 1) | (n22 == n21 - 1) & (n22 == n23 + 1))
                            playerStartSerie++;
                        if ((n32 == n31 + 1) & (n32 == n33 - 1) | (n32 == n31 - 1) & (n32 == n33 + 1))
                            playerStartSerie++;
                        if ((n21 == n11 + 1) & (n21 == n31 - 1) | (n21 == n11 - 1) & (n21 == n31 + 1))
                            playerStartSerie++;
                        if ((n22 == n12 + 1) & (n22 == n32 - 1) | (n22 == n12 - 1) & (n22 == n32 + 1))
                            playerStartSerie++;
                        if ((n23 == n13 + 1) & (n23 == n33 - 1) | (n23 == n13 - 1) & (n23 == n33 + 1))
                            playerStartSerie++;
                        if ((n22 == n11 + 1) & (n22 == n33 - 1) | (n22 == n11 - 1) & (n22 == n33 + 1))
                            playerStartSerie++;
                        if ((n22 == n13 + 1) & (n22 == n31 - 1) | (n22 == n13 - 1) & (n22 == n31 + 1))
                            playerStartSerie++;

                        if (playerStartSerie == 3)
                            boardScore = 9;
                        else if (playerStartSerie == 2)
                            boardScore = 4;
                        else if (playerStartSerie == 1)
                            boardScore = 1;
                        else
                        {
                            boardScore = 0;
                            flag = true;
                            flag1 = true;
                        }
                        if (turn % 2 == 0)
                            whoseTurn = "Computer";
                        else
                            whoseTurn = "Player";

                        Console.Clear();
                        Console.WriteLine("--------------------- Round " + round + " --------------------");
                        Console.WriteLine(); //"\n"
                        Console.WriteLine("     4  5  6                 Turn  : " + turn + "  /  " + whoseTurn);
                        Console.WriteLine("   + -  -  - +");
                        Console.WriteLine(" 1 | " + n11 + "  " + n12 + "  " + n13 + " |               Board Score     : " + boardScore);
                        Console.WriteLine(" 2 | " + n21 + "  " + n22 + "  " + n23 + " |");
                        Console.WriteLine(" 3 | " + n31 + "  " + n32 + "  " + n33 + " |               Player Score    : " + playerScore);
                        Console.WriteLine("   + -  -  - +               Computer Score  : " + computerScore);
                        Console.WriteLine();
                        Console.WriteLine(cont + move);
                        Console.ReadLine();
                        Console.Clear();


                        turn++;

                        while (!flag1)
                        {
                            int compSeries_1 = 0;
                            int compSeries_2 = 0;
                            int compSeries_3 = 0;
                            int compSeries_4 = 0;
                            int compSeries_5 = 0;
                            int compSeries_6 = 0;

                            //move 1
                            temp = 0;
                            temp = n12;
                            n12 = n11;
                            n11 = n13;
                            n13 = temp;

                            if ((n12 == n11 + 1) && (n12 == n13 - 1) || (n12 == n11 - 1) && (n12 == n13 + 1))
                                compSeries_1++;
                            if ((n22 == n21 + 1) && (n22 == n23 - 1) || (n22 == n21 - 1) && (n22 == n23 + 1))
                                compSeries_1++;
                            if ((n32 == n31 + 1) && (n32 == n33 - 1) || (n32 == n31 - 1) && (n32 == n33 + 1))
                                compSeries_1++;
                            if ((n21 == n11 + 1) && (n21 == n31 - 1) || (n21 == n11 - 1) && (n21 == n31 + 1))
                                compSeries_1++;
                            if ((n22 == n12 + 1) && (n22 == n32 - 1) || (n22 == n12 - 1) && (n22 == n32 + 1))
                                compSeries_1++;
                            if ((n23 == n13 + 1) && (n23 == n33 - 1) || (n23 == n13 - 1) && (n23 == n33 + 1))
                                compSeries_1++;
                            if ((n22 == n11 + 1) && (n22 == n33 - 1) || (n22 == n11 - 1) && (n22 == n33 + 1))
                                compSeries_1++;
                            if ((n22 == n13 + 1) && (n22 == n31 - 1) || (n22 == n13 - 1) && (n22 == n31 + 1))
                                compSeries_1++;

                            temp = 0;
                            temp = n12;
                            n12 = n13;
                            n13 = n11;
                            n11 = temp;

                            temp = 0;
                            temp = n22;
                            n22 = n21;
                            n21 = n23;
                            n23 = temp;

                            if ((n12 == n11 + 1) && (n12 == n13 - 1) || (n12 == n11 - 1) && (n12 == n13 + 1))
                                compSeries_2++;
                            if ((n22 == n21 + 1) && (n22 == n23 - 1) || (n22 == n21 - 1) && (n22 == n23 + 1))
                                compSeries_2++;
                            if ((n32 == n31 + 1) && (n32 == n33 - 1) || (n32 == n31 - 1) && (n32 == n33 + 1))
                                compSeries_2++;
                            if ((n21 == n11 + 1) && (n21 == n31 - 1) || (n21 == n11 - 1) && (n21 == n31 + 1))
                                compSeries_2++;
                            if ((n22 == n12 + 1) && (n22 == n32 - 1) || (n22 == n12 - 1) && (n22 == n32 + 1))
                                compSeries_2++;
                            if ((n23 == n13 + 1) && (n23 == n33 - 1) || (n23 == n13 - 1) && (n23 == n33 + 1))
                                compSeries_2++;
                            if ((n22 == n11 + 1) && (n22 == n33 - 1) || (n22 == n11 - 1) && (n22 == n33 + 1))
                                compSeries_2++;
                            if ((n22 == n13 + 1) && (n22 == n31 - 1) || (n22 == n13 - 1) && (n22 == n31 + 1))
                                compSeries_2++;

                            temp = 0;
                            temp = n22;
                            n22 = n23;
                            n23 = n21;
                            n21 = temp;

                            temp = 0;
                            temp = n32;
                            n32 = n31;
                            n31 = n33;
                            n33 = temp;

                            if ((n12 == n11 + 1) && (n12 == n13 - 1) || (n12 == n11 - 1) && (n12 == n13 + 1))
                                compSeries_3++;
                            if ((n22 == n21 + 1) && (n22 == n23 - 1) || (n22 == n21 - 1) && (n22 == n23 + 1))
                                compSeries_3++;
                            if ((n32 == n31 + 1) && (n32 == n33 - 1) || (n32 == n31 - 1) && (n32 == n33 + 1))
                                compSeries_3++;
                            if ((n21 == n11 + 1) && (n21 == n31 - 1) || (n21 == n11 - 1) && (n21 == n31 + 1))
                                compSeries_3++;
                            if ((n22 == n12 + 1) && (n22 == n32 - 1) || (n22 == n12 - 1) && (n22 == n32 + 1))
                                compSeries_3++;
                            if ((n23 == n13 + 1) && (n23 == n33 - 1) || (n23 == n13 - 1) && (n23 == n33 + 1))
                                compSeries_3++;
                            if ((n22 == n11 + 1) && (n22 == n33 - 1) || (n22 == n11 - 1) && (n22 == n33 + 1))
                                compSeries_3++;
                            if ((n22 == n13 + 1) && (n22 == n31 - 1) || (n22 == n13 - 1) && (n22 == n31 + 1))
                                compSeries_3++;

                            temp = 0;
                            temp = n32;
                            n32 = n33;
                            n33 = n31;
                            n31 = temp;

                            temp = 0;
                            temp = n21;
                            n21 = n11;
                            n11 = n31;
                            n31 = temp;


                            if ((n12 == n11 + 1) && (n12 == n13 - 1) || (n12 == n11 - 1) && (n12 == n13 + 1))
                                compSeries_4++;
                            if ((n22 == n21 + 1) && (n22 == n23 - 1) || (n22 == n21 - 1) && (n22 == n23 + 1))
                                compSeries_4++;
                            if ((n32 == n31 + 1) && (n32 == n33 - 1) || (n32 == n31 - 1) && (n32 == n33 + 1))
                                compSeries_4++;
                            if ((n21 == n11 + 1) && (n21 == n31 - 1) || (n21 == n11 - 1) && (n21 == n31 + 1))
                                compSeries_4++;
                            if ((n22 == n12 + 1) && (n22 == n32 - 1) || (n22 == n12 - 1) && (n22 == n32 + 1))
                                compSeries_4++;
                            if ((n23 == n13 + 1) && (n23 == n33 - 1) || (n23 == n13 - 1) && (n23 == n33 + 1))
                                compSeries_4++;
                            if ((n22 == n11 + 1) && (n22 == n33 - 1) || (n22 == n11 - 1) && (n22 == n33 + 1))
                                compSeries_4++;
                            if ((n22 == n13 + 1) && (n22 == n31 - 1) || (n22 == n13 - 1) && (n22 == n31 + 1))
                                compSeries_4++;

                            temp = 0;
                            temp = n21;
                            n21 = n31;
                            n31 = n11;
                            n11 = temp;

                            temp = 0;
                            temp = n22;
                            n22 = n12;
                            n12 = n32;
                            n32 = temp;

                            if ((n12 == n11 + 1) && (n12 == n13 - 1) || (n12 == n11 - 1) && (n12 == n13 + 1))
                                compSeries_5++;
                            if ((n22 == n21 + 1) && (n22 == n23 - 1) || (n22 == n21 - 1) && (n22 == n23 + 1))
                                compSeries_5++;
                            if ((n32 == n31 + 1) && (n32 == n33 - 1) || (n32 == n31 - 1) && (n32 == n33 + 1))
                                compSeries_5++;
                            if ((n21 == n11 + 1) && (n21 == n31 - 1) || (n21 == n11 - 1) && (n21 == n31 + 1))
                                compSeries_5++;
                            if ((n22 == n12 + 1) && (n22 == n32 - 1) || (n22 == n12 - 1) && (n22 == n32 + 1))
                                compSeries_5++;
                            if ((n23 == n13 + 1) && (n23 == n33 - 1) || (n23 == n13 - 1) && (n23 == n33 + 1))
                                compSeries_5++;
                            if ((n22 == n11 + 1) && (n22 == n33 - 1) || (n22 == n11 - 1) && (n22 == n33 + 1))
                                compSeries_5++;
                            if ((n22 == n13 + 1) && (n22 == n31 - 1) || (n22 == n13 - 1) && (n22 == n31 + 1))
                                compSeries_5++;

                            temp = 0;
                            temp = n22;
                            n22 = n32;
                            n32 = n12;
                            n12 = temp;

                            temp = 0;
                            temp = n23;
                            n23 = n13;
                            n13 = n33;
                            n33 = temp;

                            if ((n12 == n11 + 1) && (n12 == n13 - 1) || (n12 == n11 - 1) && (n12 == n13 + 1))
                                compSeries_6++;
                            if ((n22 == n21 + 1) && (n22 == n23 - 1) || (n22 == n21 - 1) && (n22 == n23 + 1))
                                compSeries_6++;
                            if ((n32 == n31 + 1) && (n32 == n33 - 1) || (n32 == n31 - 1) && (n32 == n33 + 1))
                                compSeries_6++;
                            if ((n21 == n11 + 1) && (n21 == n31 - 1) || (n21 == n11 - 1) && (n21 == n31 + 1))
                                compSeries_6++;
                            if ((n22 == n12 + 1) && (n22 == n32 - 1) || (n22 == n12 - 1) && (n22 == n32 + 1))
                                compSeries_6++;
                            if ((n23 == n13 + 1) && (n23 == n33 - 1) || (n23 == n13 - 1) && (n23 == n33 + 1))
                                compSeries_6++;
                            if ((n22 == n11 + 1) && (n22 == n33 - 1) || (n22 == n11 - 1) && (n22 == n33 + 1))
                                compSeries_6++;
                            if ((n22 == n13 + 1) && (n22 == n31 - 1) || (n22 == n13 - 1) && (n22 == n31 + 1))
                                compSeries_6++;

                            temp = 0;
                            temp = n23;
                            n23 = n33;
                            n33 = n13;
                            n13 = temp;

                            if ((compSeries_1 <= compSeries_2) && (compSeries_1 <= compSeries_3) && (compSeries_1 <= compSeries_4) && (compSeries_1 <= compSeries_5) && (compSeries_1 <= compSeries_6))
                            {
                                temp = 0;
                                temp = n12;
                                n12 = n11;
                                n11 = n13;
                                n13 = temp;
                                move = 1;
                            }
                            else if ((compSeries_2 <= compSeries_3) && (compSeries_2 <= compSeries_4) && (compSeries_2 <= compSeries_5) && (compSeries_2 <= compSeries_6))
                            {
                                temp = 0;
                                temp = n22;
                                n22 = n21;
                                n21 = n23;
                                n23 = temp;
                                move = 2;
                            }
                            else if ((compSeries_3 <= compSeries_4) && (compSeries_3 <= compSeries_5) && (compSeries_3 <= compSeries_6))
                            {
                                temp = 0;
                                temp = n32;
                                n32 = n31;
                                n31 = n33;
                                n33 = temp;
                                move = 3;
                            }
                            else if ((compSeries_4 <= compSeries_5) && (compSeries_4 <= compSeries_6))
                            {
                                temp = 0;
                                temp = n21;
                                n21 = n11;
                                n11 = n31;
                                n31 = temp;
                                move = 4;
                            }
                            else if (compSeries_5 <= compSeries_6)
                            {
                                temp = 0;
                                temp = n22;
                                n22 = n12;
                                n12 = n32;
                                n32 = temp;
                                move = 5;
                            }
                            else
                            {
                                temp = 0;
                                temp = n23;
                                n23 = n13;
                                n13 = n33;
                                n33 = temp;
                                move = 6;
                            }

                            int min = int.MaxValue;

                            min = Math.Min(min, compSeries_1);
                            min = Math.Min(min, compSeries_2);
                            min = Math.Min(min, compSeries_3);
                            min = Math.Min(min, compSeries_4);
                            min = Math.Min(min, compSeries_5);
                            min = Math.Min(min, compSeries_6);

                            boardScore = min * min;
                            if (boardScore == 0)
                            {
                                flag = true;
                            }

                            flag1 = true;

                            if (turn % 2 == 0)
                                whoseTurn = "Computer";
                            else
                                whoseTurn = "Player";

                            Console.WriteLine("--------------------- Round " + round + " --------------------");
                            Console.WriteLine(); //"\n"
                            Console.WriteLine("     4  5  6                 Turn  : " + turn + "  /  " + whoseTurn);
                            Console.WriteLine("   + -  -  - +");
                            Console.WriteLine(" 1 | " + n11 + "  " + n12 + "  " + n13 + " |               Board Score     : " + boardScore);
                            Console.WriteLine(" 2 | " + n21 + "  " + n22 + "  " + n23 + " |");
                            Console.WriteLine(" 3 | " + n31 + "  " + n32 + "  " + n33 + " |               Player Score    : " + playerScore);
                            Console.WriteLine("   + -  -  - +               Computer Score  : " + computerScore);
                            Console.WriteLine();
                            Console.WriteLine(cont + move);

                            turn++;

                        }
                        flag1 = false;
                    }
                    flag2 = false;
                    flag3 = false;
                    playerGameSeries = 0;

                    while (!flag2)

                    {
                        if (turn % 2 == 1)
                        {

                            if (turn % 2 == 0)
                                whoseTurn = "Computer";
                            else
                                whoseTurn = "Player";

                            Console.WriteLine("--------------------- Round " + round + " --------------------");
                            Console.WriteLine(); //"\n"
                            Console.WriteLine("     4  5  6                 Turn  : " + turn + "  /  " + whoseTurn);
                            Console.WriteLine("   + -  -  - +");
                            Console.WriteLine(" 1 | " + n11 + "  " + n12 + "  " + n13 + " |               Board Score     : " + boardScore);
                            Console.WriteLine(" 2 | " + n21 + "  " + n22 + "  " + n23 + " |");
                            Console.WriteLine(" 3 | " + n31 + "  " + n32 + "  " + n33 + " |               Player Score    : " + playerScore);
                            Console.WriteLine("   + -  -  - +               Computer Score  : " + computerScore);
                            Console.WriteLine();
                            move = 0;
                            flag_move = false;
                            while (!flag_move)

                            {
                                Console.Write("Command:");
                                which_move = Console.ReadLine();
                                if ((which_move.Length == 1) && (which_move[0] <= '6') && (which_move[0] >= '1'))
                                {
                                    flag_move = true;
                                    move = Convert.ToInt32(which_move);
                                }
                                else
                                {
                                    Console.WriteLine("wrong character");
                                }
                            }


                            if (move == 1)
                            {
                                temp = 0;
                                temp = n12;
                                n12 = n11;
                                n11 = n13;
                                n13 = temp;
                            }
                            else if (move == 2)
                            {
                                temp = 0;
                                temp = n22;
                                n22 = n21;
                                n21 = n23;
                                n23 = temp;
                            }
                            else if (move == 3)
                            {
                                temp = 0;
                                temp = n32;
                                n32 = n31;
                                n31 = n33;
                                n33 = temp;
                            }
                            else if (move == 4)
                            {
                                temp = 0;
                                temp = n21;
                                n21 = n11;
                                n11 = n31;
                                n31 = temp;
                            }
                            else if (move == 5)
                            {
                                temp = 0;
                                temp = n22;
                                n22 = n12;
                                n12 = n32;
                                n32 = temp;
                            }
                            else if (move == 6)
                            {
                                temp = 0;
                                temp = n23;
                                n23 = n13;
                                n13 = n33;
                                n33 = temp;
                            }

                            if ((n12 == n11 + 1) & (n12 == n13 - 1) | (n12 == n11 - 1) & (n12 == n13 + 1))
                                playerGameSeries++;
                            if ((n22 == n21 + 1) & (n22 == n23 - 1) | (n22 == n21 - 1) & (n22 == n23 + 1))
                                playerGameSeries++;
                            if ((n32 == n31 + 1) & (n32 == n33 - 1) | (n32 == n31 - 1) & (n32 == n33 + 1))
                                playerGameSeries++;
                            if ((n21 == n11 + 1) & (n21 == n31 - 1) | (n21 == n11 - 1) & (n21 == n31 + 1))
                                playerGameSeries++;
                            if ((n22 == n12 + 1) & (n22 == n32 - 1) | (n22 == n12 - 1) & (n22 == n32 + 1))
                                playerGameSeries++;
                            if ((n23 == n13 + 1) & (n23 == n33 - 1) | (n23 == n13 - 1) & (n23 == n33 + 1))
                                playerGameSeries++;
                            if ((n22 == n11 + 1) & (n22 == n33 - 1) | (n22 == n11 - 1) & (n22 == n33 + 1))
                                playerGameSeries++;
                            if ((n22 == n13 + 1) & (n22 == n31 - 1) | (n22 == n13 - 1) & (n22 == n31 + 1))
                                playerGameSeries++;

                            playerScore += playerGameSeries * playerGameSeries;

                            boardScore = playerGameSeries * playerGameSeries;

                            if (turn % 2 == 0)
                                whoseTurn = "Computer";
                            else
                                whoseTurn = "Player";
                            Console.Clear();
                            Console.WriteLine("--------------------- Round " + round + " --------------------");
                            Console.WriteLine(); //"\n"
                            Console.WriteLine("     4  5  6                 Turn  : " + turn + "  /  " + whoseTurn);
                            Console.WriteLine("   + -  -  - +");
                            Console.WriteLine(" 1 | " + n11 + "  " + n12 + "  " + n13 + " |               Board Score     : " + boardScore);
                            Console.WriteLine(" 2 | " + n21 + "  " + n22 + "  " + n23 + " |");
                            Console.WriteLine(" 3 | " + n31 + "  " + n32 + "  " + n33 + " |               Player Score    : " + playerScore);
                            Console.WriteLine("   + -  -  - +               Computer Score  : " + computerScore);
                            Console.WriteLine();
                            if (boardScore != 0)
                            {
                                Console.WriteLine(end);
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine(cont + move);
                                Console.ReadLine();
                                Console.Clear();
                            }

                            turn++;

                            if (playerGameSeries != 0)
                            {
                                flag2 = true;
                                flag3 = true;
                            }
                        }
                        if (turn % 2 == 0)
                        {
                            if (boardScore == 0)
                            {
                                flag3 = false;
                            }
                            while (!flag3)
                            {
                                int compSeries_1 = 0;
                                int compSeries_2 = 0;
                                int compSeries_3 = 0;
                                int compSeries_4 = 0;
                                int compSeries_5 = 0;
                                int compSeries_6 = 0;

                                //move 1
                                temp = 0;
                                temp = n12;
                                n12 = n11;
                                n11 = n13;
                                n13 = temp;

                                if ((n12 == n11 + 1) && (n12 == n13 - 1) || (n12 == n11 - 1) && (n12 == n13 + 1))
                                    compSeries_1++;
                                if ((n22 == n21 + 1) && (n22 == n23 - 1) || (n22 == n21 - 1) && (n22 == n23 + 1))
                                    compSeries_1++;
                                if ((n32 == n31 + 1) && (n32 == n33 - 1) || (n32 == n31 - 1) && (n32 == n33 + 1))
                                    compSeries_1++;
                                if ((n21 == n11 + 1) && (n21 == n31 - 1) || (n21 == n11 - 1) && (n21 == n31 + 1))
                                    compSeries_1++;
                                if ((n22 == n12 + 1) && (n22 == n32 - 1) || (n22 == n12 - 1) && (n22 == n32 + 1))
                                    compSeries_1++;
                                if ((n23 == n13 + 1) && (n23 == n33 - 1) || (n23 == n13 - 1) && (n23 == n33 + 1))
                                    compSeries_1++;
                                if ((n22 == n11 + 1) && (n22 == n33 - 1) || (n22 == n11 - 1) && (n22 == n33 + 1))
                                    compSeries_1++;
                                if ((n22 == n13 + 1) && (n22 == n31 - 1) || (n22 == n13 - 1) && (n22 == n31 + 1))
                                    compSeries_1++;

                                temp = 0;
                                temp = n12;
                                n12 = n13;
                                n13 = n11;
                                n11 = temp;

                                temp = 0;
                                temp = n22;
                                n22 = n21;
                                n21 = n23;
                                n23 = temp;

                                if ((n12 == n11 + 1) && (n12 == n13 - 1) || (n12 == n11 - 1) && (n12 == n13 + 1))
                                    compSeries_2++;
                                if ((n22 == n21 + 1) && (n22 == n23 - 1) || (n22 == n21 - 1) && (n22 == n23 + 1))
                                    compSeries_2++;
                                if ((n32 == n31 + 1) && (n32 == n33 - 1) || (n32 == n31 - 1) && (n32 == n33 + 1))
                                    compSeries_2++;
                                if ((n21 == n11 + 1) && (n21 == n31 - 1) || (n21 == n11 - 1) && (n21 == n31 + 1))
                                    compSeries_2++;
                                if ((n22 == n12 + 1) && (n22 == n32 - 1) || (n22 == n12 - 1) && (n22 == n32 + 1))
                                    compSeries_2++;
                                if ((n23 == n13 + 1) && (n23 == n33 - 1) || (n23 == n13 - 1) && (n23 == n33 + 1))
                                    compSeries_2++;
                                if ((n22 == n11 + 1) && (n22 == n33 - 1) || (n22 == n11 - 1) && (n22 == n33 + 1))
                                    compSeries_2++;
                                if ((n22 == n13 + 1) && (n22 == n31 - 1) || (n22 == n13 - 1) && (n22 == n31 + 1))
                                    compSeries_2++;

                                temp = 0;
                                temp = n22;
                                n22 = n23;
                                n23 = n21;
                                n21 = temp;

                                temp = 0;
                                temp = n32;
                                n32 = n31;
                                n31 = n33;
                                n33 = temp;

                                if ((n12 == n11 + 1) && (n12 == n13 - 1) || (n12 == n11 - 1) && (n12 == n13 + 1))
                                    compSeries_3++;
                                if ((n22 == n21 + 1) && (n22 == n23 - 1) || (n22 == n21 - 1) && (n22 == n23 + 1))
                                    compSeries_3++;
                                if ((n32 == n31 + 1) && (n32 == n33 - 1) || (n32 == n31 - 1) && (n32 == n33 + 1))
                                    compSeries_3++;
                                if ((n21 == n11 + 1) && (n21 == n31 - 1) || (n21 == n11 - 1) && (n21 == n31 + 1))
                                    compSeries_3++;
                                if ((n22 == n12 + 1) && (n22 == n32 - 1) || (n22 == n12 - 1) && (n22 == n32 + 1))
                                    compSeries_3++;
                                if ((n23 == n13 + 1) && (n23 == n33 - 1) || (n23 == n13 - 1) && (n23 == n33 + 1))
                                    compSeries_3++;
                                if ((n22 == n11 + 1) && (n22 == n33 - 1) || (n22 == n11 - 1) && (n22 == n33 + 1))
                                    compSeries_3++;
                                if ((n22 == n13 + 1) && (n22 == n31 - 1) || (n22 == n13 - 1) && (n22 == n31 + 1))
                                    compSeries_3++;

                                temp = 0;
                                temp = n32;
                                n32 = n33;
                                n33 = n31;
                                n31 = temp;

                                temp = 0;
                                temp = n21;
                                n21 = n11;
                                n11 = n31;
                                n31 = temp;


                                if ((n12 == n11 + 1) && (n12 == n13 - 1) || (n12 == n11 - 1) && (n12 == n13 + 1))
                                    compSeries_4++;
                                if ((n22 == n21 + 1) && (n22 == n23 - 1) || (n22 == n21 - 1) && (n22 == n23 + 1))
                                    compSeries_4++;
                                if ((n32 == n31 + 1) && (n32 == n33 - 1) || (n32 == n31 - 1) && (n32 == n33 + 1))
                                    compSeries_4++;
                                if ((n21 == n11 + 1) && (n21 == n31 - 1) || (n21 == n11 - 1) && (n21 == n31 + 1))
                                    compSeries_4++;
                                if ((n22 == n12 + 1) && (n22 == n32 - 1) || (n22 == n12 - 1) && (n22 == n32 + 1))
                                    compSeries_4++;
                                if ((n23 == n13 + 1) && (n23 == n33 - 1) || (n23 == n13 - 1) && (n23 == n33 + 1))
                                    compSeries_4++;
                                if ((n22 == n11 + 1) && (n22 == n33 - 1) || (n22 == n11 - 1) && (n22 == n33 + 1))
                                    compSeries_4++;
                                if ((n22 == n13 + 1) && (n22 == n31 - 1) || (n22 == n13 - 1) && (n22 == n31 + 1))
                                    compSeries_4++;

                                temp = 0;
                                temp = n21;
                                n21 = n31;
                                n31 = n11;
                                n11 = temp;

                                temp = 0;
                                temp = n22;
                                n22 = n12;
                                n12 = n32;
                                n32 = temp;

                                if ((n12 == n11 + 1) && (n12 == n13 - 1) || (n12 == n11 - 1) && (n12 == n13 + 1))
                                    compSeries_5++;
                                if ((n22 == n21 + 1) && (n22 == n23 - 1) || (n22 == n21 - 1) && (n22 == n23 + 1))
                                    compSeries_5++;
                                if ((n32 == n31 + 1) && (n32 == n33 - 1) || (n32 == n31 - 1) && (n32 == n33 + 1))
                                    compSeries_5++;
                                if ((n21 == n11 + 1) && (n21 == n31 - 1) || (n21 == n11 - 1) && (n21 == n31 + 1))
                                    compSeries_5++;
                                if ((n22 == n12 + 1) && (n22 == n32 - 1) || (n22 == n12 - 1) && (n22 == n32 + 1))
                                    compSeries_5++;
                                if ((n23 == n13 + 1) && (n23 == n33 - 1) || (n23 == n13 - 1) && (n23 == n33 + 1))
                                    compSeries_5++;
                                if ((n22 == n11 + 1) && (n22 == n33 - 1) || (n22 == n11 - 1) && (n22 == n33 + 1))
                                    compSeries_5++;
                                if ((n22 == n13 + 1) && (n22 == n31 - 1) || (n22 == n13 - 1) && (n22 == n31 + 1))
                                    compSeries_5++;

                                temp = 0;
                                temp = n22;
                                n22 = n32;
                                n32 = n12;
                                n12 = temp;

                                temp = 0;
                                temp = n23;
                                n23 = n13;
                                n13 = n33;
                                n33 = temp;

                                if ((n12 == n11 + 1) && (n12 == n13 - 1) || (n12 == n11 - 1) && (n12 == n13 + 1))
                                    compSeries_6++;
                                if ((n22 == n21 + 1) && (n22 == n23 - 1) || (n22 == n21 - 1) && (n22 == n23 + 1))
                                    compSeries_6++;
                                if ((n32 == n31 + 1) && (n32 == n33 - 1) || (n32 == n31 - 1) && (n32 == n33 + 1))
                                    compSeries_6++;
                                if ((n21 == n11 + 1) && (n21 == n31 - 1) || (n21 == n11 - 1) && (n21 == n31 + 1))
                                    compSeries_6++;
                                if ((n22 == n12 + 1) && (n22 == n32 - 1) || (n22 == n12 - 1) && (n22 == n32 + 1))
                                    compSeries_6++;
                                if ((n23 == n13 + 1) && (n23 == n33 - 1) || (n23 == n13 - 1) && (n23 == n33 + 1))
                                    compSeries_6++;
                                if ((n22 == n11 + 1) && (n22 == n33 - 1) || (n22 == n11 - 1) && (n22 == n33 + 1))
                                    compSeries_6++;
                                if ((n22 == n13 + 1) && (n22 == n31 - 1) || (n22 == n13 - 1) && (n22 == n31 + 1))
                                    compSeries_6++;

                                temp = 0;
                                temp = n23;
                                n23 = n33;
                                n33 = n13;
                                n13 = temp;

                                int max = int.MinValue;

                                max = Math.Max(max, compSeries_1);
                                max = Math.Max(max, compSeries_2);
                                max = Math.Max(max, compSeries_3);
                                max = Math.Max(max, compSeries_4);
                                max = Math.Max(max, compSeries_5);
                                max = Math.Max(max, compSeries_6);
                                move = 0;
                                if (max != 0)
                                {
                                    if ((compSeries_1 >= compSeries_2) && (compSeries_1 >= compSeries_3) && (compSeries_1 >= compSeries_4) && (compSeries_1 >= compSeries_5) && (compSeries_1 >= compSeries_6))
                                    {
                                        temp = 0;
                                        temp = n12;
                                        n12 = n11;
                                        n11 = n13;
                                        n13 = temp;
                                        move = 1;
                                    }

                                    else if ((compSeries_2 >= compSeries_3) && (compSeries_2 >= compSeries_4) && (compSeries_2 >= compSeries_5) && (compSeries_2 >= compSeries_6))
                                    {
                                        temp = 0;
                                        temp = n22;
                                        n22 = n21;
                                        n21 = n23;
                                        n23 = temp;
                                        move = 2;
                                    }

                                    else if ((compSeries_3 >= compSeries_4) && (compSeries_3 >= compSeries_5) && (compSeries_3 >= compSeries_6))
                                    {
                                        temp = 0;
                                        temp = n32;
                                        n32 = n31;
                                        n31 = n33;
                                        n33 = temp;
                                        move = 3;
                                    }

                                    else if ((compSeries_4 >= compSeries_5) && (compSeries_4 >= compSeries_6))
                                    {
                                        temp = 0;
                                        temp = n21;
                                        n21 = n11;
                                        n11 = n31;
                                        n31 = temp;
                                        move = 4;
                                    }

                                    else if (compSeries_5 >= compSeries_6)
                                    {
                                        temp = 0;
                                        temp = n22;
                                        n22 = n12;
                                        n12 = n32;
                                        n32 = temp;
                                        move = 5;
                                    }
                                    else
                                    {
                                        temp = 0;
                                        temp = n23;
                                        n23 = n13;
                                        n13 = n33;
                                        n33 = temp;
                                        move = 6;
                                    }
                                }
                                else
                                {
                                    int randomMove;
                                    Random rnd = new Random();
                                    randomMove = rnd.Next(1, 7);

                                    switch (randomMove)
                                    {
                                        case 1:
                                            move = 1;
                                            temp = 0;
                                            temp = n12;
                                            n12 = n11;
                                            n11 = n13;
                                            n13 = temp;
                                            break;
                                        case 2:
                                            temp = 0;
                                            temp = n22;
                                            n22 = n21;
                                            n21 = n23;
                                            n23 = temp;
                                            move = 2;
                                            break;
                                        case 3:

                                            temp = 0;
                                            temp = n32;
                                            n32 = n31;
                                            n31 = n33;
                                            n33 = temp;
                                            move = 3;
                                            break;
                                        case 4:

                                            temp = 0;
                                            temp = n21;
                                            n21 = n11;
                                            n11 = n31;
                                            n31 = temp;
                                            move = 4;
                                            break;
                                        case 5:

                                            temp = 0;
                                            temp = n22;
                                            n22 = n12;
                                            n12 = n32;
                                            n32 = temp;
                                            move = 5;
                                            break;
                                        case 6:

                                            temp = 0;
                                            temp = n23;
                                            n23 = n13;
                                            n13 = n33;
                                            n33 = temp;
                                            move = 6;
                                            break;
                                    }
                                }
                                boardScore = max * max;
                                if (boardScore != 0)
                                {
                                    computerScore += boardScore;
                                }

                                if (turn % 2 == 0)
                                    whoseTurn = "Computer";
                                else
                                    whoseTurn = "Player";

                                Console.WriteLine("--------------------- Round " + round + " --------------------");
                                Console.WriteLine(); //"\n"
                                Console.WriteLine("     4  5  6                 Turn  : " + turn + "  /  " + whoseTurn);
                                Console.WriteLine("   + -  -  - +");
                                Console.WriteLine(" 1 | " + n11 + "  " + n12 + "  " + n13 + " |               Board Score     : " + boardScore);
                                Console.WriteLine(" 2 | " + n21 + "  " + n22 + "  " + n23 + " |");
                                Console.WriteLine(" 3 | " + n31 + "  " + n32 + "  " + n33 + " |               Player Score    : " + playerScore);
                                Console.WriteLine("   + -  -  - +               Computer Score  : " + computerScore);
                                Console.WriteLine();
                                if (boardScore != 0)
                                {
                                    Console.WriteLine(end);
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine(cont + move);
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                flag3 = true;

                                turn++;

                                if (boardScore != 0)
                                {
                                    flag2 = true;
                                }
                            }
                        }
                    }
                    flag_game = true;
                }
                flag_game = false;
                Console.Clear();
                if ((round == 5) && (computerScore < playerScore))
                    Console.WriteLine("          CONGRATS PLAYER WON!!! \n");
                else if ((round == 5) && (computerScore > playerScore))
                    Console.WriteLine("          COMPUTER WON!!! \n");
                else if ((round == 5) && (computerScore == playerScore))
                {
                    Console.WriteLine("                DRAW!!! \n");
                }

                if (round == 5)
                {
                    Console.WriteLine("           Computer Score:" + computerScore);
                Console.WriteLine("            Player Score:" + playerScore);

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("       Do you want to play again?");
                Console.WriteLine("               Y / N           \n");
            Console.WriteLine();
                Console.WriteLine("           Click 1 for YES \n");
                Console.WriteLine("           Click 0 for NO");
            

                    int choice;
                    Console.WriteLine(" ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 0)
                    {
                        flag_game = true;
                    }
                    else
                    {
                        flag_game = false;
                        Console.Clear();
                    }
                }
            }
        }
    }
}
