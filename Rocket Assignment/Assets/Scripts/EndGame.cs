using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndGame : MonoBehaviour
{
    public string endgameText = "";

    public TextMeshProUGUI textEnd;

    private void OnTriggerEnter(Collider other)
    {
        textEnd.text = endgameText.ToString();
    }
}
