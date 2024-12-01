using UnityEngine;
using UnityEngine.SceneManagement;


public class EscapeKeyHandler : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape-toets ingedrukt!");
            SceneManager.LoadScene("menu");
            
        }
    }
}