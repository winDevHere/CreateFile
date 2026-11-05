using UnityEngine;
using System.IO;

public class CreateFolderInSpecifiedPath : MonoBehaviour
{
    [SerializeField] string folder = @"C:\AdminFiles\MyFolder";

    // Creates "MyFolder" in the specified path and checks it
    void Start()
    {
        Directory.CreateDirectory(folder);

        if (Directory.Exists(folder))
            Debug.Log("Folder is created");
        else
            Debug.Log("Folder does not exist");
    }
}
