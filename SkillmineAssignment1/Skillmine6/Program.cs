using System;

namespace Skillmineproject6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=1;i<=4;i++)
            {
                for (int j=1;j<=4;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern2
    {
        static void Main(string []args)
        {
            int i; 
            for ( i=1; i<=4; i++)
            {
                for (int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
 
    }
    class pattern3
    {
       static void Main(string []args)
        {
            int i;
            for (i=1;i<=4;i++)
            {
                for (int j =4;j>=i;j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern4
    { 
        static void Main( string []args)
        {
            for (int i=1;i<=4;i++)
            {
                for (int j=4 ;j>=i ;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }
        }
    }

    class Pattern5
    {
        static void Main(string []args)
        {
          
            for (int i=1;i<=4;i++)
            {
                for (int j=1;j<=4;j++)
                {
                    if(j ==1||i ==4 ||i==2&&j==2||i==3&&j==3)
                    {
                        Console.Write("$");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    

                }
                Console.WriteLine();
            }
        }
    }
class Pattern6
    {
        static void Main(string []args)
        {
            for (int i=1;i<=4;i++)
            {
                for (int j = 1; j <= 4; j++)
                    if (j == 1 || j == 4 || i == 2 && j == 2 || i == 3 && j == 3)
                    {
                        Console.Write("*");
                    }
                else
                    {
                        Console.Write(" ");
                    }
                Console.WriteLine();
            }
        }
    }
    class Pattern7
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                    if (i==3||j==3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                Console.WriteLine();
            }
        }
    }

    class Pattern8
    {

        static void Main(string []args)
        {
            for (int i=1;i<=4;i++)
            {
                for (int j=1;j<=4;j++)
                {
                    if (j==1||i==3&&j==3||i==4&&j==3)
                    {
                        Console.Write("*");

                    }
                    else if (i==2&&j==2||i==3&&j==2||i==4&&j==2||i==4&&j==4)
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
class Pattern9
    {
        static void Main(string []args)
        {
            for (char i='A';i<='D';i++)
            {
                for (char j='A';j<=i  ;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern10
    {
        static void Main(string []args)
        {

            for (char i='D';i>='A';i--)
            {
                for (char j=i;j>='A';j--)
                {
                    Console.Write(j);

                }
                Console.WriteLine();
            }
        }
    }
class Pattern11
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i=1;i<=3;i++)
            {
                for (int j=1;j<=i ;j++)
                {
                    count++;
                    Console.Write(count);
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern12
    {
        static void Main(string []args)
        {
            
            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}

