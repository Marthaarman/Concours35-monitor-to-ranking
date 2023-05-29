using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concours35_MonitorRanking
{
    public partial class Form1 : Form
    {

        private string _file = string.Empty;
        private string _outputPath = string.Empty;
        private string _outputFile = string.Empty;

        private static int _rankingSize = 10;
        private int _rankingCount = 0;
        private string[] _rankingNames = new String[_rankingSize];

        private bool _running = false;

        private int _refreshTimeMilliseconds = 5000;


        private BackgroundWorker backgroundWorker;

        public Form1()
        {
            InitializeComponent();

            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_Completed;
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true)
            {
                processFile();
                Thread.Sleep(_refreshTimeMilliseconds);
                if (backgroundWorker.CancellationPending)
                {
                    return;
                }
            }
        }

        private void backgroundWorker_Completed(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            _running = false;
            button_run.Text = "Start";
        }

        private void button_selectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "concours35 monitor files (*.DAT)|*.DAT";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    _file = openFileDialog.FileName;
                    label_selectedFile.Text = _file;
                }
            }
        }

        private void processFile()
        {
            Array.Clear(_rankingNames, 0, _rankingNames.Length);
            if (File.Exists(_file))
            {
                using (StreamReader file = new StreamReader(_file))
                {
                    string ln;
                    _rankingCount = 0;
                    while ((ln = file.ReadLine()) != null)
                    {
                        string[] words = ln.Split('	');
                        if (words.Length > 0)
                        {
                            if (words[0].Contains("rij:"))
                            {
                                string numberString = words[0].Replace("rij:", "");
                                int numberInt = 0;
                                if (int.TryParse(numberString, out numberInt))
                                {
                                    _rankingNames[_rankingCount] = words[2];
                                    _rankingCount++;
                                }
                            }
                        }
                    }

                    file.Close();
                }

                using (StreamWriter writer = new StreamWriter(_outputFile, false))
                {
                    foreach (string rankingName in _rankingNames)
                    {
                        writer.WriteLine(rankingName);
                    }
                    writer.WriteLine("-");
                    writer.Close();
                }
            }
        }

        private void button_selectOutputFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    _outputPath = fbd.SelectedPath;
                    _outputFile = _outputPath + "/concours35-monitor-ranking.csv";
                    label_selectedOutputFolder.Text = _outputFile;

                    if (!File.Exists(_outputFile))
                    {
                        File.Create(_outputFile).Close();
                    }
                }
            }
        }

        private void button_run_Click(object sender, EventArgs e)
        {
            if (_running == false)
            {
                Start(); 
            }
            else
            {
                Stop();
            }
           
            
        }


        private void Start()
        {
            if (Directory.Exists(_outputPath) && File.Exists(_outputFile) && File.Exists(_file))
            {
                button_run.Text = "Stop";
                _running = true;
                backgroundWorker.RunWorkerAsync();
                
            }
            else
            {
                Stop();
            }
        }

        private void Stop()
        {
            if (backgroundWorker.IsBusy)
            {
                button_run.Text = "Stopping, wait.";
                _running = false;
                backgroundWorker.CancelAsync();
            }
            else
            {
                button_run.Text = "Start";
            }
            
            
        }
    }
}
