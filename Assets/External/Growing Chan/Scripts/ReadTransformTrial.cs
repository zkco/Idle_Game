using System;
using UnityEngine;

namespace OnlyNew.BodyProportions
{
    [DisallowMultipleComponent]
    [DefaultExecutionOrder(-5)]
    [ExecuteAlways]

    [AddComponentMenu("/BodyProportionsTrial/ReadTransform")]
    public class ReadTransformTrial : MonoBehaviour
    {

        [Tooltip("This array stores the relationships between the real and virtual skeletons.")]
        public TransformPairTrial[] bonePair;

        // Update is called once per frame
        void LateUpdate()
        {
            if (bonePair == null)
                return;
            foreach (var pair in bonePair)
            {
                if (pair.coupledBone != null && pair.decoupledBone != null)
                {
                    pair.coupledBone.position = pair.decoupledBone.position;
                    pair.coupledBone.rotation = pair.decoupledBone.rotation;
                }
            }
        }
    }
    [Serializable]
    public struct TransformPairTrial
    {
        public Transform decoupledBone;
        public Transform coupledBone;

        public TransformPairTrial(Transform decoupledBone, Transform coupledBone)
        {
            this.decoupledBone = decoupledBone;
            this.coupledBone = coupledBone;
        }
    }
}