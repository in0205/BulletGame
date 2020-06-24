﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bulletRigidbody;

    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = transform.forward * speed;
        Destroy(gameObject, 3f);
    }
    //트리거 충돌 시 자동으로 실행되는 함수
    void OnTriggerEnter(Collider other)
    {
        // 충돌한 상대방 게임 오브젝트가 Player 태그를 가진 경우
        if (other.tag == "Player")
        {
            // 상대방 게임 오브젝트에서 PlayerController 컴포넌트 가져오기
            PlayerController playerController = other.GetComponent<PlayerController>();
            //상대방으로부터 PlayerController 컴포넌트를 가져오는데 성공했다면
            if (playerController != null)
            {
                //tkdeoqkd 컴포넌트의 Die()를 실행함.
                playerController.Die();
            }
        }
    }
}
