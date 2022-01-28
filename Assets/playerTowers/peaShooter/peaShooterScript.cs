using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peaShooterScript : MonoBehaviour
{
    int shootWaitTime=3;
    public GameObject peaShooterProjectile;

    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(shoot());
    }

    // Update is called once per frame

    IEnumerator shoot(){
        while(true){
        Instantiate(peaShooterProjectile,new Vector3(this.gameObject.transform.position.x-.5f,this.gameObject.transform.position.y+.1f,0),new Quaternion (0,0,0,0));
        yield return new WaitForSeconds(shootWaitTime);
        }
    }
    void Update()
    {
        
    }
}
