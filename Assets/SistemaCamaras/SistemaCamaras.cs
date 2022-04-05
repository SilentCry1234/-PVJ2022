using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace StarterAssets
{
    public class SistemaCamaras : MonoBehaviour
    {
        [SerializeField] GameObject CamaraVirtual1;
        [SerializeField] GameObject CamaraVirtual2;

        private void Awake()
        {
            DesactivarCamaras();
        }

        private void DesactivarCamaras()
        {
            if (CamaraVirtual1)
                CamaraVirtual1.SetActive(false);
            else
                Debug.Log("Te falta contectar la cámara 1");

            if (CamaraVirtual2)
                CamaraVirtual2.SetActive(false);
            else
                Debug.Log("Te falta contectar la cámara 2");
        }

        private void OnTriggerStay(Collider other)
        {
            if(other.tag == "Player")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    DesactivarCamaras();
                }
                else if (Input.GetKeyDown(KeyCode.Q))
                {

                    if (CamaraVirtual1) {
                        Debug.Log("Estoy Activando");
                        CamaraVirtual1.SetActive(true);
                        CamaraVirtual2.SetActive(false);
                    }
                }
                else if (Input.GetKeyDown(KeyCode.R))
                {
                    if (CamaraVirtual2)
                    { 
                        CamaraVirtual1.SetActive(false);
                        CamaraVirtual2.SetActive(true);
                    }
                }
            }
        }

        private void OnTriggerExit(Collider other)
        {
            DesactivarCamaras();
        }
    }
}
