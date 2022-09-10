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

        [Header("Bullet Properties")]
        [SerializeField] private float bulletDespawnTime = 3f; 


        void Start()
        {
            target = playerPos.position;
            StartCoroutine(BulletDespawn());
        }

        void Update()
        {
            float speed = bulletSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target, speed);
            if (transform.position == target) Destroy(this.gameObject);
        }

        private IEnumerator BulletDespawn()
        {
            yield return new WaitForSeconds(bulletDespawnTime);
            Destroy(this.gameObject);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag != "Enemy") Destroy(this.gameObject);
        }
    }
}
