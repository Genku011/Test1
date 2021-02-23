using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EiEiInwZa : MonoBehaviour
{
    public float speed;
    Vector3 startPos;

    void Start()
    {
        startPos = transform.position;


    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (Mathf.Sin(speed/Time.deltaTime)) * startPos;
    }
}
