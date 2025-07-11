using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuThWi_Google_Authentication
{
    public partial class ProfileData : Form
    {
        string token;
        public ProfileData( string token)
        {
            InitializeComponent();
            this.token = token;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lbllD_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private async void ProfileDataLoad(object sender, EventArgs e)
        {
            await loadUserData();
        }
        private async Task loadUserData()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                    var result = await client.GetStringAsync("https://www.googleapis.com/oauth2/v2/userinfo");

                    var userInfo = JObject.Parse(result);

                    string name = userInfo["name"]?.ToString();
                    string id = userInfo["id"]?.ToString();
                    string email = userInfo["email"]?.ToString();
                    string picture = userInfo["picture"]?.ToString();

                    lblName.Text = name;
                    lbllD.Text = id;
                    lblEmail.Text = email;
                    pictureBox1.Load(picture);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Failed to load user infor : "+ex.Message);
            }
        }
    }
}
