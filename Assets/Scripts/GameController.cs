using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text ScoreLabel;
    public GameObject winnerLabelObject;
    public void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Pick Up").Length;
        ScoreLabel.text = count.ToString();

        if (count == 0)
        {
            winnerLabelObject.SetActive(true);
        }
    }
}
