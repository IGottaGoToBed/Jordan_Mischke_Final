using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class TestScript
{
        [UnityTest]
        public IEnumerator PlayButtonStartsPlay()
        {
            SceneManager.LoadScene("Intro");

            yield return null;

            GameObject button = GameObject.Find("PlayButton");

            UnityEngine.UI.Button buttonComponent = button.GetComponent<UnityEngine.UI.Button>();

            bool sceneLoaded = false;

            buttonComponent.onClick.AddListener(() => sceneLoaded = true);

            buttonComponent.onClick.Invoke();

            yield return new WaitForSeconds(1f);

            Assert.IsTrue(sceneLoaded, "it worked");
    }

    [UnityTest]
    public IEnumerator StopButtonStopsPlay()
    {
        SceneManager.LoadScene("Game");

        yield return null;

        GameObject button = GameObject.Find("StopButton");

        UnityEngine.UI.Button buttonComponent = button.GetComponent<UnityEngine.UI.Button>();

        bool sceneLoaded = false;

        buttonComponent.onClick.AddListener(() => sceneLoaded = true);

        buttonComponent.onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.IsTrue(sceneLoaded, "it worked");
    }

    [UnityTest]
    public IEnumerator PlayButtonRestartsGame()
    {
        SceneManager.LoadScene("Exit");

        yield return null;

        GameObject button = GameObject.Find("PlayAgainButton");

        UnityEngine.UI.Button buttonComponent = button.GetComponent<UnityEngine.UI.Button>();

        bool sceneLoaded = false;

        buttonComponent.onClick.AddListener(() => sceneLoaded = true);

        buttonComponent.onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.IsTrue(sceneLoaded, "it worked");
    }
}
