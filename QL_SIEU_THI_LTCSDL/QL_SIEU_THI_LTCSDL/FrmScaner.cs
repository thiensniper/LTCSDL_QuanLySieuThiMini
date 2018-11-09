using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;

namespace QL_SIEU_THI_LTCSDL
{
    public partial class FrmScaner : Form
    {

        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        public FrmScaner()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
        
            
        }
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //throw new NotImplementedException();
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //ham ngan su dung alt + f4
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.F4))
            {
                return true;
            }
            if (keyData == (Keys.Alt | Keys.Tab))
            {
                return true;
            }
            if (keyData == (Keys.Control | Keys.Q))
            {
                return true;
            }
            if (keyData == (Keys.Control | Keys.Alt | Keys.Delete))
            {
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void btnLog_Click(object sender, EventArgs e)
        {
            btnCheck.Visible = true;

           

            pictureBox1.Visible = true;
            btnLog.Visible = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                timer1.Stop();
            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)pictureBox1.Image);
            try
            {
                string decoded = result.ToString().Trim();

                DialogResult ShowDecode = new DialogResult();
                ShowDecode = MessageBox.Show("CHUỖI NHẬN ĐƯỢC SAU KHI QUÉT LÀ: \n" + "<< "+decoded+" >>" + " \n"+"BẠN CÓ MUỐN TIẾP TỤC QUÉT HAY KHÔNG?"/*decoded*/, "THÔNG BÁO!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (ShowDecode == DialogResult.Yes) { timer1.Start(); }
                if (ShowDecode == DialogResult.No) { timer1.Stop(); }



                //Application.Exit();

                // HAM KIEM TRA GIONG DECODE QUY DINH
                //if (decoded == "0562324")
                //{
                //    timer1.Stop();
                //    MessageBox.Show("QUYỀN TRUY CẬP : ADMIN\n" + "" + "\n!"/*decoded*/, "ĐĂNG NHẬP THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    Form2 form = new Form2();
                //    form.Show();
                //    this.Hide();
                //}
                //else
                //{
                //    timer1.Stop();
                //    MessageBox.Show("ĐĂNG NHẬP SAI!", "CẢNH BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    //  timer1_Tick(sender, e);
                //    button2_Click(sender, e);

                //}
            }
            catch (Exception ex)
            {
                timer1.Start();
            }
        }

        private void FrmScaner_Load(object sender, EventArgs e)
        {


            btnCheck.Visible = false;
            label1.Visible = true;
            comboBox1.Visible = true;
            pictureBox1.Visible = false;
            btnLog.Visible = true;

            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                comboBox1.Items.Add(Device.Name);
            }
            comboBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();

            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }
    }
}
