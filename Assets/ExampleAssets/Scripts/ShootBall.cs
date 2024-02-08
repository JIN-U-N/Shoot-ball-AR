using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall : MonoBehaviour
{
    public GameObject  _theBall;
    public Transform _camObj;
    public Transform _shootPoint;

  public void ShootBallObj()
  {
    GameObject tObj= Instantiate(_theBall);
    tObj.transform.position= _shootPoint.transform.position;
    Vector3 tVec= (_shootPoint.transform.position - _camObj.transform.position).normalized;
    Rigidbody tR= tObj.GetComponent<Rigidbody>();
    tR.AddForce(tVec*100f);
  }

  void Update()
  {
    if(Input.touchCount>0)
    {
      ShootBallObj();
    }
  }
}


//nomalized는 목적지-현재위치를 통해 단위벡터를 구한다. 단위벡터란 크기는 1로 고정이며 방향을 나타낸다.즉 방향을 알기 위해 사용된다. 따라서 nomalized는 정규화된 이동될 방향을 나타낸다. 
//magnitude는 Vector3의 길이혹은 크기를 반환한다. 이렇게 구한 길이를 통해 두 좌 표 사이의 거리를 구하거나 물체의 속력을 구할 수 있다.(목적지 - 현재위치).magnitude = 남은 거리


  //ShootBallObj 요약
  //1. 물체의 생성  2.물체의 포지션값 설정  3.물체의 벡터값(나아갈 벡터값)설정, 4.물체의 중력작용  5. 중력작용의 힘 적용 