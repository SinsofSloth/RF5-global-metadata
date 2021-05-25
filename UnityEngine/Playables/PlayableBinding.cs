public struct PlayableBinding // TypeDefIndex: 3349
{
	// Fields
	private string m_StreamName; // 0x0
	private Object m_SourceObject; // 0x8
	private Type m_SourceBindingType; // 0x10
	private PlayableBinding.CreateOutputMethod m_CreateOutputMethod; // 0x18
	public static readonly PlayableBinding[] None; // 0x0
	public static readonly double DefaultDuration; // 0x8

	// Properties
	public string streamName { get; }
	public Object sourceObject { get; }

	// Methods

	// RVA: 0x37F3C0 Offset: 0x37F4C1 VA: 0x37F3C0
	public string get_streamName() { }

	// RVA: 0x37F3D0 Offset: 0x37F4D1 VA: 0x37F3D0
	public Object get_sourceObject() { }

	// RVA: 0x37F3E0 Offset: 0x37F4E1 VA: 0x37F3E0
	internal PlayableOutput CreateOutput(PlayableGraph graph) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9CA0 Offset: 0xD9DA1 VA: 0xD9CA0
	// RVA: 0x2B6DC20 Offset: 0x2B6DD21 VA: 0x2B6DC20
	internal static PlayableBinding CreateInternal(string name, Object sourceObject, Type sourceType, PlayableBinding.CreateOutputMethod createFunction) { }

	// RVA: 0x2B6DCC0 Offset: 0x2B6DDC1 VA: 0x2B6DCC0
	private static void .cctor() { }
}

