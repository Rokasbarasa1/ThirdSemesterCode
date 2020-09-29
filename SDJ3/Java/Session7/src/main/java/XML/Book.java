package XML;

public class Book {
    private String[] authors;
    private String title;
    private String ISBN;
    private int pages;

    public Book(String[] authors, String title, String ISBN, int pages) {
        this.authors = authors;
        this.title = title;
        this.ISBN = ISBN;
        this.pages = pages;
    }
}
