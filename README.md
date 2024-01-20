# Singleton

**It is offered as open source. You can use it as you wish. Contact me when you need help.**

## Usage
### Singleton for MonoBehaviour
- Create a class that you want to make singleton.

 ```csharp
    public class SampleSingletonObject : MonoBehaviour
    {

    }
```
- Derive this class from the MonoSingleton class.

 ```csharp
    public class SampleSingletonObject : MonoSingleton<SampleSingletonObject>
    {
        public void SampleMethod()
        {
            
        }
    }
```
- Now you can access your singleton class.

 ```csharp
    public class SampleClass : MonoBehaviour
    {
        public void Start()
        {
            SampleSingletonObject.Instance.SampleMethod();
        }
    }
```

### Singleton for Concrete class
- Create a class that you want to make singleton.

 ```csharp
    public class SampleSingletonObject
    {

    }
```
- Derive this class from the Singleton class.

 ```csharp
    public class SampleSingletonObject : Singleton<SampleSingletonObject>
    {
        public void SampleMethod()
        {
            
        }
    }
```
- Now you can access your singleton class.

 ```csharp
    public class SampleClass : MonoBehaviour // You don't have to inherit MonoBehaviour.
    {
        public void Start()
        {
            SampleSingletonObject.Instance.SampleMethod();
        }
    }
```
- You're done! 

**Happy Code Bending!**
