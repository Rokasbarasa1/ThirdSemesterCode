package EX1.Server;

import java.rmi.Remote;

public interface RemoteSender extends Remote {
    public void replyFromPerson(String message);
}
