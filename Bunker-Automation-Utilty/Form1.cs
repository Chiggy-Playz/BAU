using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Net;
using Nefarius.ViGEm.Client.Targets;
using Nefarius.ViGEm.Client.Targets.DualShock4;
using System.Runtime.ExceptionServices;
using System.Security;
using System.IO;
using System.ComponentModel;

namespace Bunker_Automation_Utilty
{



    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!CheckForInternetConnection())
            {
                MessageBox.Show("Please connect your device to the internet in order to start the application.");
                Close();
            }

            
          

           ds4 = vigem.CreateDualShock4Controller();
           FileName = updatePath + "Setup.exe";

            CUpdate();

        }

        
        #region The Imports

        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName,
    string lpWindowName);

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr SetFocus(HandleRef hWnd);

        [DllImport("user32.dll")]
        static extern bool AllowSetForegroundWindow(int dwProcessId);

        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern bool ShowWindow(IntPtr handle, int nCmdShow);

        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern bool IsIconic(IntPtr handle);
        #endregion

        #region The Variables       

        const int SW_RESTORE = 9;
        int NumberOfMin = 1;
        int NumberOfRP = 1;
        int s = 0,m;
        int rs;
        int RemotePlayId;
        Process RemotePlayProcess = new Process();
        System.Timers.Timer timer = new System.Timers.Timer();
        Thread thr;
        Thread Mytimer;
        Nefarius.ViGEm.Client.ViGEmClient vigem = new Nefarius.ViGEm.Client.ViGEmClient();
        IDualShock4Controller ds4;
        Thread update;
        string appPath = (Application.StartupPath);
        //Form DownloadProgres = new Form();
        Form2 form2 = new Form2();
        string updatePath = (Application.StartupPath + "/Updates/");
        string FileName;

        #endregion

        #region useful functions

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            form2.setProgress(0);
            form2.Close();
            MessageBox.Show("The program will quit now and The setup of newer version will be launched. Please follow the on screen instructions to install the newr version");


            Application.Exit();
            Process.Start(FileName);

           
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            form2.setProgress(e.ProgressPercentage);

        }

        public static void BringProcessToFront(Process process)
        {
            IntPtr handle = process.MainWindowHandle;
            if (IsIconic(handle))
            {
                ShowWindow(handle, SW_RESTORE);
            }

            SetForegroundWindow(handle);
        }
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {

            ds4.Disconnect();
            thr.Abort();
            Mytimer.Abort();
            update.Abort();

        }

        public static void sleep(int s)
        {

            Thread.Sleep(s);

        }
        void FindRP()
        {
            Process[] pname = Process.GetProcessesByName("RemotePlay");
            if (pname.Length == 0)
            {

                MessageBox.Show("PS4 Remote Play is not running. Please start it and run the application again. The application will now quit.");
                Close();
            }
            else
            {

                RemotePlayProcess = pname[0];
                RemotePlayId = RemotePlayProcess.Id;
            }
        }

        public void printNOM()
        {
            MessageBox.Show("" + NumberOfMin);

        }

        public void printNumberOfRP()
        {
            MessageBox.Show("" + NumberOfRP);
        }

        void OnTimedEvent(object source, System.Timers.ElapsedEventArgs e)
        {

            Invoke(new Action(() =>
            {
                if (rs > 0)
                {
                    if (m == 0 && s < 0 /*&& rs == NumberOfRP-1*/)
                    {

                        rs -= 1;

                        m = 150;
                        s = 0;
                    }
                }


                if (s == 0 && m != 0)
                {
                    s = 59;
                    if (m > 0) {
                                                
                        m -= 1; 
                    }
                }
                
                label2.Text = string.Format("{0}:{01}", m.ToString(), s.ToString());
                s -= 1;
            }));
            
        }

        #endregion

        #region useless functions

        #endregion

        #region Controls
        private void Choose_Min_ValueChanged(object sender, EventArgs e)
        {

            NumberOfMin = Convert.ToInt32(Math.Round(Choose_Min.Value, 0));
        }

      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void ChooseResupply_ValueChanged(object sender, EventArgs e)
        {
           // int NORS = Convert.ToInt32(Math.Round(ChooseResupply.Value, 0));
              NumberOfRP= Convert.ToInt32(Math.Round(ChooseResupply.Value, 0));
        }


      

        private void TextBox1_TextChanged(object sender, EventArgs e) { }


        private void Label3_Click(object sender, EventArgs e) { }

        private void MyTimer_Tick(object sender, EventArgs e)
        {


        }
        private void Timer1_Tick(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form helpF = new Form();
            helpF.Text = "Help";
            helpF.MaximizeBox = false;
            LinkLabel link = new LinkLabel();
            link.Text = "google.com";
           
            helpF.Controls.Add(link);
            helpF.ShowDialog();

        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        


        private void Button1_Click(object sender, EventArgs e)
        {
            thr = new Thread(new ThreadStart(startTimer));
            Mytimer = new Thread(new ThreadStart(clock)); 
            

            label2.Text = "";
            label1.Visible = true;
            label2.Visible = true;
            button1.Enabled = false;
            ChooseResupply.Enabled = false;
            Choose_Min.Enabled = false;
            
            thr.IsBackground = true;
            
          


            thr.Start();
            Mytimer.Start();
           
        }

        public void CUpdate() {
            try
            {
                WebClient client = new WebClient();         
                string ver = client.DownloadString("https://pastebin.com/raw/Qxa6F7rh");                  
                string File = client.DownloadString("https://pastebin.com/raw/s4p0Z3yJ");
                
                //    MessageBox.Show(ver + "\n" + updatePath + "\n" + File); this is to debug
                
                if (!System.IO.Directory.Exists(updatePath))
                {

                    System.IO.Directory.CreateDirectory(updatePath);

                }

                if (System.IO.File.Exists(FileName))
                {

                    System.IO.File.Delete(FileName);

                }
            
            
            if (ver != "1.3.0")
            {

                if (MessageBox.Show("Looks Like an update is avaiable. Do you want to download it?", "Update found", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                       

                        client.DownloadProgressChanged += client_DownloadProgressChanged;
                        client.DownloadFileCompleted += client_DownloadFileCompleted;

                        form2.Show();


                        client.DownloadFileAsync(new Uri(File), FileName);
                        button1.Enabled = false;

                }
                

            }
                else { MessageBox.Show("You are on latest version."); }
            }
            catch(Exception Ex)
        {
            MessageBox.Show(Ex.ToString());

        }

        }

        

        void clock() {

            m = NumberOfMin;
            rs = NumberOfRP;
            
            timer.Interval = 1000;
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
          
            
        }


        [HandleProcessCorruptedStateExceptions, SecurityCritical]

        private void startTimer()
        {




            FindRP();


            ds4.AutoSubmitReport = true;
            
            ds4.Connect();

         
            


            BringProcessToFront(RemotePlayProcess);
            Thread.Sleep(2000);

            AFK(ds4, NumberOfMin);
            SecuroServ_Activation(ds4);
            sleep(2000);
            Buying(ds4);
            sleep(2000);
            SecuroServ_Deactivation(ds4);
            sleep(2000);
            AFK(ds4, 10);
           
            for (int I = 1; I < NumberOfRP; I++)
            {
                
                AFK(ds4, 140);
                SecuroServ_Activation(ds4);
                sleep(2000);
                Buying(ds4);
                sleep(2000);
                SecuroServ_Deactivation(ds4);
                AFK(ds4, 10);
            }

            label1.Visible = false;
            label2.Visible = false;
            button1.Enabled = true;
            ChooseResupply.Enabled = true;
            Choose_Min.Enabled = true;
            MessageBox.Show("Finished. You can now close the window");
            timer.Stop();
            timer.Dispose();
        }
       

        #region Controller stuff
        public void AFK(IDualShock4Controller ds4, int NOM){

            ds4.SetAxisValue(Nefarius.ViGEm.Client.Targets.DualShock4.DualShock4Axis.RightThumbX, 255);
            Thread.Sleep(NOM*60000);
            ds4.SetAxisValue(Nefarius.ViGEm.Client.Targets.DualShock4.DualShock4Axis.RightThumbX, 127);
        }
        public void SecuroServ_Activation(IDualShock4Controller ds4)
        {
            ds4.SetButtonState(DualShock4SpecialButton.Touchpad, true);
            Thread.Sleep(1000);
            ds4.SetButtonState(DualShock4SpecialButton.Touchpad, false);
            ds4.SetDPadDirection(DualShock4DPadDirection.South);
            Thread.Sleep(2000);
            ds4.SetDPadDirection(DualShock4DPadDirection.None);
            Press(ds4, DualShock4Button.Cross);
            Thread.Sleep(800);
            Press(ds4, DualShock4Button.Cross);

        }

        public void SecuroServ_Deactivation(IDualShock4Controller ds4)
        {

            ds4.SetButtonState(DualShock4SpecialButton.Touchpad, true);
            sleep(1000);
            ds4.SetButtonState(DualShock4SpecialButton.Touchpad, false);

            Press(ds4, DualShock4Button.Cross);
            sleep(500);
            Dpad("up", ds4);
            sleep(500);
            Press(ds4, DualShock4Button.Cross);

        }

        public void Buying(IDualShock4Controller ds4)
        {
            Dpad("right",ds4);

            sleep(5000);

            Press(ds4, DualShock4Button.Cross);
            sleep(1200);
            Press(ds4, DualShock4Button.Cross);

            sleep(1000);
            Dpad("left", ds4);

            sleep(800);

            Dpad("up", ds4);

            sleep(800);
            Dpad("up", ds4);

            sleep(800);

            Press(ds4, DualShock4Button.Cross);

            Dpad("right",ds4);

            sleep(800);

            Dpad("down",ds4);

            sleep(800);

            Press(ds4, DualShock4Button.Cross);

            sleep(300);

            Dpad("up", ds4);

            sleep(800);

            Dpad("right", ds4);

            sleep(1200);
           
            Press(ds4, DualShock4Button.Cross);

            Press(ds4, DualShock4Button.Triangle);

            sleep(500);

            Dpad("right", ds4);


        }
        public void PressSquare(IDualShock4Controller ds4)
        {

            ds4.SetButtonState(Nefarius.ViGEm.Client.Targets.DualShock4.DualShock4Button.Square, true);
            Thread.Sleep(1200);           
            ds4.SetButtonState(Nefarius.ViGEm.Client.Targets.DualShock4.DualShock4Button.Square, false);

        }

        public void Press(IDualShock4Controller ds4 , Nefarius.ViGEm.Client.Targets.DualShock4.DualShock4Button Butt, int sleep = 800 ) {

            ds4.SetButtonState(Butt, true);
            Thread.Sleep(sleep);
            ds4.SetButtonState(Butt, false);


        }
       
        private void checkForUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CUpdate();
        }

        public void Dpad(String s,IDualShock4Controller ds4)
        {
            switch (s)
            {
                case "up": 
                    ds4.SetDPadDirection(DualShock4DPadDirection.North);
                    sleep(200);
                    ds4.SetDPadDirection(DualShock4DPadDirection.None);
                    break;

                case "down":
                    ds4.SetDPadDirection(DualShock4DPadDirection.South);
                    sleep(300);
                    ds4.SetDPadDirection(DualShock4DPadDirection.None);
                    break;

                case "left":

                    ds4.SetDPadDirection(DualShock4DPadDirection.West);
                    sleep(300);
                    ds4.SetDPadDirection(DualShock4DPadDirection.None);
                    break;

                case "right":

                    ds4.SetDPadDirection(DualShock4DPadDirection.East);
                    sleep(300);
                    ds4.SetDPadDirection(DualShock4DPadDirection.None);
                    break;

                default: 
                    MessageBox.Show("Something's wrong I can feel it");
                    break;
            }

        }

        #endregion

       

        
    }
}

