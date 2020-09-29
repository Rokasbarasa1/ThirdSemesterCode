

import com.google.gson.Gson;

import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.ServerSocket;
import java.net.Socket;

public class JsonClient {

    public static void main(String[] args) {
        Gson gson  = new Gson();
        Person person = new Person("Rokas", "ForkliftDriver",54, false);
        String jasonPerson = gson.toJson(person);
        System.out.println("Client started");
        System.out.println(jasonPerson);

        try {
            Socket socket = new Socket("localhost", 3000);
            ObjectOutputStream outToClient = new ObjectOutputStream(socket.getOutputStream());
            ObjectInputStream inFromClient = new ObjectInputStream(socket.getInputStream());
            outToClient.writeObject(jasonPerson);
        }catch (IOException e) {
            e.printStackTrace();
        }
    }
}
