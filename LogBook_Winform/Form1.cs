using Guna.UI2.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogBook_Winform
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>
        {
            new User{Fullname="Anvar Mammadov Azer",LastSeen=new DateTime(2023,10,15)},
            new User{Fullname="Murad Gojayev Elbrus",LastSeen=new DateTime(2023,10,15)},
            new User{Fullname="Nazrin Hajiyeva Terlan",LastSeen=new DateTime(2023,10,15)},
            new User{Fullname="Ali Gurbanov Semed",LastSeen=new DateTime(2023,10,15)},
            new User{Fullname="Fuad Nurlanov Nurlan",LastSeen=new DateTime(2023,10,15)},
        };
        public EventHandler<EventArgs> DiamondHandlerDecrease { get; set; }
        public EventHandler<EventArgs> DiamondHandlerIncrease { get; set; }


        private List<CheckBox> diamondCheckboxes;
        public int maxCheckedCount { get; set; } = 5;


        

        public void DiamondDecrease(object sender,EventArgs e)
        {
            if(maxCheckedCount > 0)
            {
                maxCheckedCount--;
                lblAllDiamondCount.Text = maxCheckedCount.ToString();
            }
            
        }

        public void DiamondIncrease(object sender,EventArgs e)
        {
            if (maxCheckedCount < 5)
            {
                maxCheckedCount++;
                lblAllDiamondCount.Text = maxCheckedCount.ToString();
            }
            
        }
        public Form1()
        {
            
            InitializeComponent();
            lblAllDiamondCount.Text = maxCheckedCount.ToString();
            DiamondHandlerDecrease += DiamondDecrease;
            DiamondHandlerIncrease += DiamondIncrease;  
           
            int y = this.panelUserDisplay.Location.Y;
            int id = 0;
           foreach (User user in users)
            {
                UcDisplayUser ucDisplayUser = new UcDisplayUser();
                ucDisplayUser.ID = ++id;
                ucDisplayUser.DiamondHandlerDecrease = DiamondHandlerDecrease;
                ucDisplayUser.DiamondHandlerIncrease = DiamondHandlerIncrease;
                ucDisplayUser.FullName = user.Fullname;
                ucDisplayUser.LastSeen = user.LastSeen;
                ucDisplayUser.Location = new System.Drawing.Point(ucDisplayUser.Location.X, y);
                this.panelUserDisplay.Controls.Add(ucDisplayUser);
                y += ucDisplayUser.Height;
            }

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelScrollHelper panelScroll = new PanelScrollHelper(panelUserDisplay, scrollPanelUserDisplay, true);
        }
    }
}
