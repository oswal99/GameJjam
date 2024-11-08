using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio_Controller : MonoBehaviour
{

    public Slider ValSlider;


    public void Start()
    {
        if (PlayerPrefs.HasKey("soundVolume"))
            LoadVolume();
        else
        {
            PlayerPrefs.SetFloat("soundVolume", 1);
            LoadVolume();
        }
    }

    public void Setvalue()
    {

        AudioListener.volume = ValSlider.value;
        SaveValue();
    }
    public void SaveValue()
    {

        PlayerPrefs.SetFloat("soundVolume", ValSlider.value);
    }

    public void LoadVolume()
    {
        ValSlider.value = PlayerPrefs.GetFloat("soundVolume");
    }

    //We HAVE TO ADD THE SOUND SO THIS CAN WORK
    
}
