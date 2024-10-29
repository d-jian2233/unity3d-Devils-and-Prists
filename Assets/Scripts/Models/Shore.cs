using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shore 
{
    public GameObject shore;
    public int count_priest, count_devil = 0;
    public int id;
    public Shore (Vector3 position){
        shore = GameObject.Instantiate(Resources.Load("Prefabs/Shore", typeof(GameObject))) as GameObject;
        shore.transform.localScale = new Vector3(8,5f,2); 
        shore.transform.position = position;
    }

}
