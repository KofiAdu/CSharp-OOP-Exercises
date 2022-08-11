/*
 * Create a C# program to manage a photo book using object-oriented programming.
 */

public class PhotoBookTest
{
    static void Main(String[] args)
    {
        PhotoBook book = new();
        Console.WriteLine(book.GetNumOfPages());

        PhotoBook photoBook = new(24);
        Console.WriteLine(photoBook.GetNumOfPages());

        BigPhotoBook bigPhotoBook = new();
        Console.WriteLine(bigPhotoBook.GetNumOfPages());

    }
}

public class PhotoBook
{
    protected int numOfPages;

    public PhotoBook()
    {
        numOfPages = 16;
    }

    public PhotoBook(int numOfPages) => this.numOfPages = numOfPages;

    public int GetNumOfPages() => numOfPages;
}

public class BigPhotoBook : PhotoBook
{
    public BigPhotoBook() => numOfPages = 64;
}


