using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private GameObject Player;
    private float _y;
    private float _z;
    private void Awake()
    {
        Player = GameObject.Find("Player");
        if (Player == null)
        {
            Debug.Log("Player gameobject not found!!!");
        }
        _y = transform.position.y;
        _z = transform.position.z;
    }

    private void Update()
    {
        transform.position = new Vector3(Player.transform.position.x, _y, _z);
    }
}
