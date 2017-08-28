namespace C_Sharp_Tool
{
	partial class formMapSize
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnSet = new System.Windows.Forms.Button();
			this.nudMapSize = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.nudMapSize)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Set a map size!";
			// 
			// btnSet
			// 
			this.btnSet.Location = new System.Drawing.Point(12, 106);
			this.btnSet.Name = "btnSet";
			this.btnSet.Size = new System.Drawing.Size(92, 61);
			this.btnSet.TabIndex = 1;
			this.btnSet.Text = "SET";
			this.btnSet.UseVisualStyleBackColor = true;
			this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
			// 
			// nudMapSize
			// 
			this.nudMapSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
			this.nudMapSize.Location = new System.Drawing.Point(15, 30);
			this.nudMapSize.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.nudMapSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.nudMapSize.Name = "nudMapSize";
			this.nudMapSize.Size = new System.Drawing.Size(89, 68);
			this.nudMapSize.TabIndex = 4;
			this.nudMapSize.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
			this.nudMapSize.ValueChanged += new System.EventHandler(this.nudMapSize_ValueChanged);
			// 
			// formMapSize
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(116, 179);
			this.Controls.Add(this.nudMapSize);
			this.Controls.Add(this.btnSet);
			this.Controls.Add(this.label1);
			this.Name = "formMapSize";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Map_Size";
			((System.ComponentModel.ISupportInitialize)(this.nudMapSize)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSet;
		private System.Windows.Forms.NumericUpDown nudMapSize;
	}
}