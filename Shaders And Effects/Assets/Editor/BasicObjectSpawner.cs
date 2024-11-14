using UnityEditor;
using UnityEngine;

public class BasicObjectSpawner : EditorWindow
{
    string objectName = "";
    int obj_ID = 1;
    GameObject spawnObject;
    float objectScale;
    float spawnRadius = 5f;

    [MenuItem("Tools/Object Spawner")]
    public static void ShowWindow() //static so it can be called without having reference a game object
    {
        GetWindow(typeof(BasicObjectSpawner)); //getWindow is a method inherited from editorwindow class that we're using instead of MonoBehavior
    }

    private void OnGUI() //defining the GUI of the spawner window
    {
        GUILayout.Label("Spawn the object", EditorStyles.boldLabel); //makes the text bold

        objectName = EditorGUILayout.TextField("Name", objectName);
        obj_ID = EditorGUILayout.IntField("ID", obj_ID);
        spawnObject = EditorGUILayout.ObjectField("Spawning Prefab", spawnObject, typeof(GameObject), false) as GameObject; //spawn object as a game object and don't allow objects from scene only prefabs
        objectScale = EditorGUILayout.Slider("Set Scale", objectScale, 0.1f, 10f);
        spawnRadius = EditorGUILayout.FloatField("Radius to Spawn", spawnRadius);

        if (GUILayout.Button("Spawn Object"))
        {
            SpawnObject();
        }
    }

    private void SpawnObject()
    {
        if (spawnObject == null)
        {
            Debug.LogError("Error: Assign Prefab Dumbass!");
            return;
        }
        if (objectName == string.Empty)
        {
            Debug.LogError("Error: Enter a name pleasepleaseplease");
            return;
        }

        Vector2 spawnCircle = Random.insideUnitSphere * spawnRadius; //setting spawn pos to a random area in this circle
        Vector3 spawnPos = new Vector3(spawnCircle.x, 0f, spawnCircle.y); //translating 2D coordinates to 3D we leave out the y coordinate so spawning done inside sphere


        GameObject newObject = Instantiate(spawnObject, spawnPos, Quaternion.identity);
        newObject.name = objectName + obj_ID;
        newObject.transform.localScale = Vector3.one * objectScale; //sets scale for the object

        obj_ID++;
    }
}
