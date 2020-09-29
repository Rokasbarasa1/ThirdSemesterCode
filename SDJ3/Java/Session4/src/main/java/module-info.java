module SoSmartRmi1 {
  exports via.sdj3.rmi.client;
  exports via.sdj3.rmi.common to java.rmi;
  requires javafx.controls;
  requires javafx.graphics;
  requires java.rmi;
  requires java.sql;
}