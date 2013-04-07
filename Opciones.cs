using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Tarea2
{
	
	public class Opciones : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private string nrojo,nazul;
		
		private System.ComponentModel.Container components = null;
		

		public Opciones()
		{
			
			InitializeComponent();

		}

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
		
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(56, 48);
			this.textBox1.MaxLength = 8;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(72, 26);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Azules";
			this.textBox1.WordWrap = false;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(248, 48);
			this.textBox2.MaxLength = 8;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(72, 26);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "Rojas";
			this.textBox2.WordWrap = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "Nombre del Jugador Azul";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(216, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "Nombre del Jugador Rojo";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(104, 200);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(168, 32);
			this.button1.TabIndex = 6;
			this.button1.Text = "&Aceptar";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Opciones
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(392, 266);
			this.ControlBox = false;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  this.label2,
																		  this.label1,
																		  this.textBox2,
																		  this.textBox1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Opciones";
			this.Text = "Opciones";
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			if (textBox1.Text.Trim()=="" || textBox2.Text.Trim()=="") 
				MessageBox.Show("Faltan datos por introducir");
			else{
			nazul=textBox1.Text;
			nrojo=textBox2.Text;
			this.Visible=false;}
		}
		
		public string JugadorBlanco{
			get {return this.nazul;}

		
		}
		public string JugadorNegro
		{
			get {return this.nrojo;}

		
		}

			}
}
