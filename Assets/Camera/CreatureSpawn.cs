using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using monsterList;
public class CreatureSpawn : MonoBehaviour
{
    public int waitTime=3;
    System.Random rnd = new System.Random();
    int randomInt;
    int spawn;
    int lane;
    string monsterToSpawn;
    List<GameObject> spawnedEntities= new List<GameObject>();
    Collider2D cameraBorder;
    public float spawnOnX;
    public float spawnOnY;

    
    // Start is called before the first frame update

    void Start()
    {
      cameraBorder = this.GetComponent<Collider2D>();
      spawnOnX = cameraBorder.bounds.center.x+.7f-cameraBorder.bounds.extents.x;
      spawnOnY = cameraBorder.bounds.center.y+2-cameraBorder.bounds.extents.y;
      StartCoroutine(spawnRandomUnit());
    }
    IEnumerator spawnRandomUnit(){
      
      while(true){
       randomInt = rnd.Next();
       lane = randomInt % 6; 
       
       monsterToSpawn = MonsterList.monsterList[rnd.Next() % MonsterList.monsterList.Length];
       print(monsterToSpawn);
       spawnedEntities.Add(Instantiate(GameObject.Find(monsterToSpawn),new Vector3(spawnOnX,spawnOnY+lane,0),new Quaternion(0,0,0,0)));    
       yield return new WaitForSeconds(waitTime);
      }
    }
    void Update()
    {       
    }   
}
   
    

