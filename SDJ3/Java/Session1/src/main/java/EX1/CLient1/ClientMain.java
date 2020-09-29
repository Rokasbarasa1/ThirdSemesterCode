package EX1.CLient1;

import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.util.Scanner;
public class ClientMain {
    public static void main(String[] args){
        ClientRMIClient rmc;
        Scanner key = new Scanner(System.in);
        String message = "";
        try {
            rmc = new ClientRMIClient();
            rmc.register();
            while (true){
                message = key.nextLine();
                rmc.sendMessage(message);
            }
        } catch (RemoteException | NotBoundException e){
            e.printStackTrace();
        }
    }
}
