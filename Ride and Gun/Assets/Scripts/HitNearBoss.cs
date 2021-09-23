using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitNearBoss : MonoBehaviour
{
    /// <summary>
    /// “G‚ÉUŒ‚‚ª“–‚½‚Á‚½‚Ìˆ—
    /// </summary>
    private float time = 100;

    public GameObject enemy;
    public GameObject explosion;
    public GameObject fire;
    public GameObject prediction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time < 100 && time >= 5)
        {
            Destroy(enemy);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        GameObject.Destroy(enemy.GetComponent<EnemyMove>());
        Destroy(prediction);
        explosion.SetActive(true);
        fire.SetActive(true);
        time = 0;
    }
}
