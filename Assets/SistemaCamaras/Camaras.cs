using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace StarterAssets
{
    public class Camaras : MonoBehaviour
    {
        [SerializeField] Vector3 Position;
        [SerializeField] Quaternion Rotacion;
        public string nombre;

        [SerializeField] GameObject CamaraVirtual;

        private void Awake()
        {
            PosicionarRotar();
        }

        private void PosicionarRotar()
        {
            transform.SetPositionAndRotation(Position, Rotacion);
        }
    }
}