
namespace FileSystemVisitor
{
    partial class FileSystemVisitorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.fileSystemPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.traversionStatusMessage = new System.Windows.Forms.Label();
            this.traversionStatusFiles = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.FolderChooseButton = new System.Windows.Forms.Button();
            this.chosenFolder = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox);
            this.panel1.Controls.Add(this.RefreshButton);
            this.panel1.Controls.Add(this.FolderChooseButton);
            this.panel1.Controls.Add(this.chosenFolder);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 460);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Location = new System.Drawing.Point(12, 115);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.fileSystemPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.traversionStatusMessage);
            this.splitContainer1.Panel2.Controls.Add(this.traversionStatusFiles);
            this.splitContainer1.Size = new System.Drawing.Size(908, 342);
            this.splitContainer1.SplitterDistance = 541;
            this.splitContainer1.TabIndex = 11;
            // 
            // fileSystemPanel
            // 
            this.fileSystemPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileSystemPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fileSystemPanel.Location = new System.Drawing.Point(0, 0);
            this.fileSystemPanel.Name = "fileSystemPanel";
            this.fileSystemPanel.Size = new System.Drawing.Size(541, 342);
            this.fileSystemPanel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Статус обработки";
            this.label3.Visible = false;
            // 
            // traversionStatusMessage
            // 
            this.traversionStatusMessage.AutoSize = true;
            this.traversionStatusMessage.Location = new System.Drawing.Point(19, 42);
            this.traversionStatusMessage.Name = "traversionStatusMessage";
            this.traversionStatusMessage.Size = new System.Drawing.Size(107, 20);
            this.traversionStatusMessage.TabIndex = 10;
            this.traversionStatusMessage.Text = "StatusMessage";
            // 
            // traversionStatusFiles
            // 
            this.traversionStatusFiles.AutoSize = true;
            this.traversionStatusFiles.Location = new System.Drawing.Point(19, 94);
            this.traversionStatusFiles.Name = "traversionStatusFiles";
            this.traversionStatusFiles.Size = new System.Drawing.Size(79, 20);
            this.traversionStatusFiles.TabIndex = 10;
            this.traversionStatusFiles.Text = "FoundFiles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "<= Введите регулярное выражение для фильтрации";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 82);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(293, 27);
            this.textBox.TabIndex = 7;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.RefreshButton.Image = global::FileSystemVisitor.Properties.Resources.refresh__1_;
            this.RefreshButton.Location = new System.Drawing.Point(266, 8);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(74, 28);
            this.RefreshButton.TabIndex = 4;
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // FolderChooseButton
            // 
            this.FolderChooseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderChooseButton.Location = new System.Drawing.Point(380, 8);
            this.FolderChooseButton.Name = "FolderChooseButton";
            this.FolderChooseButton.Size = new System.Drawing.Size(155, 28);
            this.FolderChooseButton.TabIndex = 2;
            this.FolderChooseButton.Text = "Выбрать папку";
            this.FolderChooseButton.UseVisualStyleBackColor = true;
            this.FolderChooseButton.Click += new System.EventHandler(this.FolderChooseButton_Click);
            // 
            // chosenFolder
            // 
            this.chosenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chosenFolder.AutoSize = true;
            this.chosenFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chosenFolder.Location = new System.Drawing.Point(380, 45);
            this.chosenFolder.Name = "chosenFolder";
            this.chosenFolder.Size = new System.Drawing.Size(138, 20);
            this.chosenFolder.TabIndex = 1;
            this.chosenFolder.Text = "Выбранная папка";
            this.chosenFolder.Visible = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(932, 75);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // FileSystemVisitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 460);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "FileSystemVisitorForm";
            this.Text = "FileSystemVisitor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button FolderChooseButton;
        private System.Windows.Forms.Label chosenFolder;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.FlowLayoutPanel fileSystemPanel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label traversionStatusMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label traversionStatusFiles;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

