using UnityEngine;
using System.Collections;

public class StarfighterControl : MonoBehaviour {

    public GameObject Bullet;

    /// <summary>
    /// 弾の発射間隔
    /// </summary>
    private float IntervalTime { get; set; }

    /// <summary>
    /// 移動速度
    /// </summary>
    private float Speed { get; set; }

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public StarfighterControl()
    {
        this.Speed = 1;
        this.IntervalTime = 1;
    }

    /// <summary>
    /// Use this for initialization
    /// </summary>
	public void Start () {
	
	}
	
    /// <summary>
    /// Update is called once per frame
    /// </summary>
	public void Update () {
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
	}
}
