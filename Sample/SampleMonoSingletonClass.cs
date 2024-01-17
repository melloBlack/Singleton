using UnityEngine;

namespace Patterns.Singleton.Examples
{
    public class SampleMonoSingletonClass : MonoSingleton<SampleMonoSingletonClass>
    {
        /// <summary>
        /// Writes the message sent to the console 
        /// </summary>
        /// <param name="message"></param>
        public void ThrowLog(string message)
        {
            Debug.Log($"SampleMonoSingleton Message  ({gameObject.name}): {message}");
        }
    }
}
