using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

    public class LoadScene : MonoBehaviour
    {
        public string sceneToLoad;
        AsyncOperation loadingOperation;
        public Slider progressBar;

         void Start()
        {
            loadingOperation = SceneManager.LoadSceneAsync(sceneToLoad);
        }

         void Update()
        {
            progressBar.value = Mathf.Clamp01(loadingOperation.progress / 0.9f);
            Debug.Log(loadingOperation.progress);
        }

    public void LoadNextScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        


    }


