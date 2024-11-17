using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator:MonoBehaviour
{
    public float rotationSpeed = 60.0f;
    void Update()
    {
        // 1초에 y축기준 몇 도 회전할것인지
        transform.Rotate(new Vector3(0f, rotationSpeed, 0f) * Time.deltaTime);
    }
}