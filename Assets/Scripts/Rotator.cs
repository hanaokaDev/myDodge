using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator:MonoBehaviour
{
    public float rotationSpeed = 60.0f;
    void Update()
    {
        // 1�ʿ� y����� �� �� ȸ���Ұ�����
        transform.Rotate(new Vector3(0f, rotationSpeed, 0f) * Time.deltaTime);
    }
}