using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace StudentRegistratioFormFinalProject
{
    public partial class Form1 : Form



    {
        //variable for later in display
        int day, month, year;
        bool isMale;
        string firstName, middleName, lastName;
        
        
        // Variables and methods for making the borderless form movable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Form1()
        {

            InitializeComponent();

            //For Soft border style
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            setDefaultValue();
            dayContent();
            monthContent();
            yearContent();
        }

        
        //method for dragging the table
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //exit method
        private void exitButton(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }


        //method for features in the Windows Form
        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightCoral;
        }
        private void MouseLeaveButton(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }
    
        private void mClickFemale(object sender, MouseEventArgs e)
        {
            femaleButton.ForeColor = Color.Black;
        }

        private void mUnClickedFemale(object sender, EventArgs e)
        {
            femaleButton.ForeColor = Color.Gray;
        }

        private void mouseClickFemale(object sender, MouseEventArgs e)
        {
            maleButton.ForeColor = Color.Black;
        }

        private void mouseUncheckedMale(object sender, EventArgs e)
        {
            maleButton.ForeColor = Color.Gray;
        }
        private void Register_MouseHover(object sender, EventArgs e)
        {
            registerButton.BackColor = Color.LightSeaGreen;
        }

        private void registerButton_MouseLeave(object sender, EventArgs e)
        {
            registerButton.BackColor = Color.Transparent;
        }



        //series of mehod in getting data
        public void getData()
        {
            // getting the name
            firstName = FnameBox.Text;
            middleName = MnameBox.Text;
            lastName = LnameBox.Text;



            // getting date of birth
            day = Int32.Parse(comboBoxDay.Text);
            month = Int32.Parse(comboBoxMonth.Text);
            year = Int32.Parse(comboBoxYear.Text);

            // Throws an exception if either of them are not selected
            if (!maleButton.Checked && !femaleButton.Checked) throw new Exception();

            // set isMale to true when selected else false
            if (maleButton.Checked) isMale = true; else isMale = false;
        }


        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                getData();
                new Form2(outputForForm()).ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on field input!!  Please check again", "ERROR!!");
            }
            }

        

    public void setDefaultValue()
    {
        //content for day
        comboBoxDay.Items.Insert(0, "DAY");
        comboBoxDay.SelectedIndex = 0;

        //content for month
        comboBoxMonth.Items.Insert(0, "MONTH");
        comboBoxMonth.SelectedIndex = 0;

        //content for year
        comboBoxYear.Items.Insert(0, "YEAR");
        comboBoxYear.SelectedIndex = 0;
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }




        //Loop method for date
        public void dayContent()
    {
        for (int x = 1; x <= 31; x++) comboBoxDay.Items.Add(x);
    }

    
    public void monthContent()
    {
        for (int x = 1; x <= 12; x++) comboBoxMonth.Items.Add(x);
    }

    
    public void yearContent()
    {
        for (int x = 1930; x <= DateTime.Now.Year; x++) comboBoxYear.Items.Add(x);
    }



    
    public string outputForForm()
    {
            return string.Format(
                "Student name :  {0} {1} {2} \n" + "Gender: {3}\n" + "Date of Birth: {4}/{5}/{6} ",
                firstName, middleName, lastName, isMale ? "Male" : "Female", day, month, year);

    }


}
}
