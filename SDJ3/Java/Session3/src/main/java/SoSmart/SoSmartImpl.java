package SoSmart;

import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.util.HashMap;

public class SoSmartImpl implements SoSmart {
    private HashMap<String,String> moms;

    public SoSmartImpl() throws RemoteException {
        UnicastRemoteObject.exportObject(this, 0);
        this.moms = moms;
    }

    public void initMoMs(){
        moms = new HashMap<>();
        moms.put("David", "ducati");
        moms.put("Anders", "KAka");
        moms.put("Niklas", "Lada");
        moms.put("Rokas", "JUju");
    }

    @Override
    public String findMoM(String name) throws RemoteException {
        return null;
    }
}
