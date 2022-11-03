using System.Data.Common;
using System.Threading;


namespace Simon_Project

{
    public partial class Form1 : Form
    {
        int score = 0; //defines variable 'score' as an integer and equal to 0
        Random rdm; //defines varaible 'rdm' as a randomly produed value
        bool start = false; //defines boolean variable 'start' as false
        List<int> list; //defines list 'ls' as an integer 
        int hs;

        public Form1()
        {
            rdm = new Random(); //produces a new random number
            list = new List<int>(); //produces a new list
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            lb_1.Text = "Score:" + score; //refereshs the score display to the current score
            if (score>hs)
            {
                hs = score; //sets the score as high score
                lb_2.Text = "High Score:" + hs; //display new high score
             
            }
            list.Add(rdm.Next(0, 4)); //adds a random number between 0-3 to the list 'ls'
            new Thread(Simon_Start).Start(); //starts Thread 'Simon_Start'
            score = 0;
        }

        void Simon_Start()
        {
           start = true; //defines boolean variable 'start' as true

            Thread.Sleep(200); //pauses the current Thread for 200 milliseconds

            foreach(int x in list) //for each number in the list
            {
                switch(x)
                {
                    case 0:
                        pb_0.Image = Properties.Resources.R2; //displays a different image in the picture box
                        Thread.Sleep(200);
                        pb_0.Image = Properties.Resources.R1; //displays the orginal image in the picture box 
                        break;  //terminates the iteration statement 
                        
                    case 1:
                        pb_1.Image = Properties.Resources.Y1;
                        Thread.Sleep(200);
                        pb_1.Image = Properties.Resources.Y2;
                        break;

                    case 2:
                        pb_2.Image = Properties.Resources.G2;
                        Thread.Sleep(200);
                        pb_2.Image = Properties.Resources.G1;
                        break;
                    
                    case 3:
                        pb_3.Image = Properties.Resources.B1;
                        Thread.Sleep(200);
                        pb_3.Image = Properties.Resources.B2;
                        break;


                }
                Thread.Sleep(200);
            }


            start = false;



        }
        
        

        private void pb_0_MouseDown(object sender, MouseEventArgs e) //when the mouse key is pressed the image changes
        {
            pb_0.Image = Properties.Resources.R2;   

        }

        private void pb_0_MouseUp(object sender, MouseEventArgs e) //when the mouse key is released the image changes
        {
            pb_0.Image = Properties.Resources.R1;

        }

        private void pb_1_MouseDown(object sender, MouseEventArgs e)
        {
            pb_1.Image = Properties.Resources.Y1;
        }

        private void pb_1_MouseUp(object sender, MouseEventArgs e)
        {
            pb_1.Image = Properties.Resources.Y2;
        }

        private void pb_2_MouseDown(object sender, MouseEventArgs e)
        {
            pb_2.Image = Properties.Resources.G2;
        }

        private void pb_2_MouseUp(object sender, MouseEventArgs e)
        {
            pb_2.Image = Properties.Resources.G1;
        }

        private void pb_3_MouseDown(object sender, MouseEventArgs e)
        {
            pb_3.Image = Properties.Resources.B1;
        }

        private void pb_3_MouseUp(object sender, MouseEventArgs e)
        {
            pb_3.Image = Properties.Resources.B2;
        }

        void verify_Sequence(int btn_pressed) //defines parameter btn_pressed as an integer 
        {
            if (start == false && list.Count > 0) //if start is equal to false and the number of items in the the list is more than 0
            {
                if (score >= list.Count) //if the score is higher or equal to than the number of items in the list
                {
                    MessageBox.Show("Game Over :( You entered too many sequences! ");
                    score = 0; //resets score
                    list.Clear(); //clears the list

                }
                else
                    if (btn_pressed == list[score])  //
                    score++; //increase score by one 
                else
                {
                    MessageBox.Show("Game Over:( Try again!");
                    score = 0;
                    list.Clear();
                }


            }
        }
        private void pb_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            verify_Sequence(int.Parse(pb.Name.ToString().Split('_')[1])); //seperates each number in the substring with an underscore and retrives the last number of the string
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hs = Properties.Settings.Default.High_Score; //sets variable hs as variable High_Score which is saved in settings
            lb_2.Text = "High Score:" + hs; //displays high score
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            hs = int.Parse(lb_2.Text.ToString().Split(':')[1]); //seperates each number in the substring with an colon and retrives the last number of the string
            Properties.Settings.Default.High_Score = hs; //assigns value in settings 

            Properties.Settings.Default.Save(); //saves value in settings
        }
    }
}       