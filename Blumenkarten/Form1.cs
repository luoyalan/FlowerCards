using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blumenkarten
{
    public partial class Form1 : Form
    {
        public List<Control> pictures = new List<Control>();
        public List<Control> backsides = new List<Control>();
        private Point backsideoldlocation;
        private Control gonebackside;
        int visibleCardCount = 0;
        public Form1()
        {
            InitializeComponent();
            pictures.Add(b1);
            pictures.Add(b2);
            pictures.Add(b3);
            pictures.Add(b4);
            pictures.Add(b5);
            pictures.Add(b6);
            pictures.Add(b7);
            pictures.Add(b8);
            pictures.Add(b9);
            backsides.Add(backside1);
            backsides.Add(backside2);
            backsides.Add(backside3);
            backsides.Add(backside4);
            backsides.Add(backside5);
            backsides.Add(backside6);
            backsides.Add(backside7);
            backsides.Add(backside8);
            backsides.Add(backside9);

            for (int i = 0; i < pictures.Count; i++)
            {
             backsides[i].Click +=  backsideGoAway;
            }


        }
        private void cover_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pictures.Count; i++)
            {
                backsides[i].Location = pictures[i].Location;

            }

        }

        void backsideGoAway(object sender, EventArgs e)
        {
            visibleCardCount += 1;
            timer1.Stop();
            backsideGoback();
            timer1.Start();
            Control backside = (Control) sender;
            gonebackside = backside;
            backsideoldlocation = new Point(backside.Location.X, backside.Location.Y);
            backside.Location = new Point(603, 214);

        } 

        void backsideGoback()
        {  
            if ( gonebackside != null)
            {
                gonebackside.Location = backsideoldlocation;
            }

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
                backsideGoback();
                timer1.Stop();
        }
    }
}
