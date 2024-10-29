using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judge : MonoBehaviour
{
    public FirstController controller;
    public Shore left_shore;
    public Shore right_shore;
    public Boat boat;
    void Start()
    {
        controller = (FirstController)SSDirector.getInstance().currentSceneController;   
        this.left_shore= controller.left_shore.GetShore();
        this.right_shore = controller.right_shore.GetShore();
        this.boat = controller.boat.Getboat();
    }
    void Update()    
    {
        controller = (FirstController)SSDirector.getInstance().currentSceneController;      
        if (left_shore.count_priest == 3) {  
            controller.Callback(false, "Success!");
        }
        else{
            int count_left_priest, count_right_priest,count_left_devil,count_right_devil;
            if (boat.pos == 2)
            {
                count_left_priest = left_shore.count_priest;
                count_left_devil = left_shore.count_devil;
                count_right_priest = right_shore.count_priest + boat.count_priest;
                count_right_devil = right_shore.count_devil + boat.count_devil;
            }
            else
            {
                count_left_priest = left_shore.count_priest + boat.count_priest;
                count_left_devil = left_shore.count_devil + boat.count_devil;
                count_right_priest = right_shore.count_priest;
                count_right_devil = right_shore.count_devil;
            }
            if ((count_left_priest > 0 && count_left_priest < count_left_devil) || (count_right_priest > 0 && count_right_priest < count_right_devil)) { 
                controller.Callback(false, "Game Over!");
            }
            else controller.Callback(true, "");
        }
    }
}
