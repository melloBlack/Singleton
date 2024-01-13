using UnityEngine;

namespace Black.Patterns.Singleton.Examples
{
    public class SampleSingleton : Singleton<SampleSingleton>
    {
        /// <summary>
        /// Writes the message sent to the console 
        /// </summary>
        /// <param name="message"></param>
        public void ThrowLog(string message)
        {
            Debug.Log($"SampleSingleton Message : {message}");
        }
    }
}
