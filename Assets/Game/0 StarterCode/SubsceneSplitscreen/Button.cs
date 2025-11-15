using System.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace Starter.SubsceneSplitscreen {
    public class Button : MonoBehaviour {
        [Header("Properties")]
        public TrapdoorType type;
        [Header("References")]
        public GameObject indicatorSymbol;

        void Start()
        {
            UpdateType();
        }

        void UpdateType()
        {
            GetComponent<MeshRenderer>().material = type.material;
            SpriteRenderer symbolRenderer = indicatorSymbol.GetComponent<SpriteRenderer>();
            symbolRenderer.sprite = type.symbol;
            symbolRenderer.color = type.symbolColor;
        }
    }
}