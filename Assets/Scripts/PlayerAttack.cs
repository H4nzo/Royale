using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hanzo
{
    public class PlayerAttack : MonoBehaviour
    {
        bool attacking = false;
        public ParticleSystem bulletParticleSystem;
        private ParticleSystem.EmissionModule em;

        float attackTimer = 0f;
        float firingRate = 10f;



        // Start is called before the first frame update
        void Start()
        {
            em = bulletParticleSystem.emission;
        }

        // Update is called once per frame
        void Update()
        {
            attacking = Input.GetMouseButton(0);
            attackTimer += Time.deltaTime;

            if (attacking && attackTimer >= firingRate)
            {
                Attack();
            }

            em.rateOverTime = attacking ? firingRate : 0f;
        }

        void Attack()
        {
            Ray ray = new Ray(bulletParticleSystem.transform.position, bulletParticleSystem.transform.forward);

            float raycastLength = 100f;
            if (Physics.Raycast(ray, out RaycastHit hit, raycastLength))
            {
                var playerHitHealth = hit.collider.GetComponent<PlayerHealth>();
                if (playerHitHealth != null)
                {
                    float reduceHealthBy = 2f;

                    playerHitHealth.ReduceHealth(reduceHealthBy);
                }
            }





        }






    }
}

