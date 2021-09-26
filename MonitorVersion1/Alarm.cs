using System;
using System.Windows.Forms;


namespace MonitorVersion1
{
    public partial class Alarm : Form
    {
        public Alarm()
        {
            InitializeComponent();
            
        }

        public static string toUser;
        public static bool enableSend = false;

        private void Alarm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            getSetting();

        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (btnToggle.Checked)
            {
                //if (DateTime.Now.Minute % 2 == 0 && DateTime.Now.Second == 0)
                //{
                //    string fromUser = "vietmapenv.alarm@gmail.com";
                //    string fromPass = "huyviet123";
                //    string toUser = "locxuan@vietmapenv.vn";

                //    email email1 = new email(fromUser, fromPass, toUser);
                //    //FormMain.listNotiAlarm.
                //    string bodyTest = "Loc Bee";
                //    email1.sendMessage(bodyTest);

                //    //FormMain.listNotiAlarm.Clear();
                //}

                enableSend = true;
               

            }
        }

        private void getSetting()
        {
            string[] preSetting = new string[10];
            ReadWriteTxt _getFile = new ReadWriteTxt();
            //preSetting = _getFile.readFile(@"D:\VIETMAPENV\CODER\All Monitor Version 1\MonitorVersion1\appSetting.txt");
            preSetting = _getFile.readFile(@"txtSetting\appSetting.txt");

            btnToggle.Checked = Convert.ToBoolean(preSetting[1]);
            txbToUser.Texts = preSetting[3];
            toUser = preSetting[3];
        }


        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            try
            {
                string[] contents = { "1. Enable", btnToggle.Checked.ToString(), "2. Email to send", txbToUser.Texts, "3. Change avatar" };
                ReadWriteTxt _writeFile = new ReadWriteTxt();
                _writeFile.writeFile(@"txtSetting\appSetting.txt", contents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void customTextBox11_Load(object sender, EventArgs e)
        {

        }
    }
}
