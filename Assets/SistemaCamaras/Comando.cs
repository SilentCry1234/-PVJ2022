using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StarterAssets
{
    public class Comando : MonoBehaviour
    {
        GameObject player;
        [SerializeField] GameObject Texto;

        private void Awake()
        {
            player = GameObject.FindGameObjectWithTag("Player");
            if (Texto)
                Texto.SetActive(false);
        }

        void Update()
        {
            if(player)
                transform.LookAt(player.transform);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (Texto)
                Texto.SetActive(true);
        }

        private void OnTriggerExit(Collider other)
        {
            if (Texto)
                Texto.SetActive(false);
        }
    }
}