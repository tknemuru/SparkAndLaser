using UnityEngine;
using System.Collections;

namespace SparkAndLaser
{
    /// <summary>
    /// ゲームメインクラス
    /// </summary>
    public class Main : MonoBehaviour
    {
        /// <summary>
        /// スタートボタン
        /// </summary>
        public GameObject GameStartButton;

        /// <summary>
        /// ゲームオーバーボタン
        /// </summary>
        public GameObject GameOverButton;

        /// <summary>
        /// 自機
        /// </summary>
        public GameObject Fighter;

        /// <summary>
        /// ゲームオーバーかどうか
        /// </summary>
        public bool IsGameOver { get; set; }

        /// <summary>
        /// Use this for initialization
        /// </summary>
        void Start()
        {
            this.IsGameOver = false;
        }

        /// <summary>
        /// Update is called once per frame
        /// </summary>
        void Update()
        {
            if (this.IsGameOver)
            {
                this.GameOverButton.SetActive(true);
            }
        }

        /// <summary>
        /// スタートボタンクリック
        /// </summary>
        public void OnClickGameStartButton()
        {
            Instantiate(this.Fighter);
            this.GameStartButton.SetActive(false);
        }

        /// <summary>
        /// ゲームオーバーボタンクリック
        /// </summary>
        public void OnClickGameOverButton()
        {
            Application.LoadLevel("MainScene");
        }
    }
}
