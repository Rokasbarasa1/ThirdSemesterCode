package Tier3;

import Shared.Request;
import Shared.User;
import Tier3.persistance.AdminDAO.AdminDAO;
import Tier3.persistance.AdminDAO.AdminDAOImp;
import Tier3.persistance.ClerkDAO.ClerkDAO;
import Tier3.persistance.ClerkDAO.ClerkDAOImp;
import Tier3.persistance.CustomerDAO.CustomerDAO;
import Tier3.persistance.CustomerDAO.CustomerDAOImp;

import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.Socket;

public class ServerSocketHandler implements Runnable {

    private Socket socket;
    private ObjectOutputStream outToClient;
    private ObjectInputStream inFromClient;
    private AdminDAO admin;
    private ClerkDAO clerk;
    private CustomerDAO customer;

    public ServerSocketHandler(Socket socket, AdminDAO admin, ClerkDAO clerk, CustomerDAO customer){
        this.socket = socket;
        this.admin = admin;
        this.clerk = clerk;
        this.customer = customer;
        try {
            outToClient = new ObjectOutputStream(socket.getOutputStream());
            inFromClient = new ObjectInputStream(socket.getInputStream());
        } catch (IOException e){
            e.printStackTrace();
        }
    }

    @Override
    public void run() {
        try{
            while (true){
                Request fromTier2 = (Request) inFromClient.readObject();
                String[] parameters = fromTier2.getParameters().split(";");
                if(fromTier2.getType() == "Customer"){
                    if(fromTier2.getCommand() == "getAccount"){
                        //customer.
                    } else if(fromTier2.getCommand() == "withdraw"){

                    }
                } else if(fromTier2.getType() == "Clerk"){
                    if(fromTier2.getCommand() == "getClerk"){

                    } else if(fromTier2.getCommand() == "getCustomer"){

                    } else if(fromTier2.getCommand() == "withdraw"){

                    } else if(fromTier2.getCommand() == "addToAccount"){

                    }
                } else if(fromTier2.getType() == "Admin"){
                    if(fromTier2.getCommand() == "createdCustomer"){

                    } else if(fromTier2.getCommand() == "createdClerk"){

                    }
                }
            }
        } catch (IOException | ClassNotFoundException e){
            e.printStackTrace();
        }
    }


}

