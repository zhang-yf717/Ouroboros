using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private GameObject Player;
    private SpriteRenderer _sr;
    private Inventory playerInventory;
    
    
    public bool isLocked;
    public string keyName;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        playerInventory = Player.GetComponent<Inventory>();
        _sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TriggerDoor(Vector2 newPos)
    {
        if (playerInventory.CheckItemInInventory(keyName))
        {
            isLocked = false;
        }

        if (!isLocked)
        {
            Player.transform.position = newPos;
        }
        else
        {
            GetComponent<DialogueTrigger>().TriggerDialogue();
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            _sr.color = new Color(1,1,1,.5f);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            _sr.color = new Color(1, 1, 1, 1f);
    }
}
