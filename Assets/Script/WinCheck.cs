using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinCheck : MonoBehaviour
{
    [SerializeField] Object m_object;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject==m_object)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
