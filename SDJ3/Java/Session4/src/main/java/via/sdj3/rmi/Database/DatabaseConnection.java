package via.sdj3.rmi.Database;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLOutput;
import java.sql.Statement;

public class DatabaseConnection {
    private Connection c;
    private Statement stmt;
    public DatabaseConnection() {
        c = null;
        stmt = null;
        try {
            Class.forName("org.postgresql.Driver");
            c = DriverManager
                    .getConnection("jdbc:postgresql://localhost:1234/postgres", "postgres", "uogauoga123");
            c.setAutoCommit(false);
            System.out.println("Opened database successfully");
        } catch ( Exception e ) {
            System.err.println( e.getClass().getName()+": "+ e.getMessage() );
            e.getStackTrace();

            System.exit(0);
        }
        System.out.println("Database query ok ");
    }
    public Connection getConnection() {
        try{
            Class.forName("org.postgresql.Driver");
            c = DriverManager
                    .getConnection("jdbc:postgresql://localhost:1234/postgres",
                            "postgres", "uogauoga123");
            c.setAutoCommit(false);
            System.out.println("COnnection");
        } catch (Exception e){
            System.err.println( e.getClass().getName()+": "+ e.getMessage() );
            e.getStackTrace();

            System.exit(0);
        }
        return c;
    }
    public Statement getStatement() {
        return stmt;
    }
    public void setStatement(Statement statement) {
        stmt = statement;
    }
}
