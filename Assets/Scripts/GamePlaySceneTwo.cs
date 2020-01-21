using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlaySceneTwo : MonoBehaviour
{
    [SerializeField] GameObject[] chains;
    [SerializeField] Rigidbody2D box;
    void Update()
    {
        if (!(chains[0].activeSelf))
        {
            if (!chains[1].activeSelf)
            {
                if (!chains[2].activeSelf)
                {
                    if (!chains[3].activeSelf)

                        if (!chains[4].activeSelf)
                        {
                            Debug.Log("Chains are destroyed");
                            box.constraints = RigidbodyConstraints2D.None;

                        }
                }
            }
        }
    }
}
