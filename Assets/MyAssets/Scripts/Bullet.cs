using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    /// <summary>
    /// 速度
    /// </summary>
    private float Speed { get; set; }

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public Bullet()
    {
        this.Speed = 2;
    }

    /// <summary>
    /// Use this for initialization
    /// </summary>
	public void Start () {
        Destroy(this.gameObject, 5);
	}

    /// <summary>
    /// Update is called once per frame
    /// </summary>
	public void Update () {
        transform.Translate(0, 0, this.Speed);
	}
}
