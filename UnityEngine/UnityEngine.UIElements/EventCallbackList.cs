[DefaultMemberAttribute] // RVA: 0x11E070 Offset: 0x11E171 VA: 0x11E070
internal class EventCallbackList // TypeDefIndex: 4170
{
	// Fields
	private List<EventCallbackFunctorBase> m_List; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x11EC20 Offset: 0x11ED21 VA: 0x11EC20
	[DebuggerBrowsableAttribute] // RVA: 0x11EC20 Offset: 0x11ED21 VA: 0x11EC20
	private int <trickleDownCallbackCount>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x11EC60 Offset: 0x11ED61 VA: 0x11EC60
	[DebuggerBrowsableAttribute] // RVA: 0x11EC60 Offset: 0x11ED61 VA: 0x11EC60
	private int <bubbleUpCallbackCount>k__BackingField; // 0x1C

	// Properties
	public int trickleDownCallbackCount { get; set; }
	public int bubbleUpCallbackCount { get; set; }
	public int Count { get; }
	public EventCallbackFunctorBase Item { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x11FBE0 Offset: 0x11FCE1 VA: 0x11FBE0
	// RVA: 0x15BC060 Offset: 0x15BC161 VA: 0x15BC060
	public int get_trickleDownCallbackCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x11FBF0 Offset: 0x11FCF1 VA: 0x11FBF0
	// RVA: 0x15BC070 Offset: 0x15BC171 VA: 0x15BC070
	private void set_trickleDownCallbackCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11FC00 Offset: 0x11FD01 VA: 0x11FC00
	// RVA: 0x15BC080 Offset: 0x15BC181 VA: 0x15BC080
	public int get_bubbleUpCallbackCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x11FC10 Offset: 0x11FD11 VA: 0x11FC10
	// RVA: 0x15BC090 Offset: 0x15BC191 VA: 0x15BC090
	private void set_bubbleUpCallbackCount(int value) { }

	// RVA: 0x15BC0A0 Offset: 0x15BC1A1 VA: 0x15BC0A0
	public void .ctor() { }

	// RVA: 0x15BC130 Offset: 0x15BC231 VA: 0x15BC130
	public void .ctor(EventCallbackList source) { }

	// RVA: 0x15BC1D0 Offset: 0x15BC2D1 VA: 0x15BC1D0
	public void AddRange(EventCallbackList list) { }

	// RVA: 0x15BC330 Offset: 0x15BC431 VA: 0x15BC330
	public int get_Count() { }

	// RVA: 0x15BC380 Offset: 0x15BC481 VA: 0x15BC380
	public EventCallbackFunctorBase get_Item(int i) { }

	// RVA: 0x15BC400 Offset: 0x15BC501 VA: 0x15BC400
	public void Clear() { }
}

