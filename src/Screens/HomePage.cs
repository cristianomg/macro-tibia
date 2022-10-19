using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screens
{
    public partial class HomePage : Form
    {
        private int PROCESS_ID;
        private bool RUNNING;
        private const int F1 = 112;
        private const int WM_KEYDOWN = 0x0100;

        public HomePage(int ProcessId)
        {

            if (ProcessId == 0)
            {
                this.Hide();
                new SelectApplicationPage().Show();
            }
            else
            {
                PROCESS_ID = ProcessId;
            }

            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
        }

        public void Run()
        {
            var process = Process.GetProcessById(PROCESS_ID);
            while (RUNNING)
            {
                SendMessage(process.MainWindowHandle, WM_KEYDOWN, new IntPtr(F1), IntPtr.Zero);
                Thread.Sleep(1000);
            }
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]

        [return: MarshalAs(UnmanagedType.Bool)]

        static extern bool SetForegroundWindow(IntPtr hWnd);

        private void button1_Click(object sender, EventArgs e)
        {
            RUNNING = true;

            Task.Factory.StartNew(() =>
            {
                Run();
            });
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            RUNNING = false;
        }
    }
}
