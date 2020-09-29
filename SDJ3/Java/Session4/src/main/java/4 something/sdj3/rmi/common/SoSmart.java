package via.sdj3.rmi.common;
import java.rmi.*;

public interface SoSmart extends Remote
{
  /**
   *
   * @param name
   * @return a means of movement or empty string if not found
   * @throws RemoteException
   */
  String findMoM(String name) throws RemoteException;
}
