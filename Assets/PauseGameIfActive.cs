using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGameIfActive : MonoBehaviour
{
    private int i;
    private PlayerController playerController;
    
    // Start is called before the first frame update
    void Start()
    {
        i = transform.childCount;
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = 1f;
        playerController.enabled = true;

        for (int x= 0; x<i; x++)
        {
            if(transform.GetChild(x).gameObject.activeSelf == true)
            {
                Time.timeScale = 0f;
                playerController.enabled = false;
            }
        }
    }
}
