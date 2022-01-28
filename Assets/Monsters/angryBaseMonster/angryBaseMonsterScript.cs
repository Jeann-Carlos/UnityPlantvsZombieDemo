using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class angryBaseMonsterScript : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = .2F;
    Rigidbody2D objectRigidBody;
    void Start()
    {
        objectRigidBody=gameObject.GetComponent<Rigidbody2D>();
        objectRigidBody.velocity=Vector2.right*speed;
    }

    // Update is called once per frame
    void Update()
    {
     
        
        
        
    }

    private  void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag=="Projectile"){
        Destroy(other.gameObject);
        Destroy(this.gameObject);
        }
    }    
}
