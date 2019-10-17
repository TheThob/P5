using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public Animator animator;
    private float counter;
    public float ChangeSceneAtSec;
    private int scene;


    // Start is called before the first frame update
    void Start()
    {
        counter = Time.deltaTime;
        scene = SceneManager.GetActiveScene().buildIndex +1;
    }

    // Update is called once per frame
    void Update()
    {
        // counter in secs
        counter += Time.deltaTime;


        // When to change scene
        if (counter >= ChangeSceneAtSec)
        {
            animator.SetTrigger("fadeOut");
        }
    }

    void OnFadeOutComplete ()
    {
        // Change to next scene
        SceneManager.LoadScene(scene);
    }

   
}
