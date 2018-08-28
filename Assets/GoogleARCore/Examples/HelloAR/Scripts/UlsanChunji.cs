using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UlsanChunji : MonoBehaviour 
{
	private void OnEnable()
	{
		ScaleControl scaleControl = GameObject.Find("ScaleControl").GetComponent<ScaleControl>();
		scaleControl.SetTargetModel(this.transform);
	}
}
