using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flare
{
    public partial class Flare : Form
    {
        private Random random = new Random();

        public Flare()
        {
            InitializeComponent();
        }

        private async void Flare_Load(object sender, EventArgs e)
        {
            await Task.Delay(random.Next(3, 5) * 1000);
            this.Hide();
            App app = new App();
            app.FormClosing += App_FormClosing;
            app.Show();
        }

        public void App_FormClosing(Object sender, FormClosingEventArgs args)
        {
            DialogResult ExitConfirmation = MessageBox.Show("Do you want to close the application?", "Flare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ExitConfirmation == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                args.Cancel = true;
            }
        }


    }
}
