using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine;

public class SetPortal : MonoBehaviour
{
    public Transform transform;
    public float UpSpeed= 0.1f;
    Vector3 Base= new Vector3(1,0,1);
    bool IsSet= false;
    
    private void Start() 
    {
        transform=this.GetComponent<Transform>();
        transform.localScale=Base;
    }

    public void Up()
    {
        while (true)
        {
            transform.localScale=new Vector3(1,UpSpeed*Time.deltaTime,1);
            if(transform.localScale.y==1)
            {
                break;
            }
        }
    }
}
