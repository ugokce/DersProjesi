using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Slider = UnityEngine.UI.Slider;

public enum GraphicsLevel
{
    Ultra = 0,
    Mega = 1,
    Patato = 2,
    UltraPatato = 3
}

public class Settings : MonoBehaviour
{
    public int musicLevel = 100;

    public GraphicsLevel graphicsLevel = 0;

    public Slider soundSlider;
    public TMP_Dropdown graphicsDropdown;

    private void Start()
    {
        musicLevel = PlayerPrefs.GetInt("musicLevel", 0);
        soundSlider.value = musicLevel;
    }

    public void ChangeMusicVolume()
    {
        musicLevel =  Mathf.RoundToInt(soundSlider.value);
        PlayerPrefs.SetInt("musicLevel", musicLevel);
    }
    
    public void ChangeGraphicsLevel()
    {
        graphicsLevel = (GraphicsLevel)graphicsDropdown.value;
    }
}
