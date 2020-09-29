package via.sdj3.dot.server;

import java.net.InetAddress;
import java.rmi.Naming;
import java.rmi.registry.LocateRegistry;

public class ObjectTransferServer
{
  public static void main(String[] args)
  {
    try {
      LocateRegistry.createRegistry(1099);
      ObjectTransferServerControler controler = new ObjectTransferServerControler();
      Naming.rebind("smallexample", controler);

      System.out.println("Server listening on " + InetAddress.getLocalHost().getHostAddress());
      System.out.println();
    } catch (Exception ex) {
      ex.printStackTrace();
    }
  }
}
