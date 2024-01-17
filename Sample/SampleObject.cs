using UnityEngine;

namespace Patterns.Singleton.Examples
{
    public class SampleObject : MonoBehaviour
    {
        private void Start()
        {
            SampleSingleton.Instance.ThrowLog("Game is started!");
            SampleMonoSingletonClass.Instance.ThrowLog("Game is started!");
        }
    }
}
