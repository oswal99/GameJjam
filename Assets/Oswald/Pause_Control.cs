using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause_Control : MonoBehaviour
{


    public GameObject Slider;
    public GameObject Button;
    public bool Ispaused;

    // Start is called before the first frame update
    void Start()
    {
        Slider.SetActive(false);
        Button.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Ispaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }

    }
    public void PauseGame()
    {
        Slider.SetActive(true);
        Button.SetActive(true);

        Time.timeScale = 0f;
        Ispaused = true;
    }
    public void ResumeGame()
    {
        Slider.SetActive(false);
        Button.SetActive(false);

        Time.timeScale = 1f;
        Ispaused = false;

    }


}
