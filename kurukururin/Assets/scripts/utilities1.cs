using UnityEngine;
using UnityEngine.SceneManagement;

public class Utilities1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void level2()
    {
        SceneManager.LoadScene("Level2");
      Debug.Log("level2");
    }
}
