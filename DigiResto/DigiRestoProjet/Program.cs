using System;
using System.Collections.Generic;
using System.Linq;
﻿using DigiRestoProjet.Model;
using DigiRestoProjet.View;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_Pi_DIGIRESTO.View;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using DigiRestoProjet;

namespace DigiResto
{
    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// test
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);    
            var mainpage = new MainPage();
            
            Application.Run(mainpage);
            
        }
      
    }
}