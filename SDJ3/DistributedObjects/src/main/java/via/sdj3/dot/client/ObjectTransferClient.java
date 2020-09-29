package via.sdj3.dot.client;

import javafx.application.Application;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.TextInputDialog;
import javafx.scene.layout.TilePane;
import javafx.stage.Stage;
import via.sdj3.dot.common.ObjectTransferRI;
import via.sdj3.dot.common.SomeObject1;
import via.sdj3.dot.common.SomeObject2;

import java.rmi.Naming;

public class ObjectTransferClient extends Application
{
    String ip;
    @Override public void start(Stage primaryStage) throws Exception
    {
        // set title for the stage
        primaryStage.setTitle("Distributed Object Transfer demo");
        // create a tile pane
        TilePane r = new TilePane();
        // create a text input dialog
        TextInputDialog td = new TextInputDialog("");
        td.setTitle("IP Input Dialog");
        // setHeaderText
        td.setHeaderText("Input IP ");
        // create a button
        Button startBtn = new Button("click me to start");

        // create a event handler
        EventHandler<ActionEvent> event = new EventHandler<ActionEvent>() {
            public void handle(ActionEvent e)
            {
                // show the text input dialog
                td.showAndWait();
                ip = td.getEditor().getText();
                transferObject(ip);
            }
        };
        // set on action of event
        startBtn.setOnAction(event);
        // add button
        r.getChildren().add(startBtn);
        // create a scene
        Scene sc = new Scene(r, 500, 300);
        // set the scene
        primaryStage.setScene(sc);
        primaryStage.show();
    }

    private void transferObject(String ip)
    {
        try {
            String URL = "rmi://"+ ip + "/smallexample";
            ObjectTransferRI server = (ObjectTransferRI) Naming.lookup(URL);
            SomeObject1 obj1 = new SomeObject1();
            obj1.setValue(10);

            System.out.println("value1: " + obj1.getValue());
            server.call1(obj1);
            System.out.println("value1: " + obj1.getValue());
            System.out.println();

            SomeObject2 obj2 = new SomeObject2();
            obj2.setValue(12);
            System.out.println("value2: " + obj2.getValue());
            server.call2(obj2);
            System.out.println("value2: " + obj2.getValue());
            System.out.println();

        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }

    public static void main(String[] args)
    {
        launch(args);
    }
}
