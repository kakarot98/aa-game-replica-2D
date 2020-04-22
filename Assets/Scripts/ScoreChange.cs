using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreChange : MonoBehaviour
{

    public static int pinCount;
    [SerializeField]
    private TextMeshProUGUI scoreValueText = default;



    private void Start()
    {
        pinCount = 0;
    }


    

    void Update()
    {
        scoreValueText.text = pinCount.ToString();   
    }
}
