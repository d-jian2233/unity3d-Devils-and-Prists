using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat
{
    public GameObject boat;
    public Role[] roles;
    public int pos;
    public int count_priest,count_devil; 

    public Boat(Vector3 position) {
        boat = GameObject.Instantiate(Resources.Load("Prefabs/Boat", typeof(GameObject))) as GameObject;
        boat.transform.position = position;
        boat.transform.localScale = new Vector3(3f,0.5f,2);   

        roles = new Role[2];        
        pos = 2;
        count_priest = count_devil = 0;      

        boat.AddComponent<BoxCollider>();              
        boat.AddComponent<Click>();                    
    }
}
