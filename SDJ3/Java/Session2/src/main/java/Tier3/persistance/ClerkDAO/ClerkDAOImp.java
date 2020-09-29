package Tier3.persistance.ClerkDAO;


import Shared.Account;
import Shared.Clerk;
import Shared.Customer;
import Tier3.DatabaseConnection;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Date;

public class ClerkDAOImp implements ClerkDAO {
    private DatabaseConnection database;

    public ClerkDAOImp(DatabaseConnection database) {
        this.database = database;
    }


    @Override
    public Clerk getClerk(String ID) {
        Clerk clerk = null;
        try {
            database.setStatement(database.getConnection().createStatement());
            ResultSet rs = database.getStatement().executeQuery(
                    "SELECT * FROM \"Exercise2\".Clerk " +
                            "WHERE ClerkID = '" + ID + "';" );

            while ( rs.next() ) {
                String ClerkIDDB = rs.getString("ClerkID");
                String nameDB = rs.getString("Name");
                String lastnameDB = rs.getString("LastName");
                int accesslevelDB = rs.getInt("AccessLevel");

                clerk = new Clerk(ClerkIDDB,nameDB, lastnameDB,accesslevelDB);

                rs.close();
                database.getStatement().close();
                database.getConnection().close();
                return clerk;
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return null;
    }

    @Override
    public Customer getCustomer(String ID) {
        Customer customer = null;
        try {
            database.setStatement(database.getConnection().createStatement());
            ResultSet rs = database.getStatement().executeQuery(
                    "SELECT * FROM \"Exercise2\".Customer " +
                            "WHERE CustomerID = '" + ID + "';" );

            while ( rs.next() ) {
                String CustomerIDB = rs.getString("CustomerID");
                String nameDB = rs.getString("Name");
                String lastnameDB = rs.getString("LastName");
                Date BirthDay = rs.getDate("AccessLevel");

                customer = new Customer(CustomerIDB,nameDB, lastnameDB,BirthDay);

                rs.close();
                database.getStatement().close();
                database.getConnection().close();
                return customer;
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return null;
    }

    @Override
    public Account Withdraw(Account account, double amount) {
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

    @Override
    public Account addToAccount(Account account, double amount) {
        Account upadet = null;
        try {
            database.setStatement(database.getConnection().createStatement());
            ResultSet rs = database.getStatement().executeQuery(
                    "SELECT * FROM \"Exercise2\".Account " +
                            "WHERE accountID = '" + account.getID() + "';" );

            while ( rs.next() ) {
                String accountIDDB = rs.getString("AccountID");
                int balanceDB = rs.getInt("Balance");
                upadet = new Account(accountIDDB, (balanceDB + amount));

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
