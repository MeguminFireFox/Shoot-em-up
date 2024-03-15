using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public string Scene;

    private void FixedUpdate()
    {
        if (GameObject.Find("NyanCat") == null)
        {
            SceneManager.LoadScene(Scene);
        }
    }
}
