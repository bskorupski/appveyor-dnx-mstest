using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNXConsoleApp
{
    public interface IMessageBuilder 
    {
        string GetMessage(String s);
    }

    public class MessageBuilder : IMessageBuilder
    {
        public string GetMessage(String s) {
            return s;
        }
    }
}
