using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public LayerMask EventLayer;
    public GameObject inventory;

    
    private Vector2 movement;
    private Rigidbody2D _rb;
    private Animator _a;
    private Vector2 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        mousePos = transform.position;
        _rb = GetComponent<Rigidbody2D>();
        _a = GetComponent<Animator>();
    }



    private void Update()
    {

        // Debug.Log(Camera.main.ScreenPointToRay(Input.mousePosition));
        if (Input.GetMouseButton(0))
        {
            // set the mousePos, mouse's position in the world space
            mousePos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
            Camera.main.ScreenToWorldPoint(Input.mousePosition).y);

        }

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, Mathf.Infinity, EventLayer);
            if (hit.collider != null)
            {
                Debug.Log("Target Position: " + hit.collider.gameObject.name);
                Interactive e = hit.collider.GetComponent<Interactive>();
                if (e != null && Mathf.Abs(hit.collider.transform.position.x - transform.position.x) <= 1f)
                {
                    e.triggerEvent();
                }
            }
        }

        // move Left or move Right
        if (mousePos.x - transform.position.x >= 0.5)
        {
            movement.x = 1;
        }
        else if (mousePos.x - transform.position.x <= -0.5)
        {
            movement.x = -1;
        }
        else
        {
            movement.x = 0;
        }

        // flip the player based on the speed
        flip();

        // set the speed of player
        Vector2 _v = new Vector2(0, 0);
        float _y = _rb.velocity.y;
        if (_y >= 0)
        {
            _y = 0f;
        }
        _v = new Vector2(movement.x * speed, _y);
        
        _rb.velocity = _v;

        // set Animator
        _a.SetFloat("SpeedHorizontal", Mathf.Abs(movement.x));


        mousePos = transform.position;


    }

    void flip()
    {
        if (movement.x < 0)
        {
            transform.eulerAngles = new Vector3(0, 180f, 0);
        }
        else if (movement.x > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }




}
