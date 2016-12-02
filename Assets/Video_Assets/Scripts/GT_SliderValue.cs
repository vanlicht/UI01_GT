using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GT_SliderValue : MonoBehaviour 
{
	public Slider userSlider;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(userSlider)
		{
			Debug.Log(userSlider.value);
		}
	}
}
