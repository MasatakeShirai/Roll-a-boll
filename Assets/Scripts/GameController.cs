using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text ScoreLabel;
    public GameObject winnerLabelObject;
    public GameObject player;

   public void start()
    {
        player = GameObject.Find("player");
    }

    public void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Pick Up").Length;
        ScoreLabel.text = count.ToString();

        if (count == 0)
        {
            winnerLabelObject.SetActive(true);
            player.SetActive(false);
            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene("start");
            }
        }
    }
}
