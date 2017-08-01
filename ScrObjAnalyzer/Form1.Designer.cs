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
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartPos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndPos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Speed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.ReshowBtn = new System.Windows.Forms.Button();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.ExportDialog = new System.Windows.Forms.SaveFileDialog();
            this.ExportBox = new System.Windows.Forms.GroupBox();
            this.ExpColorBox = new System.Windows.Forms.GroupBox();
            this.ColorA = new System.Windows.Forms.NumericUpDown();
            this.ColorB = new System.Windows.Forms.NumericUpDown();
            this.ColorG = new System.Windows.Forms.NumericUpDown();
            this.ColorR = new System.Windows.Forms.NumericUpDown();
            this.Tick = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModePanel.SuspendLayout();
            this.ExportBox.SuspendLayout();
            this.ExpColorBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorR)).BeginInit();
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
            this.ModePanel.Location = new System.Drawing.Point(636, 120);
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
            this.LoadBtn.Location = new System.Drawing.Point(636, 12);
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
            this.EndType});
            this.TextList.GridLines = true;
            this.TextList.Location = new System.Drawing.Point(12, 12);
            this.TextList.MultiSelect = false;
            this.TextList.Name = "TextList";
            this.TextList.Size = new System.Drawing.Size(618, 427);
            this.TextList.TabIndex = 6;
            this.TextList.UseCompatibleStateImageBehavior = false;
            this.TextList.View = System.Windows.Forms.View.Details;
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
            this.EndType.Width = 70;
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
            this.ReshowBtn.Location = new System.Drawing.Point(636, 65);
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
            this.ExportBtn.Location = new System.Drawing.Point(6, 74);
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
            this.ExportBox.Controls.Add(this.ExpColorBox);
            this.ExportBox.Controls.Add(this.ExportBtn);
            this.ExportBox.Location = new System.Drawing.Point(636, 315);
            this.ExportBox.Name = "ExportBox";
            this.ExportBox.Size = new System.Drawing.Size(236, 126);
            this.ExportBox.TabIndex = 8;
            this.ExportBox.TabStop = false;
            this.ExportBox.Text = "Export setting";
            // 
            // ExpColorBox
            // 
            this.ExpColorBox.Controls.Add(this.ColorA);
            this.ExpColorBox.Controls.Add(this.ColorB);
            this.ExpColorBox.Controls.Add(this.ColorG);
            this.ExpColorBox.Controls.Add(this.ColorR);
            this.ExpColorBox.Location = new System.Drawing.Point(7, 21);
            this.ExpColorBox.Name = "ExpColorBox";
            this.ExpColorBox.Size = new System.Drawing.Size(223, 47);
            this.ExpColorBox.TabIndex = 8;
            this.ExpColorBox.TabStop = false;
            this.ExpColorBox.Text = "Color (R, G, B, A)";
            // 
            // ColorA
            // 
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
            // 
            // Tick
            // 
            this.Tick.Text = "Tick";
            this.Tick.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Tick.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 451);
            this.Controls.Add(this.ExportBox);
            this.Controls.Add(this.ReshowBtn);
            this.Controls.Add(this.TextList);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.ModePanel);
            this.MinimumSize = new System.Drawing.Size(900, 490);
            this.Name = "Form1";
            this.Text = "ScrObjAnalyzer 1.2.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ModePanel.ResumeLayout(false);
            this.ModePanel.PerformLayout();
            this.ExportBox.ResumeLayout(false);
            this.ExpColorBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ColorA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorR)).EndInit();
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
    }
}

