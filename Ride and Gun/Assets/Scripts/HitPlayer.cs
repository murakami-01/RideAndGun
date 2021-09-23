using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlayer : MonoBehaviour
{
    /// <summary>
    /// �v���C���[�ւ̓����蔻��v���O����
    /// </summary>

    public GameObject blood;
    private float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 0.5)
        {
            blood.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        string name = other.gameObject.name;
        //�e�ۂ����������Ƃ��̂ݏo��
        if (name.Substring(0, 7) == "fake_bu"||name.Substring(0,7)=="boss_bu")
        {
            blood.SetActive(true);
            time = 0;
        }
    }

 
}
