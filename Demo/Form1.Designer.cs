namespace PsColorPicker
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.PnlColor = new System.Windows.Forms.Panel();
			this.BtnChoose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(118, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 70);
			this.label1.TabIndex = 5;
			this.label1.Text = "Click \"Choose...\" or the color area to select a color.";
			// 
			// PnlColor
			// 
			this.PnlColor.BackColor = System.Drawing.Color.Black;
			this.PnlColor.Location = new System.Drawing.Point(12, 12);
			this.PnlColor.Name = "PnlColor";
			this.PnlColor.Size = new System.Drawing.Size(100, 100);
			this.PnlColor.TabIndex = 4;
			this.PnlColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlColor_MouseClick);
			// 
			// BtnChoose
			// 
			this.BtnChoose.Location = new System.Drawing.Point(12, 118);
			this.BtnChoose.Name = "BtnChoose";
			this.BtnChoose.Size = new System.Drawing.Size(100, 25);
			this.BtnChoose.TabIndex = 3;
			this.BtnChoose.Text = "&Choose...";
			this.BtnChoose.UseVisualStyleBackColor = true;
			this.BtnChoose.Click += new System.EventHandler(this.BtnChoose_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(215, 154);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.PnlColor);
			this.Controls.Add(this.BtnChoose);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel PnlColor;
		private System.Windows.Forms.Button BtnChoose;
	}
}

