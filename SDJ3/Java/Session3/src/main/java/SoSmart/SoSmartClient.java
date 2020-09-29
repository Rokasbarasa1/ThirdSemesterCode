package SoSmart;

import javafx.scene.control.Button;
import javafx.stage.Stage;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;

public class SoSmartClient extends javafx.application.Application {
/*
    private TextField tfName = new TextField();
    private TextField tfMom = new TextField();

 */
    private Button btGetSmartMom = new Button("Get smart mom");

    private Stage primaryStage = new Stage();
    private SoSmart server;





    void initRMI(){
        Registry reg = null;
        try {
            reg = LocateRegistry.getRegistry("localhost", 1099);
            server = (SoSmart) reg.lookup("server");
            System.out.println("Connected to server");

        } catch (RemoteException | NotBoundException e) {
            e.printStackTrace();
        }
    }
    @Override
    public void start(Stage stage) throws Exception {
        /*
        GridPane gridPane = new GridPane();
        gridPane.setHgap(5);
        gridPane.add(new Label("Name"), 0 , 0);
        gridPane.add(new Label("Name"), 0 , 0);
        gridPane.add(tfName, 1, 0);
        gridPane.add(tfMom, 1, 1);
        gridPane.add(btGetSmartMom, 1, 2);

        Scene scene = new Scene(gridPane, 250, 250);
        primaryStage.setTitle("Smart java impl");
        primaryStage.setScene(scene);
        primaryStage.show()

         */
        initRMI();
    }
}
