using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hanzo
{
    public class GenerateEnemies : MonoBehaviour
    {
        public GameObject theEnemy;
        public int enemiesCreated = 0;

        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(CreateEnemies());
        }

        IEnumerator CreateEnemies()
        {
            int numberOfEnemies = 10;
            var yPos = 0.58f;

            while (enemiesCreated < numberOfEnemies)
            {
                var xPos = Random.Range(-25, 25);
                var zPos = Random.Range(-25, 25);

                Instantiate(theEnemy, new Vector3(xPos, yPos, zPos), Quaternion.identity);

                yield return new WaitForSeconds(0.1f);

                enemiesCreated += 1;
            }
        }


    }
}

