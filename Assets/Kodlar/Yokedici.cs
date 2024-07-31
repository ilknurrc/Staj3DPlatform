using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yokedici : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Invoke("DestroyIt",1f);
    }

   private void DestroyIt()
   {
        Destroy(gameObject);
   }
}
