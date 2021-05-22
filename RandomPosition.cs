using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{

    float x;
    float y;
    float z;
    Vector3 pos;
    void Start()
    {
        x = Random.Range(-8, 8);
        y = 5;
        z = 0;
        pos = new Vector3(x, y, z);
        transform.position = pos;

    }
}