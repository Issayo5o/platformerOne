using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class VolumeManager : MonoBehaviour
{
    public Image volumeBackground;
    public Button onButton;
    public Button offButton;
    public Button closeButton;
    private bool volumeOn = false;
    public AudioMuteToggle muteToggle;

    public void Update()
    {
        if (volumeOn == true)
        {
            if (muteToggle.isMuted == false)
            {
                onButton.gameObject.SetActive(true);
                Debug.Log("not muted");
            }
            else if (muteToggle.isMuted == true)
            {
                offButton.gameObject.SetActive(true);
                Debug.Log("is muted");
            }
        }
    }

    public void TriggerVolumeButton()
    {
        volumeBackground.gameObject.SetActive(true);
        closeButton.gameObject.SetActive(true);
        volumeOn = true;
    }

    public void TriggerVolumeOn()
    {
        offButton.gameObject.SetActive(true);
        onButton.gameObject.SetActive(false);
    }

    public void TriggerVolumeOff()
    {
        onButton.gameObject.SetActive(true);
        offButton.gameObject.SetActive(false);
    }

    public void TriggerCloseButton()
    {
        volumeBackground.gameObject.SetActive(false);
        onButton.gameObject.SetActive(false);
        offButton.gameObject.SetActive(false);
        closeButton.gameObject.SetActive (false);
        volumeOn = false;
    }
}
