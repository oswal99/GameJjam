using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause_Control : MonoBehaviour
{


    public GameObject PauseControl;

    // Start is called before the first frame update
    void Start()
    {
        PauseControl.SetActive(false);

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PauseGame()
    {
        PauseControl.SetActive(true);

        Time.timeScale = 0f;
    }
    public void ResumeGame()
    {
        PauseControl.SetActive(true);

        Time.timeScale = 1f;

    }


}
