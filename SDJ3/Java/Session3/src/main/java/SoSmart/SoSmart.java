package SoSmart;

import java.rmi.Remote;
import java.rmi.RemoteException;

public interface SoSmart extends Remote {
    String findMoM(String name) throws RemoteException;;
}
