using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseControler : MonoBehaviour
{
  private float _headRotationSpeed = 0.1f ; 
  
  public Transform headTransform;
  public Transform projectilSpawnPoint;
  public GameObject bulletPrefab;
  protected Vector3 headDirection;
  
  

  protected void HeadTowardDirection(Vector3 TargetDirection, Transform HeadTransform)
  {
    float Angle = Vector3.SignedAngle(TargetDirection, HeadTransform.forward, Vector3.up);
    Debug.Log(Angle);
    if (Angle>1f)
    {
      headTransform.Rotate(0f,-_headRotationSpeed, 0,0f);
    }
    else if(Angle<-1f)
    {
      headTransform.Rotate(0f,_headRotationSpeed, 0,0f);
    }

  }

  protected void Fire(Transform amoTransform, GameObject _amo)
  {
    Rigidbody NewAmo; 
    NewAmo = Instantiate(_amo, amoTransform, transform.rotation)
  }
}
