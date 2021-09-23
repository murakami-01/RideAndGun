using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoss : MonoBehaviour
{
    /// <summary>
    /// boss‚Ì“–‚½‚è”»’è
    /// </summary>
 
    private int damage = 0;
    private float time = 100;
    private Animator animator;
    private bool killed = false;
    public GameObject littlefire;
    public GameObject littleexplosion;
    public GameObject speak;
    public GameObject speak2;
    public GameObject speak3;
    public GameObject fire;
    public GameObject explosion;
    public GameObject prediction;

    // Start is called before the first frame update
    private void Start()
    {
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        time +=Time.deltaTime;
        if (time >= 1f)
        {
            speak.SetActive(false);
            speak2.SetActive(false);
        }
        if (killed && time >= 2)
        {
            speak3.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
            damage++;
            if (damage == 2)
            {
                littleexplosion.SetActive(true);
                littlefire.SetActive(true);
                speak.SetActive(true);
                time = 0;
            }else if (damage == 4)
            {
                speak.SetActive(false);
                animator.SetTrigger("Die");
                GameObject.Destroy(this.gameObject.GetComponent<EnemyMove>());
                prediction.SetActive(false);
                speak2.SetActive(true);
                explosion.SetActive(true);
                fire.SetActive(true);
                time = 0;
                killed = true;
            }
        
    }
}
