using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleControl : MonoBehaviour 
{
	[SerializeField] private Text scaleText_ = null;

	private Transform _model = null;

	public void SetTargetModel(Transform model)
	{
		_model = model;
	}

	public void OnValueChanged(float value)
	{
		if(_model == null)
		{
			return;
		}
		_model.localScale = Vector3.one * value;
		scaleText_.text = string.Format("{0:0.000}", value);
	}
}
