using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerScript : MonoBehaviour
{
    int Score = 0;
    public bool scorebool = false;
    Text Scoretext;
    // Start is called before the first frame update
    void Start()
    {
        Scoretext = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(scorebool == true)
        {
            Score += 10;
            Scoretext.text = "SCORE : " + Score;
            scorebool = false;
        }
    }
}
