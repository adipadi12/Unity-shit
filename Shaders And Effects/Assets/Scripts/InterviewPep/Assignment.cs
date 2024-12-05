using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment : MonoBehaviour
{
    [SerializeField]
    private int[] A;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Is sum of two elements in array 0: " + isTwoSumZero(A));
        Debug.Log("Is sum of three elements in array 0: " + isThreeSumZero(A));
    }

    public bool isTwoSumZero(int[] A)
    {
        for (int i = 0; i < A.Length; i++)
        {
            for (int j = i + 1; j < A.Length; j++)
            {
                if (A[i] + A[j] == 0)
                {
                    return true;
                }
            }
        }
        return false;
    }

    public bool isThreeSumZero(int[] A)
    {
        for (int i = 0; i < A.Length - 2; i++)
        {
            for (int j = i + 1; j < A.Length - 1; j++)
            {
                for (int k = j + 1; k < A.Length; k++)
                {
                    if (A[i] + A[j] == 0)
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
}
