using UnityEngine.SceneManagement;
using UnityEngine;

public class Ball : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
       if(transform.position.y < -10)
       {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       }
    }
}
