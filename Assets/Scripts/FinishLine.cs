using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
public class FinishLine : MonoBehaviour
{
    public bool isVictory;
    public Canvas victoryCanvas;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Player"){

            Time.timeScale = 0f;
            victoryCanvas.gameObject.SetActive(true);
            isVictory = true;
            Cursor.visible = true;
        }
    }
}
