using UnityEngine;

public class PosRotStore 
{
    public Vector3 position;
    public Quaternion rotation;
    
    public PosRotStore(Vector3 pos, Quaternion rot)
    {
        position = pos;
        rotation = rot;
    }
}
