namespace StackingPics
{
    partial class StartingQuery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupQueryData = new System.Windows.Forms.GroupBox();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.textLotIDs = new System.Windows.Forms.TextBox();
            this.labelLine = new System.Windows.Forms.Label();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.dataLotPath = new System.Windows.Forms.DataGridView();
            this.comboLines = new System.Windows.Forms.ComboBox();
            this.groupQueryData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLotPath)).BeginInit();
            this.SuspendLayout();
            // 
            // groupQueryData
            // 
            this.groupQueryData.Controls.Add(this.buttonClearAll);
            this.groupQueryData.Controls.Add(this.textLotIDs);
            this.groupQueryData.Controls.Add(this.comboLines);
            this.groupQueryData.Controls.Add(this.labelLine);
            this.groupQueryData.Controls.Add(this.buttonQuery);
            this.groupQueryData.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupQueryData.Location = new System.Drawing.Point(12, 31);
            this.groupQueryData.Name = "groupQueryData";
            this.groupQueryData.Size = new System.Drawing.Size(633, 261);
            this.groupQueryData.TabIndex = 7;
            this.groupQueryData.TabStop = false;
            this.groupQueryData.Text = "查詢功能";
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(281, 37);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(88, 29);
            this.buttonClearAll.TabIndex = 7;
            this.buttonClearAll.Text = "清除資料";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            // 
            // textLotIDs
            // 
            this.textLotIDs.Location = new System.Drawing.Point(10, 78);
            this.textLotIDs.Multiline = true;
            this.textLotIDs.Name = "textLotIDs";
            this.textLotIDs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textLotIDs.Size = new System.Drawing.Size(609, 174);
            this.textLotIDs.TabIndex = 6;
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.Location = new System.Drawing.Point(6, 40);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(46, 21);
            this.labelLine.TabIndex = 2;
            this.labelLine.Text = "線別:";
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(179, 35);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(97, 32);
            this.buttonQuery.TabIndex = 0;
            this.buttonQuery.Text = "執行[查詢]";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelTitle.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTitle.Location = new System.Drawing.Point(235, 2);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(180, 26);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "線別疊圖位置查詢";
            // 
            // dataLotPath
            // 
            this.dataLotPath.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataLotPath.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLotPath.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataLotPath.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataLotPath.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataLotPath.Location = new System.Drawing.Point(12, 298);
            this.dataLotPath.Name = "dataLotPath";
            this.dataLotPath.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLotPath.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataLotPath.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataLotPath.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataLotPath.RowTemplate.Height = 24;
            this.dataLotPath.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLotPath.Size = new System.Drawing.Size(625, 226);
            this.dataLotPath.TabIndex = 8;
            // 
            // comboLines
            // 
            this.comboLines.FormattingEnabled = true;
            this.comboLines.Location = new System.Drawing.Point(58, 37);
            this.comboLines.Name = "comboLines";
            this.comboLines.Size = new System.Drawing.Size(111, 29);
            this.comboLines.TabIndex = 3;
            // 
            // StartingQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 533);
            this.Controls.Add(this.groupQueryData);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dataLotPath);
            this.Name = "StartingQuery";
            this.Text = "                      Starting Query";
            this.Load += new System.EventHandler(this.StartingQuery_Load);
            this.groupQueryData.ResumeLayout(false);
            this.groupQueryData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLotPath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupQueryData;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.TextBox textLotIDs;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataLotPath;
        private System.Windows.Forms.ComboBox comboLines;

    }
}