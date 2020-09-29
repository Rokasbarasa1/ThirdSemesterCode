package EX1.Server;


import java.rmi.Remote;

public interface RemoteServerCommandList extends Remote {
    void sendMessage(String message, RemoteSender person);

    void addPerson(RemoteSender sender);
}
