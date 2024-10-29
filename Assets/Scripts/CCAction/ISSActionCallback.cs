using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SSActionEventType:int { Started, Competeted }

// 回调接口
public interface ISSActionCallback
{
	void SSActionEvent(SSAction source, 
		SSActionEventType events = SSActionEventType.Competeted,
		int intParam = 0 , 
		string strParam = null, 
		Object objectParam = null);
}


