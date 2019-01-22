namespace VLCRecording
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
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.btnContinousRecording = new System.Windows.Forms.Button();
            this.lblCR2 = new System.Windows.Forms.Label();
            this.txt_ContiunesRecordingMints = new System.Windows.Forms.TextBox();
            this.lblCR1 = new System.Windows.Forms.Label();
            this.cmbRecordContinues = new System.Windows.Forms.CheckBox();
            this.btnStopRecording = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.Location = new System.Drawing.Point(27, 79);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(636, 358);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 0;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("vlcControl1.VlcLibDirectory")));
            this.vlcControl1.VlcMediaplayerOptions = null;
            // 
            // btnContinousRecording
            // 
            this.btnContinousRecording.Location = new System.Drawing.Point(334, 39);
            this.btnContinousRecording.Name = "btnContinousRecording";
            this.btnContinousRecording.Size = new System.Drawing.Size(66, 24);
            this.btnContinousRecording.TabIndex = 50;
            this.btnContinousRecording.TabStop = false;
            this.btnContinousRecording.Text = "Record";
            this.btnContinousRecording.UseVisualStyleBackColor = true;
            this.btnContinousRecording.Click += new System.EventHandler(this.btnContinousRecording_Click);
            // 
            // lblCR2
            // 
            this.lblCR2.AutoSize = true;
            this.lblCR2.Location = new System.Drawing.Point(301, 45);
            this.lblCR2.Name = "lblCR2";
            this.lblCR2.Size = new System.Drawing.Size(31, 13);
            this.lblCR2.TabIndex = 49;
            this.lblCR2.Text = "mints";
            // 
            // txt_ContiunesRecordingMints
            // 
            this.txt_ContiunesRecordingMints.Location = new System.Drawing.Point(242, 43);
            this.txt_ContiunesRecordingMints.Name = "txt_ContiunesRecordingMints";
            this.txt_ContiunesRecordingMints.Size = new System.Drawing.Size(54, 20);
            this.txt_ContiunesRecordingMints.TabIndex = 48;
            // 
            // lblCR1
            // 
            this.lblCR1.AutoSize = true;
            this.lblCR1.Location = new System.Drawing.Point(173, 46);
            this.lblCR1.Name = "lblCR1";
            this.lblCR1.Size = new System.Drawing.Size(71, 13);
            this.lblCR1.TabIndex = 46;
            this.lblCR1.Text = "Overide after ";
            // 
            // cmbRecordContinues
            // 
            this.cmbRecordContinues.AutoSize = true;
            this.cmbRecordContinues.Location = new System.Drawing.Point(169, 22);
            this.cmbRecordContinues.Name = "cmbRecordContinues";
            this.cmbRecordContinues.Size = new System.Drawing.Size(131, 17);
            this.cmbRecordContinues.TabIndex = 47;
            this.cmbRecordContinues.Text = "Continuous Recording";
            this.cmbRecordContinues.UseVisualStyleBackColor = true;
            // 
            // btnStopRecording
            // 
            this.btnStopRecording.Location = new System.Drawing.Point(406, 40);
            this.btnStopRecording.Name = "btnStopRecording";
            this.btnStopRecording.Size = new System.Drawing.Size(51, 24);
            this.btnStopRecording.TabIndex = 51;
            this.btnStopRecording.TabStop = false;
            this.btnStopRecording.Text = "Stop";
            this.btnStopRecording.UseVisualStyleBackColor = true;
            this.btnStopRecording.Click += new System.EventHandler(this.btnStopRecording_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 472);
            this.Controls.Add(this.btnStopRecording);
            this.Controls.Add(this.btnContinousRecording);
            this.Controls.Add(this.lblCR2);
            this.Controls.Add(this.txt_ContiunesRecordingMints);
            this.Controls.Add(this.lblCR1);
            this.Controls.Add(this.cmbRecordContinues);
            this.Controls.Add(this.vlcControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private System.Windows.Forms.Button btnContinousRecording;
        private System.Windows.Forms.Label lblCR2;
        private System.Windows.Forms.TextBox txt_ContiunesRecordingMints;
        private System.Windows.Forms.Label lblCR1;
        private System.Windows.Forms.CheckBox cmbRecordContinues;
        private System.Windows.Forms.Button btnStopRecording;
    }
}

