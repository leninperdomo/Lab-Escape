using UnityEngine;

public class InputBlock : Block
{
    public override bool Evaluate()
    {
        return false;
    }

    public override void Reset()
    {
        value = new Value(null);
    }
}
