using System;

class Library {
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Book> Books { get; set; }
    public List<MediaItem> MediaItems { get; set; }

    public Library(string name, string address) {
        Name = name;
        Address = address;
        Books = new List<Book>();
        MediaItems = new List<MediaItem>();
    }

    public void AddBook(Book book) {
        Books.Add(book);
    }

    public void RemoveBook(Book book) {
        Books.Remove(book);
    }

    public void AddMediaItem(MediaItem item) {
        MediaItems.Add(item);
    }

    public void RemoveMediaItem(MediaItem item) {
        MediaItems.Remove(item);
    }

    public void PrintCatalog() {
        Console.WriteLine("Books:");
        foreach (Book book in Books) {
            Console.WriteLine(book);
        }
        Console.WriteLine("Media Items:");
        foreach (MediaItem item in MediaItems) {
            Console.WriteLine(item);
        }
    }
}


class Book {
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int PublicationYear { get; set; }

    public Book(string title, string author, string isbn, int publicationYear) {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationYear = publicationYear;
    }

    public override string ToString() {
        return String.Format("{0} ({1}) by {2} ({3})", Title, PublicationYear, Author, ISBN);
    }
}

class MediaItem {
    public string Title { get; set; }
    public string MediaType { get; set; }
    public int Duration { get; set; }

    public MediaItem(string title, string mediaType, int duration) {
        Title = title;
        MediaType = mediaType;
        Duration = duration;
    }

    public override string ToString() {
        return String.Format("{0} ({1}) {2} minutes", Title, MediaType, Duration);
    }
}



class Program {
    static void Main(string[] args) {
        Library library = new Library("My Library", "123 Main St.");
        Book book1 = new Book("Book1", "author1", "0131103628", 1978);
        Book book2 = new Book("Book2", "author2", "0321480910", 1990);
        MediaItem media1 = new MediaItem("The Dark Knight", "DVD", 152);
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddMediaItem(media1);
        library.PrintCatalog();
        // Console.WriteLine(library.Name);
    }
}
