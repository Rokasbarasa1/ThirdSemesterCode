package Server;

import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.util.HashMap;

public class SoSmartIntImpl implements SoSmartInt {
    private HashMap<String,String> hashMap;

    public SoSmartIntImpl()
    {
        hashMap = new HashMap<>();
        try {
            UnicastRemoteObject.exportObject(this,0);
            System.out.println("System started");
        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }


    @Override
    public String findMom(String name) throws RemoteException {
        if(hashMap.get(name) !=null) {
            return hashMap.get(name);
        }
        else
            return "Mom could not be found";
    }

    public void initMom(String name, String value)
    {
        hashMap.put(name,value);
    }
}
