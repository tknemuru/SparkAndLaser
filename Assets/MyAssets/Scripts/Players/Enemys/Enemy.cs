using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    /// <summary>
    /// 弾
    /// </summary>
    public GameObject Bullet;

    /// <summary>
    /// 爆発エフェクト
    /// </summary>
    public GameObject Explosion;

    /// <summary>
    /// 弾の発射間隔
    /// </summary>
    private float IntervalTime { get; set; }

    /// <summary>
    /// 移動速度
    /// </summary>
    private float Speed { get; set; }

    /// <summary>
    /// Use this for initialization
    /// </summary>
	void Start () {
        this.IntervalTime = 0;
        this.Speed = 0.7f;
	}

    /// <summary>
    /// Update is called once per frame
    /// </summary>
	void Update () {
        transform.Translate(0, 0, -1 * this.Speed);

        Quaternion quat = Quaternion.Euler(0, 180, 0);

        this.IntervalTime += Time.deltaTime;
        if (this.IntervalTime >= 0.6f)
        {
            this.IntervalTime = 0.0f;
            Instantiate(this.Bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat);
        }
	}

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "PlayerBullet")
        {
            Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
