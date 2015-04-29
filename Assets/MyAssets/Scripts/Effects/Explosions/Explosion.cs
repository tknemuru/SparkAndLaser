using UnityEngine;
using System.Collections;

namespace SparkAndLaser.Effects.Explosions
{
    public class Explosion : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            Destroy(this.gameObject, 5);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}