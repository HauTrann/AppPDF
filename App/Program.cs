using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string type = args[0];
            string json = Utils.Base64Decode(args[1]);
            string preNameFile = args[2];
            File.WriteAllText("test.txt", json);
            new GenPDF().getPDF(args[0], json, preNameFile);

        }
    }
}
