using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuscript : MonoBehaviour
{
    public string scenename;
    void Update() {
        if (Input.GetKey(KeyCode.P)){
            SceneManager.LoadScene(scenename);
        }

        if (Input.GetKey(KeyCode.Escape)){
            Application.Quit();
        }
    }
}
