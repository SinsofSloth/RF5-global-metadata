[NativeHeaderAttribute] // RVA: 0xE9650 Offset: 0xE9751 VA: 0xE9650
[NativeHeaderAttribute] // RVA: 0xE9650 Offset: 0xE9751 VA: 0xE9650
[RequiredByNativeCodeAttribute] // RVA: 0xE9650 Offset: 0xE9751 VA: 0xE9650
[StaticAccessorAttribute] // RVA: 0xE9650 Offset: 0xE9751 VA: 0xE9650
[NativeHeaderAttribute] // RVA: 0xE9650 Offset: 0xE9751 VA: 0xE9650
internal struct AnimationOffsetPlayable : IPlayable, IEquatable<AnimationOffsetPlayable> // TypeDefIndex: 3528
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationOffsetPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x1AF04A0 Offset: 0x1AF05A1 VA: 0x1AF04A0
	public static AnimationOffsetPlayable Create(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount) { }

	// RVA: 0x1AF05A0 Offset: 0x1AF06A1 VA: 0x1AF05A0
	private static PlayableHandle CreateHandle(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount) { }

	// RVA: 0x1C4A0 Offset: 0x1C5A1 VA: 0x1C4A0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x1C4B0 Offset: 0x1C5B1 VA: 0x1C4B0 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x1AF0890 Offset: 0x1AF0991 VA: 0x1AF0890
	public static Playable op_Implicit(AnimationOffsetPlayable playable) { }

	// RVA: 0x1C4C0 Offset: 0x1C5C1 VA: 0x1C4C0 Slot: 5
	public bool Equals(AnimationOffsetPlayable other) { }

	[NativeThrowsAttribute] // RVA: 0xECC50 Offset: 0xECD51 VA: 0xECC50
	// RVA: 0x1AF07B0 Offset: 0x1AF08B1 VA: 0x1AF07B0
	private static bool CreateHandleInternal(PlayableGraph graph, Vector3 position, Quaternion rotation, ref PlayableHandle handle) { }

	// RVA: 0x1AF0A00 Offset: 0x1AF0B01 VA: 0x1AF0A00
	private static void .cctor() { }

	// RVA: 0x1AF0990 Offset: 0x1AF0A91 VA: 0x1AF0990
	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref Vector3 position, ref Quaternion rotation, ref PlayableHandle handle) { }
}

