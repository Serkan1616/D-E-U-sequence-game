using System;

namespace console.ödev2
{
    class Program
    {
        static void Main(string[] args)
        {

            string harf1= "";
            string harf2 = "";
            string harf3 = "";
            
            string[] a1 = new string[15];
            string[] a2 = new string[15];
            string[] a3 = new string[15];                    
            int x = 20;
            int y = 2;
            int s = 20;
            int k = 20;
            int a = 0;
            double player1_score = 120;
            double player2_score = 120;
            int player_win = 3;
            int yy = 1;            
            Random random = new Random();           
            bool start = true;                                   
                Console.SetCursorPosition(17, 2);
                Console.WriteLine("a1:");

                Console.SetCursorPosition(17, 3);
                Console.WriteLine("a2:");

                Console.SetCursorPosition(17, 4);
                Console.WriteLine("a3:");
                Console.SetCursorPosition(60, 3);
                Console.WriteLine("for play press enter");

            while (start)
                {
                
                for(int u = 0; u < 4; u++) {
                    if (u != 0)
                        a = 1;
                  for (int j = a; j < 15; j++)
                    {                       
                        int ranarray = random.Next(1, 4);
                        if (ranarray == 1)
                        {
                            for (int i = 0; i <= j; i++)
                            {
                                if (a1[i] == null)
                                {
                                    int rannumber1 = random.Next(1, 4);
                                    if (rannumber1 == 1)
                                        harf1 = "D";
                                    else if (rannumber1 == 2)
                                        harf1 = "E";
                                    else
                                        harf1 = "U";
                                    a1[i] = harf1;

                                if (j % 2 == 0)
                                {
                                    Console.SetCursorPosition(24, 5);
                                    Console.WriteLine("         ");
                                    Console.SetCursorPosition(24, 1);
                                    Console.WriteLine("Player 1:");
                                    ConsoleKey cki = Console.ReadKey(true).Key;
                                    if (cki == ConsoleKey.Enter)
                                    {
                                    Console.SetCursorPosition(x, y);
                                    Console.Write(a1[i]);

                                    Console.SetCursorPosition(s, y + 1);
                                    Console.Write(a2[j]);

                                    Console.SetCursorPosition(k, y + 2);
                                    Console.Write(a3[j]);
                                    x = x + 1;
                                    if (a1[i] == "D" && a2[i] == "E" && a3[i] == "U" || i < 12 && a1[i] == "D" && a1[i + 1] == "E" && a3[i + 3] == "U" || i > 1 && a1[i] == "D" && a1[i - 1] == "E" && a1[i - 2] == "U" || i > 1 && a1[i] == "D" && a2[i - 1] == "E" && a3[i - 2] == "U" || i > 1 && a1[i] == "U" && a1[i - 1] == "E" && a1[i - 2] == "D" || a1[i] == "U" && a2[i] == "E" && a3[i] == "D" || a1[i] == "U" && a2[i + 1] == "E" && a3[i + 3] == "D")
                                            {
                                                 player_win = 1;
                                            }
                                   
                                       break;
                                    }

                                }
                                else
                                {
                                    Console.SetCursorPosition(24, 1);
                                    Console.WriteLine("         ");
                                    Console.SetCursorPosition(24, 5);
                                    Console.WriteLine("Player 2:");
                                    ConsoleKey cki = Console.ReadKey(true).Key;
                                    if (cki == ConsoleKey.Enter)
                                    {
                                    Console.SetCursorPosition(x, y);
                                    Console.Write(a1[i]);

                                    Console.SetCursorPosition(s, y + 1);
                                    Console.Write(a2[j]);

                                    Console.SetCursorPosition(k, y + 2);
                                    Console.Write(a3[j]);
                                    x = x + 1;
                                            if (a1[i] == "D" && a2[i] == "E" && a3[i] == "U" || i < 12 && a1[i] == "D" && a1[i + 1] == "E" && a3[i + 3] == "U" ||i>1&&a1[i]=="D"&&a1[i-1]=="E"&&a1[i-2]=="U" ||i>1&&a1[i]=="D"&&a2[i-1]=="E"&&a3[i-2]=="U" ||  i > 1 && a1[i] == "U" && a1[i - 1] == "E" && a1[i - 2] == "D" || a1[i] == "U" && a2[i] == "E" && a3[i] == "D"||a1[i]=="U"&&a2[i+1]=="E"&&a3[i+3]=="D")
                                            {
                                                player_win= 2;
                                            }
                                           

                                            break;
                                    }
                                }
                                }
                                
                            }


                        }
                        if (ranarray == 2)
                        {
                            for (int i = 0; i <= j; i++)
                            {
                                if (a2[i] == null)
                                {
                                    int rannumber2 = random.Next(1, 4);
                                    if (rannumber2 == 1)
                                        harf2 = "D";
                                    else if (rannumber2 == 2)
                                        harf2 = "E";
                                    else
                                        harf2 = "U";

                                    a2[i] = harf2;
                                if (j % 2 == 0)
                                {
                                    Console.SetCursorPosition(24, 5);
                                    Console.WriteLine("         ");
                                    Console.SetCursorPosition(24, 1);
                                    Console.WriteLine("Player 1:");
                                    
                                    ConsoleKey cki = Console.ReadKey(true).Key;
                                    
                                    if (cki == ConsoleKey.Enter)
                                    {
                                        Console.SetCursorPosition(x, y);
                                    Console.Write(a1[j]);

                                    Console.SetCursorPosition(s, y + 1);
                                    Console.Write(a2[i]);

                                    Console.SetCursorPosition(k, y + 2);
                                    Console.Write(a3[j]);
                                    s = s + 1;
                                    if (i>2&&a2[i]=="D"&&a2[i-1]=="E"&&a3[i-3]=="U"||i<14&&i>1&&a2[i]=="E"&&a1[i-1]=="D"&&a3[i+1]=="U"|| i<14&&i>1&&a2[i] == "E" && a1[i + 1] == "D" && a3[i-1] == "U"||i>1&&a2[i]=="U"&&a2[i-1]=="E"&&a2[i-2]=="D"|| i < 14 && i > 1 && a1[i-1]=="U"&&a2[i]=="E"&&a3[i+1]=="D"||a1[i]=="D"&&a2[i]=="E"&&a3[i]=="U"|| a1[i] == "U" && a2[i] == "E" && a3[i] == "D" || i < 14 && i > 1 && a1[i+1]=="U"&&a2[i]=="E"&&a3[i-1]=="D"||i>1&&a2[i]=="U"&&a2[i-1]=="E"&&a2[i-2]=="D")
                                        {
                                                player_win = 1;
                                            }
                                    

                                            
                                    break;
                                    }

                                }
                                else
                                {
                                    Console.SetCursorPosition(24, 1);
                                    Console.WriteLine("         ");
                                    Console.SetCursorPosition(24, 5);
                                    Console.WriteLine("Player 2:");
                                    ConsoleKey cki = Console.ReadKey(true).Key;
                                    if (cki == ConsoleKey.Enter)
                                    {
                                        Console.SetCursorPosition(x, y);
                                    Console.Write(a1[j]);

                                    Console.SetCursorPosition(s, y + 1);
                                    Console.Write(a2[i]);

                                    Console.SetCursorPosition(k, y + 2);
                                    Console.Write(a3[j]);
                                    s = s + 1;
                                            if (i > 2 && a2[i] == "D" && a2[i - 1] == "E" && a3[i - 3] == "U" || i < 14 && i > 1 && a2[i] == "E" && a1[i - 1] == "D" && a3[i + 1] == "U" || i < 14 && i > 1 && a2[i] == "E" && a1[i + 1] == "D" && a3[i - 1] == "U" || i > 2 && a2[i] == "U" && a2[i - 1] == "E" && a2[i - 2] == "D" || i < 14 && i > 1 && a1[i - 1] == "U" && a2[i] == "E" && a3[i + 1] == "D" || a1[i] == "D" && a2[i] == "E" && a3[i] == "U" || a1[i] == "U" && a2[i] == "E" && a3[i] == "D" || i < 14 && i > 1 && a1[i + 1] == "U" && a2[i] == "E" && a3[i - 1] == "D" || a2[i] == "U" && a2[i - 1] == "E" && a2[i - 2] == "D")
                                       {
                                                player_win = 2;
                                            }
                                    
                                            
                                    break;
                                    }
                                }
                            }
                                
                            }
                        }
                        if (ranarray == 3)
                        {
                            for (int i = 0; i <= j; i++)
                            {
                                if (a3[i] == null)
                                {
                                    int rannumber3 = random.Next(1, 4);
                                    if (rannumber3 == 1)
                                        harf3 = "D";
                                    else if (rannumber3 == 2)
                                        harf3 = "E";
                                    else
                                        harf3 = "U";

                                    a3[i] = harf3;
                                if (j % 2 == 0)
                                {
                                    Console.SetCursorPosition(24, 5);
                                    Console.WriteLine("         ");
                                    Console.SetCursorPosition(24, 1);
                                    Console.WriteLine("Player 1:");
                                    ConsoleKey cki = Console.ReadKey(true).Key;
                                    if (cki == ConsoleKey.Enter) { 
                                    Console.SetCursorPosition(x, y);
                                    Console.Write(a1[j]);

                                    Console.SetCursorPosition(s, y + 1);
                                    Console.Write(a2[j]);

                                    Console.SetCursorPosition(k, y + 2);
                                    Console.Write(a3[i]);
                                            k = k + 1;
                                            if (a3[i]=="D"&&a2[i]=="E"&&a3[i]=="U"||i>1&&a3[i]=="D"&&a3[i-1]=="E"&&a3[i-2]=="U"||i>1&&a3[i]=="D"&&a2[i-1]=="E"&&a1[i-2]=="U"||  i > 2 && a3[i] == "U" && a3[i - 1] == "E" && a3[i - 2] == "D" || a3[i] == "U" && a2[i] == "E" && a1[i] == "D" || i < 13 && a3[i] == "U" && a2[i + 1] == "E" && a1[i + 2] == "D"||i>1&&a3[i]=="U"&&a2[i-1]=="E"&&a1[i-2]=="D")
                                            {
                                                player_win = 1;
                                            }
                                   

                                            
                                    break;
                                    }
                                }
                                else
                                {
                                    Console.SetCursorPosition(24, 1);
                                    Console.WriteLine("         ");
                                    Console.SetCursorPosition(24, 5);
                                    Console.WriteLine("Player 2:");
                                    ConsoleKey cki = Console.ReadKey(true).Key;
                                    if (cki == ConsoleKey.Enter)
                                    {
                                        Console.SetCursorPosition(x, y);
                                    Console.Write(a1[j]);

                                    Console.SetCursorPosition(s, y + 1);
                                    Console.Write(a2[j]);

                                    Console.SetCursorPosition(k, y + 2);
                                    Console.Write(a3[i]);
                                            k = k + 1;
                                            if (a3[i] == "D" && a2[i] == "E" && a1[i] == "U" || i < 12 && a3[i] == "D" && a2[i + 1] == "E" && a1[i + 2] == "U" || i > 1 && a3[i] == "D" && a3[i - 1] == "E" && a3[i - 2] == "U" || i > 1 && a3[i] == "D" && a2[i - 1] == "E" && a1[i - 2] == "U" || i > 2 && a3[i] == "U" && a3[i - 1] == "E" && a3[i - 2] == "D" || a3[i] == "U" && a2[i] == "E" && a1[i] == "D" || i < 13 && a3[i] == "U" && a2[i + 1] == "E" && a1[i + 2] == "D" || i > 1 && a3[i] == "U" && a2[i - 1] == "E" && a1[i - 2] == "D")
                                         {
                                                player_win = 2;
                                            }
                                   
                                            
                                    break;
                                            
                                    }
                                }
                            }
                                
                            }
                        }
                        if (player_win == 3)
                            if (j % 2 == 0)
                            {
                                player1_score = (player1_score - 5.0);
                                if (player1_score < 100)
                                {
                                    Console.SetCursorPosition(55,1);
                                    Console.WriteLine("(0's are redundant)");
                                    Console.SetCursorPosition(35, 1);
                                    Console.WriteLine("player1 score: " + player1_score);

                                }
                                else
                                {
                                    Console.SetCursorPosition(35, 1);
                                    Console.WriteLine("player1 score: " + player1_score);
                                }
                                    
                               
                            }
                            else
                            {
                                player2_score = (player2_score - 5.0);
                                if (player2_score < 100)
                                {
                                    Console.SetCursorPosition(55, 8);
                                    Console.WriteLine("(0's are redundant)");
                                    Console.SetCursorPosition(35, 8);
                                    Console.WriteLine("player2 score: " + player2_score);

                                }
                                else
                                {
                                    Console.SetCursorPosition(35, 8);
                                    Console.WriteLine("player2 score: " + player2_score);
                                }
                                
                            }
                    }
                                                                
                        if (player_win == 1)
                        {
                            int name_order = 0;
                            string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" ,"Player1"};
                            double[] scores = { 100, 100, 95, 90, 85, 80, 80, 70, 55, 50, 30, 30,player1_score };
                            Console.SetCursorPosition(12, 20);
                            Console.WriteLine("Player 1 Won!!");
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine("HİGH SCORE TABLE ");
                            Array.Sort(scores);
                            Array.Reverse(scores);
                        for (int g = 0; g < scores.Length; g++)
                        {
                            if (scores[g] == player2_score)
                                name_order = g;
                        }
                        string temp;
                        temp = names[name_order];
                        names[name_order] = "player1";
                        names[12] = temp;



                        for (int g = 0; g < names.Length; g++)
                            {
                                
                               
                                Console.WriteLine(names[g]);
                               
                            }
                            
                            for (int ı = 0; ı < scores.Length; ı++)
                            {
                                int xx = 8;
                               

                                Console.SetCursorPosition(xx, yy);
                                Console.WriteLine(scores[ı]);
                                yy = yy + 1;
                                
                            }
                            Console.SetCursorPosition(8, 25);
                            Console.WriteLine("Please enter quit");
                            u = 4;
                            start = false;
                            Console.ReadLine();
                            break;                                                                               
                        }
                        if (player_win == 2)
                        {
                            int name_order = 0;


                            string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan", "Player2" };
                            double[] scores = { 100, 100, 95, 90, 85, 80, 80, 70, 55, 50, 30, 30, player2_score };
                            Console.SetCursorPosition(12, 20);
                            Console.WriteLine("Player 2 Won!!");
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine("HİGH SCORE TABLE ");
                            Array.Sort(scores);
                            Array.Reverse(scores);
                            for (int g = 0; g < scores.Length; g++)
                        {
                            if (scores[g] == player2_score)
                                 name_order = g;
                        }
                           string temp;
                           temp = names[name_order];
                           names[name_order] = "player2";
                           names[12] = temp;
                         

                            for (int g = 0; g < names.Length; g++)
                            {


                                Console.WriteLine(names[g]);

                            }

                            for (int ı = 0; ı < scores.Length; ı++)
                            {
                                int xx = 8;


                                Console.SetCursorPosition(xx, yy);
                                Console.WriteLine(scores[ı]);
                                yy = yy + 1;

                            }
                            Console.SetCursorPosition(8, 25);
                            Console.WriteLine("Please press enter to quit");
                            u = 4;
                            start = false;
                            Console.ReadLine();
                            break;
                        }                   
                }
                
            }














            
        }
    }
}
