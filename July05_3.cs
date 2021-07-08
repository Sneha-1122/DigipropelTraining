using System;
					
public class Photobook
{
 	protected int numPages;
	
	public int GetNumberPages() {
		return numPages;
	}
	public Photobook() {
		numPages = 16;
	}
	public Photobook(int numPages) {
		this.numPages = numPages;
	}
}

public class BigPhotobook : Photobook {
	
	public BigPhotobook(){
		numPages = 64;
	}
		
}

public class PhotoBookTest {
	public static void Main() {
		
		Photobook photo1 = new Photobook();
		Console.WriteLine("Photo1: "+photo1.GetNumberPages());
		
		
		Photobook photo2 = new Photobook(24);
		Console.WriteLine("Photo2: "+photo2.GetNumberPages());
		
		BigPhotobook photo3 = new BigPhotobook();
		Console.WriteLine("Photo3: "+photo3.GetNumberPages());
		
}
	
	
}