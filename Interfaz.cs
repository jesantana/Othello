using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Tarea2
{

	public class Interfaz : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private Tablero tab;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.Timer timer1;
		private System.ComponentModel.IContainer components;
		private bool creciendo;
		private int marcador;
		private string texto,jugblan,jugneg;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem8;
		private Font f;
		

		public Interfaz()
		{
			tab=new Tablero();
			InitializeComponent();
			f=new Font(FontFamily.GenericSerif,14);
			texto="Juegan Rojas";	
			marcador=0;
			creciendo=true;
		}

		
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Interfaz));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.LightGreen;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Enabled = false;
			this.pictureBox1.Location = new System.Drawing.Point(24, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(320, 320);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
			// 
			// button1
			// 
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(440, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(152, 40);
			this.button1.TabIndex = 1;
			this.button1.Text = "&Comenzar";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.LightGray;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(408, 280);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(216, 56);
			this.label4.TabIndex = 5;
			this.label4.Text = "Presiona comenzar para empezar a jugar";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label5,
																					this.label3,
																					this.label2,
																					this.label1});
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(400, 80);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(224, 112);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Numero de fichas";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(132, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 24);
			this.label5.TabIndex = 10;
			this.label5.Text = "Rojas";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(132, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 16);
			this.label3.TabIndex = 9;
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 16);
			this.label2.TabIndex = 8;
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(12, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 24);
			this.label1.TabIndex = 7;
			this.label1.Text = "Azules";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem4});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem3,
																					  this.menuItem8,
																					  this.menuItem2});
			this.menuItem1.Text = "&Archivo";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 0;
			this.menuItem3.Text = "&Comenzar";
			this.menuItem3.Click += new System.EventHandler(this.button1_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 2;
			this.menuItem2.Text = "&Salir";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem5});
			this.menuItem4.Text = "&Ayuda";
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 0;
			this.menuItem5.Text = "Acerca de...";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 300;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 1;
			this.menuItem8.Text = "Comenzar con &Jugadores Nuevos";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// Interfaz
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(674, 355);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox1,
																		  this.label4,
																		  this.button1,
																		  this.pictureBox1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Menu = this.mainMenu1;
			this.Name = "Interfaz";
			this.Text = "Othello";
			this.Load += new System.EventHandler(this.Interfaz_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		
		static void Main() 
		{
			Application.Run(new Interfaz());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.tab=new Tablero();
			label4.Text="";
			label4.Refresh();
			timer1.Enabled=true;
			pictureBox1.Enabled=true;
			pictureBox1.Refresh();
			this.ActualizaEtiquetas();
			
		}

		
		
		private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g=e.Graphics;
			Pen p=new Pen(Color.White);
			p.Width=3;
			for (int i=0;i<8;i++)
			{
				g.DrawLine(p,40*i,0,40*i,320);
				g.DrawLine(p,0,40*i,320,40*i);
			}
			this.PintaTablero(g);
		}

		private void pictureBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			int x=e.X/40;
			int y=e.Y/40;
			int[] a=tab.Busca(x,y);
			if (a.Length==0){MessageBox.Show("No se puede jugar ahí");}
			else
			{
				tab.Juega(x,y,a);
					for (int i=0;i<a.Length;i++)
					this.ActualizaFichas(x,y,tab.MatrizMov[a[i],0],tab.MatrizMov[a[i],1]);
			
				if(tab.CantFichasBlancas+tab.CantFichasNegras==64) 
				{
					this.ActualizaEtiquetas();
					this.Finalizar();
					return;
				}
				
				if (tab.CantFichasBlancas==0 || tab.CantFichasNegras==0)
					this.Finalizar();

				if (!this.tab.SePuedeJugar())
				{
					MessageBox.Show("Debes Pasar");
					tab.SaltaJugador();
					if (!this.tab.SePuedeJugar())
					{
						MessageBox.Show("Debes Pasar");
						this.Finalizar();
						
					}
				}
				label4.Refresh();
				this.ActualizaEtiquetas();
			
			}
		}
		
		
		private void PintaTablero(Graphics e)
		{
			Graphics g=e;
			SolidBrush brochaAzul=new SolidBrush(Color.Blue);
			SolidBrush brochaRoja=new SolidBrush(Color.Red);
			for (int i=0;i<8;i++)
			{
				for (int j=0;j<8;j++)
				{
					if(tab.FichaEn(i,j)==1) g.FillEllipse(brochaAzul,i*40+5,j*40+5,30,30);
					else if(tab.FichaEn(i,j)==-1) g.FillEllipse(brochaRoja,i*40+5,j*40+5,30,30);}
			}
			
		}

		private void ActualizaFichas(int x,int y,int direcx,int direcy)
		{
		SolidBrush b;
		Graphics g=pictureBox1.CreateGraphics();
		if (tab.JugadorEnTurno==1) b=new SolidBrush(Color.Red);
			else b=new SolidBrush(Color.Blue);
		for (int i=0;(tab.NoSeSale(x+i*direcx,y+i*direcy)) && (tab.FichaEn(x+i*direcx,y+i*direcy)==-tab.JugadorEnTurno);i++)
			g.FillEllipse(b,(x+i*direcx)*40+5,(y+i*direcy)*40+5,30,30);
		
		}
		
		
		private void ActualizaEtiquetas()
		{
			label2.Text=tab.CantFichasBlancas+" fichas";
			label3.Text=tab.CantFichasNegras+" fichas";
			if (this.tab.JugadorEnTurno==1)
			{
				texto="Juega "+this.jugblan;}
			else 
			{
				texto="Juega "+this.jugneg;}
				  
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			Environment.Exit(0);
		}

		

		
		
		private void Finalizar()
		{
			
			timer1.Enabled=false;
			label4.Refresh();
			this.label4.Text="Para recomenzar presiona comenzar";
			if (tab.CantFichasBlancas==tab.CantFichasNegras) MessageBox.Show("Hay un empate");
			else
			{
				int winner=Math.Max(tab.CantFichasBlancas,tab.CantFichasNegras);
				pictureBox1.Enabled=false;
				if (winner==tab.CantFichasBlancas) MessageBox.Show("Las Azules Ganan por "+tab.CantFichasBlancas+" a "+tab.CantFichasNegras);
				else MessageBox.Show("Las Rojas Ganan por "+tab.CantFichasNegras+" a "+tab.CantFichasBlancas);}
		this.pictureBox1.Enabled=false;
				}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			if (creciendo) marcador++;
			else marcador--;
			if (marcador>=texto.Length-1  ) creciendo=false;
			else if (marcador<=0) creciendo=true;
			
			this.ActualizaAnimacion();
		}
		
		private void ActualizaAnimacion(){
			Graphics g=label4.CreateGraphics();
			g.Clear(Color.LightGray);
			SolidBrush bletra=new SolidBrush(Color.Black);
			SolidBrush bola;
			if (tab.JugadorEnTurno==1) bola=new SolidBrush(Color.Blue);
			else bola=new SolidBrush(Color.Red);
			for (int i=0;i<texto.Length;i++)
				if (i!=marcador) g.DrawString(texto[i].ToString(),f,bletra,i*14,label1.Height/2);
				else 
				{
					g.DrawString(texto[i].ToString(),f,bletra,i*14,label1.Height/2-15);
					g.FillEllipse(bola,i*14,label1.Height/2+5,14,14);
				}
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			Acerca a=new Acerca();
			a.ShowDialog();
		}

		private void Interfaz_Load(object sender, System.EventArgs e)
		{
			Opciones c=new Opciones();
			c.ShowDialog();
			jugblan=c.JugadorBlanco;
			jugneg=c.JugadorNegro;
			c.Close();
			

		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			Opciones c=new Opciones();
			c.ShowDialog();
			jugblan=c.JugadorBlanco;
			jugneg=c.JugadorNegro;
			c.Close();
			

			this.tab=new Tablero();
			label4.Text="";
			label4.Refresh();
			timer1.Enabled=true;
			pictureBox1.Enabled=true;
			pictureBox1.Refresh();
			this.ActualizaEtiquetas();
			
		}

		
	}
	}

