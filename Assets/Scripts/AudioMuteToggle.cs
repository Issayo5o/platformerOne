using UnityEngine;
using UnityEngine.UI;

public class AudioMuteToggle : MonoBehaviour
{
    public bool isMuted = false;

    public void ToggleMute()
    {
        isMuted = true;
        AudioListener.pause = true;
    }

    public void ToggleUnmute()
    {
        isMuted = false;
        AudioListener.pause = false;
    }
}