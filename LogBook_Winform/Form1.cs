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
        public Form1()
        {
            
            InitializeComponent();

            int y = this.panelUserDisplay.Location.Y;
            int id = 0;
           foreach (User user in users)
            {
                UcDisplayUser ucDisplayUser = new UcDisplayUser();
                ucDisplayUser.ID = ++id;
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
