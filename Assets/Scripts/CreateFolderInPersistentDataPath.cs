using System.IO;
using UnityEngine;

public class CreateFolderInPersistentDataPath : MonoBehaviour
{
    void Start()
    {
        string path = Path.Combine(Application.persistentDataPath, "MyFolder");

        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
            Debug.Log("Folder created at " + path);
        }
        else
            Debug.Log("Folder already exists");
    }
}
