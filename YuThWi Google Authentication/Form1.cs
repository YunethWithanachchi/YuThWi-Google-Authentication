using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuThWi_Google_Authentication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] scopes = { "email", "profile" };
                var credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    new ClientSecrets
                    {
                        ClientId = "Your client id",
                        ClientSecret = "Your client secret"
                    },
                    scopes,
                    "user",
                    CancellationToken.None,
                    //new FileDataStore("GoogleLoginDemoToken", false)
                    new FileDataStore(Guid.NewGuid().ToString(), false)

                    );
                MessageBox.Show("Login Successful!");
                ProfileData profile = new ProfileData(credential.Token.AccessToken);
                profile.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
