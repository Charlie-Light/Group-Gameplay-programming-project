using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{ 
    public static int score;
    public TMPro.TextMeshProUGUI textScore;

    void Update()
    {
        textScore.text = "Score: " + score;
    }
}
