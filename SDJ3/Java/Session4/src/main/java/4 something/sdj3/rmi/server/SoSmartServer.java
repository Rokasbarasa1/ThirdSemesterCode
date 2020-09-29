package via.sdj3.rmi.server;

import via.sdj3.rmi.common.SoSmart;

import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;

public class SoSmartServer
{
  public static void main(String[] args)
  {
    try {
      SoSmart ssObj = new SoSmartImpl();
      Registry registry = LocateRegistry.createRegistry(1099);
      registry.rebind("SoSmartImpl", ssObj);
      System.out.println("Solid Smart server " + ssObj + " registered");
    }
    catch (Exception ex) {
      ex.printStackTrace();
    }
  }
}
