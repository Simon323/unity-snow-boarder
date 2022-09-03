using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelat = 1f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("This the end");
            Invoke("ReloadScene", loadDelat);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
