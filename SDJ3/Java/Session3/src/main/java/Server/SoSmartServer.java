package Server;

import java.rmi.AlreadyBoundException;
import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;

public class SoSmartServer {
    public static void main(String[] args) {
        Registry registry;
        SoSmartIntImpl server;

        try {
            registry= LocateRegistry.createRegistry(1099);
            server= new SoSmartIntImpl();
            registry.bind("server",server);
            server.initMom("Simon","Legedizbenz");
            server.initMom("Rafal","tesla");
            server.initMom("Tobias","Motorbike");

        } catch (RemoteException | AlreadyBoundException e) {
            e.printStackTrace();
        }
    }
}
