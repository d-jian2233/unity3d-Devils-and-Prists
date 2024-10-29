using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Role 
{
    public GameObject role;
    public int type;
    public int pos; 
    public int id;  
    
    public Role (Vector3 position, int type, int id) {
        this.type = type;
        this.id = id;
        pos = 2;        
        role = GameObject.Instantiate(Resources.Load("Prefabs/" + (type == 0 ? "Priests" : "Devils"), typeof(GameObject))) as GameObject;
        role.transform.position = position;

        role.AddComponent<Click>();                        
        role.AddComponent<BoxCollider>();                 
    }
}
