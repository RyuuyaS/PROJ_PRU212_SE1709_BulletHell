using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMele : BaseMeleWeapon
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) { }
    }
}
