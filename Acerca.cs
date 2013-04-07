using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Tarea2
{
	/// <summary>
	/// Summary description for Acerca.
	/// </summary>
	public class Acerca : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Acerca()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Acerca));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.SpringGreen;
			this.label1.Location = new System.Drawing.Point(120, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 56);
			this.label1.TabIndex = 0;
			this.label1.Text = "Othello";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.ForestGreen;
			this.label2.Location = new System.Drawing.Point(112, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(296, 48);
			this.label2.TabIndex = 1;
			this.label2.Text = "Julio Enrique Santana              C123                                          " +
				"                                      Enero 2003";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(24, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(80, 80);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(136, 192);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 32);
			this.button1.TabIndex = 3;
			this.button1.Text = "&Aceptar";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Acerca
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(424, 237);
			this.ControlBox = false;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  this.pictureBox1,
																		  this.label2,
																		  this.label1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Acerca";
			this.Text = "Acerca de ";
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
