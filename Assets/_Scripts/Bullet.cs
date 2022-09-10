using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace BEAN 
{
    public class Bullet : MonoBehaviour
    {
        [HideInInspector] public Transform playerPos;
        [HideInInspector] public float bulletSpeed;
        private Vector3 target;


        void Start()
        {
            target = playerPos.position;
        }

        void Update()
        {
            float speed = bulletSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target, speed);
            if (transform.position == target) Destroy(this.gameObject);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag != "Enemy") Destroy(this.gameObject);
        }
    }
}
