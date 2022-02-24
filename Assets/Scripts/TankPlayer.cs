using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankPlayer : BaseControler
{
    public float moveSpeed = 2;

    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     MoveTank();
    }

    private void MoveTank()
    {
        if(Input.GetKey(KeyCode.Z))
        {
            gameObject.transform.Translate(Vector3.forward*moveSpeed);
        }
        if(Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(Vector3.back*moveSpeed);
        }
        if(Input.GetKey(KeyCode.Q))
        {
            gameObject.transform.Rotate(0f, 0.1f*rotationSpeed, 0f ); 
        }
        if(Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Rotate(0f, -0.1f*rotationSpeed, 0f ); 
        }
    }

    private void GetMousePosition()
    {
        RaycastHit hit;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
           
        }
    }

    private void GetMouseClic()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Fire();
            
        }
    }
}
