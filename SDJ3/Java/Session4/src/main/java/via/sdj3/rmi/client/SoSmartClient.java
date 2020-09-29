package via.sdj3.rmi.client;

import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.layout.GridPane;
import javafx.stage.Stage;
import via.sdj3.rmi.common.SoSmart;

import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;

public class SoSmartClient extends Application
{
  // declare the interface
  private SoSmart smartInterface;

  private Button btGetSmartMoM = new Button("Get Smart MoM");
  private TextField tfName = new TextField();
  private TextField tfSmartMoM = new TextField();

  @Override
  public void start(Stage primaryStage) throws Exception{
    GridPane gridPane = new GridPane();
    gridPane.setHgap(5);
    gridPane.add(new Label("Name"), 0, 0);
    gridPane.add(new Label("SmartMoM"), 0, 1);
    gridPane.add(tfName, 1, 0);
    gridPane.add(tfSmartMoM, 1, 1);
    gridPane.add(btGetSmartMoM, 1, 2);

    // Create a scene and place the pane in the stage
    Scene scene = new Scene(gridPane, 250, 250);
    primaryStage.setTitle("Solid Smart Means of Movement");
    primaryStage.setScene(scene); // Place the scene in the stage
    primaryStage.show(); // Display the stage

    initRMI();
    btGetSmartMoM.setOnAction(e -> getSmartMoM());
  }

  private void getSmartMoM()
  {
    try {
      // Get smart student's smart means of movement
      String mom = smartInterface.findMoM(tfName.getText().trim());
      // Display the result
      if (mom.isEmpty())
        tfSmartMoM.setText("Not found");
      else
        tfSmartMoM.setText(mom);
    }
    catch(Exception ex) {
      ex.printStackTrace();
    }
  }

  private void initRMI()
  {
    String host = "localhost";

    try {
      Registry registry = LocateRegistry.getRegistry(1099);
      smartInterface = (SoSmart)
          registry.lookup("SoSmartImpl");
      System.out.println("Server object " + smartInterface + " found");
    }
    catch(Exception ex) {
      System.out.println(ex);
    }
  }

  public static void main(String[] args) {
    launch(args);
  }
}
