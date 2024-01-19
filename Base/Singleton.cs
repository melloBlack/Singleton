/*
 * The Generic Singleton presented here is crafted to allow the creation of singleton instances for different types.
 * 
 * Usage:
 * - Create a singleton class that implements => public class SampleSingletonClass : Singleton<SampleSingletonClass>
 * - Access the singleton instance using SampleSingletonClass.Instance.
 
 * Created by: İsmail Hakkı Kara (Mello Black)
 * Date: [January, 2024]
 *
 * Note: This class employs a lock mechanism to safely operate in multi-threaded environments.
 */

namespace Patterns.Singleton
{
    public class Singleton<T> where T : class, new()
    {
        private static volatile T instance;
        private static readonly object lockObject = new object();

        /// <summary>
        /// Return an instance of the class. Initializes a new instance if the instance is null.
        /// </summary>
        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject) // Only one thread can enter
                    {
                        instance = new T();
                    }
                }

                return instance;
            }
        }
    }
}
