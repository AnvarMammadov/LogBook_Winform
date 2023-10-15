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

        public int ID { get=>Convert.ToInt32(lblUserID.Text); set {lblUserID.Text=value.ToString(); } }
        public Image UserImage { get=>pbUserPicture.Image; set {pbUserPicture.Image=value; } }
        public string FullName { get=>lblFullname.Text ; set { lblFullname.Text = value; } }
        public DateTime LastSeen { get=>Convert.ToDateTime(lblLastSeen.Text); set {lblLastSeen.Text=value.ToString("dd/MM/yyyy"); } }
        public bool IsTakePart { get=>rbGreen.Checked; set {rbGreen.Checked=value; } }
        public bool IsLater { get=>rbYellow.Checked; set {rbYellow.Checked=value; } }
        public bool IsAbsent { get=>rbRed.Checked; set {rbRed.Checked=value; } }
        public bool IsOnline { get=>cbOnline.Checked; set {cbOnline.Checked=value; } }
        public int TestScore { get=>Convert.ToInt32(cmbTestScore.SelectedItem.ToString()); set{cmbTestScore.SelectedIndex=cmbTestScore.FindString(value.ToString());} }
        public int ClassScore { get=>Convert.ToInt32(cmbClassScore.SelectedItem.ToString()); set{ cmbClassScore.SelectedIndex= cmbClassScore.FindString(value.ToString());} }

        public int DiamondCount { get; set; }

        public bool isCheckedDiamond{ get { if (DiamondCount == 1) return cbDiamond1.Checked && !cbDiamond2.Checked && !cbDiamond3.Checked;
            else if(DiamondCount == 2) return cbDiamond1.Checked && cbDiamond2.Checked && !cbDiamond3.Checked;
                return cbDiamond1.Checked && cbDiamond2.Checked && cbDiamond3.Checked; 
            }
            set { ; } }

        public string Comment { get=> txtComment.Text; set {txtComment.Text=value; } }


        public UcDisplayUser()
        {
            InitializeComponent();
        }

      
    }
}
