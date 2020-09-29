package XML;

import com.fasterxml.jackson.dataformat.xml.XmlMapper;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.Marshaller;
import java.io.FileOutputStream;

public class xmlshit {
    public static void main(String[] args) throws Exception{
        /*
        Libary libary = new Libary();


        Book book2 = new Book(authors,"Kaks", "5519fd", 48);
        Magazine magazine1 = new Magazine("Masina", "traukinys", 81, 199);
        System.out.println(book1);
        //libary.addBook(book1);
        //libary.addBook(book2);
        //libary.addMagazine(magazine1);

        JAXBContext contextObj = JAXBContext.newInstance(Book.class);
        Marshaller marshallerObj = contextObj.createMarshaller();
        marshallerObj.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);
        marshallerObj.marshal(book1, new FileOutputStream("Book1.xml"));

         */
        String[] authors = {"Rokas", "Barasa" };
        Book book1 = new Book(authors,"sudas", "5519fd", 486);
        XmlMapper xmlMapper = new XmlMapper();
        String xml = xmlMapper.writeValueAsString(book1);
        System.out.println(xml);
    }
}
