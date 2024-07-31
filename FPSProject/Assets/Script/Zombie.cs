using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public float moveSpeed = 0.5f, detectRange = 10f, attackRange = 1.5f;
    public Transform target;
    public GameObject zombi, ekranFlas;
    private Animator animator;
    public AudioSource[] sound;
    public int Saldiri, VurmaSesi;
    private bool isAttacking = false, isCashing = false;

    private float attackCoolDown = 1.5f, currentCoolDown =0f;

    private void Start()
    {
        animator = zombi.GetComponent<Animator>();
        InvokeRepeating("RandomMovement", 0f, 2f);
    }

    private void Update()
    {
        if(target != null)
        {
            float distanceToTarget = Vector3.Distance(transform.position, target.position);

            if (distanceToTarget <= attackRange)
            {
                Attack();
            }
            else if (distanceToTarget <= detectRange)
            {
                MoveTowardsTarget();
                isCashing = true;
            }
            else {
                isCashing=false; 
                animator.SetBool("isWalking", true);
                animator.SetBool("isAttacking", false);
            }
        }
        if(currentCoolDown > 0)
        {
            currentCoolDown -= Time.deltaTime;
        }
        else
        {
            isAttacking = false;
        }
    }
    void RandomMovement()
    {
        if (!isCashing)
        {
            float randomAngle = UnityEngine.Random.Range(0, 360f);
            transform.Rotate(0f, randomAngle, 0f);
        }
    }

    private void Attack()
    {
        animator.SetBool("isWalking", false);
        animator.SetBool("isAttacking", true);
        if (!isAttacking && KalanCan.OyuncuCan > 0)
        {
            isAttacking = true;
            KalanCan.OyuncuCan -= 1;
            currentCoolDown = attackCoolDown;
            if(KalanCan.OyuncuCan > 0)
            {
                int randomSoundIndex = UnityEngine.Random.Range(0, sound.Length);
                sound[randomSoundIndex].Play();
                StartCoroutine(ActiveAndDeActiveFlas());
            }

        }
    }

    void MoveTowardsTarget()
    {
        transform.LookAt(target);
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
        animator.SetBool("isWalking", true);
        animator.SetBool("isAttacking", false);
    }

    IEnumerator ActiveAndDeActiveFlas()
    {
        ekranFlas.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        ekranFlas.SetActive(false);
    }


}
