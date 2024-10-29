using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleCtrl : ClickAction       
{
    Role role;
    IUserAction action;

    public RoleCtrl() {
        action = SSDirector.getInstance().currentSceneController as IUserAction;   
    }

    public void CreateRole(Vector3 position, int type, int id) {     
        role = new Role(position, type, id);     
        role.role.GetComponent<Click>().setClickAction(this);      
    }

    public Role GetRoleModel() {      
        return role;
    }

    public void DealClick() {          
        action.MoveRole(role);
    }
}
