using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    // private bool _isFirstTime;
    
    public GameObject PuzzleUI;
    // Start is called before the first frame update
    void Start()
    {
        
        // _isFirstTime = true;
    }

    public void TriggerPuzzle()
    {
        PuzzleUI.SetActive(true);
        
        Time.timeScale = 0f;
    }

    public void ClosePuzzle()
    {
        PuzzleUI.SetActive(false);
        
        Time.timeScale = 1f;
    }


}
