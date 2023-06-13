using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
   public Transform frutspawnpoint;
   public GameObject frutprefab;
   public float frutspeed;
   void start(){
   frutspeed=Random.Range(8,13);
   }

  void Update() {
    if(Input.GetKeyDown(KeyCode.Space)){
        var frut=Instantiate(frutprefab, frutspawnpoint.position+new Vector3(Random.Range(-8,8),0,0),frutspawnpoint.rotation);
        frut.GetComponent<Rigidbody2D>().velocity= frutspawnpoint.up*frutspeed;
        }
    }
    
   }

