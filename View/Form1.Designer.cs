namespace NoteCuoiKyWF.View
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.btShowNote = new System.Windows.Forms.Button();
            this.btSeacrh = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnaddNote = new System.Windows.Forms.Button();
            this.fpnButton = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1169, 628);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1169, 653);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbSearch);
            this.splitContainer1.Panel1.Controls.Add(this.btShowNote);
            this.splitContainer1.Panel1.Controls.Add(this.btSeacrh);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
            this.splitContainer1.Panel1.Controls.Add(this.btnaddNote);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.fpnButton);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(1169, 628);
            this.splitContainer1.SplitterDistance = 40;
            this.splitContainer1.TabIndex = 0;
            // 
            // cbSearch
            // 
            this.cbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbSearch.Items.AddRange(new object[] {
            "ID",
            "TITLE",
            "DESCRIPTION",
            "TAG"});
            this.cbSearch.Location = new System.Drawing.Point(661, 6);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(121, 30);
            this.cbSearch.TabIndex = 4;
            // 
            // btShowNote
            // 
            this.btShowNote.Location = new System.Drawing.Point(14, 5);
            this.btShowNote.Name = "btShowNote";
            this.btShowNote.Size = new System.Drawing.Size(200, 32);
            this.btShowNote.TabIndex = 3;
            this.btShowNote.Text = "NOTE OF YOU";
            this.btShowNote.UseVisualStyleBackColor = true;
            this.btShowNote.Click += new System.EventHandler(this.btShowNote_Click);
            // 
            // btSeacrh
            // 
            this.btSeacrh.Location = new System.Drawing.Point(787, 4);
            this.btSeacrh.Name = "btSeacrh";
            this.btSeacrh.Size = new System.Drawing.Size(180, 32);
            this.btSeacrh.TabIndex = 2;
            this.btSeacrh.Text = "Search";
            this.btSeacrh.UseVisualStyleBackColor = true;
            this.btSeacrh.Click += new System.EventHandler(this.btSeacrh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(220, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(434, 30);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnaddNote
            // 
            this.btnaddNote.Location = new System.Drawing.Point(974, 4);
            this.btnaddNote.Name = "btnaddNote";
            this.btnaddNote.Size = new System.Drawing.Size(180, 32);
            this.btnaddNote.TabIndex = 0;
            this.btnaddNote.Text = "+ ADD NEW NOTE";
            this.btnaddNote.UseVisualStyleBackColor = true;
            this.btnaddNote.Click += new System.EventHandler(this.addNote_Click);
            // 
            // fpnButton
            // 
            this.fpnButton.AutoScroll = true;
            this.fpnButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fpnButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnButton.Location = new System.Drawing.Point(0, 0);
            this.fpnButton.Name = "fpnButton";
            this.fpnButton.Size = new System.Drawing.Size(1169, 562);
            this.fpnButton.TabIndex = 1;
            this.fpnButton.Paint += new System.Windows.Forms.PaintEventHandler(this.fpnButton_Paint);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 562);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1169, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 653);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NOTE";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnaddNote;
        private System.Windows.Forms.FlowLayoutPanel fpnButton;
        private System.Windows.Forms.Button btSeacrh;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btShowNote;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

