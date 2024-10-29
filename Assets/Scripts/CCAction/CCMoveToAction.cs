using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CCMoveToAction : SSAction
{
	public float speed;      
	public Vector3 target;   

	public static CCMoveToAction GetSSAction(Vector3 target, float speed){  
		CCMoveToAction action = ScriptableObject.CreateInstance<CCMoveToAction> ();   
		action.target = target;
		action.speed = speed;
		return action;    
	}

	public override void Update ()     
	{
		this.transform.localPosition = Vector3.MoveTowards(this.transform.localPosition, target, speed * Time.deltaTime);  
		if (this.transform.localPosition == target) {     
			this.destory = true;         
			this.callback.SSActionEvent (this) ;    
		}
	}

	public override void Start () {
	}
}

