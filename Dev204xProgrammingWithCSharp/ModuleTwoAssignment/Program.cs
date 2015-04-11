using System;
using System.Text;

namespace ModuleTwoAssignment
{
    /// <summary>
    /// This is Homework assignment 2 for Module Two
    /// 
    /// We are to use loop and conditional logic to produce the below output:
    /// 
    /// XOXOXOXO
    /// OXOXOXOX
    /// XOXOXOXO
    /// OXOXOXOX
    /// XOXOXOXO
    /// OXOXOXOX
    /// XOXOXOXO
    /// OXOXOXOX
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Constant Values

            /* 
             * 'const' means these values cannot change
             * Documentation here: https://msdn.microsoft.com/en-us/library/e6w8fe1b.aspx
             */
            const int TOTALGRIDITEMS = 64; //8x8 structure
            const int ROWLENGTH = 8;
            const string X = "X";
            const string O = "O";

            #endregion Constant Values

            /*These built-in C# objects are memory efficient ways to deal with lots of 
             * string contacts aka + overloaded operands or string.concat() method calls
             * 
             * Documentation: https://msdn.microsoft.com/en-us/library/system.text.stringbuilder%28v=vs.110%29.aspx
             */
            var output = new StringBuilder();
            var currentLine = new StringBuilder();

            int numLines = 0;
            for (var i = 0; i <= TOTALGRIDITEMS; i++)
            {
                if ((numLines%2) == 0)
                {
                    /*
                       ((i % 2) != 0 ? O : X) is an if/else done in it's operator format
                       Documentation here: https://msdn.microsoft.com/en-us/library/ty67wk28.aspx
                     
                        It's the same as writing the code this way:
                        if ((i%2) == 0)
                        {
                            currentLine.Append(O);
                        }
                        else
                        {
                            currentLine.Append(X);
                        }
                     */
                    currentLine.Append((i % 2) != 0 ? O : X);
                }
                else
                {
                    currentLine.Append((i % 2) == 0 ? O : X);
                }

                if (currentLine.Length == ROWLENGTH)
                {
                    output.AppendLine(currentLine.ToString());
                    currentLine.Clear();
                    numLines++;
                }
            }

            Console.WriteLine(output.ToString());
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();

            /*
               If you would like to be able to run this code and test it quickly without using visual studio
               you can download LINQPad at https://www.linqpad.net/. Once downloaded open LINQPad change the 
               language drop down to C# Program, delete the void Main() and paste this code in there. Press
               the play button and you will get the output. LINQPad is a great way to try out snippets of code
               without having to build an entire project within Visual Studio.
             
               I hope who ever grades this tries out this wonderful tool to help your learning.
             */
        }
    }
}
