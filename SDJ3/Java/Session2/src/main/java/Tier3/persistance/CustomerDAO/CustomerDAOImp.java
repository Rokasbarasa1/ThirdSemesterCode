package Tier3.persistance.CustomerDAO;


import Shared.Account;
import Shared.User;
import Tier3.DatabaseConnection;

import java.sql.ResultSet;
import java.sql.SQLException;

public class CustomerDAOImp implements CustomerDAO {
    private DatabaseConnection database;

    public CustomerDAOImp(DatabaseConnection database) {
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
    public Account getAccount(String ID) {
        Account account = null;
        try {
            database.setStatement(database.getConnection().createStatement());
            ResultSet rs = database.getStatement().executeQuery(
                    "SELECT * FROM \"Exercise2\".Account " +
                    "WHERE accountID = '" + ID + "';" );

            while ( rs.next() ) {
                String accountIDDB = rs.getString("AccountID");
                int balanceDB = rs.getInt("Balance");
                account = new Account(accountIDDB, balanceDB);

                rs.close();
                database.getStatement().close();
                database.getConnection().close();
                return account;
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return null;
    }

    @Override
    public Account withdraw(Account account, double amount) {
        Account upadet = null;
        try {
            database.setStatement(database.getConnection().createStatement());
            ResultSet rs = database.getStatement().executeQuery(
                    "SELECT * FROM \"Exercise2\".Account " +
                            "WHERE accountID = '" + account.getID() + "';" );

            while ( rs.next() ) {
                String accountIDDB = rs.getString("AccountID");
                int balanceDB = rs.getInt("Balance");
                upadet = new Account(accountIDDB, (balanceDB - amount));

                database.getStatement().executeUpdate(
                        "UPDATE \"Exercise2\".Account set balance = " + upadet.getBalance() +" where AccountID = '" + accountIDDB +"';");

                rs.close();
                database.getStatement().close();
                database.getConnection().close();
                return upadet;
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return null;
    }
}
