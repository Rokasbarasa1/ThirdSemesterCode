package via.sdj3.rmi.server;

import via.sdj3.rmi.common.SoSmart;
import via.sdj3.rmi.common.SoSmartMom;

import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;
import java.rmi.server.UnicastRemoteObject;
import java.util.HashMap;

public class SoSmartImpl extends UnicastRemoteObject implements
    SoSmart
{

  // Stores smart means in a map indexed by name
  //private HashMap<String, String> moms = new HashMap<String, String>();
  private SoSmartMom database;
  protected SoSmartImpl() throws RemoteException
  {
    ///initSoSmartStudent();
    //init();
  }

  /** Initialize student information */
  /*private void initSoSmartStudent()
  {
    moms.put("Michel", "BMW");
    moms.put("Tobias", "MotorBike");
    moms.put("Mathias", "Tesla");
  }

   */

  /** Implement the findMoM method from the interface */
  @Override public String findMoM(String name) throws RemoteException
  {
    //String m = moms.get(name);
    String n = database.findMom(name);
    if (n == null) {
      System.out.println("Smart Student - " + name + " is not found ");
      return "";
    }
    else {
      System.out.println("Smart Student - " + name + "\'s smart Means of Movement is " + n);
      return n;
    }
  }

  public void init(){
    try {
      Registry registry = LocateRegistry.getRegistry(1100);
      database = (SoSmartMom)
              registry.lookup("SoSmartMomImpl");
      System.out.println("Database object " + database + " found");
    }
    catch(Exception ex) {
      System.out.println(ex);
    }
  }
}
