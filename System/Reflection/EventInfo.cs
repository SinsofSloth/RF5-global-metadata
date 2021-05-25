[ComDefaultInterfaceAttribute] // RVA: 0xAE230 Offset: 0xAE331 VA: 0xAE230
[ComVisibleAttribute] // RVA: 0xAE230 Offset: 0xAE331 VA: 0xAE230
[ClassInterfaceAttribute] // RVA: 0xAE230 Offset: 0xAE331 VA: 0xAE230
[Serializable]
public abstract class EventInfo : MemberInfo, _EventInfo // TypeDefIndex: 577
{
	// Fields
	private EventInfo.AddEventAdapter cached_add_event; // 0x10

	// Properties
	public virtual Type EventHandlerType { get; }
	public override MemberTypes MemberType { get; }

	// Methods

	// RVA: 0x1967370 Offset: 0x1967471 VA: 0x1967370 Slot: 16
	public virtual Type get_EventHandlerType() { }

	// RVA: 0x19673F0 Offset: 0x19674F1 VA: 0x19673F0 Slot: 6
	public override MemberTypes get_MemberType() { }

	// RVA: 0x1967400 Offset: 0x1967501 VA: 0x1967400
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract MethodInfo GetAddMethod(bool nonPublic) { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract MethodInfo GetRaiseMethod(bool nonPublic) { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract MethodInfo GetRemoveMethod(bool nonPublic) { }

	// RVA: 0x1967420 Offset: 0x1967521 VA: 0x1967420 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1967430 Offset: 0x1967531 VA: 0x1967430 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1967450 Offset: 0x1967551 VA: 0x1967450
	public static bool op_Equality(EventInfo left, EventInfo right) { }

	// RVA: 0x19674A0 Offset: 0x19675A1 VA: 0x19674A0
	public static bool op_Inequality(EventInfo left, EventInfo right) { }

	// RVA: 0x1967510 Offset: 0x1967611 VA: 0x1967510
	private static EventInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	// RVA: 0x1967520 Offset: 0x1967621 VA: 0x1967520
	internal static EventInfo GetEventFromHandle(RuntimeEventHandle handle, RuntimeTypeHandle reflectedType) { }
}

