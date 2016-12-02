using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GT_GetSliderValues : MonoBehaviour 
{
	#region Public Variables
	public Slider debugSlider;
	public ScrollRect scroller;
	#endregion

	#region Private Variables
	#endregion

	#region Main Methods
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(debugSlider)
		{
			Debug.Log(debugSlider.value);
		}

		if(scroller)
		{
			Debug.Log(scroller.verticalNormalizedPosition);
		}
	}
	#endregion
}
