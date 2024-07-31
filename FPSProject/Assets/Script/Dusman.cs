using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dusman : MonoBehaviour
{
    [SerializeField] int DusmanSagligi = 10;
    public GameObject zombi;

    public void dusman(int HasarMiktari)
    {
        DusmanSagligi -= HasarMiktari;
    }

    private void Update()
    {
        if(DusmanSagligi <= 0)
        {
            zombi.GetComponent<Animator>().SetBool("isDyling", true);
            zombi.GetComponent<Animator>().SetBool("isWalking", false);
            zombi.GetComponent<Animator>().SetBool("isAttacking", false);
            Invoke("ZombiOlum", 3);
        }
    }

    void ZombiOlum()
    {
        Destroy(gameObject);
    }
}
