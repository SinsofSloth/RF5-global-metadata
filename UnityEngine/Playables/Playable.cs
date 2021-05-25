[RequiredByNativeCodeAttribute] // RVA: 0xC8B90 Offset: 0xC8C91 VA: 0xC8B90
public struct Playable : IPlayable, IEquatable<Playable> // TypeDefIndex: 3345
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly Playable m_NullPlayable; // 0x0

	// Properties
	public static Playable Null { get; }

	// Methods

	// RVA: 0x2B6CE30 Offset: 0x2B6CF31 VA: 0x2B6CE30
	public static Playable get_Null() { }

	// RVA: 0x2B6CEA0 Offset: 0x2B6CFA1 VA: 0x2B6CEA0
	public static Playable Create(PlayableGraph graph, int inputCount = 0) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9C70 Offset: 0xD9D71 VA: 0xD9C70
	// RVA: 0x37F290 Offset: 0x37F391 VA: 0x37F290
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x37F2A0 Offset: 0x37F3A1 VA: 0x37F2A0 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: -1 Offset: -1
	public bool IsPlayableOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F20F0 Offset: 0x2F21F1 VA: 0x2F20F0
	|-Playable.IsPlayableOfType<AudioClipPlayable>
	|
	|-RVA: 0x2F2100 Offset: 0x2F2201 VA: 0x2F2100
	|-Playable.IsPlayableOfType<AudioMixerPlayable>
	*/

	// RVA: 0x37F2B0 Offset: 0x37F3B1 VA: 0x37F2B0
	public Type GetPlayableType() { }

	// RVA: 0x37F360 Offset: 0x37F461 VA: 0x37F360 Slot: 5
	public bool Equals(Playable other) { }

	// RVA: 0x2B6D2B0 Offset: 0x2B6D3B1 VA: 0x2B6D2B0
	private static void .cctor() { }
}

