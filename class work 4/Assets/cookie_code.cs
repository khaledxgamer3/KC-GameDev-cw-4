using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class cookie_code : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoretext;
    int price =5;
    public int increase = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void cookie_press()
    {
        score+= increase;
        scoretext.text = "score: " + score.ToString();
    }


    public void shop_press()
    {
        if (score >= price)
        {
            increase++;
            score -= price;
            scoretext.text = "score: " + score.ToString();

        }
    }
}
