using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position  
{
    public static Vector3 left_shore = new Vector3(-10,0,0);  
    public static Vector3 right_shore = new Vector3(10,0,0);   
    public static Vector3 river = new Vector3(0,-0.9f,0);              
    public static Vector3 left_boat = new Vector3(-4f,0.7f,0);  
    public static Vector3 right_boat = new Vector3(4f, 0.7f, 0); 
    public static Vector3[] role_shore = new Vector3[] {new Vector3(0.4f,0.7f,0), new Vector3(0.25f,0.7f,0), new Vector3(0.1f,0.7f,0), new Vector3(-0.05f,0.7f,0), new Vector3(-0.2f,0.7f,0), new Vector3(-0.35f,0.7f,0)};   
    public static Vector3[] role_boat = new Vector3[] {new Vector3(0.2f,2.5f,0), new Vector3(-0.2f,2.5f,0)};
}
