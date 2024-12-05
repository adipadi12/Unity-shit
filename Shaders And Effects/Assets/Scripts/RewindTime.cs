using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewindTime : MonoBehaviour
{
    public bool isRewinding = true;
    List<PosRotStore> posRot;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        posRot = new List<PosRotStore>(); //storing positions in this list for rewinding time
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartRewind();
        }
        if (Input.GetKeyUp(KeyCode.Return))
        {
            StopRewind();
        }
    }
    private void FixedUpdate()
    {
        if (isRewinding)
        {
            Rewind();
        }
        else { Record(); }
    }
    void Rewind()
    {
        if (posRot.Count > 0) {
            PosRotStore posRotStore = posRot[0];
            transform.position = posRotStore.position;
            transform.rotation = posRotStore.rotation;
            posRot.RemoveAt(0);
        }
        else
        {
            StopRewind();
        }
    }
    void Record()
    {
        if(posRot.Count > Mathf.Round(10f/ Time.fixedDeltaTime)) //checking for points in time only till 5 seconds
        { posRot.RemoveAt(posRot.Count - 1); }
        posRot.Insert(0, new PosRotStore(transform.position, transform.rotation)); //storing the position in the 0th index
    }
    public void StartRewind()
    {
        isRewinding = true;
        rb.isKinematic = true;
    }

    public void StopRewind()
    {
        isRewinding = false;
        rb.isKinematic = false;
    }
}
