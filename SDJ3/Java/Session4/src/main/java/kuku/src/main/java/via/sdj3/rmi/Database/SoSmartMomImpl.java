package kuku.src.main.java.via.sdj3.rmi.Database;

import via.sdj3.rmi.Database.DatabaseConnection;
import via.sdj3.rmi.common.SoSmartMom;

import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.sql.ResultSet;
import java.sql.SQLException;

public class SoSmartMomImpl extends UnicastRemoteObject implements SoSmartMom {
    private DatabaseConnection database;

    public SoSmartMomImpl(DatabaseConnection database) throws RemoteException {
        this.database = database;
    }

    @Override
    public String findMom(String ID) {
        String mom = null;
        System.out.println("IN DB");
        try {
            database.setStatement(database.getConnection().createStatement());
            ResultSet rs = database.getStatement().executeQuery(
                    "SELECT * FROM \"Exercise1\".Means " +
                    "WHERE name = '" + ID + "';" );

            while ( rs.next() ) {
                String nameDB = rs.getString("name");
                String momDB = rs.getString("mom");
                mom =momDB;
                rs.close();
                database.getStatement().close();
                database.getConnection().close();
                return mom;
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return null;
    }
}
