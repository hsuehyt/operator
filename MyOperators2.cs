using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyOperators3 : MonoBehaviour
{
    private TextMeshProUGUI TextMeshPro;


    void Start()
    {
        TextMeshPro = GetComponent<TextMeshProUGUI>();
    }


    void Update()
    {

    }



    public void DisplayMessage()
    {
        int anyName = 99;
        anyName += 10;
        anyName -= 10;
        anyName *= 10;
        anyName /= 10;
        ++anyName;

        int anyName2 = 18;
        anyName2++;

        TextMeshPro.text = $"anyName: {anyName} anyName2: {anyName2}";



    }
}
