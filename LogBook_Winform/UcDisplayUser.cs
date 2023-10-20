using Guna.UI2.WinForms;
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
    public partial class UcDisplayUser : UserControl
    {

        public int ID { get => Convert.ToInt32(lblUserID.Text); set { lblUserID.Text = value.ToString(); } }
        public Image UserImage { get => pbUserPicture.Image; set { pbUserPicture.Image = value; } }
        public string FullName { get => lblFullname.Text; set { lblFullname.Text = value; } }
        public DateTime LastSeen { get => Convert.ToDateTime(lblLastSeen.Text); set { lblLastSeen.Text = value.ToString("dd/MM/yyyy"); } }
        public bool IsTakePart { get => rbGreen.Checked; set { rbGreen.Checked = value; } }
        public bool IsLater { get => rbYellow.Checked; set { rbYellow.Checked = value; } }
        public bool IsAbsent { get => rbRed.Checked; set { rbRed.Checked = value; } }
        public bool IsOnline { get => cbOnline.Checked; set { cbOnline.Checked = value; } }
        public int TestScore { get => Convert.ToInt32(cmbTestScore.SelectedItem.ToString()); set { cmbTestScore.SelectedIndex = cmbTestScore.FindString(value.ToString()); } }
        public int ClassScore { get => Convert.ToInt32(cmbClassScore.SelectedItem.ToString()); set { cmbClassScore.SelectedIndex = cmbClassScore.FindString(value.ToString()); } }

        public int DiamondCount { get; set; }

        public EventHandler<EventArgs>DiamondHandlerDecrease { get; set; }
        public EventHandler<EventArgs> DiamondHandlerIncrease { get; set; }

        public bool isCheckedDiamond
        {
            get
            {
                if (DiamondCount == 1) return cbDiamond1.Checked && !cbDiamond2.Checked && !cbDiamond3.Checked;
                else if (DiamondCount == 2) return cbDiamond1.Checked && cbDiamond2.Checked && !cbDiamond3.Checked;
                return cbDiamond1.Checked && cbDiamond2.Checked && cbDiamond3.Checked;
            }
            set {; }
        }

        public string Comment { get => txtComment.Text; set { txtComment.Text = value; } }


        private List<Guna2ImageCheckBox> diamondCheckboxes;
        public UcDisplayUser()
        {
            InitializeComponent();
            diamondCheckboxes = new List<Guna2ImageCheckBox> { cbDiamond1, cbDiamond2, cbDiamond3 };
            DiamondCheckedManage(diamondCheckboxes);
        }




        private void DiamondCheckedManage(List<Guna2ImageCheckBox> cbs)
        {

           
            for (int i = 0; i < diamondCheckboxes.Count; i++)
            {
                int index = i; 
                diamondCheckboxes[i].CheckedChanged += (s, e) =>
                {
                    if (diamondCheckboxes[index].Checked)
                    {
                       
                        for (int j = 0; j < index; j++)
                        {
                            diamondCheckboxes[j].Checked = true;
                        }
                    }
                    else
                    {
                        
                        for (int j = diamondCheckboxes.Count - 1; j > index; j--)
                        {
                            diamondCheckboxes[j].Checked = false;
                        }
                    }
                };
            }
        }

        private void cbDiamond1_CheckedChanged(object sender, EventArgs e)
        {
            var diamond = (Guna2ImageCheckBox)sender;
            if(diamond.Checked ) { DiamondHandlerDecrease.Invoke(sender, e); }
            else { DiamondHandlerIncrease.Invoke(sender, e); }
            
        }

        private void cbDiamond2_CheckedChanged(object sender, EventArgs e)
        {
            var diamond = (Guna2ImageCheckBox)sender;
            if (diamond.Checked) { DiamondHandlerDecrease.Invoke(sender, e); }
            else { DiamondHandlerIncrease.Invoke(sender, e); }
        }

        private void cbDiamond3_CheckedChanged(object sender, EventArgs e)
        {
            var diamond = (Guna2ImageCheckBox)sender;
            if (diamond.Checked) { DiamondHandlerDecrease.Invoke(sender, e); }
            else { DiamondHandlerIncrease.Invoke(sender, e); }
        }
    }
}
