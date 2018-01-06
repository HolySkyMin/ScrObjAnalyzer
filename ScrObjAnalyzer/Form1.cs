using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using TempestWave.TWx;

namespace ScrObjAnalyzer
{
    public partial class Form1 : Form
    {
        public string OriginText;
        public Color PaletteColor;
        public ListData PickedData;
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
                if(ListDatas.Count > 0)
                {
                    ExportBtn.Enabled = false;
                    ReshowBtn.Enabled = true;
                    FilterBtn.Enabled = true;
                }
            }
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
                else if (data.Length > 2 && data[1].Equals("tick"))
                {
                    int val = int.Parse(data[3]);
                    ListDatas[totalCount].Tick = val;
                    if (bpmDataCount >= 0) { BPMs[bpmDataCount].Tick = val; }
                }
                else if (data.Length > 2 && data[1].Equals("type"))
                {
                    int val = int.Parse(data[3]);
                    ListDatas[totalCount].Type = val;
                    ListDatas[totalCount].NoteColor = new byte[4] { 255, 255, 255, 255 };

                    if (val.Equals(5) || val.Equals(7))
                    {
                        trackDic[ListDatas[totalCount].MyMix]++;
                        ListDatas[totalCount].SubColor.Add(new byte[4] { 255, 255, 255, 255 });
                    }
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

                    if(ListDatas[totalCount].SubTick.Count > 1)
                    {
                        trackDic[ListDatas[totalCount].MyMix]++;
                        ListDatas[totalCount].SubColor.Add(new byte[4] { 255, 255, 255, 255 });
                    }
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
            for (int i = 0; i < ListDatas.Count; i++) { CurrentDatas.Add(ListDatas[i]); }
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
                item.SubItems.Add(datas[i].Tick.ToString());
                item.SubItems.Add(datas[i].Type.ToString());
                item.SubItems.Add(datas[i].StartPos.ToString());
                item.SubItems.Add(datas[i].EndPos.ToString());
                item.SubItems.Add(datas[i].Speed.ToString());
                item.SubItems.Add(datas[i].EndType.ToString());

                if(datas[i].MyMix >= 100)
                {
                    if (datas[i].Type.Equals(6)) { item.SubItems.Add("Slide note."); }
                    else if (datas[i].Type.Equals(5) || datas[i].Type.Equals(7)) { item.SubItems.Add("Hold note."); }
                }

                TextList.Items.Add(item);
            }
        }

        private void ReshowBtn_Click(object sender, EventArgs e)
        {
            AddToList(ListDatas);
            for (int i = 0; i < ListDatas.Count; i++) { CurrentDatas.Add(ListDatas[i]); }
            ExportBtn.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OriginText = Text;
            PaletteColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
        }

        private void TextList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SpecificNoteList.Items.Clear();
            ColorApplyBtn.Enabled = false;

            if (TextList.SelectedIndices.Count > 0)
            {
                ListData pickData = CurrentDatas[TextList.SelectedIndices[0]];
                if (pickData.MyMix < 100)
                {
                    NoteOrNot.Text = "This is not a note.";
                }
                else
                {
                    if (pickData.Type.Equals(5) || pickData.Type.Equals(7))
                    {
                        NoteOrNot.Text = "Hold note selected. #" + pickData.ID.ToString();

                        ListViewItem itemHead = new ListViewItem("Start");
                        itemHead.SubItems.Add(pickData.EndPos.ToString());
                        itemHead.SubItems.Add(pickData.NoteColor[0].ToString() + "," + pickData.NoteColor[1].ToString() + "," + pickData.NoteColor[2].ToString() + "," + pickData.NoteColor[3].ToString());
                        SpecificNoteList.Items.Add(itemHead);

                        ListViewItem itemTail = new ListViewItem("End");
                        itemTail.SubItems.Add(pickData.EndPos.ToString());
                        itemTail.SubItems.Add(pickData.SubColor[0][0].ToString() + "," + pickData.SubColor[0][1].ToString() + "," + pickData.SubColor[0][2].ToString() + "," + pickData.SubColor[0][3].ToString());
                        SpecificNoteList.Items.Add(itemTail);
                    }
                    else if (pickData.Type.Equals(6))
                    {
                        NoteOrNot.Text = "Slide note selected. #" + pickData.ID.ToString();

                        ListViewItem itemHead = new ListViewItem("Start");
                        itemHead.SubItems.Add(pickData.EndPos.ToString());
                        itemHead.SubItems.Add(pickData.NoteColor[0].ToString() + "," + pickData.NoteColor[1].ToString() + "," + pickData.NoteColor[2].ToString() + "," + pickData.NoteColor[3].ToString());
                        SpecificNoteList.Items.Add(itemHead);

                        for (int i = 1; i < pickData.SubPos.Count; i++)
                        {
                            ListViewItem itemCheck;
                            if (i.Equals(pickData.SubPos.Count - 1)) { itemCheck = new ListViewItem("End"); }
                            else { itemCheck = new ListViewItem("Check"); }
                            itemCheck.SubItems.Add(pickData.SubPos[i].ToString());
                            itemCheck.SubItems.Add(pickData.SubColor[i - 1][0].ToString() + "," + pickData.SubColor[i - 1][1].ToString() + "," + pickData.SubColor[i - 1][2].ToString() + "," + pickData.SubColor[i - 1][3].ToString());
                            SpecificNoteList.Items.Add(itemCheck);
                        }
                    }
                    else
                    {
                        ListViewItem itemHead = new ListViewItem("Start");
                        itemHead.SubItems.Add(pickData.EndPos.ToString());
                        itemHead.SubItems.Add(pickData.NoteColor[0].ToString() + "," + pickData.NoteColor[1].ToString() + "," + pickData.NoteColor[2].ToString() + "," + pickData.NoteColor[3].ToString());
                        SpecificNoteList.Items.Add(itemHead);

                        if (pickData.Type.Equals(2) || pickData.Type.Equals(3) || pickData.Type.Equals(4)) { NoteOrNot.Text = "Flick note selected. #" + pickData.ID.ToString(); }
                        else { NoteOrNot.Text = "Tap note selected. #" + pickData.ID.ToString(); }
                    }
                    ColorApplyBtn.Enabled = true;
                }
                PickedData = pickData;
            }
        }

        private void ReloadSpecificList()
        {
            SpecificNoteList.Items.Clear();

            if (PickedData.Type.Equals(5) || PickedData.Type.Equals(7))
            {
                ListViewItem itemHead = new ListViewItem("Start");
                itemHead.SubItems.Add(PickedData.EndPos.ToString());
                itemHead.SubItems.Add(PickedData.NoteColor[0].ToString() + "," + PickedData.NoteColor[1].ToString() + "," + PickedData.NoteColor[2].ToString() + "," + PickedData.NoteColor[3].ToString());
                SpecificNoteList.Items.Add(itemHead);

                ListViewItem itemTail = new ListViewItem("End");
                itemTail.SubItems.Add(PickedData.EndPos.ToString());
                itemTail.SubItems.Add(PickedData.SubColor[0][0].ToString() + "," + PickedData.SubColor[0][1].ToString() + "," + PickedData.SubColor[0][2].ToString() + "," + PickedData.SubColor[0][3].ToString());
                SpecificNoteList.Items.Add(itemTail);
            }
            else if (PickedData.Type.Equals(6))
            {
                ListViewItem itemHead = new ListViewItem("Start");
                itemHead.SubItems.Add(PickedData.EndPos.ToString());
                itemHead.SubItems.Add(PickedData.NoteColor[0].ToString() + "," + PickedData.NoteColor[1].ToString() + "," + PickedData.NoteColor[2].ToString() + "," + PickedData.NoteColor[3].ToString());
                SpecificNoteList.Items.Add(itemHead);

                for (int i = 1; i < PickedData.SubPos.Count; i++)
                {
                    ListViewItem itemCheck;
                    if (i.Equals(PickedData.SubPos.Count - 1)) { itemCheck = new ListViewItem("End"); }
                    else { itemCheck = new ListViewItem("Check"); }
                    itemCheck.SubItems.Add(PickedData.SubPos[i].ToString());
                    itemCheck.SubItems.Add(PickedData.SubColor[i - 1][0].ToString() + "," + PickedData.SubColor[i - 1][1].ToString() + "," + PickedData.SubColor[i - 1][2].ToString() + "," + PickedData.SubColor[i - 1][3].ToString());
                    SpecificNoteList.Items.Add(itemCheck);
                }
            }
            else
            {
                ListViewItem itemHead = new ListViewItem("Start");
                itemHead.SubItems.Add(PickedData.EndPos.ToString());
                itemHead.SubItems.Add(PickedData.NoteColor[0].ToString() + "," + PickedData.NoteColor[1].ToString() + "," + PickedData.NoteColor[2].ToString() + "," + PickedData.NoteColor[3].ToString());
                SpecificNoteList.Items.Add(itemHead);
            }
        }

        private void ColorApplyBtn_Click(object sender, EventArgs e)
        {
            if(ApplyAllCheck.Checked)
            {
                for(int i = 0; i < CurrentDatas.Count; i++)
                {
                    CurrentDatas[i].NoteColor = new byte[4] { PaletteColor.R, PaletteColor.G, PaletteColor.B, PaletteColor.A };
                    if(CurrentDatas[i].SubColor.Count > 0)
                    {
                        for (int j = 0; j < CurrentDatas[i].SubColor.Count; j++) { CurrentDatas[i].SubColor[j] = new byte[4] { PaletteColor.R, PaletteColor.G, PaletteColor.B, PaletteColor.A }; }
                    }
                }
                if (SpecificNoteList.Items.Count > 0) { ReloadSpecificList(); }
            }
            else
            {
                if (SpecificNoteList.SelectedIndices.Count > 0)
                {
                    if (SpecificNoteList.Items.Count > 1)
                    {
                        for (int i = 0; i < SpecificNoteList.SelectedIndices.Count; i++)
                        {
                            if (SpecificNoteList.SelectedIndices[i].Equals(0)) { PickedData.NoteColor = new byte[4] { PaletteColor.R, PaletteColor.G, PaletteColor.B, PaletteColor.A }; }
                            else { PickedData.SubColor[SpecificNoteList.SelectedIndices[i] - 1] = new byte[4] { PaletteColor.R, PaletteColor.G, PaletteColor.B, PaletteColor.A }; }
                        }
                        ReloadSpecificList();
                    }
                    else { PickedData.NoteColor = new byte[4] { PaletteColor.R, PaletteColor.G, PaletteColor.B, PaletteColor.A }; }
                }
            }
        }

        private void ColorChanged(object sender, EventArgs e)
        {
            PaletteColor = System.Drawing.Color.FromArgb((byte)ColorA.Value, (byte)ColorR.Value, (byte)ColorG.Value, (byte)ColorB.Value);
            Palette.BackColor = PaletteColor;
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
                Metadata data = new Metadata();
                if (EasyRadio.Checked) { data.level = 1; }
                else if (NormalRadio.Checked) { data.level = 2; }
                else if (HardRadio.Checked) { data.level = 3; }
                else if (ApexRadio.Checked) { data.level = 4; }
                else if (CustomRadio.Checked) { data.level = (int)CustomLevelVal.Value; }
                data.artist = Artist.Text;
                data.mapper = Mapper.Text;
                data.density = (int)DensityVal.Value;

                DataParser parser = new DataParser();
                string jsonText = parser.ParseToTWx(curParseMode, CurrentDatas, BPMs, new byte[] { (byte)ColorR.Value, (byte)ColorG.Value, (byte)ColorB.Value, (byte)ColorA.Value }, data);

                StreamWriter writer = new StreamWriter(ExportDialog.OpenFile());
                writer.Write(jsonText);
                writer.Close();
                MessageBox.Show("Finished exporting.", "ScrObjAnalyzer", MessageBoxButtons.OK);
            }
        }

    }

    public class ListData
    {
        public int ID { get; set; }
        public int MyMix { get; set; }
        public int Track { get; set; }
        public int Type { get; set; }
        public int Tick { get; set; }
        public double Time { get; set; }
        public double StartPos { get; set; }
        public double EndPos { get; set; }
        public double Speed { get; set; }
        public int TickDistance { get; set; }
        public int EndType { get; set; }
        public byte[] NoteColor { get; set; }
        public List<double> SubPos { get; set; }
        public List<int> SubTick { get; set; }
        public List<byte[]> SubColor { get; set; }

        public ListData()
        {
            NoteColor = new byte[4] { 255, 255, 255, 255 };
            SubPos = new List<double>();
            SubTick = new List<int>();
            SubColor = new List<byte[]>(4);
        }
    }

    public class BPMData
    {
        public int Tick { get; set; }
        public double Time { get; set; }
        public double SecPerTick { get; set; }

        public BPMData()
        {

        }
    }
}
