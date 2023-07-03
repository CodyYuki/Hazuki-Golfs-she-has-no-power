using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThugSpawner : MonoBehaviour
{
    public GameObject Thug;
    //public GameObject canvas;
    public List<GameObject> bushes;
    public float respawnTime = 1.0f;
    public int rollthedice; 
    

 
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(thugwave());a
    }


    public void StartWave()
    {
        StartCoroutine(thugwave());
        Timer.roundStart = true;
    }

    // public void MoveToGolf()
    // {
    //     SceneManager.LoadScene(2);
    // }

    private void spawnThug()
    {
        //a.transform.SetParent(canvas.transform, false);

        if (bushes.Count >= 1)
        {
             if (Timer.roundStart == true)
         {
            GameObject clonethug = Instantiate(Thug) as GameObject;
            rollthedice = (Random.Range(0, bushes.Count));
            clonethug.transform.position = bushes[rollthedice].transform.position; //new Vector3(0,0,0)
         }
         else
         {
            
         }
            

        }
    }




    IEnumerator thugwave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnThug();
        }
    }
}
