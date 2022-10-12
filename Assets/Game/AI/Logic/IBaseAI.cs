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
    public interface IAIBase
    {
         
        void OnStart(IAIBase prevAI);

        void DoUpdate();
        
        void OnEnd(IAIBase nextAI);


    }
}
