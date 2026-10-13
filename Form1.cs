    
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace EventApp  

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isValid = int.TryParse(txtinput.Text, out int numericalResult);
            if(isValid) {
                // Do something with the valid integer result
                MessageBox.Show($"You entered a valid integer: {numericalResult}");
            }
            else
        {
            // Handle the case where the input is not a valid integer
            MessageBox.Show("Please enter a valid integer.");
        }
    }

        private void txtinput_TextChanged(object sender, EventArgs e)
        {
            click.Enabled = !string.IsNullOrWhiteSpace(txtinput.Text);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            click.Enabled = false; // Disable the button initially
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
