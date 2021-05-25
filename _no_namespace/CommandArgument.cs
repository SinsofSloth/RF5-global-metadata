[Serializable]
public class CommandArgument // TypeDefIndex: 6208
{
	// Fields
	public string String; // 0x10
	public float Float; // 0x18
	public bool Bool; // 0x1C

	// Properties
	public Vector3 Vector3 { get; }
	public Vector2 Vector2 { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T GetEnum<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BED50 Offset: 0x23BEE51 VA: 0x23BED50
	|-CommandArgument.GetEnum<Ease>
	|-CommandArgument.GetEnum<EffectID>
	|-CommandArgument.GetEnum<TimeScaleID>
	|-CommandArgument.GetEnum<EventProjectileActionCommand.CreateTimingType>
	|-CommandArgument.GetEnum<Prefab>
	|-CommandArgument.GetEnum<SetBehaviorCommand.BehaviorType>
	|-CommandArgument.GetEnum<Int32Enum>
	*/

	// RVA: 0x1FC4660 Offset: 0x1FC4761 VA: 0x1FC4660
	public Vector3 get_Vector3() { }

	// RVA: 0x1FC4820 Offset: 0x1FC4921 VA: 0x1FC4820
	public Vector2 get_Vector2() { }

	// RVA: -1 Offset: -1
	public static T GetEnum<T>(CommandArgument commandArgument) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BED60 Offset: 0x23BEE61 VA: 0x23BED60
	|-CommandArgument.GetEnum<Int32Enum>
	*/

	// RVA: 0x1FC4670 Offset: 0x1FC4771 VA: 0x1FC4670
	public static Vector3 ParseVector3(CommandArgument commandArgument) { }

	// RVA: 0x1FC4830 Offset: 0x1FC4931 VA: 0x1FC4830
	public static Vector2 ParseVector2(CommandArgument commandArgument) { }

	// RVA: 0x1FC49F0 Offset: 0x1FC4AF1 VA: 0x1FC49F0
	public void .ctor() { }
}

