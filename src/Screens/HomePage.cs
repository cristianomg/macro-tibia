using Emgu.CV.ML;
using Screenshot;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Screens
{
    public partial class HomePage : Form
    {
        public Configuration Configs { get; set; }
        private Bitmap imageToCheck;
        private int PROCESS_ID = 0;
        private List<Task> tasks = new List<Task>();
        private Dictionary<int, Keys> hotkeys = new Dictionary<int, Keys>
        {
            {1, Keys.Insert },
            {2, Keys.Home },
            {3, Keys.Delete },
            {4, Keys.End },
            {5, Keys.Pause }
        };

        private bool BOT_IS_RUNNING = true;
        private Combo Combo1 = new Combo();
        private Combo Combo2 = new Combo();
        private Combo Combo3 = new Combo();
        public HomePage(int ProcessId)
        {
            Configs = Configuration.FromFile();

            if (ProcessId == 0)
            {
                this.Hide();
                new SelectApplicationPage().Show();
            }
            else
            {
                PROCESS_ID = ProcessId;
            }

            imageToCheck = new Bitmap(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Healing.jpg"));


            RegisterHotKey(this.Handle, 1, 0, (int)Keys.Insert); // Registra o hotkey
            RegisterHotKey(this.Handle, 2, 0, (int)Keys.Home); // Registra o hotkey
            RegisterHotKey(this.Handle, 3, 0, (int)Keys.Delete); // Registra o hotkey
            RegisterHotKey(this.Handle, 4, 0, (int)Keys.End); // Registra o hotkey
            RegisterHotKey(this.Handle, 5, 0, (int)Keys.Pause); // Registra o hotkey

            tasks.Add(Combar(Combo1, (int)Keys.F1, (int)Keys.F2));
            tasks.Add(Combar(Combo2, (int)Keys.F3, (int)Keys.F4));
            tasks.Add(Combar(Combo3, (int)Keys.F8, (int)Keys.F9));

            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            base.WndProc(ref m);

            if (m.Msg == KeyBoardConstants.WM_HOTKEY) // Verifica se é a mensagem de hotkey
            {
                int id = m.WParam.ToInt32(); // Obtém o ID do hotkey registrado

                if (hotkeys.TryGetValue(id, out Keys hotkey))
                {
                    switch (hotkey)
                    {
                        case Keys.Insert:
                            Combo1.Controller = !Combo1.Controller;
                            break;
                        case Keys.Home:
                            Combo2.Controller = !Combo2.Controller;
                            break;
                        case Keys.Delete:
                            Combo3.Controller = !Combo3.Controller;
                            break;
                        case Keys.End:
                            break;
                        case Keys.Pause:
                            Combo1.Controller = false;
                            Combo2.Controller = false;
                            Combo3.Controller = false;
                            break;
                    }
                }
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            Combo1.FirstInterval = Convert.ToInt32(intervalHealing1.Text);
            Combo1.SecondInterval = Convert.ToInt32(intervalHealing2.Text);

            Combo2.FirstInterval = Convert.ToInt32(intervalCombo11.Text);
            Combo2.SecondInterval = Convert.ToInt32(IntervalCombo12.Text);

            Combo3.FirstInterval = Convert.ToInt32(IntervalCombo21.Text);
            Combo3.SecondInterval = Convert.ToInt32(IntervalCombo22.Text);
        }

        private Task Combar(Combo combo, int key1, int key2)
        {
            var process = Process.GetProcessById(PROCESS_ID);
            return Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    if (BOT_IS_RUNNING && combo.Controller)
                    {
                        SendMessage(process.MainWindowHandle, KeyBoardConstants.WM_KEYDOWN, new IntPtr(key1), IntPtr.Zero);
                        Thread.Sleep(combo.FirstInterval);
                        SendMessage(process.MainWindowHandle, KeyBoardConstants.WM_KEYDOWN, new IntPtr(key2), IntPtr.Zero);
                        Thread.Sleep(combo.SecondInterval);
                    }
                }
            }, combo.Cancellation.Token);
        }

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]

        [return: MarshalAs(UnmanagedType.Bool)]

        static extern bool SetForegroundWindow(IntPtr hWnd);
        private void formEvent_closing(object sender, FormClosingEventArgs e)
        {
            Combo1.Cancellation.Cancel();
            Combo2.Cancellation.Cancel();
            Combo3.Cancellation.Cancel();

        }
        private void intervalHealing1_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(intervalHealing1.Text, out var value);
            Combo1.FirstInterval = value;
        }

        private void intervalHealing2_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(intervalHealing2.Text, out var value);
            Combo1.SecondInterval = value;

        }

        private void intervalCombo11_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(intervalCombo11.Text, out var value);
            Combo2.FirstInterval = value;
        }

        private void IntervalCombo12_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(IntervalCombo12.Text, out var value);
            Combo2.SecondInterval = value;
        }

        private void IntervalCombo21_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(IntervalCombo21.Text, out var value);
            Combo3.FirstInterval = value;
        }

        private void IntervalCombo22_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(IntervalCombo22.Text, out var value);
            Combo3.SecondInterval = value;
        }

        private void btn_Calibrar_Healing_Click(object sender, EventArgs e)
        {
            SelectArea area = new SelectArea(this, "Healing");
            this.Hide();
            area.Show();
        }
        private bool CheckImagePresence(Image<Bgr, byte> screenImage, Image<Bgr, byte> referenceImage, Rectangle area)
        {
            // Recorta a área da tela onde será feita a verificação
            Image<Bgr, byte> croppedImage = screenImage.Copy(area);

            // Realiza a correspondência de características
            using (var result = screenImage.MatchTemplate(croppedImage, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                // Verifica se a correspondência encontrada é suficientemente alta para considerar a imagem presente
                if (maxValues[0] > 0.8)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
