package kuku.src.main.java.via.sdj3.rmi.Database;

import via.sdj3.rmi.common.SoSmartMom;

import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;

public class Tier3Main {
    public static void main(String[] args)
    {
        DatabaseConnection database = new DatabaseConnection();
        try {
            SoSmartMom ssObj = new SoSmartMomImpl(database);
            Registry registry = LocateRegistry.createRegistry(1100);
            registry.rebind("SoSmartMomImpl", ssObj);
            System.out.println("Solid Smart server " + ssObj + " registered");
        }
        catch (Exception ex) {
            ex.printStackTrace();
            System.out.println("didnt work");
        }
    }
}
