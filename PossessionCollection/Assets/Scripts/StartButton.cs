using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    [SerializeField]
    Fade fade = null;

    // OnClick is called push button
    public void OnClick () {
        fade.FadeIn(1, () => {
            SceneManager.LoadScene("HomeScene");
            fade.FadeOut(1, () => { });
        });
    }
}
