using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatCtrl : ClickAction   
{
    Boat boat;     
    IUserAction action;
    public BoatCtrl() {
        action = SSDirector.getInstance().currentSceneController as IUserAction;     
    }
    public void CreateBoat(Vector3 position) {   
        boat = new Boat(position);    
        boat.boat.GetComponent<Click>().setClickAction(this);      
    }
    public Boat Getboat() {     
        return boat;
    }
    
    public Vector3 AddRole(Role role) {
        int id = -1;   
        if (boat.roles[0] == null) id = 0;      
        else if (boat.roles[1] == null) id = 1; 
        else return role.role.transform.localPosition;  

        boat.roles[id] = role;
        role.pos = 3;        
        role.role.transform.parent = boat.boat.transform; 
        if (role.type == 0) boat.count_priest++;   
        else boat.count_devil++;               
        return Position.role_boat[id];   
    }

    
    public void RemoveRole(Role role) {
       
        if (boat.roles[0]!=null&&boat.roles[0].id == role.id) {
            if (role.type == 0) boat.count_priest--;
            else boat.count_devil--;
            boat.roles[0] = null;
            return;
        }
        if (boat.roles[1] != null&&boat.roles[1].id == role.id)
        {
            if (role.type == 0) boat.count_priest--;
            else boat.count_devil--;
            boat.roles[1] = null;
            return;
        }
    }

    public void DealClick() {               
            action.MoveBoat();           
    }
}
