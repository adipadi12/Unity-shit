using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;
    
    public Transform bulletFiringPoint;
    [SerializeField]
    private float bulletSpeed = 10f;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)){
            GameObject bulletInstance = Instantiate(bullet, bulletFiringPoint.position, bulletFiringPoint.rotation);
            bulletInstance.GetComponent<Rigidbody>().velocity = bulletFiringPoint.forward * bulletSpeed;  //direction * speed = velocity
        }
    }
}
