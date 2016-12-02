using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GT_CanvasController : MonoBehaviour 
{
	#region Public Variables
	public bool isTimedScreen = false;
	public float screenTime = 3f;
	public GameObject targetTimedScreen;
	#endregion

	#region Private Variables
	private float startTime = 0f;
	#endregion

	#region Main Methods
	// Use this for initialization
	void Start () 
	{
		SetupCanvas ();
	}

	void OnEnable()
	{
		SetupCanvas ();
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
	void SetupCanvas()
	{
		startTime = Time.time;
	}
	#endregion
}
