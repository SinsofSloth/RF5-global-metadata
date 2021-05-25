[RequiredByNativeCodeAttribute] // RVA: 0xC8E90 Offset: 0xC8F91 VA: 0xC8E90
public struct ScriptPlayableOutput : IPlayableOutput // TypeDefIndex: 3362
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0

	// Properties
	public static ScriptPlayableOutput Null { get; }

	// Methods

	// RVA: 0x2B720F0 Offset: 0x2B721F1 VA: 0x2B720F0
	public static ScriptPlayableOutput Create(PlayableGraph graph, string name) { }

	// RVA: 0x381AD0 Offset: 0x381BD1 VA: 0x381AD0
	internal void .ctor(PlayableOutputHandle handle) { }

	// RVA: 0x2B72190 Offset: 0x2B72291 VA: 0x2B72190
	public static ScriptPlayableOutput get_Null() { }

	// RVA: 0x381AE0 Offset: 0x381BE1 VA: 0x381AE0 Slot: 4
	public PlayableOutputHandle GetHandle() { }

	// RVA: 0x2B72180 Offset: 0x2B72281 VA: 0x2B72180
	public static PlayableOutput op_Implicit(ScriptPlayableOutput output) { }
}

