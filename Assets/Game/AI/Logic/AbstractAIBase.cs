using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game.AI.Logic
{
    /**
     * AI노드 -> 평가 -> 다음 연결된 AI노드
     */
    public abstract class AbstractAIBase : IAIBase
    {
        public void OnStart(IAIBase prevAI)
        { 
        }

        public void DoUpdate()
        { 
        }

        public void OnEnd(IAIBase nextAI)
        {
             
        }
    }
}
