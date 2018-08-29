using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UlsanChunji : MonoBehaviour 
{
	private const float kScale = 0.2f;
	private void OnEnable()
	{
		this.transform.localScale = Vector3.one * kScale;
		ScaleControl scaleControl = GameObject.Find("ScaleControl").GetComponent<ScaleControl>();
		scaleControl.SetTargetModel(this.transform);
		scaleControl.OnValueChanged(kScale);
	}
}
