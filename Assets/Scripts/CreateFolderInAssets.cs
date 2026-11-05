using UnityEngine;
using System.IO;

public class CreateFolderInAssets : MonoBehaviour
{
    void Start()
    {
        string path = Path.Combine(Application.dataPath, "MyFolder");

        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
            Debug.Log("Folder created at " + path);
        }
        else
            Debug.Log("Folder already exist " + path);
    }
}
