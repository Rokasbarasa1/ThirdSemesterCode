package via.sdj3.rmi.common;

import java.rmi.Remote;

public interface SoSmartMom extends Remote {
    String findMom(String name);
}
