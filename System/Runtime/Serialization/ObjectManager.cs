[ComVisibleAttribute] // RVA: 0xB0600 Offset: 0xB0701 VA: 0xB0600
public class ObjectManager // TypeDefIndex: 1010
{
	// Fields
	private DeserializationEventHandler m_onDeserializationHandler; // 0x10
	private SerializationEventHandler m_onDeserializedHandler; // 0x18
	internal ObjectHolder[] m_objects; // 0x20
	internal object m_topObject; // 0x28
	internal ObjectHolderList m_specialFixupObjects; // 0x30
	internal long m_fixupCount; // 0x38
	internal ISurrogateSelector m_selector; // 0x40
	internal StreamingContext m_context; // 0x48

	// Properties
	internal object TopObject { get; set; }
	internal ObjectHolderList SpecialFixupObjects { get; }

	// Methods

	// RVA: 0x1518DC0 Offset: 0x1518EC1 VA: 0x1518DC0
	internal void .ctor(ISurrogateSelector selector, StreamingContext context, bool checkSecurity, bool isCrossAppDomain) { }

	// RVA: 0x1518E70 Offset: 0x1518F71 VA: 0x1518E70
	private bool CanCallGetType(object obj) { }

	// RVA: 0x1518E80 Offset: 0x1518F81 VA: 0x1518E80
	internal void set_TopObject(object value) { }

	// RVA: 0x1518E90 Offset: 0x1518F91 VA: 0x1518E90
	internal object get_TopObject() { }

	// RVA: 0x1518EA0 Offset: 0x1518FA1 VA: 0x1518EA0
	internal ObjectHolderList get_SpecialFixupObjects() { }

	// RVA: 0x1518F90 Offset: 0x1519091 VA: 0x1518F90
	internal ObjectHolder FindObjectHolder(long objectID) { }

	// RVA: 0x1516B30 Offset: 0x1516C31 VA: 0x1516B30
	internal ObjectHolder FindOrCreateObjectHolder(long objectID) { }

	// RVA: 0x1519000 Offset: 0x1519101 VA: 0x1519000
	private void AddObjectHolder(ObjectHolder holder) { }

	// RVA: 0x1519160 Offset: 0x1519261 VA: 0x1519160
	private bool GetCompletionInfo(FixupHolder fixup, out ObjectHolder holder, out object member, bool bThrowIfMissing) { }

	// RVA: 0x1519470 Offset: 0x1519571 VA: 0x1519470
	private void FixupSpecialObject(ObjectHolder holder) { }

	// RVA: 0x151A340 Offset: 0x151A441 VA: 0x151A340
	private bool ResolveObjectReference(ObjectHolder holder) { }

	// RVA: 0x1519A60 Offset: 0x1519B61 VA: 0x1519A60
	private bool DoValueTypeFixup(FieldInfo memberToFix, ObjectHolder holder, object value) { }

	// RVA: 0x1517340 Offset: 0x1517441 VA: 0x1517340
	internal void CompleteObject(ObjectHolder holder, bool bObjectFullyComplete) { }

	// RVA: 0x151A0B0 Offset: 0x151A1B1 VA: 0x151A0B0
	private void DoNewlyRegisteredObjectFixups(ObjectHolder holder) { }

	// RVA: 0x151A740 Offset: 0x151A841 VA: 0x151A740 Slot: 4
	public virtual object GetObject(long objectID) { }

	// RVA: 0x151A8A0 Offset: 0x151A9A1 VA: 0x151A8A0
	internal void RegisterString(string obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member) { }

	// RVA: 0x151A9A0 Offset: 0x151AAA1 VA: 0x151A9A0
	public void RegisterObject(object obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member, int[] arrayIndex) { }

	// RVA: 0x15197F0 Offset: 0x15198F1 VA: 0x15197F0
	internal void CompleteISerializableObject(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x151AF40 Offset: 0x151B041 VA: 0x151AF40
	internal static RuntimeConstructorInfo GetConstructor(RuntimeType t) { }

	// RVA: 0x151B2B0 Offset: 0x151B3B1 VA: 0x151B2B0 Slot: 5
	public virtual void DoFixups() { }

	// RVA: 0x151B670 Offset: 0x151B771 VA: 0x151B670
	private void RegisterFixup(FixupHolder fixup, long objectToBeFixed, long objectRequired) { }

	// RVA: 0x151B780 Offset: 0x151B881 VA: 0x151B780 Slot: 6
	public virtual void RecordFixup(long objectToBeFixed, MemberInfo member, long objectRequired) { }

	// RVA: 0x151B9F0 Offset: 0x151BAF1 VA: 0x151B9F0 Slot: 7
	public virtual void RecordDelayedFixup(long objectToBeFixed, string memberName, long objectRequired) { }

	// RVA: 0x151BB40 Offset: 0x151BC41 VA: 0x151BB40 Slot: 8
	public virtual void RecordArrayElementFixup(long arrayToBeFixed, int[] indices, long objectRequired) { }

	// RVA: 0x151BC90 Offset: 0x151BD91 VA: 0x151BC90 Slot: 9
	public virtual void RaiseDeserializationEvent() { }

	// RVA: 0x151BFB0 Offset: 0x151C0B1 VA: 0x151BFB0 Slot: 10
	internal virtual void AddOnDeserialization(DeserializationEventHandler handler) { }

	// RVA: 0x151C040 Offset: 0x151C141 VA: 0x151C040 Slot: 11
	internal virtual void AddOnDeserialized(object obj) { }

	// RVA: 0x151C5F0 Offset: 0x151C6F1 VA: 0x151C5F0 Slot: 12
	internal virtual void RaiseOnDeserializedEvent(object obj) { }

	// RVA: 0x151C8F0 Offset: 0x151C9F1 VA: 0x151C8F0
	public void RaiseOnDeserializingEvent(object obj) { }
}

