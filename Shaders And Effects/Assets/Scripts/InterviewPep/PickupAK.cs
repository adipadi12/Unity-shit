using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupAK : MonoBehaviour
{
    [SerializeField]
    private GameObject defaultGun;
    [SerializeField]
    private GameObject ak47;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Picked up an AK!");
            Destroy(gameObject);
            defaultGun.SetActive(false);
            ak47.SetActive(true);
        }
    }
}
