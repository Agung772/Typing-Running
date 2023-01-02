
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button[] button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MulaiPermainan(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
    public void KeluarPermainan()
    {
        Application.Quit();
        Debug.Log("Keluar dari permainan");
    }
}
