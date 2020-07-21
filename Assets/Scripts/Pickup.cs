using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    private Inventory inventory;
    public GameObject itemIcon;

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.Find("Player").GetComponent<Inventory>();
    }

    public void AddToInventory()
    {
        for (int i = 0; i < inventory.slots.Length; i++)
        {
            if (inventory.isFull[i] == false)
            {
                // ITEM CAN BE ADDED TO INVENTROY
                inventory.isFull[i] = true;
                Instantiate(itemIcon, inventory.slots[i].transform, false);
                Destroy(gameObject);
                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
