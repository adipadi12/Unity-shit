using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public Transform[] points;
    private int currentPoint = 0;

    private void Start()
    {
        
    }
    private void OnDrawGizmosSelected()
    {
        for (int i = 0; i < points.Length; i++)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(points[i].position, 0.1f);
        }
    }
    void Update()
    {

        if (Vector3.Distance(transform.position, points[currentPoint].position) < 0.1f)
        {
            currentPoint = (currentPoint + 1) % points.Length;
        }
        transform.position = Vector3.MoveTowards(transform.position, points[currentPoint].position, Time.deltaTime * 3f);
    }
}
