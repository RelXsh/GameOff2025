using TMPro;
using UnityEngine;
using System.Collections;

public class TypeEffect : MonoBehaviour
{
    private TextMeshProUGUI tmp;

    private void Awake()
    {
        tmp = GetComponentInParent<TextMeshProUGUI>();
        if (tmp == null)
            Debug.Log("No TextMeshProUGUI Found");
    }

    public void Print(string textToPrint)
    {
        tmp.text = "";
        tmp.text = textToPrint;
    }
}
