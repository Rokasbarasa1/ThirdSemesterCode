package EX1.Server;

import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.util.ArrayList;

public class AddressServer implements RemoteServerCommandList{

    private ArrayList<RemoteSender> users;

    public AddressServer() throws RemoteException {
        UnicastRemoteObject.exportObject(this, 0);
        users = new ArrayList<>();
    }

    @Override
    public void sendMessage(String message, RemoteSender person) {

        for (int i = 0; i < users.size(); i++) {
            if(person.equals(users.get(i))){
                users.get(i).replyFromPerson("Anonymus: " + message);
            }
        }
    }

    @Override
    public void addPerson(RemoteSender sender) {
        if(!(users.contains(sender))){
            users.add(sender);
        }
    }
}
