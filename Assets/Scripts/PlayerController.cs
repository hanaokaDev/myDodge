using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    private Rigidbody playerRigidBody;
    public float speed = 8f;

    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        playerRigidBody.linearVelocity = newVelocity;
        
    }
    public void Die()
    {
        gameObject.SetActive(false);
        GameManager gameManager = FindAnyObjectByType<GameManager>();
        gameManager.EndGame();
    }
}
