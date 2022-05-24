using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    public AudioMixer audioMixer;

    public Slider volumeSlider;

    public TMPro.TMP_Dropdown qualityDropdown;

    public TMPro.TMP_Dropdown resolutionDropdown;

    public Toggle fullscreenToggle;

    Resolution[] resolutions;

    void Start()
    {   
        //Resolutions dropdown code

        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height + " @ " + resolutions[i].refreshRate + "Hz";
            options.Add(option);

            if (resolutions[i].width == Screen.width &&
                resolutions[i].height == Screen.height &&
                resolutions[i].refreshRate == Screen.currentResolution.refreshRate)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();

        //Set volume slider to current volume
        audioMixer.GetFloat("volume", out float volumevalue);
        volumeSlider.value = volumevalue;

        //Set Quality Dropdown to current quality
        qualityDropdown.value = QualitySettings.GetQualityLevel();

        //Set fullscreen toggle to current fullscreen state
        fullscreenToggle.isOn = Screen.fullScreen;
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
    
}
