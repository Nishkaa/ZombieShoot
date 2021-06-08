using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ControllerScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void NextScene()
    {
        SceneManager.LoadScene("Level01");
    }
    public void QuitApplication()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
    }
}
