

import com.google.gson.Gson;

import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.ServerSocket;
import java.net.Socket;

public class JsonServer {
    public static void main(String[] args) {
        Gson gson = new Gson();
        ServerSocket welcomeSocket = null;
        try {
            System.out.println("Server started");
            welcomeSocket = new ServerSocket(3000);
            Socket socket = welcomeSocket.accept();
            ObjectOutputStream outToClient = new ObjectOutputStream(socket.getOutputStream());
            ObjectInputStream inFromClient = new ObjectInputStream(socket.getInputStream());
            while (true){
                String jsonString = (String)inFromClient.readObject();
                Person person = gson.fromJson(jsonString, Person.class);
                System.out.println(person.getName());
                System.out.println(person.getPosition());
                System.out.println(person.getAge());
                System.out.println(person.isHappy());
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}