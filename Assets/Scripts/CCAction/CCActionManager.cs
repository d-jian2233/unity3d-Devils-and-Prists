using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;


public class CCActionManager : SSActionManager, ISSActionCallback {
	
	private FirstController firstcontroller;       
	private CCMoveToAction move_boat,move_role;        
      
	protected new void Start() {  
		firstcontroller = (FirstController)SSDirector.getInstance ().currentSceneController;  
		firstcontroller.actionManager = this;  
	}
	
    public void MoveBoat(GameObject boat, Vector3 target, float speed)
    {
        move_boat = CCMoveToAction.GetSSAction(target, speed);  
        this.RunAction(boat, move_boat, this);  
    }

    public void MoveRole(GameObject role, Vector3 target, float speed)
    {

        move_role = CCMoveToAction.GetSSAction(target, speed);
        this.RunAction(role, move_role, this); 
    }

	#region ISSActionCallback implementation
	public void SSActionEvent (SSAction source, SSActionEventType events = SSActionEventType.Competeted, int intParam = 0, string strParam = null, Object objectParam = null)
	{
	}
	#endregion
}

