package kuku.src.main.java.via.sdj3.rmi.server;

import via.sdj3.rmi.common.SoSmart;
import via.sdj3.rmi.common.SoSmartMom;

import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;
import java.rmi.server.UnicastRemoteObject;
import java.util.HashMap;

public class SoSmartImpl extends UnicastRemoteObject implements SoSmart
{
  private SoSmartMom database;
  public SoSmartImpl() throws RemoteException
  {
    init();
  }

  @Override public String findMoM(String name) throws RemoteException
  {
    String m = database.findMom(name);
    if (m == null) {
      System.out.println("Smart Student - " + name + " is not found ");
      return "";
    }
    else {
      System.out.println("Smart Student - " + name + "\'s smart Means of Movement is " + m);
      return m;
    }
  }

  public void init(){
    String host = "localhost";

    try {
      Registry registry = LocateRegistry.getRegistry(1100);
      database = (SoSmartMom)
              registry.lookup("SoSmartMomImpl");
      System.out.println("Server object " + database + " found");
    }
    catch(Exception ex) {
      System.out.println(ex);
    }
  }
}
