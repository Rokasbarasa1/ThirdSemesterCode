
namespace Blazor.Data
{
    public class CounterService
    {
		public int currentCount { get; set; }

		public  void IncrementCount()
		{
			if (currentCount == null)
			{
				currentCount = 0;
			}
			currentCount++;
		}
	}
}
