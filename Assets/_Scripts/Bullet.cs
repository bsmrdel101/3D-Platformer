using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace BEAN 
{
    public class Bullet : MonoBehaviour
    {
        public Transform playerPos;

        [Header("Bullet Values")]
        // [SerializeField] private int bulletDespawnTime = 1000;
        [SerializeField] private float bulletSpeed = 10f;

        void Update()
        {
            float speed = bulletSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, playerPos.position, speed);
        }
    }
}
