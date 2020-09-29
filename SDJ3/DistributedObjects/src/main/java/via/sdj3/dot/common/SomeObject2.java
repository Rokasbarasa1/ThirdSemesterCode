package via.sdj3.dot.common;

import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;

public class SomeObject2 extends UnicastRemoteObject implements SomeInterface2
{
  /**
   * A simple remote object
   * @throws RemoteException
   */
  private static final long serialVersionUID = 1L;
  private int value;

  public SomeObject2() throws RemoteException
  {
    super();
  }

  @Override
  public void setValue(int value) throws RemoteException
  {
    this.value = value;
  }

  @Override
  public int getValue() throws RemoteException
  {
    return value;
  }
}
