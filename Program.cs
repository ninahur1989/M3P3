using System;

namespace M3P3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MessageBox messageBox = new MessageBox();
            messageBox.Open();
            if(messageBox.Result == "Ok")
            {
                Console.WriteLine("Operation was confirmed");
            }
            else if(messageBox.Result == "Cancel")
            {
                Console.WriteLine("Operation was denied");
            }
        }
    }
}
