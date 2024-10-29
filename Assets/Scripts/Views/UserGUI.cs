using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UserGUI : MonoBehaviour  
{
    private IUserAction userAction;    
    public string gameMessage ;         
    void Start()
    {
        userAction = SSDirector.getInstance().currentSceneController as IUserAction;

    }

    void OnGUI() { 
        GUI.Label(new Rect(Screen.width / 2 -150, 0, 300, 150), "牧师与魔鬼是一款益智游戏，你将帮助牧师和魔鬼过河。河的一边有三个牧师和三个魔鬼。他们都想去河的对岸，但只有一条船，这条船每次只能载两个人。而且必须有一个人把船从一边开到另一边。你可以点击它们来移动它们，也可以点击船移动到另一个方向。如果在河的两边，牧师的人数比魔鬼多，他们就会被杀死，游戏也就结束了。请让所有的牧师活下去!");
        GUI.Label(new Rect(700, 50, 200, 200), gameMessage);       
    }
}
