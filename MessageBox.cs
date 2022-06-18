using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3P3
{
    public class MessageBox
    {
        public Func<string, string> OnMessage;
        public event Func<string, string> Message;
        public string[] _state = new string[] { "Ok", "Cancel" };
        public string Result { get; set; }

        public MessageBox()
        {
            OnMessage = ToDelegate;
            Message = OnMessage;
        }

        public async void Open()
        {
            Random random = new Random();
            int x = random.Next(0, 2);
            var  t = Task.Run(() =>
            {
                Message.Invoke(_state[x]);
            });
            Task.WaitAll(t);

            Console.WriteLine("Window are opened");
            await Task.Delay(3000);
            Console.WriteLine("Window are closed by user");

        }

        public string ToDelegate(string a)
        {
            Console.WriteLine("Window are closed");
            return Result = a;
        }
    }
}
