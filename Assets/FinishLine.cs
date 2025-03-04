using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class FinishLine : MonoBehaviour
{

    public TextMeshProUGUI VictoryText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Player"){

            VictoryText.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
