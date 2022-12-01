using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine6
{
    class Frequency
    {public void Frequency1(int[]a)
        {
            for (int i = 0; i <a.Length ; i++)
            {
                int count = 1;
                bool isvisited = false;
                for (int k=i-1;k>=0;k--)
                {
                    if(a[i]==a[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited =false )
                {
                    for (int j=i+1;j<a.Length;j++)
                    {
                        if(a[i]==a[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(a + "  " + count);
                }

            }

        }
        static void Main(string []args)
        {
            int[] arr = { 1, 1, 2, 4, 1, 4, 2, 2 };
            Frequency b = new Frequency();
            b.Frequency1(arr);
            


        }
    }
}
