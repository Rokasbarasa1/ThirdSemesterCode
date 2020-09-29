module SoSmartRmi1 {
  exports via.sdj3.dot.client;
  exports via.sdj3.dot.common to java.rmi;
  requires javafx.controls;
  requires javafx.graphics;
  requires java.rmi;
}