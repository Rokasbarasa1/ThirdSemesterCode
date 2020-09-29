package Server;

import java.rmi.Remote;
import java.rmi.RemoteException;

public interface SoSmartInt extends Remote {
    String findMom(String name) throws RemoteException;
}
