package XML;

import java.awt.*;
import java.io.Serializable;
import java.util.ArrayList;

public class Libary implements Serializable {
    private ArrayList<Book> book;
    private ArrayList<Magazine> magazine;
    private String name;
    private String lastname;

    public Libary(){}

    public void addBook(Book newbook){
        book.add(newbook);
    }

    public void addMagazine(Magazine newMagazine){
        magazine.add(newMagazine);
    }
}
