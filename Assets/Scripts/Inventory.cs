using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    
    public bool[] isFull;
    public GameObject[] slots;
    public string[] items;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToInventory(GameObject Item)
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (isFull[i] == false)
            {
                Debug.Log(i);
                // ITEM CAN BE ADDED TO INVENTROY
                isFull[i] = true;

                GameObject temp = Instantiate(Item, slots[i].transform, false);

                items[i] = Item.name;
                break;
            }
        }
    }

    public bool CheckItemInInventory(string ItemName)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == ItemName)
            {
                return true;
            }
        }
        return false;
    }

}
