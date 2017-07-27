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
            this.ModePanel.SuspendLayout();
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
            this.ModePanel.Location = new System.Drawing.Point(736, 150);
            this.ModePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ModePanel.Name = "ModePanel";
            this.ModePanel.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ModePanel.Size = new System.Drawing.Size(270, 236);
            this.ModePanel.TabIndex = 1;
            this.ModePanel.TabStop = false;
            this.ModePanel.Text = "Game Mode";
            // 
            // FilterBtn
            // 
            this.FilterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterBtn.Location = new System.Drawing.Point(6, 170);
            this.FilterBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(258, 58);
            this.FilterBtn.TabIndex = 4;
            this.FilterBtn.Text = "Reload";
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // Mix2P
            // 
            this.Mix2P.AutoSize = true;
            this.Mix2P.Location = new System.Drawing.Point(7, 52);
            this.Mix2P.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Mix2P.Name = "Mix2P";
            this.Mix2P.Size = new System.Drawing.Size(113, 19);
            this.Mix2P.TabIndex = 3;
            this.Mix2P.TabStop = true;
            this.Mix2P.Text = "2Mix+ [3, 4]";
            this.Mix2P.UseVisualStyleBackColor = true;
            // 
            // Mix2
            // 
            this.Mix2.AutoSize = true;
            this.Mix2.Location = new System.Drawing.Point(7, 25);
            this.Mix2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Mix2.Name = "Mix2";
            this.Mix2.Size = new System.Drawing.Size(105, 19);
            this.Mix2.TabIndex = 2;
            this.Mix2.TabStop = true;
            this.Mix2.Text = "2Mix [1, 2]";
            this.Mix2.UseVisualStyleBackColor = true;
            // 
            // Mix4
            // 
            this.Mix4.AutoSize = true;
            this.Mix4.Location = new System.Drawing.Point(7, 80);
            this.Mix4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Mix4.Name = "Mix4";
            this.Mix4.Size = new System.Drawing.Size(165, 19);
            this.Mix4.TabIndex = 2;
            this.Mix4.TabStop = true;
            this.Mix4.Text = "4Mix [9, 10, 11, 12]";
            this.Mix4.UseVisualStyleBackColor = true;
            // 
            // MixM
            // 
            this.MixM.AutoSize = true;
            this.MixM.Location = new System.Drawing.Point(7, 135);
            this.MixM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MixM.Name = "MixM";
            this.MixM.Size = new System.Drawing.Size(263, 19);
            this.MixM.TabIndex = 1;
            this.MixM.TabStop = true;
            this.MixM.Text = "Million Mix [31, 32, 33, 34, 35, 36]";
            this.MixM.UseVisualStyleBackColor = true;
            // 
            // Mix6
            // 
            this.Mix6.AutoSize = true;
            this.Mix6.Location = new System.Drawing.Point(7, 108);
            this.Mix6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Mix6.Name = "Mix6";
            this.Mix6.Size = new System.Drawing.Size(225, 19);
            this.Mix6.TabIndex = 0;
            this.Mix6.TabStop = true;
            this.Mix6.Text = "6Mix [25, 26, 27, 28, 29, 30]";
            this.Mix6.UseVisualStyleBackColor = true;
            // 
            // LoadBtn
            // 
            this.LoadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadBtn.Location = new System.Drawing.Point(736, 15);
            this.LoadBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(270, 58);
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
            this.Type,
            this.StartPos,
            this.EndPos,
            this.Speed,
            this.EndType});
            this.TextList.GridLines = true;
            this.TextList.Location = new System.Drawing.Point(14, 15);
            this.TextList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextList.MultiSelect = false;
            this.TextList.Name = "TextList";
            this.TextList.Size = new System.Drawing.Size(716, 436);
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
            this.Time.Width = 150;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Type.Width = 70;
            // 
            // StartPos
            // 
            this.StartPos.Text = "StartPos";
            this.StartPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.StartPos.Width = 70;
            // 
            // EndPos
            // 
            this.EndPos.Text = "EndPos";
            this.EndPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EndPos.Width = 70;
            // 
            // Speed
            // 
            this.Speed.Text = "Speed";
            this.Speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Speed.Width = 70;
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
            this.ReshowBtn.Location = new System.Drawing.Point(736, 81);
            this.ReshowBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReshowBtn.Name = "ReshowBtn";
            this.ReshowBtn.Size = new System.Drawing.Size(270, 58);
            this.ReshowBtn.TabIndex = 5;
            this.ReshowBtn.Text = "Reshow all";
            this.ReshowBtn.UseVisualStyleBackColor = true;
            this.ReshowBtn.Click += new System.EventHandler(this.ReshowBtn_Click);
            // 
            // ExportBtn
            // 
            this.ExportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportBtn.Location = new System.Drawing.Point(736, 393);
            this.ExportBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(270, 58);
            this.ExportBtn.TabIndex = 7;
            this.ExportBtn.Text = "Export as TWx";
            this.ExportBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 467);
            this.Controls.Add(this.ExportBtn);
            this.Controls.Add(this.ReshowBtn);
            this.Controls.Add(this.TextList);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.ModePanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1036, 514);
            this.Name = "Form1";
            this.Text = "ScrObjAnalyzer 1.0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ModePanel.ResumeLayout(false);
            this.ModePanel.PerformLayout();
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
    }
}

