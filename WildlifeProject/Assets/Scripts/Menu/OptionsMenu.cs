using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio; 

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public CameraMechanicsRework CamMec;

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }

    public void setSens(float Sens)
    {
        CamMec.cameraDragSpeed = Sens;
    }

    public void SetQuality (int  qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen ()
    {
        if (Screen.fullScreen == true)
        {
            Screen.fullScreen = false;
            Debug.Log("!fullscreen");

            return;
        }

        if (Screen.fullScreen == false)
        {
            Screen.fullScreen = true;
            Debug.Log("fullscreen");

            return;
        }
    }
}
