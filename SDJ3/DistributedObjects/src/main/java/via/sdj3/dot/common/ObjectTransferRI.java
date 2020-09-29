package via.sdj3.dot.common;

import java.rmi.Remote;
import java.rmi.RemoteException;

public interface ObjectTransferRI extends Remote
{
  public void call1(SomeObject1 object1) throws RemoteException;

  public void call2(SomeInterface2 object2) throws RemoteException;
}
