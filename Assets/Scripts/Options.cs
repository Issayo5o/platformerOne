using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    public Canvas optionsCanvas;
    public PlayerMovement PlayerMovementScript;
    public FinishLine finishLineScript;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && PlayerMovementScript.number < 2 && finishLineScript.isVictory == false)
        {
            Time.timeScale = 0;
            optionsCanvas.gameObject.SetActive(true);
            Debug.Log("Escape key was pressed!");
            Cursor.visible = true;
            // You can do stuff here, like open a pause menu or quit
        }
    }

    public void Unpause()
    {
        Time.timeScale = 1;
        optionsCanvas.gameObject.SetActive(false);
        Cursor.visible = false;
    }
}
