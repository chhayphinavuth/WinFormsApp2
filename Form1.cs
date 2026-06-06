namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            string str_name=TxtName.Text;
            string str_id = TxtID.Text;

            //Display
            MessageBox.Show 
                ("My Name is: " + str_name + "\n" + "My id is: " + str_id,
                "My Information",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Information );
        }
    }
}
