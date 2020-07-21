using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactive : MonoBehaviour
{
    
    private bool _isPlayerWithinZone = false;


    public GameObject InteractIndicator;

    

    public bool showDialogue;
    public bool showPuzzle;
    public bool showImage;
    public GameObject Image;
    public bool isDoor;
    public Vector2 newPosition;

    public bool isTriggerNewInteract;
    public GameObject NewInteract;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if (_isPlayerWithinZone)
        {
            InteractIndicator.SetActive(true);
        }
        else
        {
            InteractIndicator.SetActive(false);
        }
    }

    public void triggerEvent()
    {
        if (showDialogue)
        {
            GetComponent<DialogueTrigger>().TriggerDialogue();
        }
        if(showPuzzle)
        {
            GetComponent<Puzzle>().TriggerPuzzle(); // remember to disable player controller

        }
        if (isDoor)
        {
            GetComponent<Door>().TriggerDoor(newPosition);
        }

        if (showImage)
        {
            Image.SetActive(true);
        }
        if (isTriggerNewInteract)
        {
            NewInteract.SetActive(true);
        }

    }
    public void endEvent()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Someone near");
        _isPlayerWithinZone = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Someone leaves");
        _isPlayerWithinZone = false;
    }
}
