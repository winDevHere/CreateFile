using UnityEngine;
using System.IO;

public class CreateFolderInSpecifiedPath : MonoBehaviour
{
    [SerializeField] string folder = @"C:\AdminFiles\MyFolder";

    // Creates "MyFolder" in the specified path and checks it
    void Start()
    {
        Directory.CreateDirectory(folder);  // creates it if missing, does nothing if it exists

        if (Directory.Exists(folder))
            Debug.Log("Folder exists");
        else
            Debug.Log("Folder does not exist");
    }
}