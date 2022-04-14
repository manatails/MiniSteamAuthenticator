using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SteamAuth;

namespace MiniSteamAuthenticator
{
    public partial class MainForm : Form
    {

        SteamGuardAccount account = new SteamGuardAccount();
        string currentCode = "";
        Timer generationTimer = new Timer();

        public MainForm()
        {
            InitializeComponent();

            IniFile MyIni = new IniFile("settings.ini");
            string sharedsecret = MyIni.Read("SharedSecret", "Account");
            if (sharedsecret != ""  && sharedsecret != "updateme")
            {
                account.SharedSecret = sharedsecret;
            }
            else
            {
                MyIni.Write("SharedSecret", "updateme", "Account");
                MessageBox.Show("Please update the shared secret in the settings file.");
                Environment.Exit(1);
            }

            try
            {
                // Convert the key to Base64 format as SteamAuth expects
                byte[] decodedsecret = Base32.FromBase32String(sharedsecret);
                String base64encoded = Convert.ToBase64String(decodedsecret);

                account.SharedSecret = base64encoded;
                currentCode = account.GenerateSteamGuardCode();
            }
            catch
            {
                MessageBox.Show("There was an error processing the shared secret.");
                Environment.Exit(1);
            }

            generationTimer.Interval = 1000;
            generationTimer.Tick += new EventHandler(generateCodes);
            generationTimer.Start();
        }

        private void generateCodes(object sender, EventArgs e)
        {
            currentCode = account.GenerateSteamGuardCode();

            long currentTime = TimeAligner.GetSteamTime();
            long remainingTime = currentTime % 30L;

            pbRemainingTime.Value = (int)remainingTime;

            lCurrentCode.Text = currentCode;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
