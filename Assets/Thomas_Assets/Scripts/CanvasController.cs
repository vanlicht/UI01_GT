using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    #region Public Variables
    public bool isTimedScreen;
    public float screenTime = 3f;
    public GameObject targetTimedScreen;
    #endregion

    #region Private Variables
    private float startTime;
    #endregion

    #region Main Methods
    void Start()
    {
        SetupCanvas();
    }

    void OnEnable()
    {
        SetupCanvas();
    }

    void Update()
    {
        if (isTimedScreen)
        {
            while(Time.time < startTime + screenTime)
            {
                return;
            }
            if (targetTimedScreen)
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
