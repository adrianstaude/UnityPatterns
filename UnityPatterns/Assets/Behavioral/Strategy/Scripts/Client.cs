using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern
{
    public class Client : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown("a"))
            {
                Missile sidewinder = ScriptableObject.CreateInstance<MiSidewinder>();
                sidewinder.ApplySeek();
            }
            if (Input.GetKeyDown("s"))
            {
                Missile sidewinderWithGPS = ScriptableObject.CreateInstance<MiSidewinder>();
                ISeekBehavior gps = new SeekWithGPS();
                sidewinderWithGPS.SetSeekBehavior(gps);
                sidewinderWithGPS.ApplySeek();
            }
        }
    }
}

