using System;
					
public class PhotoAlbum
{
 	protected int numberOfPages;
	
	public int GetNumberOfPages() {
		return numberOfPages;
	}
	public PhotoAlbum() {
		numberOfPages = 16;
	}
	public PhotoAlbum(int numberOfPages) {
		this.numberOfPages = numberOfPages;
	}
}


// Inheriting from class PhotAlbum
public class BigPhotoAlbum : PhotoAlbum {
	
	public BigPhotoAlbum(){
		numberOfPages = 64;
	}
		
}

// Creating a test class and calling the methods from previous classes
public class AlbumTest {
	public static void Main() {
		
		PhotoAlbum p1 = new PhotoAlbum();
		Console.WriteLine("Photo1: "+p1.GetNumberOfPages());
		
		
		PhotoAlbum p2 = new PhotoAlbum(24);
		Console.WriteLine("Photo2: "+p2.GetNumberOfPages());
		
		BigPhotoAlbum p3 = new BigPhotoAlbum();
		Console.WriteLine("Photo3: "+p3.GetNumberOfPages());
		
}

}

/* 
OUTPUT:
p1: 16
p2: 24
p3: 64
*/