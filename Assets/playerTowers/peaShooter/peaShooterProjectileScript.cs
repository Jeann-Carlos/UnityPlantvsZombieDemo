using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peaShooterProjectileScript : MonoBehaviour
{
    float speed = 10;
    Rigidbody2D objectRigidBody;
    void Start()
    {
        objectRigidBody=gameObject.GetComponent<Rigidbody2D>();
        objectRigidBody.velocity=Vector2.left*speed;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
