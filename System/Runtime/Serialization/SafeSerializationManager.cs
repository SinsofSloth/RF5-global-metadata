[Serializable]
internal sealed class SafeSerializationManager : IObjectReference, ISerializable // TypeDefIndex: 1020
{
	// Fields
	private IList<object> m_serializedStates; // 0x10
	private SerializationInfo m_savedSerializationInfo; // 0x18
	private object m_realObject; // 0x20
	private RuntimeType m_realType; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0xB5510 Offset: 0xB5611 VA: 0xB5510
	private EventHandler<SafeSerializationEventArgs> SerializeObjectState; // 0x30
	private const string RealTypeSerializationName = "CLR_SafeSerializationManager_RealType";

	// Properties
	internal bool IsActive { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xB9320 Offset: 0xB9421 VA: 0xB9320
	// RVA: 0x151CDB0 Offset: 0x151CEB1 VA: 0x151CDB0
	internal void add_SerializeObjectState(EventHandler<SafeSerializationEventArgs> value) { }

	[CompilerGeneratedAttribute] // RVA: 0xB9330 Offset: 0xB9431 VA: 0xB9330
	// RVA: 0x151CE60 Offset: 0x151CF61 VA: 0x151CE60
	internal void remove_SerializeObjectState(EventHandler<SafeSerializationEventArgs> value) { }

	// RVA: 0x151CF10 Offset: 0x151D011 VA: 0x151CF10
	internal void .ctor() { }

	// RVA: 0x151CF20 Offset: 0x151D021 VA: 0x151CF20
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x151D420 Offset: 0x151D521 VA: 0x151D420
	internal bool get_IsActive() { }

	// RVA: 0x151D430 Offset: 0x151D531 VA: 0x151D430
	internal void CompleteSerialization(object serializedObject, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x151D800 Offset: 0x151D901 VA: 0x151D800
	internal void CompleteDeserialization(object deserializedObject) { }

	// RVA: 0x151DB40 Offset: 0x151DC41 VA: 0x151DB40 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x151DBF0 Offset: 0x151DCF1 VA: 0x151DBF0 Slot: 4
	private object System.Runtime.Serialization.IObjectReference.GetRealObject(StreamingContext context) { }

	[OnDeserializedAttribute] // RVA: 0xB9340 Offset: 0xB9441 VA: 0xB9340
	// RVA: 0x151DED0 Offset: 0x151DFD1 VA: 0x151DED0
	private void OnDeserialized(StreamingContext context) { }
}

