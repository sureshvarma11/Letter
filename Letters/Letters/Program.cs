using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row, column;
            Console.WriteLine();

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (((row == 0 || row == 3 || row == 6) && column > 1 && column < 5) ||
                     (column == 1 && (row == 1 || row == 2 || row == 6)) ||
                     (column == 5 && (row == 0 || row == 4 || row == 5)))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
              

                Console.Write("\t");

                for (column = 0; column <= 6; column++)
                {

                    if (((column == 0 || column == 5) && row != 6) || (row == 6 && column > 1 && column < 5))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.Write("\t");

                for (column = 0; column <= 6; column++)
                {

                    if ((column == 1) ||
                       ((row == 0 || row == 3) && column > 1 && column < 5)
                       ||(column==5 && row !=0 && row<3)
                       || (column==row-1 && row>2))
                    {

                        Console.Write("*");

                    }
                    else
                    {

                        Console.Write(" ");

                    }
                }
                Console.Write("\t");

                for (column = 0; column <= 6; column++)
                {
                    if ((column == 1) ||
                        ((row==0 || row == 6) && column >1 && column < 6) ||
                            (row==3 && column > 1 && column < 5))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\t");

                for(column = 0;column <= 6; column++)
                {
                    if(((row==0 || row==3 || row==6) && column>1 && column < 5) ||
                            (column==1 && (row==1 || row==2 || row==6))
                            || (column==5 && (row==0 || row==4 || row==5)))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\t");

                for(column=0;column<= 6; column++)
                {
                    if((column == 0 || column == 6) ||
                        (row==3) && column >0 && column < 6)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
           

            }
            Console.ReadLine();
        }
    }
}



