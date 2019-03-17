using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    Text txt;
    public static int currentscore = 0;

    // Use this for initialization
    void Start()
    {
        txt = gameObject.GetComponent<Text>();
        txt.text = "Score = " + currentscore;
    }
    void Update()
    {
        txt.text = "Score = " + currentscore;
    }
}
