using System.Threading;

namespace CrackDSA
{

    public class H20
    {
        private SemaphoreSlim semaphoreH = new SemaphoreSlim(2, 2);
        private SemaphoreSlim semaphoreO = new SemaphoreSlim(0, 1);
        private int hydrogenCount = 0;

        public H20()
        {
        }

        public void Hydrogen(Action releaseHydrogen)
        {
            semaphoreH.Wait();
            releaseHydrogen();
            hydrogenCount++;

            if (hydrogenCount == 2)
            {
                semaphoreO.Release();
            }
            else
            {
                semaphoreH.Release();
            }
        }

        public void Oxygen(Action releaseOxygen)
        {
            semaphoreO.Wait();
            releaseOxygen();
            hydrogenCount = 0;
            semaphoreH.Release();
        }
    }
}