using UnityEngine;

namespace Dante {
	public class Dissolve : MonoBehaviour
	{
        #region References

        Renderer rend;

        public float dissolveLevel;

        #endregion

        #region RuntimeVariables



        #endregion

        #region UnityMethods

        void Start()
        {
            rend = GetComponent<Renderer>();
        }

        private void Update()
        {
            rend.materials[1].SetFloat("_DissolveT", dissolveLevel);
        }

        #endregion

        #region PublicMethods



        #endregion

        #region LocalMethods



        #endregion

        #region GettersSetters



        #endregion
    }
}
