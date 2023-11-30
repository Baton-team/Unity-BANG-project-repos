using Firebase;
using UnityEngine;

public class FirebaseManager : MonoBehaviour
{
    private static FirebaseManager instance;
    private static bool isFirebaseInitialized = false;

    public static FirebaseManager Instance
    {
        get
        {
            if (instance == null)
            {
                // Try to find an existing instance in the scene
                instance = FindObjectOfType<FirebaseManager>();

                if (instance == null)
                {
                    // If it still doesn't exist, create a new GameObject and attach the script
                    GameObject singletonObject = new GameObject("FirebaseManager");
                    instance = singletonObject.AddComponent<FirebaseManager>();
                }

                DontDestroyOnLoad(instance.gameObject);
            }
            return instance;
        }
    }

    // Awake is called before Start and is a good place for DontDestroyOnLoad
    void Awake()
    {
        // If an instance already exists and it's not the current instance, destroy this new instance
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (!isFirebaseInitialized)
        {
            FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
            {
                FirebaseApp app = FirebaseApp.DefaultInstance;

                if (task.IsCompleted)
                {
                    // Firebase has been initialized successfully
                    Debug.Log("Firebase initialized successfully");
                    isFirebaseInitialized = true; // Set the flag to true
                }
                else if (task.IsFaulted)
                {
                    // Handle initialization error
                    Debug.LogError("Firebase initialization error: " + task.Exception);
                }
            });
        }
        else
        {
            // Firebase has already been initialized
            Debug.Log("Firebase has already been initialized");
        }
    }
}
