﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KCSimlator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Game g = new Game();
            g.Start(this);
        }

        public void ReseveCommand(Command c)
        {

        }

        public void DrawBaseShips(object Ships)
        {

        }
    }
}
