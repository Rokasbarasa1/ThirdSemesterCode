package EX1.CLient1;

import EX1.Server.RemoteSender;
import EX1.Server.RemoteServerCommandList;

import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;
import java.rmi.server.UnicastRemoteObject;

public class ClientRMIClient implements RemoteSender {
    private boolean stop = false;
    private RemoteServerCommandList rml;

    public ClientRMIClient() throws RemoteException, NotBoundException {
        Registry reg = LocateRegistry.getRegistry("localhost", 1099);
        UnicastRemoteObject.exportObject(this, 1099);
        rml = (RemoteServerCommandList)reg.lookup("msgList");
    }
    public void register(){
        rml.addPerson(this);
    }
    public void sendMessage(String message){
        rml.sendMessage(message, this);
    }

    @Override
    public void replyFromPerson(String message) {
        System.out.println(message);
    }
}
