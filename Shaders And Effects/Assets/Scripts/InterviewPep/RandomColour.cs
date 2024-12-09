using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomColour : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    private void Update()
    {
        ColorRandom();
    }

    // Update is called once per frame
    void ColorRandom()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            target.GetComponent<Renderer>().material.color = Random.ColorHSV();
        }
    }

   
}
