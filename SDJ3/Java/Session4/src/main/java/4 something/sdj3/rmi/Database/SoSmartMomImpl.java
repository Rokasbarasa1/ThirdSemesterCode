package via.sdj3.rmi.Database;

import via.sdj3.rmi.Database.DatabaseConnection;
import via.sdj3.rmi.common.SoSmartMom;

import java.sql.ResultSet;
import java.sql.SQLException;

public class SoSmartMomImpl implements SoSmartMom {
    private DatabaseConnection database;

    public SoSmartMomImpl(DatabaseConnection database) {
        this.database = database;
    }

        /*
        set search_path = 'PharmaSystem';

        CREATE TABLE SystemUser
                (
                        username  varchar(25) NOT NULL,
                        password  varchar(25) UNIQUE NOT NULL,
                        accessLevel varchar(10),
                        buildingNo varchar(4),
                        userNo varchar(10)
                );
        Insert into SystemUser(username, password, accessLevel, buildingNo, userNo)
        VALUES ('admin', 'admin', 'admin', 'null', 'U001');

        Select * from SystemUser;
        */

    @Override
    public String findMom(String ID) {
        String mom = null;
        System.out.println("IN DB");
        try {
            database.setStatement(database.getConnection().createStatement());
            ResultSet rs = database.getStatement().executeQuery(
                    "SELECT * FROM \"Exercise2\".Account " +
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
