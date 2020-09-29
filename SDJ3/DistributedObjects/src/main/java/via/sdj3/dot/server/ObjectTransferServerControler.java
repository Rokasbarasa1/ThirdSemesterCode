package via.sdj3.dot.server;

import via.sdj3.dot.common.ObjectTransferRI;
import via.sdj3.dot.common.SomeInterface2;
import via.sdj3.dot.common.SomeObject1;

import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;

public class ObjectTransferServerControler extends UnicastRemoteObject implements
    ObjectTransferRI
{
  private static final long serialVersionUID = 1L;
  public ObjectTransferServerControler() throws RemoteException
  {
    super();
  }

  @Override
  public void call1(SomeObject1 object1) throws RemoteException
  {
    System.out.println("Value1: " + object1.getValue());
    object1.setValue(12);
    System.out.println("Second Value1: " + object1.getValue());
  }

  @Override
  public void call2(SomeInterface2 object2) throws RemoteException
  {
    System.out.println("Value2: " + object2.getValue());
    object2.setValue(12);
    System.out.println("Second Value2: " + object2.getValue());
    System.out.println();
  }
}
