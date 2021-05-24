public sealed class SafeSerializationEventArgs : EventArgs // TypeDefIndex: 1018
{
	// Fields
	private StreamingContext m_streamingContext; // 0x10
	private List<object> m_serializedStates; // 0x20

	// Properties
	internal IList<object> SerializedStates { get; }

	// Methods

	// RVA: 0x151CCE0 Offset: 0x151CDE1 VA: 0x151CCE0
	internal void .ctor(StreamingContext streamingContext) { }

	// RVA: 0x151CDA0 Offset: 0x151CEA1 VA: 0x151CDA0
	internal IList<object> get_SerializedStates() { }
}

