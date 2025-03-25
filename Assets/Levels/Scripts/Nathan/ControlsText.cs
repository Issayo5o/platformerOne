using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

public class ControlsText : MonoBehaviour
{
    public TextMeshProUGUI text; // Reference to your UI Text element

    private void Start()
    {
        // Hide the text initially
        if (text != null)
        {
            text.gameObject.SetActive(false);
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        // Check if the player (or other object) is inside the trigger area
        if (other.CompareTag("Player")) // Make sure your player has the "Player" tag
        {
            // Show the text while inside the collider
            if (text != null)
            {
                text.gameObject.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Hide the text when the player leaves the collider
        if (other.CompareTag("Player"))
        {
            if (text != null)
            {
                text.gameObject.SetActive(false);
            }
        }
    }
}
