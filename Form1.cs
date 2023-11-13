using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;

namespace Tray_Launcher {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

        } // end Form1

        private void exitClickHandler(object sender, EventArgs e) {
            Application.Exit();

        } // end exitClickHandler

        private string dnsLookup(string locationNumber) {
            IPHostEntry ipHostEntry = Dns.GetHostEntry(locationNumber.TrimStart('0') + ".example.com");
            IPAddress ipAddress = ipHostEntry.AddressList[0];
            string[] octets = ipAddress.ToString().Split('.');
            return octets[0] + "." + octets[1] + "." + octets[2] + ".";

        }

        private string findViClient() {
            string viClient = "VpxClient.exe";

            try {
                RegistryKey rvsphere = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\VMware, Inc.\VMware Virtual Infrastructure Client");
                if (rvsphere != null && (rvsphere.GetValue("LauncherPath") != null && (File.Exists(rvsphere.GetValue("LauncherPath").ToString() + viClient)))) {
                    return rvsphere.GetValue("LauncherPath").ToString() + viClient;
                
                }
            } catch(Exception e) {

            }

            string ofsPath = @"C:\vSphereClient_4.X_5.X\VMware vSphere Client.exe";

            if (File.Exists(ofsPath)) {
                return ofsPath;
            }

            return viClient;

        }

        private void virtualCenter_Click(object sender, EventArgs e) {
            string locationNum = locationNumber.Text;
            string ipAddress = dnsLookup(locationNum) + "185";

            ProcessStartInfo psParameters = new ProcessStartInfo();
            psParameters.FileName = findViClient();
            psParameters.Arguments = "--server " + ipAddress + "--user root --password passw0rd";

            Process pVSphere = new Process();
            pVSphere.StartInfo = psParameters;

            try {
                pVSphere.Start();

            } catch (Exception ex) {
                MessageBox.Show("Please install VMware vSphere Client", "Error");

            }

        }

        private void focusHandler(object sender, EventArgs e) {
            locationNumber.SelectAll();
            locationNumber.Focus();

        }

        /// <summary>
        /// Handles click events for the CMM context menu item
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="e">Event parameters</param>
        private void cmm_Click(object sender, EventArgs e) {
            string locationNum = locationNumber.Text;
            string ipAddress = dnsLookup(locationNum) + "187";

            ProcessStartInfo psParameters = new ProcessStartInfo();

            Process pBrowser = new Process();
            pBrowser.StartInfo.FileName = "https://example.com/LocationLauncher/?ip=" + ipAddress;

            try {
                pBrowser.Start();
            } catch (Exception ex) {
                MessageBox.Show("Please install a web browser", "Error");

            }

        }

    } // end Form1 class


} // end namespace
