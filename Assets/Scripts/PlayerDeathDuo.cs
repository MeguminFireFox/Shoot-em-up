using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeathDuo : MonoBehaviour
{
    public string Scene;

    private void FixedUpdate()
    {
        if (GameObject.Find("NyanCat") == null)
        {
            if (GameObject.Find("NyanCat 1") == null)
            {
                SceneManager.LoadScene(Scene);
            }
        }
    }

}
