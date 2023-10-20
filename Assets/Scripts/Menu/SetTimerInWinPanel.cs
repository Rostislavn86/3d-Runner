using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetTimerInWinPanel : MonoBehaviour
{
    public TMP_Text clockText;
    public TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Общее время " + clockText.text;
    }
}
