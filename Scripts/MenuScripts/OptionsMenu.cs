using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    Resolution[] resolutions;
    public Dropdown resolutionsDropdown;
    void Start(){
        resolutions = Screen.resolutions;
        int currentResolutionIndex = 0;
        resolutionsDropdown.ClearOptions();
        List<string> options = new List<string>();
        for(int i = 0; i < resolutions.Length; i++){
            string option = resolutions[i].width + " x " +resolutions[i].height;
            options.Add(option);
            if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height){
                currentResolutionIndex = i;
            }
        }
        resolutionsDropdown.AddOptions(options);
        resolutionsDropdown.value = currentResolutionIndex;
        resolutionsDropdown.RefreshShownValue();

    }
    public AudioMixer audioMixer;
    public void SetResolution(int resolutionIndex){
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    public void SetVolume(float volume){
        audioMixer.SetFloat("volume", volume);
    }
    public void setQuality(int qualityIndex){
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    public void FullScreen(bool isFullscreen){
        Screen.fullScreen = isFullscreen;
    }
}
