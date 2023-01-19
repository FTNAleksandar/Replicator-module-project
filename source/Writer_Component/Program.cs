using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Writer_Component.UIHandler;

namespace Writer_Component
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriterUI ui = new WriterUI();

            ui.WriterUIhandler();
        }
    }
}
