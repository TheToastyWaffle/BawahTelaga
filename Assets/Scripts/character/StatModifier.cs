using System;

public enum StatModType
{
    Flat = 100,
    PercentAdd = 200,
    PercentMult = 300,
}
[Serializable]
public class StatModifier
{
    public readonly float Value;
    public readonly StatModType Type;
    public readonly int Order;
    public readonly object Source; // Added this variable
    public readonly bool Persistant;

    // "Main" constructor. Requires all variables.
    public StatModifier(float value, StatModType type, int order, object source, bool persistant) // Added "source" input parameter
    {
        Value = value;
        Type = type;
        Order = order;
        Source = source; // Assign Source to our new input parameter
        Persistant = persistant;
    }

    // Requires Value and Type. Calls the "Main" constructor and sets Order and Source to their default values: (int)type and null, respectively.
    public StatModifier(float value, StatModType type) : this(value, type, (int)type, null, false) { }

    // Requires Value, Type and Order. Sets Source to its default value: null
    public StatModifier(float value, StatModType type, int order) : this(value, type, order, null, false) { }

    // Requires Value, Type and Source. Sets Order to its default value: (int)Type
    public StatModifier(float value, StatModType type, object source) : this(value, type, (int)type, source, false) { }

     // Requires Value, Type and Source and persistance. Sets Order to its default value: (int)Type
    public StatModifier(float value, StatModType type, object source, bool persistant) : this(value, type, (int)type, source, persistant) { }

}
