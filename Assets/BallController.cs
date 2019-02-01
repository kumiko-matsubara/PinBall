using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour {
    //ボールが見える可能性のあるz軸の最大値
    private float visibleposZ = -6.5f;
    //ゲームオーバーを表示するテキスト
    private GameObject gameoverText;
    //Text用の変数
    public Text ScoreText;
    

	// Use this for initialization
	void Start () {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
	}

    // Update is called once per frame
    void Update() {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visibleposZ) {
            //GameoverTestにゲームオーバーを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }

    }
    //衝突時に呼ばれる関数
    void OnCOllisionEnter (Collision other) {
        if (other.gameObject.tag == "SmallStarTag")
        {
            this.ScoreText.GetComponent<ScoreController>().score += 10;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            this.ScoreText.GetComponent<ScoreController>().score += 20;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            this.ScoreText.GetComponent<ScoreController>().score += 10;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            this.ScoreText.GetComponent<ScoreController>().score += 20;
        }
        this.ScoreText.GetComponent<Text>().text = "score:0" + this.ScoreText.GetComponent<ScoreController>().score;
             }
            
        
}
