package EX1.Server;

import java.rmi.AlreadyBoundException;
import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;

public class ServerMain {
    public static void main(String[] args) {
        try {
            Registry registry = LocateRegistry.createRegistry(1099);
            RemoteServerCommandList server = new AddressServer();
            registry.bind("msgList", server);
            System.out.println("Server started...");
        } catch (RemoteException | AlreadyBoundException e){
            e.printStackTrace();
        }
    }
}
