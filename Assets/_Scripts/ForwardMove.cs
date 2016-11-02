using UnityEngine;
using System.Collections;

public class ForwardMove : MonoBehaviour {

	public TrainState instance;

	void OnMouseDown() 
	{/*
		if (instance.hold == 2 || instance.hold == 4)
			instance.ph = 0;
		else if (instance.hold == 1 || instance.hold == 3)
			instance.ph = 2;
		else*/
			instance.ph = 1;	
	}
}
