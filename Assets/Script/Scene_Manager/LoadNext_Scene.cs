using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadNext_Scene : MonoBehaviour
{
    public void ClicktoNextScene()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   
    }
}
