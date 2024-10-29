using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoreCtrl
{
    Shore shore;
    public void CreateShore(Vector3 position) {  
            shore = new Shore(position);
    }
    public Shore GetShore() {  
        return shore;
    }

    public Vector3 AddRole(Role role) {

        role.role.transform.parent = shore.shore.transform;
        role.pos = shore.id;
        if (role.type == 0) shore.count_priest++;  
        else shore.count_devil++;                      
        return Position.role_shore[role.id];          
    }

    public void RemoveRole(Role role) {
        if (role.type == 0) shore.count_priest--;     
        else shore.count_devil--;       
    }
}