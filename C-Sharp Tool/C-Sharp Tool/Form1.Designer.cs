namespace C_Sharp_Tool
{
	partial class formMmaakpe
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.main_Menu1 = new C_Sharp_Tool.Main_Menu();
            this.SuspendLayout();
            // 
            // main_Menu1
            // 
            this.main_Menu1.Location = new System.Drawing.Point(-8, -30);
            this.main_Menu1.Name = "main_Menu1";
            this.main_Menu1.Size = new System.Drawing.Size(1560, 830);
            this.main_Menu1.TabIndex = 0;
            // 
            // formMmaakpe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 792);
            this.Controls.Add(this.main_Menu1);
            this.Name = "formMmaakpe";
            this.Text = "Form1";
            this.ResumeLayout(false);

		}

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private Main_Menu main_Menu1;
    }
}

