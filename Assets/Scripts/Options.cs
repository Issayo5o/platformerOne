using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    public Button continueButton;
    public Button restartButton;
    public Button mainmenuButton;
    public Image optionsBackground;
    public TextMeshProUGUI pausedText;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            continueButton.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
            mainmenuButton.gameObject.SetActive(true);
            optionsBackground.gameObject.SetActive(true);
            pausedText.gameObject.SetActive(true);
            Debug.Log("Escape key was pressed!");
            // You can do stuff here, like open a pause menu or quit
        }
    }

    public void Unpause()
    {
        Time.timeScale = 1;
        continueButton.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        mainmenuButton.gameObject.SetActive(false);
        optionsBackground.gameObject.SetActive(false);
        pausedText.gameObject.SetActive(false);
    }
}
