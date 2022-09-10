using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BEAN 
{
    public class EnemyController : MonoBehaviour
    {
        [Header("Shooting")]
        [SerializeField] private float shootDelay = 2f;

        [Header("Detection")]
        [SerializeField] private float detectionRange = 50f;

        [Header("References")]
        [SerializeField] private Transform playerPos;
        [SerializeField] private GameObject bulletPrefab;


        void Start()
        {
            StartCoroutine(DetectPlayer());
        }

        // If player is in range then attack
        private IEnumerator DetectPlayer()
        {
            while (true)
            {
                float distance = Vector3.Distance(playerPos.position, transform.position);
                if (distance < detectionRange)
                {
                    AttackPlayer();
                }
                yield return new WaitForSeconds(shootDelay);
            }
        }

        // Shoot at the player
        private void AttackPlayer()
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            bullet.GetComponent<Bullet>().playerPos = playerPos;
        }
    }
}
