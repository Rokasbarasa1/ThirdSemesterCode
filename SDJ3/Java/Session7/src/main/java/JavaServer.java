

import com.google.gson.Gson;

import java.io.Console;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.ServerSocket;
import java.net.Socket;

public class JavaServer {

    public static void main(String[] args) throws IOException{
        Gson gson = new Gson(); //Just a json serializer/deserializer
        ServerSocket serverSocket = new ServerSocket(4343, 10);
        System.out.println("Server started");
        while (true){
            Socket socket = serverSocket.accept();
            System.out.println("Something connected");
            InputStream is = socket.getInputStream();
            OutputStream os = socket.getOutputStream();

            byte[] lenBytes = new byte[4];
            is.read(lenBytes, 0, 4);
            int len = (((lenBytes[3] & 0xff) << 24) | ((lenBytes[2] & 0xff) << 16) |
                    ((lenBytes[1] & 0xff) << 8) | (lenBytes[0] & 0xff));
            byte[] receivedBytes = new byte[len];
            is.read(receivedBytes, 0, len);
            String received = new String(receivedBytes, 0, len);

            System.out.println("Server received: " + received);

            Person person = gson.fromJson(received, Person.class);
            System.out.println(person.isHappy());
            System.out.println(person.getAge());
            System.out.println(person.getPosition());
            System.out.println(person.getName());
        }

    }
}
