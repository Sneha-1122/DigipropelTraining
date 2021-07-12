using System;
					
public class Photobook
{
 	protected int numPages;
	
	// Creating methods
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

// Inheriting from class Photobook
public class BigPhotobook : Photobook {
	
	public BigPhotobook(){
		numPages = 64;
	}
		
}

// A class to test the logic of the other classes
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
