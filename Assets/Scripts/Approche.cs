using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Approche : MonoBehaviour
{
    private const string PLAYER_TAG = "Player";

    [SerializeField] Animator m_animator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != PLAYER_TAG)
        {
            return;
        }

        Debug.Log("Approche");
        m_animator.SetBool("IsWithinPlayerRange", true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag != PLAYER_TAG)
        {
            return;
        }

        Debug.Log("Eloignement");
        m_animator.SetBool("IsWithinPlayerRange", false);
    }
}
