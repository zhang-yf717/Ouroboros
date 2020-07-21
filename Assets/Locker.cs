using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Locker : MonoBehaviour
{
    public Text InputText;
    public string CorrectPassword;
    public GameObject ItemAfterUnlock;
    public GameObject MyInteractive;
    private int InputTimer = 0;
    private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        InputText.text = "";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InputButton(string num)
    {
        if (InputText.text == "error")
        {
            InputText.text = "";
        }
        InputTimer++;
        string temp = InputText.text;
        temp += num;
        InputText.text = temp;
        
    }

    public void CheckPassword()
    {
        if (InputText.text != CorrectPassword)
        {
            InputText.text = "error";
            InputTimer = 0;
        }
        else
        {
            Unlock();
        }
    }

    public void ClearPassword()
    {
        InputText.text = "";
    }

    public void Unlock()
    {
        Player.GetComponent<Inventory>().AddToInventory(ItemAfterUnlock);
        gameObject.SetActive(false);
        // "unlock success text"
        GetComponent<DialogueTrigger>().TriggerDialogue();
        DisableInteractiveAfterUnlock();
    }
    
    void DisableInteractiveAfterUnlock()
    {
        MyInteractive.SetActive(false);
    }
}
