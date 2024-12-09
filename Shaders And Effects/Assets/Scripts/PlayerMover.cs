using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;
    [SerializeField]
    private float jumpSpeed = 10f;

    [SerializeField]
    private TextMeshProUGUI name;
    [SerializeField]
    private TextMeshProUGUI health;

    [SerializeField]
    private float healthValue = 100f;

    [SerializeField]
    private int collectibleCountValue = 0;

    [SerializeField]
    private TextMeshProUGUI collectibleCount;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        name.text = "Adi";
        health.text = healthValue.ToString();
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.Translate(input * moveSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            healthValue -= 10f;
        }

        if (other.CompareTag("Collectible")) {
            Destroy(other.gameObject);
            Debug.Log("Item Picked Up!");
            collectibleCountValue++;
            collectibleCount.text = collectibleCountValue.ToString();
        }
    }
}
