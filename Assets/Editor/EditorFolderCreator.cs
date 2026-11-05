#if UNITY_EDITOR    // Keep this or put this file in "Editor" folder in Assets so it will not break the build
using UnityEditor;

public static class EditorFolderCreator
{
    [MenuItem("Tools/Create My Folder")]    // Creates a Menu on the toolbar on the Unity editor
    static void CreateFolder()
    {
        if (!AssetDatabase.IsValidFolder("Assets/MyFolder"))
        {
            AssetDatabase.CreateFolder("Assets", "MyFolder");
            AssetDatabase.Refresh();
        }
    }
}
#endif