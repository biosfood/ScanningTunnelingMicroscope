namespace ScanningTunnelingMicroscope {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.devices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshDevicesButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.maxValueSlider = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minValueSlider = new System.Windows.Forms.TrackBar();
            this.output = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.maxValueSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minValueSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // devices
            // 
            this.devices.AllowDrop = true;
            this.devices.FormattingEnabled = true;
            this.devices.Location = new System.Drawing.Point(15, 54);
            this.devices.Name = "devices";
            this.devices.Size = new System.Drawing.Size(121, 21);
            this.devices.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "available devices:";
            // 
            // refreshDevicesButton
            // 
            this.refreshDevicesButton.Location = new System.Drawing.Point(15, 25);
            this.refreshDevicesButton.Name = "refreshDevicesButton";
            this.refreshDevicesButton.Size = new System.Drawing.Size(75, 23);
            this.refreshDevicesButton.TabIndex = 2;
            this.refreshDevicesButton.Text = "Refresh";
            this.refreshDevicesButton.UseVisualStyleBackColor = true;
            this.refreshDevicesButton.Click += new System.EventHandler(this.refreshDevicesButtonClick);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(15, 81);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 3;
            this.testButton.Text = "test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButtonClick);
            // 
            // maxValueSlider
            // 
            this.maxValueSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxValueSlider.Location = new System.Drawing.Point(605, 25);
            this.maxValueSlider.Minimum = -10;
            this.maxValueSlider.Name = "maxValueSlider";
            this.maxValueSlider.Size = new System.Drawing.Size(183, 45);
            this.maxValueSlider.TabIndex = 4;
            this.maxValueSlider.Value = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(696, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "max value:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(720, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "min value:";
            // 
            // minValueSlider
            // 
            this.minValueSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minValueSlider.Location = new System.Drawing.Point(605, 89);
            this.minValueSlider.Minimum = -10;
            this.minValueSlider.Name = "minValueSlider";
            this.minValueSlider.Size = new System.Drawing.Size(183, 45);
            this.minValueSlider.TabIndex = 6;
            this.minValueSlider.Value = -5;
            // 
            // output
            // 
            this.output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.output.Location = new System.Drawing.Point(12, 140);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(776, 298);
            this.output.TabIndex = 8;
            this.output.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minValueSlider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maxValueSlider);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.refreshDevicesButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.devices);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "STM microscope interface";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maxValueSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minValueSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox devices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refreshDevicesButton;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.TrackBar maxValueSlider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar minValueSlider;
        private System.Windows.Forms.RichTextBox output;
    }
}

