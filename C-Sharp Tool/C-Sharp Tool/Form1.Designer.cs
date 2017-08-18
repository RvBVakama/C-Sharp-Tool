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
            this.ucMainMenu = new C_Sharp_Tool.Main_Menu();
            this.ucMapCreation = new C_Sharp_Tool.Map_Creation();
            this.SuspendLayout();
            // 
            // ucMainMenu
            // 
            this.ucMainMenu.Location = new System.Drawing.Point(-8, -30);
            this.ucMainMenu.Name = "ucMainMenu";
            this.ucMainMenu.Size = new System.Drawing.Size(1560, 830);
            this.ucMainMenu.TabIndex = 0;
            this.ucMainMenu.Load += new System.EventHandler(this.main_Menu1_Load);
            // 
            // ucMapCreation
            // 
            this.ucMapCreation.Location = new System.Drawing.Point(-8, 2);
            this.ucMapCreation.Name = "ucMapCreation";
            this.ucMapCreation.Size = new System.Drawing.Size(1560, 830);
            this.ucMapCreation.TabIndex = 1;
            // 
            // formMmaakpe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 792);
            this.Controls.Add(this.ucMainMenu);
            this.Controls.Add(this.ucMapCreation);
            this.Name = "formMmaakpe";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formMmaakpe_Load);
            this.ResumeLayout(false);

		}

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private Map_Creation ucMapCreation;
        private Main_Menu ucMainMenu;
    }
}

