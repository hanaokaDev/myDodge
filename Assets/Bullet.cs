using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bulletRigidBody;
    void Start()
    {
        bulletRigidBody = GetComponent<Rigidbody>();
        bulletRigidBody.linearVelocity = transform.forward * speed;
        Destroy(gameObject, 3f); // 3ÃÊµÚ ÆÄ±«
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
            if (playerController != null)
            {
                playerController.Die();
            }
        }
        // if (other.CompareTag("Player"))
        // {
        //     other.GetComponent<PlayerController>().Die();
        // }
        // Destroy(gameObject);
    }

}
