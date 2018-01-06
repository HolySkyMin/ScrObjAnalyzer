namespace ScrObjAnalyzer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ModePanel = new System.Windows.Forms.GroupBox();
            this.FilterBtn = new System.Windows.Forms.Button();
            this.Mix2P = new System.Windows.Forms.RadioButton();
            this.Mix2 = new System.Windows.Forms.RadioButton();
            this.Mix4 = new System.Windows.Forms.RadioButton();
            this.MixM = new System.Windows.Forms.RadioButton();
            this.Mix6 = new System.Windows.Forms.RadioButton();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.TextList = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Track = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tick = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartPos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndPos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Speed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.ReshowBtn = new System.Windows.Forms.Button();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.ExportDialog = new System.Windows.Forms.SaveFileDialog();
            this.ExportBox = new System.Windows.Forms.GroupBox();
            this.MetadataBox = new System.Windows.Forms.GroupBox();
            this.DensityVal = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.LevelBox = new System.Windows.Forms.GroupBox();
            this.CustomLevelVal = new System.Windows.Forms.NumericUpDown();
            this.CustomRadio = new System.Windows.Forms.RadioButton();
            this.ApexRadio = new System.Windows.Forms.RadioButton();
            this.HardRadio = new System.Windows.Forms.RadioButton();
            this.NormalRadio = new System.Windows.Forms.RadioButton();
            this.EasyRadio = new System.Windows.Forms.RadioButton();
            this.Mapper = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Artist = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExpColorBox = new System.Windows.Forms.GroupBox();
            this.ApplyAllCheck = new System.Windows.Forms.CheckBox();
            this.ColorApplyBtn = new System.Windows.Forms.Button();
            this.Palette = new System.Windows.Forms.Panel();
            this.ColorA = new System.Windows.Forms.NumericUpDown();
            this.ColorB = new System.Windows.Forms.NumericUpDown();
            this.ColorG = new System.Windows.Forms.NumericUpDown();
            this.ColorR = new System.Windows.Forms.NumericUpDown();
            this.SelectedTargetBox = new System.Windows.Forms.GroupBox();
            this.SpecificNoteList = new System.Windows.Forms.ListView();
            this.State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NoteOrNot = new System.Windows.Forms.Label();
            this.ModePanel.SuspendLayout();
            this.ExportBox.SuspendLayout();
            this.MetadataBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DensityVal)).BeginInit();
            this.LevelBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomLevelVal)).BeginInit();
            this.ExpColorBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorR)).BeginInit();
            this.SelectedTargetBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModePanel
            // 
            this.ModePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModePanel.Controls.Add(this.FilterBtn);
            this.ModePanel.Controls.Add(this.Mix2P);
            this.ModePanel.Controls.Add(this.Mix2);
            this.ModePanel.Controls.Add(this.Mix4);
            this.ModePanel.Controls.Add(this.MixM);
            this.ModePanel.Controls.Add(this.Mix6);
            this.ModePanel.Location = new System.Drawing.Point(706, 116);
            this.ModePanel.Name = "ModePanel";
            this.ModePanel.Size = new System.Drawing.Size(236, 189);
            this.ModePanel.TabIndex = 1;
            this.ModePanel.TabStop = false;
            this.ModePanel.Text = "Game Mode";
            // 
            // FilterBtn
            // 
            this.FilterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterBtn.Enabled = false;
            this.FilterBtn.Location = new System.Drawing.Point(5, 136);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(226, 46);
            this.FilterBtn.TabIndex = 4;
            this.FilterBtn.Text = "Reload";
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // Mix2P
            // 
            this.Mix2P.AutoSize = true;
            this.Mix2P.Location = new System.Drawing.Point(6, 42);
            this.Mix2P.Name = "Mix2P";
            this.Mix2P.Size = new System.Drawing.Size(92, 16);
            this.Mix2P.TabIndex = 3;
            this.Mix2P.Text = "2Mix+ [3, 4]";
            this.Mix2P.UseVisualStyleBackColor = true;
            // 
            // Mix2
            // 
            this.Mix2.AutoSize = true;
            this.Mix2.Location = new System.Drawing.Point(6, 20);
            this.Mix2.Name = "Mix2";
            this.Mix2.Size = new System.Drawing.Size(86, 16);
            this.Mix2.TabIndex = 2;
            this.Mix2.Text = "2Mix [1, 2]";
            this.Mix2.UseVisualStyleBackColor = true;
            // 
            // Mix4
            // 
            this.Mix4.AutoSize = true;
            this.Mix4.Location = new System.Drawing.Point(6, 64);
            this.Mix4.Name = "Mix4";
            this.Mix4.Size = new System.Drawing.Size(132, 16);
            this.Mix4.TabIndex = 2;
            this.Mix4.Text = "4Mix [9, 10, 11, 12]";
            this.Mix4.UseVisualStyleBackColor = true;
            // 
            // MixM
            // 
            this.MixM.AutoSize = true;
            this.MixM.Checked = true;
            this.MixM.Location = new System.Drawing.Point(6, 108);
            this.MixM.Name = "MixM";
            this.MixM.Size = new System.Drawing.Size(213, 16);
            this.MixM.TabIndex = 1;
            this.MixM.TabStop = true;
            this.MixM.Text = "Million Mix [31, 32, 33, 34, 35, 36]";
            this.MixM.UseVisualStyleBackColor = true;
            // 
            // Mix6
            // 
            this.Mix6.AutoSize = true;
            this.Mix6.Location = new System.Drawing.Point(6, 86);
            this.Mix6.Name = "Mix6";
            this.Mix6.Size = new System.Drawing.Size(178, 16);
            this.Mix6.TabIndex = 0;
            this.Mix6.Text = "6Mix [25, 26, 27, 28, 29, 30]";
            this.Mix6.UseVisualStyleBackColor = true;
            // 
            // LoadBtn
            // 
            this.LoadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadBtn.Location = new System.Drawing.Point(706, 12);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(236, 46);
            this.LoadBtn.TabIndex = 5;
            this.LoadBtn.Text = "Load file";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // TextList
            // 
            this.TextList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Track,
            this.Time,
            this.Tick,
            this.Type,
            this.StartPos,
            this.EndPos,
            this.Speed,
            this.EndType,
            this.Description});
            this.TextList.FullRowSelect = true;
            this.TextList.GridLines = true;
            this.TextList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.TextList.Location = new System.Drawing.Point(12, 12);
            this.TextList.MultiSelect = false;
            this.TextList.Name = "TextList";
            this.TextList.Size = new System.Drawing.Size(688, 787);
            this.TextList.TabIndex = 6;
            this.TextList.UseCompatibleStateImageBehavior = false;
            this.TextList.View = System.Windows.Forms.View.Details;
            this.TextList.SelectedIndexChanged += new System.EventHandler(this.TextList_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 40;
            // 
            // Track
            // 
            this.Track.Text = "Track";
            this.Track.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Track.Width = 50;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Time.Width = 140;
            // 
            // Tick
            // 
            this.Tick.Text = "Tick";
            this.Tick.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Tick.Width = 50;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // StartPos
            // 
            this.StartPos.Text = "StartPos";
            this.StartPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EndPos
            // 
            this.EndPos.Text = "EndPos";
            this.EndPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Speed
            // 
            this.Speed.Text = "Speed";
            this.Speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EndType
            // 
            this.EndType.Text = "EndType";
            this.EndType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EndType.Width = 65;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Description.Width = 79;
            // 
            // OpenDialog
            // 
            this.OpenDialog.DefaultExt = "txt";
            this.OpenDialog.FileName = "*";
            this.OpenDialog.Filter = "Text file (*.txt)|*.txt|All file|*.*";
            // 
            // ReshowBtn
            // 
            this.ReshowBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReshowBtn.Enabled = false;
            this.ReshowBtn.Location = new System.Drawing.Point(706, 64);
            this.ReshowBtn.Name = "ReshowBtn";
            this.ReshowBtn.Size = new System.Drawing.Size(236, 46);
            this.ReshowBtn.TabIndex = 5;
            this.ReshowBtn.Text = "Reshow all";
            this.ReshowBtn.UseVisualStyleBackColor = true;
            this.ReshowBtn.Click += new System.EventHandler(this.ReshowBtn_Click);
            // 
            // ExportBtn
            // 
            this.ExportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportBtn.Enabled = false;
            this.ExportBtn.Location = new System.Drawing.Point(6, 224);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(224, 46);
            this.ExportBtn.TabIndex = 7;
            this.ExportBtn.Text = "Export as TWx";
            this.ExportBtn.UseVisualStyleBackColor = true;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // ExportDialog
            // 
            this.ExportDialog.FileName = "New Beatmap";
            // 
            // ExportBox
            // 
            this.ExportBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportBox.Controls.Add(this.MetadataBox);
            this.ExportBox.Controls.Add(this.ExportBtn);
            this.ExportBox.Location = new System.Drawing.Point(706, 528);
            this.ExportBox.Name = "ExportBox";
            this.ExportBox.Size = new System.Drawing.Size(236, 276);
            this.ExportBox.TabIndex = 8;
            this.ExportBox.TabStop = false;
            this.ExportBox.Text = "Export setting";
            // 
            // MetadataBox
            // 
            this.MetadataBox.Controls.Add(this.DensityVal);
            this.MetadataBox.Controls.Add(this.label3);
            this.MetadataBox.Controls.Add(this.LevelBox);
            this.MetadataBox.Controls.Add(this.Mapper);
            this.MetadataBox.Controls.Add(this.label2);
            this.MetadataBox.Controls.Add(this.Artist);
            this.MetadataBox.Controls.Add(this.label1);
            this.MetadataBox.Location = new System.Drawing.Point(6, 20);
            this.MetadataBox.Name = "MetadataBox";
            this.MetadataBox.Size = new System.Drawing.Size(224, 197);
            this.MetadataBox.TabIndex = 8;
            this.MetadataBox.TabStop = false;
            this.MetadataBox.Text = "Metadata";
            // 
            // DensityVal
            // 
            this.DensityVal.Location = new System.Drawing.Point(127, 170);
            this.DensityVal.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.DensityVal.Name = "DensityVal";
            this.DensityVal.Size = new System.Drawing.Size(84, 21);
            this.DensityVal.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Density (Difficulty)";
            // 
            // LevelBox
            // 
            this.LevelBox.Controls.Add(this.CustomLevelVal);
            this.LevelBox.Controls.Add(this.CustomRadio);
            this.LevelBox.Controls.Add(this.ApexRadio);
            this.LevelBox.Controls.Add(this.HardRadio);
            this.LevelBox.Controls.Add(this.NormalRadio);
            this.LevelBox.Controls.Add(this.EasyRadio);
            this.LevelBox.Location = new System.Drawing.Point(6, 72);
            this.LevelBox.Name = "LevelBox";
            this.LevelBox.Size = new System.Drawing.Size(211, 92);
            this.LevelBox.TabIndex = 4;
            this.LevelBox.TabStop = false;
            this.LevelBox.Text = "Level";
            // 
            // CustomLevelVal
            // 
            this.CustomLevelVal.Location = new System.Drawing.Point(121, 64);
            this.CustomLevelVal.Name = "CustomLevelVal";
            this.CustomLevelVal.Size = new System.Drawing.Size(84, 21);
            this.CustomLevelVal.TabIndex = 5;
            // 
            // CustomRadio
            // 
            this.CustomRadio.AutoSize = true;
            this.CustomRadio.Location = new System.Drawing.Point(6, 64);
            this.CustomRadio.Name = "CustomRadio";
            this.CustomRadio.Size = new System.Drawing.Size(67, 16);
            this.CustomRadio.TabIndex = 4;
            this.CustomRadio.TabStop = true;
            this.CustomRadio.Text = "Custom";
            this.CustomRadio.UseVisualStyleBackColor = true;
            // 
            // ApexRadio
            // 
            this.ApexRadio.AutoSize = true;
            this.ApexRadio.Location = new System.Drawing.Point(121, 42);
            this.ApexRadio.Name = "ApexRadio";
            this.ApexRadio.Size = new System.Drawing.Size(72, 16);
            this.ApexRadio.TabIndex = 3;
            this.ApexRadio.TabStop = true;
            this.ApexRadio.Text = "Apex (4)";
            this.ApexRadio.UseVisualStyleBackColor = true;
            // 
            // HardRadio
            // 
            this.HardRadio.AutoSize = true;
            this.HardRadio.Location = new System.Drawing.Point(6, 42);
            this.HardRadio.Name = "HardRadio";
            this.HardRadio.Size = new System.Drawing.Size(69, 16);
            this.HardRadio.TabIndex = 2;
            this.HardRadio.TabStop = true;
            this.HardRadio.Text = "Hard (3)";
            this.HardRadio.UseVisualStyleBackColor = true;
            // 
            // NormalRadio
            // 
            this.NormalRadio.AutoSize = true;
            this.NormalRadio.Location = new System.Drawing.Point(121, 20);
            this.NormalRadio.Name = "NormalRadio";
            this.NormalRadio.Size = new System.Drawing.Size(84, 16);
            this.NormalRadio.TabIndex = 1;
            this.NormalRadio.TabStop = true;
            this.NormalRadio.Text = "Normal (2)";
            this.NormalRadio.UseVisualStyleBackColor = true;
            // 
            // EasyRadio
            // 
            this.EasyRadio.AutoSize = true;
            this.EasyRadio.Location = new System.Drawing.Point(6, 20);
            this.EasyRadio.Name = "EasyRadio";
            this.EasyRadio.Size = new System.Drawing.Size(72, 16);
            this.EasyRadio.TabIndex = 0;
            this.EasyRadio.TabStop = true;
            this.EasyRadio.Text = "Easy (1)";
            this.EasyRadio.UseVisualStyleBackColor = true;
            // 
            // Mapper
            // 
            this.Mapper.Location = new System.Drawing.Point(60, 45);
            this.Mapper.Name = "Mapper";
            this.Mapper.Size = new System.Drawing.Size(157, 21);
            this.Mapper.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mapper";
            // 
            // Artist
            // 
            this.Artist.Location = new System.Drawing.Point(60, 18);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(157, 21);
            this.Artist.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artist";
            // 
            // ExpColorBox
            // 
            this.ExpColorBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ExpColorBox.Controls.Add(this.ApplyAllCheck);
            this.ExpColorBox.Controls.Add(this.ColorApplyBtn);
            this.ExpColorBox.Controls.Add(this.Palette);
            this.ExpColorBox.Controls.Add(this.ColorA);
            this.ExpColorBox.Controls.Add(this.ColorB);
            this.ExpColorBox.Controls.Add(this.ColorG);
            this.ExpColorBox.Controls.Add(this.ColorR);
            this.ExpColorBox.Location = new System.Drawing.Point(7, 126);
            this.ExpColorBox.Name = "ExpColorBox";
            this.ExpColorBox.Size = new System.Drawing.Size(225, 79);
            this.ExpColorBox.TabIndex = 8;
            this.ExpColorBox.TabStop = false;
            this.ExpColorBox.Text = "Set color (R, G, B, A)";
            // 
            // ApplyAllCheck
            // 
            this.ApplyAllCheck.AutoSize = true;
            this.ApplyAllCheck.Location = new System.Drawing.Point(90, 53);
            this.ApplyAllCheck.Name = "ApplyAllCheck";
            this.ApplyAllCheck.Size = new System.Drawing.Size(73, 16);
            this.ApplyAllCheck.TabIndex = 14;
            this.ApplyAllCheck.Text = "All notes";
            this.ApplyAllCheck.UseVisualStyleBackColor = true;
            // 
            // ColorApplyBtn
            // 
            this.ColorApplyBtn.Location = new System.Drawing.Point(169, 48);
            this.ColorApplyBtn.Name = "ColorApplyBtn";
            this.ColorApplyBtn.Size = new System.Drawing.Size(48, 25);
            this.ColorApplyBtn.TabIndex = 13;
            this.ColorApplyBtn.Text = "Apply";
            this.ColorApplyBtn.UseVisualStyleBackColor = true;
            this.ColorApplyBtn.Click += new System.EventHandler(this.ColorApplyBtn_Click);
            // 
            // Palette
            // 
            this.Palette.BackColor = System.Drawing.Color.White;
            this.Palette.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Palette.Location = new System.Drawing.Point(7, 48);
            this.Palette.Name = "Palette";
            this.Palette.Size = new System.Drawing.Size(73, 25);
            this.Palette.TabIndex = 12;
            // 
            // ColorA
            // 
            this.ColorA.BackColor = System.Drawing.SystemColors.Window;
            this.ColorA.Location = new System.Drawing.Point(169, 20);
            this.ColorA.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ColorA.Name = "ColorA";
            this.ColorA.Size = new System.Drawing.Size(48, 21);
            this.ColorA.TabIndex = 11;
            this.ColorA.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ColorA.ValueChanged += new System.EventHandler(this.ColorChanged);
            // 
            // ColorB
            // 
            this.ColorB.Location = new System.Drawing.Point(115, 20);
            this.ColorB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ColorB.Name = "ColorB";
            this.ColorB.Size = new System.Drawing.Size(48, 21);
            this.ColorB.TabIndex = 10;
            this.ColorB.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ColorB.ValueChanged += new System.EventHandler(this.ColorChanged);
            // 
            // ColorG
            // 
            this.ColorG.Location = new System.Drawing.Point(60, 20);
            this.ColorG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ColorG.Name = "ColorG";
            this.ColorG.Size = new System.Drawing.Size(48, 21);
            this.ColorG.TabIndex = 9;
            this.ColorG.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ColorG.ValueChanged += new System.EventHandler(this.ColorChanged);
            // 
            // ColorR
            // 
            this.ColorR.Location = new System.Drawing.Point(6, 20);
            this.ColorR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ColorR.Name = "ColorR";
            this.ColorR.Size = new System.Drawing.Size(48, 21);
            this.ColorR.TabIndex = 0;
            this.ColorR.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ColorR.ValueChanged += new System.EventHandler(this.ColorChanged);
            // 
            // SelectedTargetBox
            // 
            this.SelectedTargetBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedTargetBox.Controls.Add(this.SpecificNoteList);
            this.SelectedTargetBox.Controls.Add(this.NoteOrNot);
            this.SelectedTargetBox.Controls.Add(this.ExpColorBox);
            this.SelectedTargetBox.Location = new System.Drawing.Point(706, 311);
            this.SelectedTargetBox.Name = "SelectedTargetBox";
            this.SelectedTargetBox.Size = new System.Drawing.Size(238, 211);
            this.SelectedTargetBox.TabIndex = 9;
            this.SelectedTargetBox.TabStop = false;
            this.SelectedTargetBox.Text = "Selected item";
            // 
            // SpecificNoteList
            // 
            this.SpecificNoteList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.State,
            this.EndLine,
            this.Color});
            this.SpecificNoteList.FullRowSelect = true;
            this.SpecificNoteList.GridLines = true;
            this.SpecificNoteList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.SpecificNoteList.Location = new System.Drawing.Point(6, 32);
            this.SpecificNoteList.Name = "SpecificNoteList";
            this.SpecificNoteList.Size = new System.Drawing.Size(224, 88);
            this.SpecificNoteList.TabIndex = 10;
            this.SpecificNoteList.UseCompatibleStateImageBehavior = false;
            this.SpecificNoteList.View = System.Windows.Forms.View.Details;
            // 
            // State
            // 
            this.State.Text = "State";
            this.State.Width = 50;
            // 
            // EndLine
            // 
            this.EndLine.Text = "End";
            this.EndLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EndLine.Width = 40;
            // 
            // Color
            // 
            this.Color.Text = "Color";
            this.Color.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Color.Width = 110;
            // 
            // NoteOrNot
            // 
            this.NoteOrNot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteOrNot.Location = new System.Drawing.Point(84, 17);
            this.NoteOrNot.Name = "NoteOrNot";
            this.NoteOrNot.Size = new System.Drawing.Size(148, 12);
            this.NoteOrNot.TabIndex = 9;
            this.NoteOrNot.Text = "Nothing selected.";
            this.NoteOrNot.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 811);
            this.Controls.Add(this.SelectedTargetBox);
            this.Controls.Add(this.ExportBox);
            this.Controls.Add(this.ReshowBtn);
            this.Controls.Add(this.TextList);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.ModePanel);
            this.MinimumSize = new System.Drawing.Size(970, 850);
            this.Name = "Form1";
            this.Text = "ScrObjAnalyzer 1.3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ModePanel.ResumeLayout(false);
            this.ModePanel.PerformLayout();
            this.ExportBox.ResumeLayout(false);
            this.MetadataBox.ResumeLayout(false);
            this.MetadataBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DensityVal)).EndInit();
            this.LevelBox.ResumeLayout(false);
            this.LevelBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomLevelVal)).EndInit();
            this.ExpColorBox.ResumeLayout(false);
            this.ExpColorBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorR)).EndInit();
            this.SelectedTargetBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox ModePanel;
        private System.Windows.Forms.RadioButton Mix2P;
        private System.Windows.Forms.RadioButton Mix2;
        private System.Windows.Forms.RadioButton Mix4;
        private System.Windows.Forms.RadioButton MixM;
        private System.Windows.Forms.RadioButton Mix6;
        private System.Windows.Forms.Button FilterBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.ListView TextList;
        private System.Windows.Forms.ColumnHeader Track;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader StartPos;
        private System.Windows.Forms.ColumnHeader EndPos;
        private System.Windows.Forms.ColumnHeader Speed;
        private System.Windows.Forms.ColumnHeader EndType;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.OpenFileDialog OpenDialog;
        private System.Windows.Forms.Button ReshowBtn;
        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.SaveFileDialog ExportDialog;
        private System.Windows.Forms.GroupBox ExportBox;
        private System.Windows.Forms.GroupBox ExpColorBox;
        private System.Windows.Forms.NumericUpDown ColorA;
        private System.Windows.Forms.NumericUpDown ColorB;
        private System.Windows.Forms.NumericUpDown ColorG;
        private System.Windows.Forms.NumericUpDown ColorR;
        private System.Windows.Forms.ColumnHeader Tick;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.GroupBox MetadataBox;
        private System.Windows.Forms.NumericUpDown DensityVal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox LevelBox;
        private System.Windows.Forms.NumericUpDown CustomLevelVal;
        private System.Windows.Forms.RadioButton CustomRadio;
        private System.Windows.Forms.RadioButton ApexRadio;
        private System.Windows.Forms.RadioButton HardRadio;
        private System.Windows.Forms.RadioButton NormalRadio;
        private System.Windows.Forms.RadioButton EasyRadio;
        private System.Windows.Forms.TextBox Mapper;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Artist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ColorApplyBtn;
        private System.Windows.Forms.Panel Palette;
        private System.Windows.Forms.GroupBox SelectedTargetBox;
        private System.Windows.Forms.ListView SpecificNoteList;
        private System.Windows.Forms.ColumnHeader State;
        private System.Windows.Forms.ColumnHeader EndLine;
        private System.Windows.Forms.ColumnHeader Color;
        private System.Windows.Forms.Label NoteOrNot;
        private System.Windows.Forms.CheckBox ApplyAllCheck;
    }
}

