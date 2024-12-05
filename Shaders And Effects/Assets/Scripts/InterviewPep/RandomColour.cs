using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomColour : MonoBehaviour
{
    public Button colorButton;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        colorButton.onClick.AddListener(ColorRandom);
    }

    // Update is called once per frame
    void ColorRandom()
    {
        target.GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
}
