using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Click_functions : MonoBehaviour
{  
    public int loadlvl;

    public void LoadScene(int level)
    {
        loadlvl = level;
        Application.LoadLevel(loadlvl);
    }

    public void quitScene()
    {
        Application.Quit();
    }
}
