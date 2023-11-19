using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int hp = 3;
    public int currentLevel;
    public List<string> levels;

    public static GameManager instance;
    void Start()
    {
        if (instance == null)
        {


            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void Win()
    {
        currentLevel++;
        Invoke("loadnextlevel", 1f);
        
    }
    void loadnextlevel()
    {
        SceneManager.LoadScene(levels[currentLevel]);
    }
    public void lose()
    {
        if (hp ==0)
        {
            SceneManager.LoadScene(levels[0]);
        }
        hp = 3;
    }

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
