package via.sdj3.dot.common;

import java.rmi.Remote;
import java.rmi.RemoteException;

public interface SomeInterface2 extends Remote
{
  public void setValue(int value) throws RemoteException;
  public int getValue() throws RemoteException;
}
