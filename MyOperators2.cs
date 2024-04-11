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

        int anyName3 = anyName2++;

        int anyName4 = 5 / 2;

        int anyName5 = 5 % 2;

        int anyName6 = 2 * anyName2;

        int anyName7 = 18 - 3 * 6 + 1;

        int multiplication = 3 * 6;
        int additional = 18;
        int solution = additional - multiplication + 1;

        TextMeshPro.text = $"anyName: {anyName} anyName2: {anyName2} anyName3: {anyName3} anyName4: {anyName4} anyName5: {anyName5} anyName6: {anyName6} anyName7:{anyName7} solution:{solution}";



    }
}
