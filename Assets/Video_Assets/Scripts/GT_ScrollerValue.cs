using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GT_ScrollerValue : MonoBehaviour 
{
	public ScrollRect userScrollRect;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(userScrollRect)
		{
			Debug.Log(userScrollRect.horizontalNormalizedPosition);
		}
	}
}
