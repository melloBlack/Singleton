/*
 * MonoSingleton<T> Class
 * 
 * This class is a generic implementation of the Singleton pattern for Unity's MonoBehaviour.
 * It ensures that only one instance of the specified MonoBehaviour type exists in the scene.
 * 
 * Usage:
 * - Attach this script to any GameObject in the scene.
 * - Access the singleton instance using MonoSingleton<YourType>.Instance.
 * 
 * Features:
 * - Automatically destroys new instances if one already exists.
 * - Optionally uses DontDestroyOnLoad to persist across scene changes.
 * 
 * Created by: İsmail Hakkı Kara (Mello Black)
 * Date: [January, 2024]
 * 
 * Note: Ensure that the type specified for T in MonoSingleton<T> inherits from MonoBehaviour.
 */

using UnityEngine;

namespace Black.Patterns.Singleton
{
    public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static volatile T instance;

        /// <summary>
        /// Returns the instance of the MonoSingleton.
        /// </summary>
        public static T Instance => instance;

        [SerializeField] private bool dontDestroyOnLoad; // true : One object in game | false : One object in scene (object destroyed when scene closes)
        
        protected virtual void Awake()
        {
            if (instance == null)
            {
                instance = this as T;
                
                if (dontDestroyOnLoad)
                {
                    transform.parent = null; // Parent must be null for object to be "DontDestroyOnLoad"
                    DontDestroyOnLoad(gameObject);
                }
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
