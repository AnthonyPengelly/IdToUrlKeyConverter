namespace UrlConverter
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
            this.convertButton = new System.Windows.Forms.Button();
            this.inputFileTextBox = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputFileLabel = new System.Windows.Forms.Label();
            this.outputDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.inputBrowseButton = new System.Windows.Forms.Button();
            this.outputBrowseButton = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.eventRadioButton = new System.Windows.Forms.RadioButton();
            this.actRadioButton = new System.Windows.Forms.RadioButton();
            this.seriesRadioButton = new System.Windows.Forms.RadioButton();
            this.coverageRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Enabled = false;
            this.convertButton.Location = new System.Drawing.Point(768, 283);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(118, 86);
            this.convertButton.TabIndex = 0;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // inputFileTextBox
            // 
            this.inputFileTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.inputFileTextBox.Location = new System.Drawing.Point(198, 100);
            this.inputFileTextBox.Name = "inputFileTextBox";
            this.inputFileTextBox.ReadOnly = true;
            this.inputFileTextBox.Size = new System.Drawing.Size(520, 31);
            this.inputFileTextBox.TabIndex = 1;
            this.inputFileTextBox.TextChanged += new System.EventHandler(this.inputFileTextBox_TextChanged);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(84, 103);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(108, 25);
            this.inputLabel.TabIndex = 2;
            this.inputLabel.Text = "Input CSV";
            // 
            // outputFileLabel
            // 
            this.outputFileLabel.AutoSize = true;
            this.outputFileLabel.Location = new System.Drawing.Point(24, 171);
            this.outputFileLabel.Name = "outputFileLabel";
            this.outputFileLabel.Size = new System.Drawing.Size(168, 25);
            this.outputFileLabel.TabIndex = 4;
            this.outputFileLabel.Text = "Output Directory";
            // 
            // outputDirectoryTextBox
            // 
            this.outputDirectoryTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.outputDirectoryTextBox.Location = new System.Drawing.Point(198, 171);
            this.outputDirectoryTextBox.Name = "outputDirectoryTextBox";
            this.outputDirectoryTextBox.ReadOnly = true;
            this.outputDirectoryTextBox.Size = new System.Drawing.Size(520, 31);
            this.outputDirectoryTextBox.TabIndex = 3;
            this.outputDirectoryTextBox.TextChanged += new System.EventHandler(this.outputDirectoryTextBox_TextChanged);
            // 
            // inputBrowseButton
            // 
            this.inputBrowseButton.Location = new System.Drawing.Point(768, 83);
            this.inputBrowseButton.Name = "inputBrowseButton";
            this.inputBrowseButton.Size = new System.Drawing.Size(118, 65);
            this.inputBrowseButton.TabIndex = 5;
            this.inputBrowseButton.Text = "Browse";
            this.inputBrowseButton.UseVisualStyleBackColor = true;
            this.inputBrowseButton.Click += new System.EventHandler(this.inputBrowseButton_Click);
            // 
            // outputBrowseButton
            // 
            this.outputBrowseButton.Location = new System.Drawing.Point(768, 157);
            this.outputBrowseButton.Name = "outputBrowseButton";
            this.outputBrowseButton.Size = new System.Drawing.Size(118, 59);
            this.outputBrowseButton.TabIndex = 6;
            this.outputBrowseButton.Text = "Browse";
            this.outputBrowseButton.UseVisualStyleBackColor = true;
            this.outputBrowseButton.Click += new System.EventHandler(this.outputBrowseButton_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(83, 234);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(109, 25);
            this.fileNameLabel.TabIndex = 8;
            this.fileNameLabel.Text = "File Name";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileNameTextBox.Location = new System.Drawing.Point(198, 231);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(388, 31);
            this.fileNameTextBox.TabIndex = 7;
            this.fileNameTextBox.TextChanged += new System.EventHandler(this.fileNameTextBox_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "CSV Files|*.csv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Upload a csv containing only the ids, 1 per line";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(517, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "(this can be done by saving an Excel sheet as a csv)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(610, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = ".csv";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.coverageRadioButton);
            this.panel1.Controls.Add(this.seriesRadioButton);
            this.panel1.Controls.Add(this.actRadioButton);
            this.panel1.Controls.Add(this.eventRadioButton);
            this.panel1.Location = new System.Drawing.Point(12, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 100);
            this.panel1.TabIndex = 12;
            // 
            // eventRadioButton
            // 
            this.eventRadioButton.AutoSize = true;
            this.eventRadioButton.Checked = true;
            this.eventRadioButton.Location = new System.Drawing.Point(17, 57);
            this.eventRadioButton.Name = "eventRadioButton";
            this.eventRadioButton.Size = new System.Drawing.Size(138, 29);
            this.eventRadioButton.TabIndex = 0;
            this.eventRadioButton.Text = "Event (\'e\')";
            this.eventRadioButton.UseVisualStyleBackColor = true;
            // 
            // actRadioButton
            // 
            this.actRadioButton.AutoSize = true;
            this.actRadioButton.Location = new System.Drawing.Point(170, 57);
            this.actRadioButton.Name = "actRadioButton";
            this.actRadioButton.Size = new System.Drawing.Size(114, 29);
            this.actRadioButton.TabIndex = 1;
            this.actRadioButton.Text = "Act (\'a\')";
            this.actRadioButton.UseVisualStyleBackColor = true;
            // 
            // seriesRadioButton
            // 
            this.seriesRadioButton.AutoSize = true;
            this.seriesRadioButton.Location = new System.Drawing.Point(290, 57);
            this.seriesRadioButton.Name = "seriesRadioButton";
            this.seriesRadioButton.Size = new System.Drawing.Size(139, 29);
            this.seriesRadioButton.TabIndex = 2;
            this.seriesRadioButton.Text = "Series (\'r\')";
            this.seriesRadioButton.UseVisualStyleBackColor = true;
            // 
            // coverageRadioButton
            // 
            this.coverageRadioButton.AutoSize = true;
            this.coverageRadioButton.Location = new System.Drawing.Point(435, 57);
            this.coverageRadioButton.Name = "coverageRadioButton";
            this.coverageRadioButton.Size = new System.Drawing.Size(221, 29);
            this.coverageRadioButton.TabIndex = 3;
            this.coverageRadioButton.Text = "Live Coverage (\'c\')";
            this.coverageRadioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Prefix";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 403);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.outputBrowseButton);
            this.Controls.Add(this.inputBrowseButton);
            this.Controls.Add(this.outputFileLabel);
            this.Controls.Add(this.outputDirectoryTextBox);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.inputFileTextBox);
            this.Controls.Add(this.convertButton);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "EAVIS URL Converter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox inputFileTextBox;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputFileLabel;
        private System.Windows.Forms.TextBox outputDirectoryTextBox;
        private System.Windows.Forms.Button inputBrowseButton;
        private System.Windows.Forms.Button outputBrowseButton;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton coverageRadioButton;
        private System.Windows.Forms.RadioButton seriesRadioButton;
        private System.Windows.Forms.RadioButton actRadioButton;
        private System.Windows.Forms.RadioButton eventRadioButton;
    }
}

