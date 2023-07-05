using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    public void MoveToShooting()
    {
        SceneManager.LoadScene(1);
    }
    
    public void MoveToGolf()
    {
        SceneManager.LoadScene(2);
    }

    public void MoveToShop()
    {
        SceneManager.LoadScene(3);
    }
}
