using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Shootball : MonoBehaviour
{
    public GameObject ball;
    
    public Transform camObj;

    public Transform shootPoint;

    public void Shoot()
    {
        GameObject _ball= Instantiate(ball);
        _ball.transform.position=camObj.transform.position;
        Vector3 bVec=(shootPoint.transform.position-camObj.transform.position).normalized;

        Rigidbody _bRb=_ball.GetComponent<Rigidbody>();

        _bRb.AddForce(bVec*100f);
    }

    void Update()
    {
        if(Input.touchCount>0)
        {
            Shoot();
        }
    }
}
