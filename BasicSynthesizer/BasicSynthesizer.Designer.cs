namespace BasicSynthesizer
{
	partial class BasicSynthesizer
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
			this.oscillator1 = new Oscillator();
			this.SuspendLayout();
			// 
			// oscillator1
			// 
			this.oscillator1.Location = new System.Drawing.Point(167, 115);
			this.oscillator1.Name = "oscillator1";
			this.oscillator1.Size = new System.Drawing.Size(200, 100);
			this.oscillator1.TabIndex = 0;
			this.oscillator1.TabStop = false;
			this.oscillator1.Text = "oscillator1";
			// 
			// BasicSynthesizer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.oscillator1);
			this.KeyPreview = true;
			this.Name = "BasicSynthesizer";
			this.Text = "BasicSynthesizer";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BasicSynthesizer_KeyDown);
			this.ResumeLayout(false);

		}

		#endregion

		private Oscillator oscillator1;
	}
}

