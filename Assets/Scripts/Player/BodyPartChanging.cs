using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPartChanging : MonoBehaviour
{
   
    
        public Mesh [] meshes;
        public MeshFilter meshRenderer;
    
    
    public void ChangeBody()
    {
        int meshIndex = System.Array.IndexOf(meshes, meshRenderer.sharedMesh);
        meshRenderer.mesh = meshes[(meshIndex + 1) % meshes.Length];
        meshRenderer.transform.localScale = new Vector3(7000f, 7000f, 7000f) ;
    }
}
