using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // 左上向きの速度の設定
        this.GetComponent<Rigidbody>().velocity = new Vector3(-10.0f, 9.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Ball destroy when this out of screen
    void OnBecameInvisible() //ゲームオブジェクトが画面の外に移動して描画されなくなった時に呼ばれる
    {
        Destroy(this.gameObject);
    }
}
