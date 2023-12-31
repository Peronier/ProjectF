using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOperation : MonoBehaviour
{

    /**
    * 次に行う予定の行動状態を返す
    */
    public EAct Operate(ActorMovement actorMovement)
    {
        EDir d = DirUtil.KeyToDir();
        if (d != EDir.Pause)
        {
            actorMovement.SetActorDirection(d);
            return EAct.MoveBegin;
        }
        return EAct.WaitingKeyInput;
    }
}
