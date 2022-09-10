using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BEAN 
{
    public class EnemyController : MonoBehaviour
    {
        [Header("Detection")]
        [SerializeField] private float detectionRange = 50f;

        [Header("References")]
        [SerializeField] private Transform playerPos;


        void Update()
        {
            DetectPlayer();
        }

        // If player is in range then attack
        private void DetectPlayer()
        {
            float distance = Vector3.Distance(playerPos.position, transform.position);
            if (distance < detectionRange)
            {
                AttackPlayer();
            }
        }

        // Shoot at the player
        private void AttackPlayer()
        {
            
        }
    }
}
