using System;

namespace Tarea2
{
	
	public class Tablero
	{
	
	private int[,] matriz;
	private int jugadorEnTurno;
	private int cantblan;
	private int cantneg;
	private int[,] mov=new int[,]{{0,-1},{1,-1},{1,0},{1,1},{0,1},{-1,1},{-1,0},{-1,-1}};


		public Tablero()
		{
			this.matriz=new int[8,8];
			this.matriz[3,3]=1;
			this.matriz[4,4]=1;
			this.matriz[3,4]=-1;
			this.matriz[4,3]=-1;
			this.jugadorEnTurno=-1;
			cantblan=cantneg=2;
		}
	
		public int FichaEn(int x,int y){
		
		if (NoSeSale(x,y)) return matriz[x,y];
			else throw new Exception("Error");
		}

		public bool NoSeSale(int x,int y){
		if (x>7 || x<0 || y>7 || y<0) return false;
			return true;
		}
		
		public int CantFichasBlancas{
			get{return cantblan;}
		}
		
		public int CantFichasNegras
		{
			get{return cantneg;}
		}
		
		public int JugadorEnTurno{
			get{return this.jugadorEnTurno;}
		}

		public int[,] MatrizMov{
			get{return this.mov;}
		
		
		}
		
		public int[] Busca(int x,int y){
			int[] result=new int[0]; 			
			if (NoSeSale(x,y) && matriz[x,y]==0){
				int[] a=new int[8];
				int c=0;
			for (int i=0;i<8;i++)
				if (BuscaDir(x,y,mov[i,0],mov[i,1])) a[c++]=i;  
				result=new int[c];
				Array.Copy(a,0,result,0,c);}
			return result;
			
		}
			
		private bool BuscaDir(int fil,int col,int fdir,int cdir){
		int i=1;
			for (;NoSeSale(fil+i*fdir,col+i*cdir) && matriz[fil+i*fdir,col+i*cdir]==-1*jugadorEnTurno;i++){;}
		if (i==1) return false;
		if (NoSeSale(fil+i*fdir,col+i*cdir) && matriz[fil+i*fdir,col+i*cdir]==jugadorEnTurno) return true;
		return false;}	
			
		public void Juega(int x,int y,int[] direcciones)
		{
			if (direcciones.Length==0){return;}
			else 
			{
				
				for (int i=0;i<direcciones.Length;i++)
				{
					for(int j=1;matriz[x+j*mov[direcciones[i],0],y+j*mov[direcciones[i],1]]==(-1*jugadorEnTurno);j++)
					{
						matriz[x+j*mov[direcciones[i],0],y+j*mov[direcciones[i],1]]*=-1;
						if (jugadorEnTurno==1){cantblan++;cantneg--;}
						else {cantblan--;cantneg++;}
					}
				
				}
				matriz[x,y]=jugadorEnTurno;
				if (jugadorEnTurno==1)cantblan++;
				else cantneg++;
				jugadorEnTurno=-1*jugadorEnTurno;}
			}
		
		
		public bool SePuedeJugar()
		{
			for (int i=0;i<8;i++)
			{
				for (int j=0;j<8;j++)
				{
					if (matriz[i,j]==-jugadorEnTurno)
					{
						for(int k=0;k<8;k++)
						{
							if (NoSeSale(i+mov[k,0],j+mov[k,1]) && matriz[i+mov[k,0],j+mov[k,1]]==0)
								if (BuscaDir(i+mov[k,0],j+mov[k,1],-mov[k,0],-mov[k,1])) return true;
						}					
					}
				
				}
			
			}
		return false;
		}
		
		
		public void SaltaJugador(){
		this.jugadorEnTurno*=-1;
		}	
	
	}
	}

