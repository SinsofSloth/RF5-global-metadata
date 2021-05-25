[RequiredByNativeCodeAttribute] // RVA: 0xC8DD0 Offset: 0xC8ED1 VA: 0xC8DD0
public struct PlayableOutput : IPlayableOutput, IEquatable<PlayableOutput> // TypeDefIndex: 3357
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0
	private static readonly PlayableOutput m_NullPlayableOutput; // 0x0

	// Properties
	public static PlayableOutput Null { get; }

	// Methods

	// RVA: 0x2B6DBB0 Offset: 0x2B6DCB1 VA: 0x2B6DBB0
	public static PlayableOutput get_Null() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDAE30 Offset: 0xDAF31 VA: 0xDAE30
	// RVA: 0x3812B0 Offset: 0x3813B1 VA: 0x3812B0
	internal void .ctor(PlayableOutputHandle handle) { }

	// RVA: 0x3812C0 Offset: 0x3813C1 VA: 0x3812C0 Slot: 4
	public PlayableOutputHandle GetHandle() { }

	// RVA: -1 Offset: -1
	public bool IsPlayableOutputOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F2DB0 Offset: 0x2F2EB1 VA: 0x2F2DB0
	|-PlayableOutput.IsPlayableOutputOfType<AudioPlayableOutput>
	*/

	// RVA: 0x3812D0 Offset: 0x3813D1 VA: 0x3812D0 Slot: 5
	public bool Equals(PlayableOutput other) { }

	// RVA: 0x2B71180 Offset: 0x2B71281 VA: 0x2B71180
	private static void .cctor() { }
}

