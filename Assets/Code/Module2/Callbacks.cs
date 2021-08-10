using UnityEngine;

namespace QuesilloStudios.Bootcamp.Module2
{
    public class Callbacks : MonoBehaviour
    {
        public int countStart = 0;
        public int countUpdate = 0;
        public int countOnMouseDown = 0;

        void Awake()
        {
            Debug.Log("HEY HEY HEY");
        }

        void Start()
        {
            countStart++;
            //Debug.Log("Me he ejecutado " + countStart + " veces");
        }

        void Update()
        {
            countUpdate++;
            //Debug.Log("Me he ejecutado " + countUpdate + " veces");
        }

        private void OnMouseDown()
        {
            countOnMouseDown++;
            Debug.Log("Me has dado un click");
        }
    }
}

