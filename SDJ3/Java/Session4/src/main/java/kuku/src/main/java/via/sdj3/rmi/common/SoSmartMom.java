package kuku.src.main.java.via.sdj3.rmi.common;

import java.rmi.Remote;
import java.rmi.RemoteException;

public interface SoSmartMom extends Remote {
    String findMom(String name) throws RemoteException;
}
