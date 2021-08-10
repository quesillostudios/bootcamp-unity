using UnityEngine;

namespace QuesilloStudios.Bootcamp.Module2
{
    public class Movement : MonoBehaviour
    {
        public float Speed;

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate((Vector3.right * Speed) * Time.deltaTime, Space.Self);
        }
    }  
}
