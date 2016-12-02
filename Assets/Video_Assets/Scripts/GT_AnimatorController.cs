using UnityEngine;
using System.Collections;

public class GT_AnimatorController : MonoBehaviour 
{
	#region Public Variables
	public GameObject mainScreen;
	public GameObject optionsScreen;
	public GameObject labScreen;
	public GameObject startScreen;
	#endregion

	#region Private Variables
	private Animator curAnimator;
	public int screenID = 0;
	#endregion

	void Start()
	{
		AnimatorSetup ();
	}

	void OnEnable()
	{
		AnimatorSetup ();
	}

	public void ToggleAnimation(bool trigger)
	{
		if(curAnimator)
		{
			curAnimator.SetBool("IsActive", trigger);
		}
	}

	void AnimatorSetup()
	{
		if(!curAnimator)
		{
			curAnimator = GetComponent<Animator>();
		}
	}

	public void SetScreenID(int id)
	{
		screenID = id;
	}

	public void SwitchScreen()
	{
		switch(screenID)
		{
			case 0:
				if(startScreen)
				{
					startScreen.SetActive(true);
				}
				break;

			case 1:
				if(optionsScreen)
				{
					optionsScreen.SetActive(true);
				}
				break;

			case 2:
				if(labScreen)
				{
					labScreen.SetActive(true);
				}
				break;

			default:
				break;
		}

		if(mainScreen)
		{
			mainScreen.SetActive(false);
		}
	}
}
