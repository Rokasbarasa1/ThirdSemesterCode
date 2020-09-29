import com.google.inject.AbstractModule;

public class SoSmartGGModule extends AbstractModule
{
  @Override protected void configure()
  {
    bind(SoSmartGGService.class).to(SoSmartGGServiceImpl.class);
  }
}
