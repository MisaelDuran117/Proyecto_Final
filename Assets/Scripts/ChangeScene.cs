using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int Index;
    private void Awake()
    {
        Scene scene = SceneManager.GetActiveScene();
        Index = scene.buildIndex;
    }
    void Update()
    {
        if (Input.GetKey("space"))
        {
            LoadScene(Index);
        }

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    public void LoadScene(int scene)
    {
        if (Index == 2)
        {
            Application.Quit();
        }
        else
        {
            SceneManager.LoadScene(scene + 1);
        }
    }
}
