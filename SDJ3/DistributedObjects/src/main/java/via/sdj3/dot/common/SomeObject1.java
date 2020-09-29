package via.sdj3.dot.common;

import java.io.Serializable;

public class SomeObject1 implements Serializable
{
  /**
   * A simple serializable object
   */
  private static final long serialVersionUID = 1L;
  private int value;

  public int getValue()
  {
    return value;
  }

  public void setValue(int value)
  {
    this.value = value;
  }
}
