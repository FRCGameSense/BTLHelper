using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Meebey.SmartIrc4net;

namespace BTLHelper
{
    public partial class Form1 : Form
    {
        xSplitHandler2 xsHandler;
        SettingsForm settingsForm;
        List<string[]> QuestionsAddedList = new List<string[]>();
        GSTwitchClient twitch;
        GSTwitterClient twitter;
        public Form1()
        {
            InitializeComponent();
            xsHandler = new xSplitHandler2();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.firstInstall)
            {
                MessageBox.Show("Welcome to BTL Helper!  Please go to settings and set your file paths.");
                if (!xsHandler.checkXsplitLocation(Properties.Settings.Default.XsplitInstallLocation))
                {
                    Properties.Settings.Default.XsplitInstallLocation = "unknown";
                    Properties.Settings.Default.Save();
                }
                settingsForm = new SettingsForm();
                settingsForm.ShowDialog();
            }

            if (!xsHandler.checkXsplitLocation(Properties.Settings.Default.XsplitInstallLocation))
            {
                MessageBox.Show("Unable to locate XSplit installation in the location saved in settings, please go to Settings to locate manually.");
            }
            else
            {               
                if (Properties.Settings.Default.firstInstall)
                {
                    string xml = System.IO.Path.Combine(Properties.Settings.Default.BTLFolderLocation, "Software", "streamcontrol_base.xml");
                    xsHandler.moveStreamControlXMLToXsplitLocation(xml);

                    Properties.Settings.Default.firstInstall = false;
                    Properties.Settings.Default.Save();
                }                
                Properties.Settings.Default.Save();
            }

            //load these from settings
            Host1ComboBox.Text = Properties.Settings.Default.Host1;
            Host2ComboBox.Text = Properties.Settings.Default.Host2;
            Guest1ComboBox.Text = Properties.Settings.Default.Guest1;
            Guest2ComboBox.Text = Properties.Settings.Default.Guest2;
            Guest3ComboBox.Text = Properties.Settings.Default.Guest3;
            Guest4ComboBox.Text = Properties.Settings.Default.Guest4;

            twitterHashtagBox.Text = Properties.Settings.Default.twitterSearchTag;

            dataGridView1.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
        }

        private void importBackedUpQuestions(string filePath)
        {
            if (File.Exists(filePath))
            {
                StreamReader fileReader = new StreamReader(filePath, false);
                Properties.Settings.Default.ImportingQuestions = true;
                while (fileReader.Peek() != -1)
                {
                    string row = fileReader.ReadLine();
                    string[] question = row.Split('\t');
                    dataGridView1.Rows.Add(question);
                    QuestionsAddedList.Add(question);
                }
                fileReader.Dispose();
                fileReader.Close();
            }
            Properties.Settings.Default.ImportingQuestions = false;
        }

        private void castersGoLiveButton_Click(object sender, EventArgs e)
        {
            //save these to settings so they can be referenced outside this tab.
            Properties.Settings.Default.Host1 = Host1ComboBox.Text;
            Properties.Settings.Default.Host2 = Host2ComboBox.Text;
            Properties.Settings.Default.Guest1 = Guest1ComboBox.Text;
            Properties.Settings.Default.Guest2 = Guest2ComboBox.Text;
            Properties.Settings.Default.Guest3 = Guest3ComboBox.Text;
            Properties.Settings.Default.Guest4 = Guest4ComboBox.Text;
            

            Properties.Settings.Default.Save();

            xsHandler.loadTagsFromXML();

            xsHandler.changeXMLTag("host1", Properties.Settings.Default.Host1, true);
            xsHandler.changeXMLTag("host2", Properties.Settings.Default.Host2, true);
            xsHandler.changeXMLTag("guest1", Properties.Settings.Default.Guest1, true);
            xsHandler.changeXMLTag("guest2", Properties.Settings.Default.Guest2, true);
            xsHandler.changeXMLTag("guest3", Properties.Settings.Default.Guest3, true);
            xsHandler.changeXMLTag("guest4", Properties.Settings.Default.Guest4, true);

            xsHandler.writeXMLFile();

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsForm = new SettingsForm();

            settingsForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void masterPublishButton_Click(object sender, EventArgs e)
        {
            masterPublishButton.BackColor = Color.White;
            masterPublishButton.ForeColor = Color.FromArgb(0, 100, 179);

            switch (tabControl1.SelectedTab.Name)
            {
                case "castersTab":
                    castersGoLiveButton_Click(sender, e);
                    break;
                case "questionsTab":
                    publishQuestion();
                    break;
                case "splashTab":
                    publishSplashTab();
                    break;
                default:
                    break;
            }

            masterPublishButton.BackColor = Color.FromArgb(0, 100, 179);
            masterPublishButton.ForeColor = Color.White;
        }

        private void publishSplashTab()
        {
            xsHandler.loadTagsFromXML();

            xsHandler.changeXMLTag("splashTop", splashBottomBox.Text, true);
            xsHandler.changeXMLTag("SplashBottom", splashBottomBox.Text, true);

            xsHandler.writeXMLFile();
        }

        private void manualQuestionButton_Click(object sender, EventArgs e)
        {
            BTLQuestionForm manualForm = new BTLQuestionForm();
            manualForm.FormClosed += manualForm_FormClosed;

            manualForm.ShowDialog();
        }

        private void manualForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Properties.Settings.Default.ManualQuestion != "")
            {
                dataGridView1.Rows.Add(new string[] { Properties.Settings.Default.ManualQuestion, Properties.Settings.Default.ManualAuthor});               
            }
        }

        private void publishQuestion()
        {
            Properties.Settings.Default.PublishedQuestion = dataGridView1[0,dataGridView1.CurrentRow.Index].Value.ToString();
            Properties.Settings.Default.PublishedAuthor = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();


            Properties.Settings.Default.Save();

            xsHandler.loadTagsFromXML();

            xsHandler.changeXMLTag("question", Properties.Settings.Default.PublishedQuestion, true);
            if (Properties.Settings.Default.PublishedAuthor == "")
                xsHandler.changeXMLTag("author", Properties.Settings.Default.PublishedAuthor, true);            
            else
                xsHandler.changeXMLTag("author", "-" + Properties.Settings.Default.PublishedAuthor, true);

            xsHandler.writeXMLFile();

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                
                
                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[currentMouseOverRow].Selected = true;

                    ContextMenu m = new ContextMenu();
                    MenuItem menuDeleteQuestion = new MenuItem("Delete Question");
                    MenuItem menuPublishQuestion = new MenuItem("Publish Question");
                    menuDeleteQuestion.Click += new EventHandler(menuDeleteQuestion_Click);
                    menuPublishQuestion.Click += new EventHandler(masterPublishButton_Click);

                    m.MenuItems.Add(menuPublishQuestion);
                    m.MenuItems.Add(menuDeleteQuestion);
                    m.Show(dataGridView1, new Point(e.X, e.Y));
                }
            }
        }

        private void menuDeleteQuestion_Click(object sender, EventArgs e)
        {
            MenuItem clickedItem = sender as MenuItem;
            dataGridView1.Rows.RemoveAt(dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected));
            dataGridView1.ClearSelection();

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (!Properties.Settings.Default.ImportingQuestions)
            {
                StringBuilder sb = new StringBuilder();
                //sb.AppendLine("Question, Author");
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    sb.AppendLine(row.Cells["questions"].Value.ToString() + '\t' + row.Cells["authors"].Value.ToString());
                }

                string backupFile = Path.Combine(Properties.Settings.Default.BTLFolderLocation, "Documents", "BTLQuestionsBackup.txt");

                File.WriteAllText(backupFile, sb.ToString());
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            string questionsBackupFile = Path.Combine(Properties.Settings.Default.BTLFolderLocation, "Documents", "BTLQuestionsBackup.txt");
            if (File.Exists(questionsBackupFile))
            {
                DialogResult result = MessageBox.Show("BTLHelper found a questions backup file. \n\nWould you like to import the backed up questions?", "Backup File Found", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    importBackedUpQuestions(questionsBackupFile);
                }
            }
        }

        private void twitchGetQuestionsButton_Click(object sender, EventArgs e)
        {
            if (twitchGetQuestionsButton.Text == "Start Getting Questions")
            {
                twitch = new GSTwitchClient("#frcgamesense");
                twitch.Connect();
                twitch.Listen();
                backgroundWorker1.RunWorkerAsync();
                twitchGetQuestionsButton.Text = "Stop Getting Questions";
            }
            else
            {
                twitch.Stop();
                backgroundWorker1.CancelAsync();
                twitchGetQuestionsButton.Text = "Start Getting Questions";
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            while (!worker.CancellationPending)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    worker.ReportProgress(0);
                    Thread.Sleep(100);
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, EventArgs e)
        {
            if (twitch.QuestionsList.Count > 0)
            {
                foreach (string[] array in twitch.QuestionsList)
                {
                    dataGridView1.Rows.Add(array);
                }
                twitch.QuestionsList.Clear();
            }
        }

        private void twitterGetQuestionsButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.twitterVerified)
            {
                Properties.Settings.Default.twitterSearchTag = twitterHashtagBox.Text;
                Properties.Settings.Default.Save();

                twitter = new GSTwitterClient();
                twitter.Authenticate();
                twitter.StartGettingQuestions();

                IEnumerable<string[]> questionsNotAdded = twitter.QuestionsList.Except(QuestionsAddedList, new QuestionComparer());

                foreach (string[] q in questionsNotAdded)
                {
                    dataGridView1.Rows.Add(q);
                }

                QuestionsAddedList = twitter.QuestionsList;
            }
            else
            {
                DialogResult result = MessageBox.Show("Verify this app with Twitter?", "App not verified.", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    settingsForm = new SettingsForm();
                    settingsForm.ShowDialog();
                }
            }
        }

        class QuestionComparer : IEqualityComparer<string[]>
        {
            public bool Equals(string[] s1, string[] s2)
            {
                if (s1[0] == s2[0] && s1[1] == s2[1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public int GetHashCode(string[] s)
            {
                int hCode = s[0].Length + s[1].Length;
                return hCode.GetHashCode();
            }
        }

        private void clearQuestionsButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This cannot be undone.", "Are you sure?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                dataGridView1.Rows.Clear();
                QuestionsAddedList.Clear();
            }
        }

        private void clearQuestionButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PublishedAuthor = "";
            Properties.Settings.Default.PublishedQuestion = "";
            Properties.Settings.Default.Save();

            xsHandler.changeXMLTag("question", Properties.Settings.Default.PublishedQuestion, true);
            if (Properties.Settings.Default.PublishedAuthor == "")
                xsHandler.changeXMLTag("author", Properties.Settings.Default.PublishedAuthor, true);
            else
                xsHandler.changeXMLTag("author", "-" + Properties.Settings.Default.PublishedAuthor, true);

            xsHandler.writeXMLFile();
        }
    }        
}