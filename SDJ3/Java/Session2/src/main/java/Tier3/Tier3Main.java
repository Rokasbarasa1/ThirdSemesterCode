package Tier3;

import Shared.Customer;
import Tier3.persistance.AdminDAO.AdminDAO;
import Tier3.persistance.AdminDAO.AdminDAOImp;
import Tier3.persistance.ClerkDAO.ClerkDAO;
import Tier3.persistance.ClerkDAO.ClerkDAOImp;
import Tier3.persistance.CustomerDAO.CustomerDAO;
import Tier3.persistance.CustomerDAO.CustomerDAOImp;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

public class Tier3Main {
    public static void main(String[] args) {
        DatabaseConnection database = new DatabaseConnection();
        CustomerDAO customer = new CustomerDAOImp(database);
        ClerkDAO clerk = new ClerkDAOImp(database);
        AdminDAO admin = new AdminDAOImp(database);
        try {
            ServerSocket welcomeSocket = new ServerSocket(3000);
            while(true){
                Socket connectionSocket = welcomeSocket.accept();
                ServerSocketHandler c = new ServerSocketHandler(connectionSocket, admin, clerk, customer);
                new Thread(c, "Chat user").start();
                System.out.println("Connected");
            }
        }catch (IOException e){
            e.printStackTrace();
        }
    }
}
