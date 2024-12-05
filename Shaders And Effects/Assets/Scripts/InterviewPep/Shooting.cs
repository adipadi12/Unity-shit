using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public List<GameObject> bulletPool;
    [SerializeField]
    private GameObject bullet;
    
    public Transform bulletFiringPoint;
    [SerializeField]
    private float bulletSpeed = 10f;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            GameObject bulletInstance = Instantiate(bullet, bulletFiringPoint.position, bulletFiringPoint.rotation);
            bulletInstance.GetComponent<Rigidbody>().velocity = bulletFiringPoint.forward * bulletSpeed;  //direction * speed = velocity
            StartCoroutine(DestroyBulletsAfterTime(bulletInstance, 1f));
        }
    }

    IEnumerator DestroyBulletsAfterTime(GameObject bulletInstance, float timeDestroy)
    {
        yield return new WaitForSeconds(timeDestroy);
        Destroy(bulletInstance);
    }
}
