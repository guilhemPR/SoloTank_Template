using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : BaseControler
{
    public Transform TankTransform;
    public float detectionDistance = 20f;
    private bool ifTankDetected = false;
    private float _fireDelay = 2;
    private float _timer; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TankDetected();
    }

    private void TankDetected()
    {
        RaycastHit hit;

        Vector3 direction = Vector3.Normalize((TankTransform.position - headTransform.position));
        if (Physics.Raycast(headTransform.position,direction, out hit, detectionDistance ))
        {
            if (hit.collider.gameObject.GetComponentInParent<TankPlayer>() != null)
            {
                HeadTowardDirection(direction, headTransform);
                Debug.Log("proute");
                Debug.DrawRay(headTransform.position, direction, Color.blue, 2f);

                
            }
        }
    }

    private void FirerTimer()
    {
       Debug.Log("Coucou");
    }
}
