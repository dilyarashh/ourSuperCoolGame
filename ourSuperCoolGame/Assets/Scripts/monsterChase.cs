using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterChase : MonoBehaviour
{
     public Rigidbody monsRigid;
     public Transform monsTrans, playTrans;
     public int monSpeed;

     void FixedUpdate() {
           monsRigid.velocity = transform.forward * monSpeed * Time.deltaTime;
    }
    void Update () {
         monsTrans.LookAt(playTrans);
    }
}