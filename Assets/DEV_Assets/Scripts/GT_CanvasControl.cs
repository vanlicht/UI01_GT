using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GT_CanvasControl : MonoBehaviour
{
	#region Public Variables
	public bool isTimedScreen = false;
	public float screenTime = 3f;
	public GameObject targetTimedScreen;
	public Button startButton;
	#endregion

	#region Private Variables
	private float startTime;
	#endregion

	#region Main Methods
	// Use this for initialization
	void Start () 
	{
		GetStartTime();
		SelectStartControl ();
	}

	void OnEnable()
	{
		GetStartTime();
		SelectStartControl ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(isTimedScreen)
		{
			while(Time.time < startTime + screenTime)
			{
				return;
			}

			if(targetTimedScreen)
			{
				gameObject.SetActive(false);
				targetTimedScreen.SetActive(true);
			}
		}
	}
	#endregion

	#region Utility Methods
	void GetStartTime()
	{
		startTime = Time.time;
	}

	void SelectStartControl()
	{
		if(startButton)
		{
			startButton.Select();
		}
	}
	#endregion
}
