[ComVisibleAttribute] // RVA: 0xADD30 Offset: 0xADE31 VA: 0xADD30
[ClassInterfaceAttribute] // RVA: 0xADD30 Offset: 0xADE31 VA: 0xADD30
[ComDefaultInterfaceAttribute] // RVA: 0xADD30 Offset: 0xADE31 VA: 0xADD30
[Serializable]
public abstract class MethodInfo : MethodBase, _MethodInfo // TypeDefIndex: 553
{
	// Properties
	public override MemberTypes MemberType { get; }
	public virtual Type ReturnType { get; }

	// Methods

	// RVA: 0x196AB30 Offset: 0x196AC31 VA: 0x196AB30
	protected void .ctor() { }

	// RVA: 0x1969EC0 Offset: 0x1969FC1 VA: 0x1969EC0
	public static bool op_Equality(MethodInfo left, MethodInfo right) { }

	// RVA: 0x196A1D0 Offset: 0x196A2D1 VA: 0x196A1D0
	public static bool op_Inequality(MethodInfo left, MethodInfo right) { }

	// RVA: 0x196AB40 Offset: 0x196AC41 VA: 0x196AB40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x196AB50 Offset: 0x196AC51 VA: 0x196AB50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x196AB60 Offset: 0x196AC61 VA: 0x196AB60 Slot: 6
	public override MemberTypes get_MemberType() { }

	// RVA: 0x196AB70 Offset: 0x196AC71 VA: 0x196AB70 Slot: 40
	public virtual Type get_ReturnType() { }

	[ComVisibleAttribute] // RVA: 0xB8120 Offset: 0xB8221 VA: 0xB8120
	// RVA: 0x196ABD0 Offset: 0x196ACD1 VA: 0x196ABD0 Slot: 23
	public override Type[] GetGenericArguments() { }

	[ComVisibleAttribute] // RVA: 0xB8140 Offset: 0xB8241 VA: 0xB8140
	// RVA: 0x196AC50 Offset: 0x196AD51 VA: 0x196AC50 Slot: 41
	public virtual MethodInfo GetGenericMethodDefinition() { }

	// RVA: 0x196ACD0 Offset: 0x196ADD1 VA: 0x196ACD0 Slot: 42
	public virtual MethodInfo MakeGenericMethod(Type[] typeArguments) { }

	// RVA: 0x196AD50 Offset: 0x196AE51 VA: 0x196AD50 Slot: 43
	public virtual Delegate CreateDelegate(Type delegateType) { }

	// RVA: 0x196ADD0 Offset: 0x196AED1 VA: 0x196ADD0 Slot: 44
	public virtual Delegate CreateDelegate(Type delegateType, object target) { }

	// RVA: 0x196AE50 Offset: 0x196AF51 VA: 0x196AE50 Slot: 45
	internal virtual MethodInfo GetBaseMethod() { }
}

