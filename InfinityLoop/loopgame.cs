using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfinityLoop
{
    public partial class loopgame : Form
    {
        int[] rng = new int[15];
        int[] rngL = new int[15];
        int[] tagK = new int[15];
        int[] tagL = new int[15];
        int[] tagR = new int[15];
        int tempK = 0;
        int tempL = 0;
        int tempR = 0;
        


        public loopgame()
        {
            InitializeComponent();
            
            setup();
                     
        }

        async void checkforWinner()
        {
            
            if (tagR[0] == 1 && tagR[1] == 2 && tagR[2] == 1 && tagR[3] == 4 && tagR[4] == 3 &&
                tagK[0] == 2 && tagK[1] == 3 &&
                tagL[0] == 2 && tagL[1] == 1)
            {
                disableButtons();
                await Task.Delay(750);
                label2.Visible = true;
                await Task.Delay(190);
                label2.Visible = false;
                await Task.Delay(190);
                label2.Visible = true;
                await Task.Delay(190);
                label2.Visible = false;
                await Task.Delay(190);
                label2.Visible = true;



            }//end if
        }//end checkforWinner

        private void disableButtons()
        {
           var disableButtons = new[] { this.button1, this.button2, this.button3, this.button4, this.button5, this.button6, this.button7, this.button8, this.button9 };

            for (int i = 0; i < 9; i++)
            {
                disableButtons[i].Enabled = false;

            }//end for

        }//end disableButtons
           
        private void kClick(object sender, EventArgs e){
                       

            Button clickedButton = (Button)sender;
            
            if (clickedButton == button6)
            {
                tempK = tagK[0];
                clickedButton = button6;

            }//end if

            else if (clickedButton == button8)
            {
                tempK = tagK[1];
                clickedButton = button8;

            };//end else if

            switch (tempK)
            {
                case 1:
                    {
                        clickedButton.BackgroundImage = Properties.Resources.K2;
                        tempK++;
                        if (clickedButton == button6)
                        {
                            tagK[0]++;
                        }
                        else tagK[1]++;
                        break;
                    }
                case 2:
                    {
                        clickedButton.BackgroundImage = Properties.Resources.K3;
                        tempK++;
                        if (clickedButton == button6)
                        {
                            tagK[0]++;
                        }
                        else tagK[1]++;
                        break;
                    }
                case 3:
                    {
                        clickedButton.BackgroundImage = Properties.Resources.K4;
                        tempK++;
                        if (clickedButton == button6)
                        {
                            tagK[0]++;
                        }
                        else tagK[1]++;
                        break;
                    }
                case 4:
                    {
                        clickedButton.BackgroundImage = Properties.Resources.K1;
                        tempK = 1;
                        if (clickedButton == button6)
                        {
                            tagK[0] = 1;
                        }
                        else tagK[1] = 1;
                        break;
                    }

            }//end switch

            checkforWinner();

        }//tClick end

        private void lClick(object sender, EventArgs e){

            Button clickedButton = (Button)sender;

            if (clickedButton == button2)
            {
                tempL = tagL[0];
                clickedButton = button2;

            }//end if

            else if (clickedButton == button4)
            {
                tempL = tagL[1];
                clickedButton = button4;

            };//end else if

            switch (tempL)
            {
                case 1:
                    {
                        clickedButton.BackgroundImage = Properties.Resources.L2;
                        tempL++;
                        if (clickedButton == button2)
                        {
                            tagL[0]++;
                        }
                        else tagL[1]++;
                        break;
                    }
                case 2:
                    {
                        clickedButton.BackgroundImage = Properties.Resources.L1;
                        tempL++;
                        if (clickedButton == button2)
                        {
                            tagL[0] = 1;
                        }
                        else tagL[1] = 1;
                        break;
                    }
              

            }//end switch

            checkforWinner();

        }//lClick end

        private void rClick(object sender, EventArgs e){

            Button clickedButton = (Button)sender;
            var rButtons = new[] { this.button1, this.button3, this.button5, this.button7, this.button9 };


            for (int i = 0; i < 5; i++)
            {
                if (clickedButton == rButtons[i])
                {
                    tempR = tagR[i];
                    clickedButton = rButtons[i];

                }//end if 
            }//end for
                       

            switch (tempR)
            {
                case 1:
                    {
                        clickedButton.BackgroundImage = Properties.Resources.R2;
                        tempR++;
                        for (int i = 0; i < 5; i++)
                        {
                            if (clickedButton == rButtons[i])
                            {
                                tagR[i]++;
                            }//end if

                        }//end for
                        break;
                    }
                case 2:
                    {
                        clickedButton.BackgroundImage = Properties.Resources.R3;
                        tempR++;
                        for (int i = 0; i < 5; i++)
                        {
                            if (clickedButton == rButtons[i])
                            { 
                                tagR[i]++;
                            }//end if
                            
                        }//end for
                        break;
                    }
                case 3:
                    {
                        clickedButton.BackgroundImage = Properties.Resources.R4;
                        tempR++;
                        for (int i = 0; i < 5; i++)
                        {
                            if (clickedButton == rButtons[i])
                            {
                                tagR[i]++;
                            }//end if

                        }//end for
                        break;
                    }
                case 4:
                    {
                        clickedButton.BackgroundImage = Properties.Resources.R1;
                        tempR = 1;
                        for (int i = 0; i < 5; i++)
                        {
                            if (clickedButton == rButtons[i])
                            {
                                tagR[i] = 1;
                            }//end if

                        }//end for
                        break;
                    }

            }//end switch

            checkforWinner();

        }//rClick end
           
        private void button10_Click(object sender, EventArgs e){

            Close();

        }//button10 end

        private void setup()
        {

            var rButtons = new[] { this.button1, this.button3, this.button5, this.button7, this.button9 };
            var lButtons = new[] { this.button2, this.button4 };
            var kButtons = new[] { this.button6, this.button8 };
            rng = randomNumber(rng);    //rnd 1 to 4
            rngL = randomNumberL(rngL); //rnd 1 to 2
           
              for (int i = 0; i < 5; i++)
                {
            
                    switch (rng[i])
                    {
                        case 1:
                        {
                            rButtons[i].BackgroundImage = Properties.Resources.R1;
                            tagR[i] = 1;
                            break;
                        }
                        case 2:
                        {
                            rButtons[i].BackgroundImage = Properties.Resources.R2;
                            tagR[i] = 2;
                            break;
                        }
                        case 3:
                        {
                            rButtons[i].BackgroundImage = Properties.Resources.R3;
                            tagR[i] = 3;
                            break;
                        }
                        case 4:
                        {
                            rButtons[i].BackgroundImage = Properties.Resources.R4;
                            tagR[i] = 4;
                            break;
                        }

                    } //end switch 
        
                }//end for i

              for(int i = 0; i < 2; i++)
            {
               
                switch (rng[i+5])
                {
                    case 1:
                        {
                            kButtons[i].BackgroundImage = Properties.Resources.K1;
                            tagK[i] = 1;
                            break;
                        }
                    case 2:
                        {
                            kButtons[i].BackgroundImage = Properties.Resources.K2;
                            tagK[i] = 2;
                            break;
                        }
                    case 3:
                        {
                            kButtons[i].BackgroundImage = Properties.Resources.K3;
                            tagK[i] = 3;
                            break;
                        }
                    case 4:
                        {
                            kButtons[i].BackgroundImage = Properties.Resources.K4;
                            tagK[i] = 4;
                            break;
                        }

                } //end switch 
                switch (rngL[i])
                {
                    case 1:
                        {
                            lButtons[i].BackgroundImage = Properties.Resources.L1;
                            tagL[i] = 1;
                            break;
                        }
                    case 2:
                        {
                            lButtons[i].BackgroundImage = Properties.Resources.L2;
                            tagL[i] = 2;
                            break;
                        }

                }//end switch
            }//end for

           
        }//setup end

        static int[] randomNumber(int[] random)
        {


            Random rnd = new Random();

            for (int i = 0; i < 15; i++)
            {
                random[i] = rnd.Next(1, 5);

            }//for end

            return random;

        }//randomNumber end

        static int[] randomNumberL(int[] random)
        {


            Random rnd = new Random();

            for (int i = 0; i < 15; i++)
            {
                random[i] = rnd.Next(1, 3);

            }//for end

            return random;

        }//randomNumber end


    }//loopgame end

}//infinityloop end
