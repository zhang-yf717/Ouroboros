using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInfo : MonoBehaviour
{
    public string info;
    private Text DisplayText;
    // Start is called before the first frame update
    void Start()
    {
        DisplayText = GameObject.Find("ItemDisplayText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowInfo()
    {
        DisplayText.text = info;
    }
}
