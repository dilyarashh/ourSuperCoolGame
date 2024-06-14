using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Door : MonoBehaviour
{
    public GameObject door_closed, door_opened, intText;
    public AudioSource open, close;
    public bool opened;

    void OnTriggerStay (Collider other) {
        if (other.CompareTag("MainCamera")) {
            if (opened == false) {
                intText.SetActive (true);
                if (Input.GetKeyDown(KeyCode.E)){
                    door_closed.SetActive(false);
                    door_opened.SetActive(true);
                    intText.SetActive(false);
                    //open.Play();
                    StartCoroutine(repeat());
                    opened = true;
                }
            }
        }
    }

    void OnTriggerExit (Collider other) {
        if (other.CompareTag ("MainCamera")) {
            intText.SetActive (false);
        }
    }

    IEnumerator repeat () {
        yield return new WaitForSeconds (4.0f);
        opened = false;
        door_closed.SetActive(true);
        door_opened.SetActive(false);
        //close.Play();
    }
}
