using UnityEngine;
using System.Collections;

namespace SparkAndLaser.Players.Mines
{
    public class Starfighter : MonoBehaviour
    {
        /// <summary>
        /// 弾
        /// </summary>
        public GameObject Bullet;

        /// <summary>
        /// 敵
        /// </summary>
        public GameObject Enemy;

        /// <summary>
        /// 爆発エフェクト
        /// </summary>
        public GameObject Explosion;

        /// <summary>
        /// 弾の発射間隔
        /// </summary>
        private float IntervalTime { get; set; }

        /// <summary>
        /// 敵の発生間隔
        /// </summary>
        private float EnemyIntervalTime { get; set; }

        /// <summary>
        /// 移動速度
        /// </summary>
        private float Speed { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Starfighter()
        {
            this.Speed = 1;
            this.IntervalTime = 1;
            this.EnemyIntervalTime = 0;
        }

        /// <summary>
        /// Use this for initialization
        /// </summary>
        public void Start()
        {

        }

        /// <summary>
        /// Update is called once per frame
        /// </summary>
        public void Update()
        {
            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");

            if (Input.GetKey("up"))
            {
                transform.Translate(0, 0, vertical * this.Speed);
            }
            if (Input.GetKey("down"))
            {
                transform.Translate(0, 0, vertical * this.Speed);
            }
            if (Input.GetKey("left"))
            {
                transform.Translate(horizontal * this.Speed, 0, 0);
            }
            if (Input.GetKey("right"))
            {
                transform.Translate(horizontal * this.Speed, 0, 0);
            }

            this.IntervalTime += Time.deltaTime;
            if (Input.GetKey("space"))
            {
                if (this.IntervalTime >= 0.1f)
                {
                    this.IntervalTime = 0.0f;
                    Instantiate(this.Bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
                }
            }

            // プレイヤーの座標を取得
            Vector3 pos = transform.position;
            pos.x = Mathf.Clamp(transform.position.x, -35, 35);
            transform.position = pos;

            this.EnemyIntervalTime += Time.deltaTime;
            if (this.EnemyIntervalTime >= 0.5f)
            {
                this.EnemyIntervalTime = 0;
                Instantiate(this.Enemy, new Vector3(Random.Range(-35.0f, 35.0f), transform.position.y, transform.position.z + 200), Quaternion.identity);
            }
        }

        void OnTriggerEnter(Collider coll)
        {
            if (coll.gameObject.tag == "EnemyBullet")
            {
                Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
                Destroy(this.gameObject);
                GameObject.Find("Main Camera").GetComponent<Main>().IsGameOver = true;
            }
        }
    }
}
