using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mouse
{
    public partial class canvas : Form
    {
        Mouse mouse = new Mouse();
        Wormhole wormhole = new Wormhole();
        List<Button> buttons = new List<Button>();
        bool[] cheeseOn = new bool[37];
        bool[] buttonsCheck = new bool[37];
        public canvas()
        {
            InitializeComponent();
            Error_Testing();
            iniGame();
            new Settings();
            StartGame();
        }

        private void Error_Testing()
        {
            try
            {

                    Bitmap p1 = new Bitmap(@"Resources\worm.png");
                   Bitmap p2 = new Bitmap(@"Resources\cheese.png");
                   Bitmap p3 = new Bitmap(@"Resources\mouse.png");
            }
            catch
            {
                MessageBox.Show("An error has occurred ! Reinstalling the program may fix this problem !");
                Environment.Exit(0);
            }
        }

        private void iniGame()
        {
            buttons.Add(button1);
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);
            buttons.Add(button10);
            buttons.Add(button11);
            buttons.Add(button12);
            buttons.Add(button13);
            buttons.Add(button14);
            buttons.Add(button15);
            buttons.Add(button16);
            buttons.Add(button17);
            buttons.Add(button18);
            buttons.Add(button19);
            buttons.Add(button20);
            buttons.Add(button21);
            buttons.Add(button22);
            buttons.Add(button23);
            buttons.Add(button24);
            buttons.Add(button25);
            buttons.Add(button26);
            buttons.Add(button27);
            buttons.Add(button28);
            buttons.Add(button29);
            buttons.Add(button30);
            buttons.Add(button31);
            buttons.Add(button32);
            buttons.Add(button33);
            buttons.Add(button34);
            buttons.Add(button35);
            buttons.Add(button36);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Gameover = true;
            StartGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("      This is Mouse" + '\n' + '\n' + "               Made By Slevy");
        }


        private void StartGame()
        {
            if (Settings.Gameover)
            {
                new Settings();
                mouse.butttonOn = 1;
            }
            else
            {
                if (Settings.Score >= 150)
                    Settings.Nr_Cheese = 10;
                if (Settings.Score >= 1000)
                {
                    Settings.Nr_Cheese = 15;
                    Settings.FoodScore = 20;
                }
                if(Settings.Nr_Cheese >= 3000)
                {
                    Settings.Nr_Cheese = 20;
                    Settings.FoodScore = 50;
                }
            }
            for (int i = 1; i <= 36; i++)
            {
                cheeseOn[i] = false;
                buttonsCheck[i] = false;
            }
            doButtons();
                randomCheese();
                randomWormhole();
            //

                this.Refresh();
        }

        private void doButtons()
        {
            button1.BackColor = System.Drawing.Color.Cornsilk;
            button2.BackColor = System.Drawing.Color.Cornsilk;
            button3.BackColor = System.Drawing.Color.Cornsilk;
            button4.BackColor = System.Drawing.Color.Cornsilk;
            button5.BackColor = System.Drawing.Color.Cornsilk;
            button6.BackColor = System.Drawing.Color.Cornsilk;
            button7.BackColor = System.Drawing.Color.Cornsilk;
            button8.BackColor = System.Drawing.Color.Cornsilk;
            button9.BackColor = System.Drawing.Color.Cornsilk;
            button10.BackColor = System.Drawing.Color.Cornsilk;
            button11.BackColor = System.Drawing.Color.Cornsilk;
            button12.BackColor = System.Drawing.Color.Cornsilk;
            button13.BackColor = System.Drawing.Color.Cornsilk;
            button14.BackColor = System.Drawing.Color.Cornsilk;
            button15.BackColor = System.Drawing.Color.Cornsilk;
            button16.BackColor = System.Drawing.Color.Cornsilk;
            button17.BackColor = System.Drawing.Color.Cornsilk;
            button18.BackColor = System.Drawing.Color.Cornsilk;
            button19.BackColor = System.Drawing.Color.Cornsilk;
            button20.BackColor = System.Drawing.Color.Cornsilk;
            button21.BackColor = System.Drawing.Color.Cornsilk;
            button22.BackColor = System.Drawing.Color.Cornsilk;
            button23.BackColor = System.Drawing.Color.Cornsilk;
            button24.BackColor = System.Drawing.Color.Cornsilk;
            button25.BackColor = System.Drawing.Color.Cornsilk;
            button26.BackColor = System.Drawing.Color.Cornsilk;
            button27.BackColor = System.Drawing.Color.Cornsilk;
            button28.BackColor = System.Drawing.Color.Cornsilk;
            button29.BackColor = System.Drawing.Color.Cornsilk;
            button30.BackColor = System.Drawing.Color.Cornsilk;
            button31.BackColor = System.Drawing.Color.Cornsilk;
            button32.BackColor = System.Drawing.Color.Cornsilk;
            button33.BackColor = System.Drawing.Color.Cornsilk;
            button34.BackColor = System.Drawing.Color.Cornsilk;
            button35.BackColor = System.Drawing.Color.Cornsilk;
            button36.BackColor = System.Drawing.Color.Cornsilk;
        }

        private void randomWormhole()
        {
            Random r = new Random();
            int x;
            x = r.Next(2, 35);
            while ((cheeseOn[x]) || (x == mouse.butttonOn))
                x = r.Next(2, 35);
            wormhole.buttonOn = x;
        }

        private void randomCheese()
        {
            Random r = new Random();
            int x;
            for (int i = 1; i <= Settings.Nr_Cheese; i++)
            {
                x= r.Next(2, 35);
                while ((cheeseOn[x]) || (x == mouse.butttonOn))
                    x = r.Next(2, 36);
                cheeseOn[x] = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        // GAME DESIGN 

        private void _Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if(wormhole.buttonOn == 1)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"),Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
               
                if(cheeseOn[1])
                canvas.DrawImage(new Bitmap(@"Resources\cheese.png"),Settings.pozX,Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 1)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint2(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 2)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                
                if (cheeseOn[2])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 2)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint3(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 3)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
               
                if (cheeseOn[3])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 3)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint4(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 4)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
               
                if (cheeseOn[4])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 4)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint5(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 5)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
               
                if (cheeseOn[5])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 5)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint6(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 6)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
               
                if (cheeseOn[6])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 6)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint7(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 7)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
               
                if (cheeseOn[7])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 7)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint8(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 8)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
              
                if (cheeseOn[8])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 8)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint9(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 9)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
              
                if (cheeseOn[9])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 9)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint10(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 10)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
               
                if (cheeseOn[10])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 10)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint11(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 11)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
              
                if (cheeseOn[11])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 11)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint12(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 12)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                
                if (cheeseOn[12])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 12)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint13(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 13)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
               
                if (cheeseOn[13])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 13)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint14(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 14)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
               
                if (cheeseOn[14])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 14)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint15(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 15)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
               
                if (cheeseOn[15])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 15)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint16(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 16)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
               
                if (cheeseOn[16])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 16)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint17(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 17)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
               
                if (cheeseOn[17])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 17)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint18(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 18)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
              
                if (cheeseOn[18])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 18)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint19(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 19)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
               
                if (cheeseOn[19])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 19)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint20(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 20)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                
                if (cheeseOn[20])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 20)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint21(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 21)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
               
                if (cheeseOn[21])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 21)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint22(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 22)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
               
                if (cheeseOn[22])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 22)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint23(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 23)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
              
                if (cheeseOn[23])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 23)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint24(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 24)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
              
                if (cheeseOn[24])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 24)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint25(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 25)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                
                if (cheeseOn[25])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 25)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint26(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 26)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
               
                if (cheeseOn[26])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 26)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint27(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 27)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
              
                if (cheeseOn[27])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 27)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint28(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 28)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
               
                if (cheeseOn[28])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 28)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint29(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 29)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                
                if (cheeseOn[29])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 29)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint30(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 30)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
               
                if (cheeseOn[30])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 30)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint31(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 31)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
               
                if (cheeseOn[31])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 31)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint32(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 32)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
              
                if (cheeseOn[32])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 32)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint33(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 33)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
               
                if (cheeseOn[33])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 33)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint34(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 34)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (cheeseOn[34])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 34)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Paint35(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 35)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (cheeseOn[35])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 35)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void _Pain36(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            try
            {
                if (wormhole.buttonOn == 36)
                    canvas.DrawImage(new Bitmap(@"Resources\worm.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (cheeseOn[36])
                    canvas.DrawImage(new Bitmap(@"Resources\cheese.png"), Settings.pozX, Settings.pozY, Settings.Width, Settings.Height);
                if (mouse.butttonOn == 36)
                    canvas.DrawImage(new Bitmap(@"Resources\mouse.png"), mouse.pozX, mouse.pozY, Settings.Width, Settings.Height);
            }
            catch
            {
                Application.Exit();
            }
        }

        void AllInvalidate()
        {
            this.Refresh();
        }

        bool checkS(int x)
        {
            for (int i = 7; i <= 36; i += 6)
                if (x == i)
                    return false;
            return true;
        }
        
        bool checkD(int x)
        {
            for (int i = 6; i <= 36; i += 6)
                if (x == i)
                    return false;
            return true;
        }

        private void ColorBlock(int x)
        {
            buttons[x].BackColor = System.Drawing.Color.Crimson;
        }

        private bool ButtonBlocked(int x)
        { return buttonsCheck[x]; }

        private void canvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Settings.Gameover)
            {
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                {
                    if ((mouse.butttonOn + 6 >= 1) && (mouse.butttonOn + 6 <= 36))
                    {
                        if (!ButtonBlocked(mouse.butttonOn + 6))
                        {
                            ColorBlock(mouse.butttonOn);
                            buttonsCheck[mouse.butttonOn] = true;
                            mouse.butttonOn += 6;
                            AllInvalidate();
                        }
                    }
                }

                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                {
                    if ((mouse.butttonOn - 6 >= 1) && (mouse.butttonOn - 6 <= 36)) 
                    {
                        if (!ButtonBlocked(mouse.butttonOn - 6))
                        {
                            ColorBlock(mouse.butttonOn);
                            buttonsCheck[mouse.butttonOn] = true;
                            mouse.butttonOn -= 6;
                            AllInvalidate();
                        }
                    }
                }

                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                {
                    if (checkS(mouse.butttonOn))
                    {
                        if ((mouse.butttonOn - 1 >= 1) && (mouse.butttonOn - 1 <= 36)  && (!ButtonBlocked(mouse.butttonOn)))
                        {

                            if (!ButtonBlocked(mouse.butttonOn - 1))
                            {
                                ColorBlock(mouse.butttonOn);
                                buttonsCheck[mouse.butttonOn] = true;
                                mouse.butttonOn -= 1;
                                AllInvalidate();
                            }
                        }
                    }
                }

                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                {
                    if (checkD(mouse.butttonOn))
                    {
                        if ((mouse.butttonOn + 1 >= 1) && (mouse.butttonOn + 1 <= 36)  && (!ButtonBlocked(mouse.butttonOn)))
                        {

                            if (!ButtonBlocked(mouse.butttonOn + 1))
                            {
                                ColorBlock(mouse.butttonOn);
                                buttonsCheck[mouse.butttonOn] = true;
                                mouse.butttonOn +=1;
                                AllInvalidate();
                            }
                        }
                    }
                }
                int x = mouse.butttonOn;
                    if(cheeseOn[x])
                    {
                        cheeseOn[x] = false;
                        Settings.Score += Settings.FoodScore;
                        buttons[x].Refresh();
                    }
                if(wormhole.buttonOn == mouse.butttonOn)
                {
                    int y = wormhole.buttonOn;
                    wormhole.buttonOn = 0;
                    buttons[y].Refresh();
                    StartGame();
                }
                else
                    if (Gameover(x))
                    {
                        Settings.Gameover = true;
                        Lose lose = new Lose(Settings.Score);
                        lose.ShowDialog();
                        StartGame();
                    }
            }
        }
            //
          

        private bool Gameover(int x)
        {
            if (x == 1)
            {
                if (buttonsCheck[2] && buttonsCheck[7])
                    return true;
            }
            else
                if (x == 6)
                {
                    if (buttonsCheck[5] && buttonsCheck[12])
                        return true;
                }
                else
                    if (x == 31)
                    {
                        if (buttonsCheck[32] && buttonsCheck[25])
                            return true;
                    }
                    else
                        if (x == 36)
                        {
                            if (buttonsCheck[35] && buttonsCheck[30])
                                return true;
                        }
                        else
                            if ((x >= 2) && (x <= 5))
                            {
                                if (buttonsCheck[x - 1] && buttonsCheck[x + 1] && buttonsCheck[x + 6])
                                    return true;
                            }
                            else
                                if ((x >= 31) && (x <= 35))
                                {
                                    if (buttonsCheck[x - 1] && buttonsCheck[x + 1] && buttonsCheck[x - 6])
                                        return true;
                                }
                                else
                                    if ((x % 6 == 0) && (x != 6) && (x != 36))
                                    {
                                        if (buttonsCheck[x - 6] && buttonsCheck[x - 1] && buttonsCheck[x + 6])
                                            return true;
                                    }
                                    else
                                        if ((x % 6 == 1) && (x != 31) && (x != 1))
                                        {
                                            if (buttonsCheck[x - 6] && buttonsCheck[x + 1] && buttonsCheck[x + 6])
                                                return true;
                                        }
                                        else
                                            if (buttonsCheck[x - 6] && buttonsCheck[x + 1] && buttonsCheck[x + 6] && buttonsCheck[x - 1])
                                       return true;
           return false;
        }
    }
}
