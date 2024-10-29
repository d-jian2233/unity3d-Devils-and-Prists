using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FirstController : MonoBehaviour, ISceneController, IUserAction {    
 
    public BoatCtrl boat;    
    RoleCtrl[] role;
    public ShoreCtrl left_shore, right_shore;
    River river;  
    SSDirector director;   
    public CCActionManager actionManager;
    bool isContinue;

    void Awake()
    {
        director = SSDirector.getInstance();
        director.currentSceneController = this;
        director.setFPS(60);
        director.currentSceneController.LoadResources();
        this.gameObject.AddComponent<UserGUI>();
        this.gameObject.AddComponent<CCActionManager>();
        this.gameObject.AddComponent<Judge>();
        isContinue = true;
    }

    public void LoadResources() {


        left_shore = new ShoreCtrl();
        left_shore.CreateShore(Position.left_shore);
        left_shore.GetShore().id = 1;
        right_shore = new ShoreCtrl();
        right_shore.CreateShore(Position.right_shore);
        right_shore.GetShore().id = 2;

        river = new River(Position.river);


        role = new RoleCtrl[6];     
        for (int i = 0; i < 6; i++) {
            role[i] = new RoleCtrl();
            if (i < 3) role[i].CreateRole(Position.role_shore[i], 0, i);
            else role[i].CreateRole(Position.role_shore[i], 1, i);
            role[i].GetRoleModel().role.transform.localPosition = right_shore.AddRole(role[i].GetRoleModel());
        }

        boat = new BoatCtrl();
        boat.CreateBoat(Position.right_boat);
      
    }


    public void MoveBoat() {
        if (boat.Getboat().roles[0] == null && boat.Getboat().roles[1] == null) return;
        Vector3 destination = new Vector3();
        if(boat.Getboat().pos == 2) destination = Position.left_boat;
        else destination = Position.right_boat;
        actionManager.MoveBoat(boat.Getboat().boat, destination, 5);        
        if(boat.Getboat().pos == 2)  boat.Getboat().pos = 1;
        else boat.Getboat().pos = 2;
        if (!isContinue) Time.timeScale = 0;
    }

    public void MoveRole(Role role) {  
        Vector3 destination; 
        

        if (role.pos == 3) {           
            if (boat.Getboat().pos == 2) {
                destination = right_shore.AddRole(role);  
            }
            else {    
                destination = left_shore.AddRole(role);   
            }
            boat.RemoveRole(role);
            actionManager.MoveRole(role.role, destination, 5);   
            role.pos = boat.Getboat().pos;  
               
        }
        else {     
            if (boat.Getboat().pos == role.pos) {  
                if (role.pos == 2) {  
                    right_shore.RemoveRole(role);  
                }
                else {  
                    left_shore.RemoveRole(role);   
                }
                destination = boat.AddRole(role);  
                actionManager.MoveRole(role.role, destination, 5);   
            }
        }
    }


    public void Callback(bool isRuning, string message)
    {
        isContinue = isRuning;
        this.gameObject.GetComponent<UserGUI>().gameMessage = message;
    }
}
