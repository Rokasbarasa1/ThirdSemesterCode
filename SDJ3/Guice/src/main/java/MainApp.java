
import com.google.inject.Guice;
import com.google.inject.Inject;
import com.google.inject.Injector;
import com.google.inject.Module;

public class MainApp
{
  @Inject
  private SoSmartGGService service;

  public static void main(String[] args)
  {
    MainApp main = new MainApp();
    Module module = new SoSmartGGModule();
    // inject the implementation of the service
    Injector injector = Guice.createInjector(module);
    injector.injectMembers(main);

    main.testGuice();
  }

  public void testGuice()
  {
    // Use the service
    service.stayCoolnMotivated();
  }
}
