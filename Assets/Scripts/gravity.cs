  using System.Collections;
  using System.Collections.Generic;
  using UnityEngine;
  
  public class gravity : MonoBehaviour {
  
      public bool UW;
      Rigidbody rb;
  
      // Use this for initialization
      void Start () {
          rb = this.gameObject.GetComponent<Rigidbody> ();
      }
      
      void Update ()
      {
          Physics.gravity = new Vector3(0, -1.0F, 0);
          /*
          if (this.transform.position.y <= 15f) {
              new WaitForSeconds (0.2f);
              if (transform.position.y < 15f) {
                  rb.useGravity = true;
                  UW = true;
              }
              else if (transform.position.y >= 15f) {
                  rb.useGravity = false;
                  UW = false;
              } 
          }*/
      }
  }