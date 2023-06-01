using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui : MonoBehaviour
{
    private Text m_text;
    private int m_score = 0;

    private GameObject counting;

    // Start is called before the first frame update

    void Start()
    {
        m_text = GetComponent<Text>();
        counting = GameObject.Find("Counting");
    }

    void ScoreUP()
    {
        m_score += 10;
        m_text.text = "SCORE: " + m_score.ToString();
    }

    /*
    void Update()
    {
        if (counting.GetComponent<Counting>().isCountUp)
        {
            ScoreUP();
        }
    }
    */
}
