using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public float counter;
    public int ChangeSceneAtSec;

    // Start is called before the first frame update
    void Start()
    {
        counter = Time.deltaTime;

        //SceneManager.LoadScene("Sceneworkspace");
    }

    // Update is called once per frame
    void Update()
    {
        // counter in secs
        counter += Time.deltaTime;
        // When to change scene
        if (counter > ChangeSceneAtSec) {
            int scene = SceneManager.GetActiveScene().buildIndex;
            // Change to next scene
            SceneManager.LoadScene(scene + 1);
        }
    }
}
