using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

    /// <summary>
    /// 戦闘機との距離の差異
    /// </summary>
    private Vector3 Difference { get; set; }

    /// <summary>
    /// Use this for initialization
    /// </summary>
	void Start () {
        this.Difference = transform.localPosition;
	}

    /// <summary>
    /// Update is called once per frame
    /// </summary>
	void Update () {
        if (GameObject.Find("SciFi_Fighter_AK5"))
        {
            Vector3 startVector = GameObject.Find("SciFi_Fighter_AK5(Clone)").transform.localPosition;
            transform.localPosition = new Vector3(this.Difference.x, startVector.y + this.Difference.y, startVector.z + this.Difference.z);
        }
	}
}
