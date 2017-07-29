using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace ScrObjAnalyzer
{
    public partial class Form1 : Form
    {
        public string OriginText;
        public List<ListData> ListDatas = new List<ListData>(), CurrentDatas = new List<ListData>();
        public List<BPMData> BPMs = new List<BPMData>();

        public Form1()
        {
            OriginText = Text;
            InitializeComponent();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            DialogResult res = OpenDialog.ShowDialog();
            if(res.Equals(DialogResult.OK))
            {
                Text = (OriginText + " - " + OpenDialog.SafeFileName);
                StreamReader reader = new StreamReader(OpenDialog.OpenFile());
                List<string> strList = new List<string>();
                while(reader.Peek() != -1)
                {
                    strList.Add(reader.ReadLine());
                }
                reader.Close();
                ReadFumenFile(strList.ToArray());
            }
            ExportBtn.Enabled = false;
        }

        private void ReadFumenFile(string[] target)
        {
            char[] parseTool = new char[] { ' ' };
            Dictionary<int, int> trackDic = new Dictionary<int, int>();
            int totalCount = -1, bpmDataCount = -1;

            ListDatas.Clear();
            BPMs.Clear();
            for (int i = 0; i < target.Length; i++)
            {
                string[] data = target[i].Split(parseTool, StringSplitOptions.RemoveEmptyEntries);
                if (data.Length > 0 && (data[0].Equals("\t\tEventNoteData") || data[0].Equals("\t\tEventConductorData")) && i > 9)
                {
                    ListDatas.Add(new ListData());
                    totalCount++;
                    if(data[0].Equals("\t\tEventConductorData"))
                    {
                        BPMs.Add(new BPMData());
                        bpmDataCount++;
                    }
                }
                else if (data.Length > 2 && data[1].Equals("track"))
                {
                    int val = int.Parse(data[3]);
                    ListDatas[totalCount].Track = val;

                    int mixVal = val;
                    if (val >= 1 && val <= 2) { mixVal = 100; }
                    else if (val >= 3 && val <= 4) { mixVal = 101; }
                    else if (val >= 9 && val <= 12) { mixVal = 110; }
                    else if (val >= 25 && val <= 30) { mixVal = 120; }
                    else if (val >= 31 && val <= 36) { mixVal = 121; }
                    ListDatas[totalCount].MyMix = mixVal;
                    if (!trackDic.ContainsKey(mixVal)) { trackDic.Add(mixVal, 0); }
                    trackDic[mixVal]++;
                    ListDatas[totalCount].ID = trackDic[mixVal];
                }
                else if (data.Length > 2 && data[1].Equals("absTime"))
                {
                    double val = double.Parse(data[3]);
                    ListDatas[totalCount].Time = val;
                    if(bpmDataCount >= 0) { BPMs[bpmDataCount].Time = val; }
                }
                else if (data.Length > 2 && data[1].Equals("type"))
                {
                    int val = int.Parse(data[3]);
                    ListDatas[totalCount].Type = val;

                    if (val.Equals(5) || val.Equals(7)) { trackDic[ListDatas[totalCount].MyMix]++; }
                }
                else if (data.Length > 2 && data[1].Equals("startPosx"))
                {
                    double val = double.Parse(data[3]);
                    ListDatas[totalCount].StartPos = val;
                }
                else if (data.Length > 2 && data[1].Equals("endPosx"))
                {
                    double val = double.Parse(data[3]);
                    ListDatas[totalCount].EndPos = val;
                }
                else if (data.Length > 2 && data[1].Equals("speed"))
                {
                    double val = double.Parse(data[3]);
                    ListDatas[totalCount].Speed = val;
                }
                else if(data.Length > 2 && data[1].Equals("duration"))
                {
                    int val = int.Parse(data[3]);
                    ListDatas[totalCount].TickDistance = val;
                }
                else if (data.Length > 2 && data[1].Equals("endType"))
                {
                    int val = int.Parse(data[3]);
                    ListDatas[totalCount].EndType = val;
                }
                else if(data.Length > 2 && data[1].Equals("subtick"))
                {
                    int val = int.Parse(data[3]);
                    ListDatas[totalCount].SubTick.Add(val);

                    if(ListDatas[totalCount].SubTick.Count > 1) { trackDic[ListDatas[totalCount].MyMix]++; }
                }
                else if (data.Length > 2 && data[1].Equals("posx"))
                {
                    double val = double.Parse(data[3]);
                    ListDatas[totalCount].SubPos.Add(val);
                }
                else if(data.Length > 2 && data[1].Equals("tempo"))
                {
                    double val = double.Parse(data[3]);
                    BPMs[bpmDataCount].SecPerTick = (60 / val) / 480;
                }
            }

            AddToList(ListDatas);
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            CurrentDatas.Clear();

            for(int i = 0; i < ListDatas.Count; i++)
            {
                if(Mix2.Checked)
                {
                    if(ListDatas[i].Track >= 1 && ListDatas[i].Track <= 2) { CurrentDatas.Add(ListDatas[i]); }
                }
                else if(Mix2P.Checked)
                {
                    if (ListDatas[i].Track >= 3 && ListDatas[i].Track <= 4) { CurrentDatas.Add(ListDatas[i]); }
                }
                else if(Mix4.Checked)
                {
                    if (ListDatas[i].Track >= 9 && ListDatas[i].Track <= 12) { CurrentDatas.Add(ListDatas[i]); }
                }
                else if(Mix6.Checked)
                {
                    if (ListDatas[i].Track >= 25 && ListDatas[i].Track <= 30) { CurrentDatas.Add(ListDatas[i]); }
                }
                else if(MixM.Checked)
                {
                    if (ListDatas[i].Track >= 31 && ListDatas[i].Track <= 36) { CurrentDatas.Add(ListDatas[i]); }
                }
            }

            AddToList(CurrentDatas);
            ExportBtn.Enabled = true;
        }

        private void AddToList(List<ListData> datas)
        {
            TextList.Items.Clear();
            for (int i = 0; i < datas.Count; i++)
            {
                ListViewItem item = new ListViewItem(datas[i].ID.ToString());
                item.SubItems.Add(datas[i].Track.ToString());
                item.SubItems.Add(datas[i].Time.ToString());
                item.SubItems.Add(datas[i].Type.ToString());
                item.SubItems.Add(datas[i].StartPos.ToString());
                item.SubItems.Add(datas[i].EndPos.ToString());
                item.SubItems.Add(datas[i].Speed.ToString());
                item.SubItems.Add(datas[i].EndType.ToString());

                TextList.Items.Add(item);
            }
        }

        private void ReshowBtn_Click(object sender, EventArgs e)
        {
            AddToList(ListDatas);
            ExportBtn.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OriginText = Text;
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            int curParseMode = 0;
            if (Mix2.Checked || Mix2P.Checked)
            {
                ExportDialog.DefaultExt = "tw2";
                ExportDialog.Filter = "2Lane TWx Beatmap format (*.tw2)|*.tw2";
                curParseMode = 2;
            }
            else if (Mix4.Checked)
            {
                ExportDialog.DefaultExt = "tw4";
                ExportDialog.Filter = "4Lane TWx Beatmap format (*.tw4)|*.tw4";
                curParseMode = 4;
            }
            else if (Mix6.Checked || MixM.Checked)
            {
                ExportDialog.DefaultExt = "tw6";
                ExportDialog.Filter = "6Lane TWx Beatmap format (*.tw6)|*.tw6";
                curParseMode = 6;
            }

            DialogResult res = ExportDialog.ShowDialog();
            if(res.Equals(DialogResult.OK))
            {
                DataParser parser = new DataParser();
                string jsonText = parser.ParseToTWx(curParseMode, CurrentDatas, BPMs);

                StreamWriter writer = new StreamWriter(ExportDialog.OpenFile());
                writer.Write(jsonText);
                writer.Close();
            }
        }

    }

    public class ListData
    {
        public int ID { get; set; }
        public int MyMix { get; set; }
        public int Track { get; set; }
        public int Type { get; set; }
        public double Time { get; set; }
        public double StartPos { get; set; }
        public double EndPos { get; set; }
        public double Speed { get; set; }
        public int TickDistance { get; set; }
        public int EndType { get; set; }
        public List<double> SubPos { get; set; }
        public List<int> SubTick { get; set; }

        public ListData()
        {
            SubPos = new List<double>();
            SubTick = new List<int>();
        }
    }

    public class BPMData
    {
        public double Time { get; set; }
        public double SecPerTick { get; set; }

        public BPMData()
        {

        }
    }
}
