using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeButtonLabel : MonoBehaviour
{
    public void SetText(string text)
    {
        Debug.Log("MY TEXT SET FOR BUTTON "+ text);
        TextMeshProUGUI buttonLabel = transform.Find("ButtonLabel").GetComponent<TextMeshProUGUI>();
        buttonLabel.GetComponent<TextMeshProUGUI>().text = text;
    }
}
