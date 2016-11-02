using UnityEngine;
using System.Collections;

public class BackButton : MonoBehaviour {

		public TrainState instance;

		void OnMouseDown() 
		{/*
			if (instance.hold == 3 || instance.hold == 5)
				instance.ph = 0;
			else if (instance.hold == 1 || instance.hold == 4)
				instance.ph = 1;
			else*/
				instance.ph = 2;	
		}
	}
