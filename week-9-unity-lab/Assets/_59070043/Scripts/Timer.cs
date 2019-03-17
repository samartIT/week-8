using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    Text txt;
    public static float timeLeft = 30.0f;
    private void Start()
    {
        txt = gameObject.GetComponent<Text>();
        txt.text = ""+timeLeft;
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        txt.text = ""+(int)timeLeft;
        if (timeLeft <= 0)
        {
            timeLeft = 0;
        }
    }
}