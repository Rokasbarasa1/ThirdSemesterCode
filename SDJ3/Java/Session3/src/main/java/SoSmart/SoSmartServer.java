package SoSmart;

import java.rmi.AlreadyBoundException;
import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;

public class SoSmartServer {

    public static void main(String[] args) {
        try {
            Registry registry = LocateRegistry.createRegistry(1099);
            SoSmart smart = new SoSmartImpl();
            registry.bind("localhost", smart);

        } catch (RemoteException | AlreadyBoundException e){
            e.printStackTrace();
        }
    }
}
