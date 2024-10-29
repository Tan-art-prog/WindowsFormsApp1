using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<string> KeeperPorsition = new List<string>() { "left", "right", "topcenter", "topleft", "topright" };
        List<PictureBox> goalTarget;
        int ballX = 0;
        int ballY = 0;
        int goal = 0;
        int miss = 0;
        string state;
        string playerTarget;
        bool aimSet = false;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            goalTarget = new List<PictureBox> { left, right, topcenter, topleft, topright };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SetGoalTargetEvent(object sender, EventArgs e)
        {
            if(aimSet == true) { return; }
            Balltimer.Start();
            Keepertimer.Start();
            ChangeGoalKeeperImage();
            var senderObject = (PictureBox)sender;
            senderObject.BackColor = Color.Beige;
            if(senderObject.Tag.ToString() == "topright")
            {
                ballX = -7;
                ballY = 15;
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;
            }
            if(senderObject.Tag.ToString() == "right")
            {
                ballX = -11;
                ballY = 15;
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;
            }
            if(senderObject.Tag.ToString() == "topcenter")
            {
                ballX = 0;
                ballY = 20;
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;
            }
            if(senderObject.Tag.ToString() == "topleft")
            {
                ballX = 8;
                ballY = 15;
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;
            }
            if (senderObject.Tag.ToString() == "left")
            {
                ballX = 7;
                ballY = 8;
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;
            }
            CheckScore();
        }

        private void KeeperTimerEvent(object sender, EventArgs e)
        {
            switch(state)
            {
                case "left":
                    goalKeeper.Left -= 6;
                    goalKeeper.Top = 204;
                    break;
                case "right":
                    goalKeeper.Left += 6;
                    goalKeeper.Top = 204;
                    break;
                case "topcenter":
                    goalKeeper.Top -= 6;
                    break;
                case "topleft":
                    goalKeeper.Left -= 6;
                    goalKeeper.Top -= 3;
                    break;
                case "topright":
                    goalKeeper.Left += 6;
                    goalKeeper.Top -= 3;
                    break;
            }
            foreach (PictureBox c in goalTarget)
            {
                if(goalKeeper.Bounds.Intersectswitch(x.Bounds))
            }    
        }
    }
}
