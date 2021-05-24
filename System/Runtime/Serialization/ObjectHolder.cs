internal sealed class ObjectHolder // TypeDefIndex: 1011
{
	// Fields
	private object m_object; // 0x10
	internal long m_id; // 0x18
	private int m_missingElementsRemaining; // 0x20
	private int m_missingDecendents; // 0x24
	internal SerializationInfo m_serInfo; // 0x28
	internal ISerializationSurrogate m_surrogate; // 0x30
	internal FixupHolderList m_missingElements; // 0x38
	internal LongList m_dependentObjects; // 0x40
	internal ObjectHolder m_next; // 0x48
	internal int m_flags; // 0x50
	private bool m_markForFixupWhenAvailable; // 0x54
	private ValueTypeFixupInfo m_valueFixup; // 0x58
	private TypeLoadExceptionHolder m_typeLoad; // 0x60
	private bool m_reachable; // 0x68

	// Properties
	internal bool IsIncompleteObjectReference { get; set; }
	internal bool RequiresDelayedFixup { get; }
	internal bool RequiresValueTypeFixup { get; }
	internal bool ValueTypeFixupPerformed { get; set; }
	internal bool HasISerializable { get; }
	internal bool HasSurrogate { get; }
	internal bool CanSurrogatedObjectValueChange { get; }
	internal bool CanObjectValueChange { get; }
	internal int DirectlyDependentObjects { get; }
	internal int TotalDependentObjects { get; }
	internal bool Reachable { get; set; }
	internal bool TypeLoadExceptionReachable { get; }
	internal TypeLoadExceptionHolder TypeLoadException { get; set; }
	internal object ObjectValue { get; }
	internal SerializationInfo SerializationInfo { get; set; }
	internal ISerializationSurrogate Surrogate { get; }
	internal LongList DependentObjects { get; set; }
	internal bool RequiresSerInfoFixup { get; set; }
	internal ValueTypeFixupInfo ValueFixup { get; }
	internal bool CompletelyFixed { get; }
	internal long ContainerID { get; }

	// Methods

	// RVA: 0x1516250 Offset: 0x1516351 VA: 0x1516250
	internal void .ctor(long objID) { }

	// RVA: 0x15163D0 Offset: 0x15164D1 VA: 0x15163D0
	internal void .ctor(object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x1516290 Offset: 0x1516391 VA: 0x1516290
	internal void .ctor(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x15168D0 Offset: 0x15169D1 VA: 0x15168D0
	private void IncrementDescendentFixups(int amount) { }

	// RVA: 0x15168E0 Offset: 0x15169E1 VA: 0x15168E0
	internal void DecrementFixupsRemaining(ObjectManager manager) { }

	// RVA: 0x15169E0 Offset: 0x1516AE1 VA: 0x15169E0
	internal void RemoveDependency(long id) { }

	// RVA: 0x1516A00 Offset: 0x1516B01 VA: 0x1516A00
	internal void AddFixup(FixupHolder fixup, ObjectManager manager) { }

	// RVA: 0x1516970 Offset: 0x1516A71 VA: 0x1516970
	private void UpdateDescendentDependencyChain(int amount, ObjectManager manager) { }

	// RVA: 0x1516C20 Offset: 0x1516D21 VA: 0x1516C20
	internal void AddDependency(long dependentObject) { }

	// RVA: 0x1516D10 Offset: 0x1516E11 VA: 0x1516D10
	internal void UpdateData(object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, FieldInfo field, int[] arrayIndex, ObjectManager manager) { }

	// RVA: 0x1517070 Offset: 0x1517171 VA: 0x1517070
	internal void MarkForCompletionWhenAvailable() { }

	// RVA: 0x1516810 Offset: 0x1516911 VA: 0x1516810
	internal void SetFlags() { }

	// RVA: 0x1517080 Offset: 0x1517181 VA: 0x1517080
	internal bool get_IsIncompleteObjectReference() { }

	// RVA: 0x1517090 Offset: 0x1517191 VA: 0x1517090
	internal void set_IsIncompleteObjectReference(bool value) { }

	// RVA: 0x15170B0 Offset: 0x15171B1 VA: 0x15170B0
	internal bool get_RequiresDelayedFixup() { }

	// RVA: 0x1516960 Offset: 0x1516A61 VA: 0x1516960
	internal bool get_RequiresValueTypeFixup() { }

	// RVA: 0x15170C0 Offset: 0x15171C1 VA: 0x15170C0
	internal bool get_ValueTypeFixupPerformed() { }

	// RVA: 0x1517100 Offset: 0x1517201 VA: 0x1517100
	internal void set_ValueTypeFixupPerformed(bool value) { }

	// RVA: 0x1517120 Offset: 0x1517221 VA: 0x1517120
	internal bool get_HasISerializable() { }

	// RVA: 0x1517130 Offset: 0x1517231 VA: 0x1517130
	internal bool get_HasSurrogate() { }

	// RVA: 0x1517140 Offset: 0x1517241 VA: 0x1517140
	internal bool get_CanSurrogatedObjectValueChange() { }

	// RVA: 0x15171F0 Offset: 0x15172F1 VA: 0x15171F0
	internal bool get_CanObjectValueChange() { }

	// RVA: 0x15172C0 Offset: 0x15173C1 VA: 0x15172C0
	internal int get_DirectlyDependentObjects() { }

	// RVA: 0x15172D0 Offset: 0x15173D1 VA: 0x15172D0
	internal int get_TotalDependentObjects() { }

	// RVA: 0x15172E0 Offset: 0x15173E1 VA: 0x15172E0
	internal bool get_Reachable() { }

	// RVA: 0x15172F0 Offset: 0x15173F1 VA: 0x15172F0
	internal void set_Reachable(bool value) { }

	// RVA: 0x1517300 Offset: 0x1517401 VA: 0x1517300
	internal bool get_TypeLoadExceptionReachable() { }

	// RVA: 0x1517310 Offset: 0x1517411 VA: 0x1517310
	internal TypeLoadExceptionHolder get_TypeLoadException() { }

	// RVA: 0x1517320 Offset: 0x1517421 VA: 0x1517320
	internal void set_TypeLoadException(TypeLoadExceptionHolder value) { }

	// RVA: 0x1517330 Offset: 0x1517431 VA: 0x1517330
	internal object get_ObjectValue() { }

	// RVA: 0x1516F80 Offset: 0x1517081 VA: 0x1516F80
	internal void SetObjectValue(object obj, ObjectManager manager) { }

	// RVA: 0x1517AD0 Offset: 0x1517BD1 VA: 0x1517AD0
	internal SerializationInfo get_SerializationInfo() { }

	// RVA: 0x1517AE0 Offset: 0x1517BE1 VA: 0x1517AE0
	internal void set_SerializationInfo(SerializationInfo value) { }

	// RVA: 0x1517AF0 Offset: 0x1517BF1 VA: 0x1517AF0
	internal ISerializationSurrogate get_Surrogate() { }

	// RVA: 0x1517B00 Offset: 0x1517C01 VA: 0x1517B00
	internal LongList get_DependentObjects() { }

	// RVA: 0x1517B10 Offset: 0x1517C11 VA: 0x1517B10
	internal void set_DependentObjects(LongList value) { }

	// RVA: 0x1517B20 Offset: 0x1517C21 VA: 0x1517B20
	internal bool get_RequiresSerInfoFixup() { }

	// RVA: 0x1517B40 Offset: 0x1517C41 VA: 0x1517B40
	internal void set_RequiresSerInfoFixup(bool value) { }

	// RVA: 0x1517B60 Offset: 0x1517C61 VA: 0x1517B60
	internal ValueTypeFixupInfo get_ValueFixup() { }

	// RVA: 0x1517B70 Offset: 0x1517C71 VA: 0x1517B70
	internal bool get_CompletelyFixed() { }

	// RVA: 0x1516B10 Offset: 0x1516C11 VA: 0x1516B10
	internal long get_ContainerID() { }
}

internal sealed class ObjectHolder // TypeDefIndex: 1011
{
	// Fields
	private object m_object; // 0x10
	internal long m_id; // 0x18
	private int m_missingElementsRemaining; // 0x20
	private int m_missingDecendents; // 0x24
	internal SerializationInfo m_serInfo; // 0x28
	internal ISerializationSurrogate m_surrogate; // 0x30
	internal FixupHolderList m_missingElements; // 0x38
	internal LongList m_dependentObjects; // 0x40
	internal ObjectHolder m_next; // 0x48
	internal int m_flags; // 0x50
	private bool m_markForFixupWhenAvailable; // 0x54
	private ValueTypeFixupInfo m_valueFixup; // 0x58
	private TypeLoadExceptionHolder m_typeLoad; // 0x60
	private bool m_reachable; // 0x68

	// Properties
	internal bool IsIncompleteObjectReference { get; set; }
	internal bool RequiresDelayedFixup { get; }
	internal bool RequiresValueTypeFixup { get; }
	internal bool ValueTypeFixupPerformed { get; set; }
	internal bool HasISerializable { get; }
	internal bool HasSurrogate { get; }
	internal bool CanSurrogatedObjectValueChange { get; }
	internal bool CanObjectValueChange { get; }
	internal int DirectlyDependentObjects { get; }
	internal int TotalDependentObjects { get; }
	internal bool Reachable { get; set; }
	internal bool TypeLoadExceptionReachable { get; }
	internal TypeLoadExceptionHolder TypeLoadException { get; set; }
	internal object ObjectValue { get; }
	internal SerializationInfo SerializationInfo { get; set; }
	internal ISerializationSurrogate Surrogate { get; }
	internal LongList DependentObjects { get; set; }
	internal bool RequiresSerInfoFixup { get; set; }
	internal ValueTypeFixupInfo ValueFixup { get; }
	internal bool CompletelyFixed { get; }
	internal long ContainerID { get; }

	// Methods

	// RVA: 0x1516250 Offset: 0x1516351 VA: 0x1516250
	internal void .ctor(long objID) { }

	// RVA: 0x15163D0 Offset: 0x15164D1 VA: 0x15163D0
	internal void .ctor(object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x1516290 Offset: 0x1516391 VA: 0x1516290
	internal void .ctor(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x15168D0 Offset: 0x15169D1 VA: 0x15168D0
	private void IncrementDescendentFixups(int amount) { }

	// RVA: 0x15168E0 Offset: 0x15169E1 VA: 0x15168E0
	internal void DecrementFixupsRemaining(ObjectManager manager) { }

	// RVA: 0x15169E0 Offset: 0x1516AE1 VA: 0x15169E0
	internal void RemoveDependency(long id) { }

	// RVA: 0x1516A00 Offset: 0x1516B01 VA: 0x1516A00
	internal void AddFixup(FixupHolder fixup, ObjectManager manager) { }

	// RVA: 0x1516970 Offset: 0x1516A71 VA: 0x1516970
	private void UpdateDescendentDependencyChain(int amount, ObjectManager manager) { }

	// RVA: 0x1516C20 Offset: 0x1516D21 VA: 0x1516C20
	internal void AddDependency(long dependentObject) { }

	// RVA: 0x1516D10 Offset: 0x1516E11 VA: 0x1516D10
	internal void UpdateData(object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, FieldInfo field, int[] arrayIndex, ObjectManager manager) { }

	// RVA: 0x1517070 Offset: 0x1517171 VA: 0x1517070
	internal void MarkForCompletionWhenAvailable() { }

	// RVA: 0x1516810 Offset: 0x1516911 VA: 0x1516810
	internal void SetFlags() { }

	// RVA: 0x1517080 Offset: 0x1517181 VA: 0x1517080
	internal bool get_IsIncompleteObjectReference() { }

	// RVA: 0x1517090 Offset: 0x1517191 VA: 0x1517090
	internal void set_IsIncompleteObjectReference(bool value) { }

	// RVA: 0x15170B0 Offset: 0x15171B1 VA: 0x15170B0
	internal bool get_RequiresDelayedFixup() { }

	// RVA: 0x1516960 Offset: 0x1516A61 VA: 0x1516960
	internal bool get_RequiresValueTypeFixup() { }

	// RVA: 0x15170C0 Offset: 0x15171C1 VA: 0x15170C0
	internal bool get_ValueTypeFixupPerformed() { }

	// RVA: 0x1517100 Offset: 0x1517201 VA: 0x1517100
	internal void set_ValueTypeFixupPerformed(bool value) { }

	// RVA: 0x1517120 Offset: 0x1517221 VA: 0x1517120
	internal bool get_HasISerializable() { }

	// RVA: 0x1517130 Offset: 0x1517231 VA: 0x1517130
	internal bool get_HasSurrogate() { }

	// RVA: 0x1517140 Offset: 0x1517241 VA: 0x1517140
	internal bool get_CanSurrogatedObjectValueChange() { }

	// RVA: 0x15171F0 Offset: 0x15172F1 VA: 0x15171F0
	internal bool get_CanObjectValueChange() { }

	// RVA: 0x15172C0 Offset: 0x15173C1 VA: 0x15172C0
	internal int get_DirectlyDependentObjects() { }

	// RVA: 0x15172D0 Offset: 0x15173D1 VA: 0x15172D0
	internal int get_TotalDependentObjects() { }

	// RVA: 0x15172E0 Offset: 0x15173E1 VA: 0x15172E0
	internal bool get_Reachable() { }

	// RVA: 0x15172F0 Offset: 0x15173F1 VA: 0x15172F0
	internal void set_Reachable(bool value) { }

	// RVA: 0x1517300 Offset: 0x1517401 VA: 0x1517300
	internal bool get_TypeLoadExceptionReachable() { }

	// RVA: 0x1517310 Offset: 0x1517411 VA: 0x1517310
	internal TypeLoadExceptionHolder get_TypeLoadException() { }

	// RVA: 0x1517320 Offset: 0x1517421 VA: 0x1517320
	internal void set_TypeLoadException(TypeLoadExceptionHolder value) { }

	// RVA: 0x1517330 Offset: 0x1517431 VA: 0x1517330
	internal object get_ObjectValue() { }

	// RVA: 0x1516F80 Offset: 0x1517081 VA: 0x1516F80
	internal void SetObjectValue(object obj, ObjectManager manager) { }

	// RVA: 0x1517AD0 Offset: 0x1517BD1 VA: 0x1517AD0
	internal SerializationInfo get_SerializationInfo() { }

	// RVA: 0x1517AE0 Offset: 0x1517BE1 VA: 0x1517AE0
	internal void set_SerializationInfo(SerializationInfo value) { }

	// RVA: 0x1517AF0 Offset: 0x1517BF1 VA: 0x1517AF0
	internal ISerializationSurrogate get_Surrogate() { }

	// RVA: 0x1517B00 Offset: 0x1517C01 VA: 0x1517B00
	internal LongList get_DependentObjects() { }

	// RVA: 0x1517B10 Offset: 0x1517C11 VA: 0x1517B10
	internal void set_DependentObjects(LongList value) { }

	// RVA: 0x1517B20 Offset: 0x1517C21 VA: 0x1517B20
	internal bool get_RequiresSerInfoFixup() { }

	// RVA: 0x1517B40 Offset: 0x1517C41 VA: 0x1517B40
	internal void set_RequiresSerInfoFixup(bool value) { }

	// RVA: 0x1517B60 Offset: 0x1517C61 VA: 0x1517B60
	internal ValueTypeFixupInfo get_ValueFixup() { }

	// RVA: 0x1517B70 Offset: 0x1517C71 VA: 0x1517B70
	internal bool get_CompletelyFixed() { }

	// RVA: 0x1516B10 Offset: 0x1516C11 VA: 0x1516B10
	internal long get_ContainerID() { }
}

internal sealed class ObjectHolder // TypeDefIndex: 1011
{
	// Fields
	private object m_object; // 0x10
	internal long m_id; // 0x18
	private int m_missingElementsRemaining; // 0x20
	private int m_missingDecendents; // 0x24
	internal SerializationInfo m_serInfo; // 0x28
	internal ISerializationSurrogate m_surrogate; // 0x30
	internal FixupHolderList m_missingElements; // 0x38
	internal LongList m_dependentObjects; // 0x40
	internal ObjectHolder m_next; // 0x48
	internal int m_flags; // 0x50
	private bool m_markForFixupWhenAvailable; // 0x54
	private ValueTypeFixupInfo m_valueFixup; // 0x58
	private TypeLoadExceptionHolder m_typeLoad; // 0x60
	private bool m_reachable; // 0x68

	// Properties
	internal bool IsIncompleteObjectReference { get; set; }
	internal bool RequiresDelayedFixup { get; }
	internal bool RequiresValueTypeFixup { get; }
	internal bool ValueTypeFixupPerformed { get; set; }
	internal bool HasISerializable { get; }
	internal bool HasSurrogate { get; }
	internal bool CanSurrogatedObjectValueChange { get; }
	internal bool CanObjectValueChange { get; }
	internal int DirectlyDependentObjects { get; }
	internal int TotalDependentObjects { get; }
	internal bool Reachable { get; set; }
	internal bool TypeLoadExceptionReachable { get; }
	internal TypeLoadExceptionHolder TypeLoadException { get; set; }
	internal object ObjectValue { get; }
	internal SerializationInfo SerializationInfo { get; set; }
	internal ISerializationSurrogate Surrogate { get; }
	internal LongList DependentObjects { get; set; }
	internal bool RequiresSerInfoFixup { get; set; }
	internal ValueTypeFixupInfo ValueFixup { get; }
	internal bool CompletelyFixed { get; }
	internal long ContainerID { get; }

	// Methods

	// RVA: 0x1516250 Offset: 0x1516351 VA: 0x1516250
	internal void .ctor(long objID) { }

	// RVA: 0x15163D0 Offset: 0x15164D1 VA: 0x15163D0
	internal void .ctor(object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x1516290 Offset: 0x1516391 VA: 0x1516290
	internal void .ctor(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x15168D0 Offset: 0x15169D1 VA: 0x15168D0
	private void IncrementDescendentFixups(int amount) { }

	// RVA: 0x15168E0 Offset: 0x15169E1 VA: 0x15168E0
	internal void DecrementFixupsRemaining(ObjectManager manager) { }

	// RVA: 0x15169E0 Offset: 0x1516AE1 VA: 0x15169E0
	internal void RemoveDependency(long id) { }

	// RVA: 0x1516A00 Offset: 0x1516B01 VA: 0x1516A00
	internal void AddFixup(FixupHolder fixup, ObjectManager manager) { }

	// RVA: 0x1516970 Offset: 0x1516A71 VA: 0x1516970
	private void UpdateDescendentDependencyChain(int amount, ObjectManager manager) { }

	// RVA: 0x1516C20 Offset: 0x1516D21 VA: 0x1516C20
	internal void AddDependency(long dependentObject) { }

	// RVA: 0x1516D10 Offset: 0x1516E11 VA: 0x1516D10
	internal void UpdateData(object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, FieldInfo field, int[] arrayIndex, ObjectManager manager) { }

	// RVA: 0x1517070 Offset: 0x1517171 VA: 0x1517070
	internal void MarkForCompletionWhenAvailable() { }

	// RVA: 0x1516810 Offset: 0x1516911 VA: 0x1516810
	internal void SetFlags() { }

	// RVA: 0x1517080 Offset: 0x1517181 VA: 0x1517080
	internal bool get_IsIncompleteObjectReference() { }

	// RVA: 0x1517090 Offset: 0x1517191 VA: 0x1517090
	internal void set_IsIncompleteObjectReference(bool value) { }

	// RVA: 0x15170B0 Offset: 0x15171B1 VA: 0x15170B0
	internal bool get_RequiresDelayedFixup() { }

	// RVA: 0x1516960 Offset: 0x1516A61 VA: 0x1516960
	internal bool get_RequiresValueTypeFixup() { }

	// RVA: 0x15170C0 Offset: 0x15171C1 VA: 0x15170C0
	internal bool get_ValueTypeFixupPerformed() { }

	// RVA: 0x1517100 Offset: 0x1517201 VA: 0x1517100
	internal void set_ValueTypeFixupPerformed(bool value) { }

	// RVA: 0x1517120 Offset: 0x1517221 VA: 0x1517120
	internal bool get_HasISerializable() { }

	// RVA: 0x1517130 Offset: 0x1517231 VA: 0x1517130
	internal bool get_HasSurrogate() { }

	// RVA: 0x1517140 Offset: 0x1517241 VA: 0x1517140
	internal bool get_CanSurrogatedObjectValueChange() { }

	// RVA: 0x15171F0 Offset: 0x15172F1 VA: 0x15171F0
	internal bool get_CanObjectValueChange() { }

	// RVA: 0x15172C0 Offset: 0x15173C1 VA: 0x15172C0
	internal int get_DirectlyDependentObjects() { }

	// RVA: 0x15172D0 Offset: 0x15173D1 VA: 0x15172D0
	internal int get_TotalDependentObjects() { }

	// RVA: 0x15172E0 Offset: 0x15173E1 VA: 0x15172E0
	internal bool get_Reachable() { }

	// RVA: 0x15172F0 Offset: 0x15173F1 VA: 0x15172F0
	internal void set_Reachable(bool value) { }

	// RVA: 0x1517300 Offset: 0x1517401 VA: 0x1517300
	internal bool get_TypeLoadExceptionReachable() { }

	// RVA: 0x1517310 Offset: 0x1517411 VA: 0x1517310
	internal TypeLoadExceptionHolder get_TypeLoadException() { }

	// RVA: 0x1517320 Offset: 0x1517421 VA: 0x1517320
	internal void set_TypeLoadException(TypeLoadExceptionHolder value) { }

	// RVA: 0x1517330 Offset: 0x1517431 VA: 0x1517330
	internal object get_ObjectValue() { }

	// RVA: 0x1516F80 Offset: 0x1517081 VA: 0x1516F80
	internal void SetObjectValue(object obj, ObjectManager manager) { }

	// RVA: 0x1517AD0 Offset: 0x1517BD1 VA: 0x1517AD0
	internal SerializationInfo get_SerializationInfo() { }

	// RVA: 0x1517AE0 Offset: 0x1517BE1 VA: 0x1517AE0
	internal void set_SerializationInfo(SerializationInfo value) { }

	// RVA: 0x1517AF0 Offset: 0x1517BF1 VA: 0x1517AF0
	internal ISerializationSurrogate get_Surrogate() { }

	// RVA: 0x1517B00 Offset: 0x1517C01 VA: 0x1517B00
	internal LongList get_DependentObjects() { }

	// RVA: 0x1517B10 Offset: 0x1517C11 VA: 0x1517B10
	internal void set_DependentObjects(LongList value) { }

	// RVA: 0x1517B20 Offset: 0x1517C21 VA: 0x1517B20
	internal bool get_RequiresSerInfoFixup() { }

	// RVA: 0x1517B40 Offset: 0x1517C41 VA: 0x1517B40
	internal void set_RequiresSerInfoFixup(bool value) { }

	// RVA: 0x1517B60 Offset: 0x1517C61 VA: 0x1517B60
	internal ValueTypeFixupInfo get_ValueFixup() { }

	// RVA: 0x1517B70 Offset: 0x1517C71 VA: 0x1517B70
	internal bool get_CompletelyFixed() { }

	// RVA: 0x1516B10 Offset: 0x1516C11 VA: 0x1516B10
	internal long get_ContainerID() { }
}

internal sealed class ObjectHolder // TypeDefIndex: 1011
{
	// Fields
	private object m_object; // 0x10
	internal long m_id; // 0x18
	private int m_missingElementsRemaining; // 0x20
	private int m_missingDecendents; // 0x24
	internal SerializationInfo m_serInfo; // 0x28
	internal ISerializationSurrogate m_surrogate; // 0x30
	internal FixupHolderList m_missingElements; // 0x38
	internal LongList m_dependentObjects; // 0x40
	internal ObjectHolder m_next; // 0x48
	internal int m_flags; // 0x50
	private bool m_markForFixupWhenAvailable; // 0x54
	private ValueTypeFixupInfo m_valueFixup; // 0x58
	private TypeLoadExceptionHolder m_typeLoad; // 0x60
	private bool m_reachable; // 0x68

	// Properties
	internal bool IsIncompleteObjectReference { get; set; }
	internal bool RequiresDelayedFixup { get; }
	internal bool RequiresValueTypeFixup { get; }
	internal bool ValueTypeFixupPerformed { get; set; }
	internal bool HasISerializable { get; }
	internal bool HasSurrogate { get; }
	internal bool CanSurrogatedObjectValueChange { get; }
	internal bool CanObjectValueChange { get; }
	internal int DirectlyDependentObjects { get; }
	internal int TotalDependentObjects { get; }
	internal bool Reachable { get; set; }
	internal bool TypeLoadExceptionReachable { get; }
	internal TypeLoadExceptionHolder TypeLoadException { get; set; }
	internal object ObjectValue { get; }
	internal SerializationInfo SerializationInfo { get; set; }
	internal ISerializationSurrogate Surrogate { get; }
	internal LongList DependentObjects { get; set; }
	internal bool RequiresSerInfoFixup { get; set; }
	internal ValueTypeFixupInfo ValueFixup { get; }
	internal bool CompletelyFixed { get; }
	internal long ContainerID { get; }

	// Methods

	// RVA: 0x1516250 Offset: 0x1516351 VA: 0x1516250
	internal void .ctor(long objID) { }

	// RVA: 0x15163D0 Offset: 0x15164D1 VA: 0x15163D0
	internal void .ctor(object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x1516290 Offset: 0x1516391 VA: 0x1516290
	internal void .ctor(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x15168D0 Offset: 0x15169D1 VA: 0x15168D0
	private void IncrementDescendentFixups(int amount) { }

	// RVA: 0x15168E0 Offset: 0x15169E1 VA: 0x15168E0
	internal void DecrementFixupsRemaining(ObjectManager manager) { }

	// RVA: 0x15169E0 Offset: 0x1516AE1 VA: 0x15169E0
	internal void RemoveDependency(long id) { }

	// RVA: 0x1516A00 Offset: 0x1516B01 VA: 0x1516A00
	internal void AddFixup(FixupHolder fixup, ObjectManager manager) { }

	// RVA: 0x1516970 Offset: 0x1516A71 VA: 0x1516970
	private void UpdateDescendentDependencyChain(int amount, ObjectManager manager) { }

	// RVA: 0x1516C20 Offset: 0x1516D21 VA: 0x1516C20
	internal void AddDependency(long dependentObject) { }

	// RVA: 0x1516D10 Offset: 0x1516E11 VA: 0x1516D10
	internal void UpdateData(object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, FieldInfo field, int[] arrayIndex, ObjectManager manager) { }

	// RVA: 0x1517070 Offset: 0x1517171 VA: 0x1517070
	internal void MarkForCompletionWhenAvailable() { }

	// RVA: 0x1516810 Offset: 0x1516911 VA: 0x1516810
	internal void SetFlags() { }

	// RVA: 0x1517080 Offset: 0x1517181 VA: 0x1517080
	internal bool get_IsIncompleteObjectReference() { }

	// RVA: 0x1517090 Offset: 0x1517191 VA: 0x1517090
	internal void set_IsIncompleteObjectReference(bool value) { }

	// RVA: 0x15170B0 Offset: 0x15171B1 VA: 0x15170B0
	internal bool get_RequiresDelayedFixup() { }

	// RVA: 0x1516960 Offset: 0x1516A61 VA: 0x1516960
	internal bool get_RequiresValueTypeFixup() { }

	// RVA: 0x15170C0 Offset: 0x15171C1 VA: 0x15170C0
	internal bool get_ValueTypeFixupPerformed() { }

	// RVA: 0x1517100 Offset: 0x1517201 VA: 0x1517100
	internal void set_ValueTypeFixupPerformed(bool value) { }

	// RVA: 0x1517120 Offset: 0x1517221 VA: 0x1517120
	internal bool get_HasISerializable() { }

	// RVA: 0x1517130 Offset: 0x1517231 VA: 0x1517130
	internal bool get_HasSurrogate() { }

	// RVA: 0x1517140 Offset: 0x1517241 VA: 0x1517140
	internal bool get_CanSurrogatedObjectValueChange() { }

	// RVA: 0x15171F0 Offset: 0x15172F1 VA: 0x15171F0
	internal bool get_CanObjectValueChange() { }

	// RVA: 0x15172C0 Offset: 0x15173C1 VA: 0x15172C0
	internal int get_DirectlyDependentObjects() { }

	// RVA: 0x15172D0 Offset: 0x15173D1 VA: 0x15172D0
	internal int get_TotalDependentObjects() { }

	// RVA: 0x15172E0 Offset: 0x15173E1 VA: 0x15172E0
	internal bool get_Reachable() { }

	// RVA: 0x15172F0 Offset: 0x15173F1 VA: 0x15172F0
	internal void set_Reachable(bool value) { }

	// RVA: 0x1517300 Offset: 0x1517401 VA: 0x1517300
	internal bool get_TypeLoadExceptionReachable() { }

	// RVA: 0x1517310 Offset: 0x1517411 VA: 0x1517310
	internal TypeLoadExceptionHolder get_TypeLoadException() { }

	// RVA: 0x1517320 Offset: 0x1517421 VA: 0x1517320
	internal void set_TypeLoadException(TypeLoadExceptionHolder value) { }

	// RVA: 0x1517330 Offset: 0x1517431 VA: 0x1517330
	internal object get_ObjectValue() { }

	// RVA: 0x1516F80 Offset: 0x1517081 VA: 0x1516F80
	internal void SetObjectValue(object obj, ObjectManager manager) { }

	// RVA: 0x1517AD0 Offset: 0x1517BD1 VA: 0x1517AD0
	internal SerializationInfo get_SerializationInfo() { }

	// RVA: 0x1517AE0 Offset: 0x1517BE1 VA: 0x1517AE0
	internal void set_SerializationInfo(SerializationInfo value) { }

	// RVA: 0x1517AF0 Offset: 0x1517BF1 VA: 0x1517AF0
	internal ISerializationSurrogate get_Surrogate() { }

	// RVA: 0x1517B00 Offset: 0x1517C01 VA: 0x1517B00
	internal LongList get_DependentObjects() { }

	// RVA: 0x1517B10 Offset: 0x1517C11 VA: 0x1517B10
	internal void set_DependentObjects(LongList value) { }

	// RVA: 0x1517B20 Offset: 0x1517C21 VA: 0x1517B20
	internal bool get_RequiresSerInfoFixup() { }

	// RVA: 0x1517B40 Offset: 0x1517C41 VA: 0x1517B40
	internal void set_RequiresSerInfoFixup(bool value) { }

	// RVA: 0x1517B60 Offset: 0x1517C61 VA: 0x1517B60
	internal ValueTypeFixupInfo get_ValueFixup() { }

	// RVA: 0x1517B70 Offset: 0x1517C71 VA: 0x1517B70
	internal bool get_CompletelyFixed() { }

	// RVA: 0x1516B10 Offset: 0x1516C11 VA: 0x1516B10
	internal long get_ContainerID() { }
}

internal sealed class ObjectHolder // TypeDefIndex: 1011
{
	// Fields
	private object m_object; // 0x10
	internal long m_id; // 0x18
	private int m_missingElementsRemaining; // 0x20
	private int m_missingDecendents; // 0x24
	internal SerializationInfo m_serInfo; // 0x28
	internal ISerializationSurrogate m_surrogate; // 0x30
	internal FixupHolderList m_missingElements; // 0x38
	internal LongList m_dependentObjects; // 0x40
	internal ObjectHolder m_next; // 0x48
	internal int m_flags; // 0x50
	private bool m_markForFixupWhenAvailable; // 0x54
	private ValueTypeFixupInfo m_valueFixup; // 0x58
	private TypeLoadExceptionHolder m_typeLoad; // 0x60
	private bool m_reachable; // 0x68

	// Properties
	internal bool IsIncompleteObjectReference { get; set; }
	internal bool RequiresDelayedFixup { get; }
	internal bool RequiresValueTypeFixup { get; }
	internal bool ValueTypeFixupPerformed { get; set; }
	internal bool HasISerializable { get; }
	internal bool HasSurrogate { get; }
	internal bool CanSurrogatedObjectValueChange { get; }
	internal bool CanObjectValueChange { get; }
	internal int DirectlyDependentObjects { get; }
	internal int TotalDependentObjects { get; }
	internal bool Reachable { get; set; }
	internal bool TypeLoadExceptionReachable { get; }
	internal TypeLoadExceptionHolder TypeLoadException { get; set; }
	internal object ObjectValue { get; }
	internal SerializationInfo SerializationInfo { get; set; }
	internal ISerializationSurrogate Surrogate { get; }
	internal LongList DependentObjects { get; set; }
	internal bool RequiresSerInfoFixup { get; set; }
	internal ValueTypeFixupInfo ValueFixup { get; }
	internal bool CompletelyFixed { get; }
	internal long ContainerID { get; }

	// Methods

	// RVA: 0x1516250 Offset: 0x1516351 VA: 0x1516250
	internal void .ctor(long objID) { }

	// RVA: 0x15163D0 Offset: 0x15164D1 VA: 0x15163D0
	internal void .ctor(object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x1516290 Offset: 0x1516391 VA: 0x1516290
	internal void .ctor(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x15168D0 Offset: 0x15169D1 VA: 0x15168D0
	private void IncrementDescendentFixups(int amount) { }

	// RVA: 0x15168E0 Offset: 0x15169E1 VA: 0x15168E0
	internal void DecrementFixupsRemaining(ObjectManager manager) { }

	// RVA: 0x15169E0 Offset: 0x1516AE1 VA: 0x15169E0
	internal void RemoveDependency(long id) { }

	// RVA: 0x1516A00 Offset: 0x1516B01 VA: 0x1516A00
	internal void AddFixup(FixupHolder fixup, ObjectManager manager) { }

	// RVA: 0x1516970 Offset: 0x1516A71 VA: 0x1516970
	private void UpdateDescendentDependencyChain(int amount, ObjectManager manager) { }

	// RVA: 0x1516C20 Offset: 0x1516D21 VA: 0x1516C20
	internal void AddDependency(long dependentObject) { }

	// RVA: 0x1516D10 Offset: 0x1516E11 VA: 0x1516D10
	internal void UpdateData(object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, FieldInfo field, int[] arrayIndex, ObjectManager manager) { }

	// RVA: 0x1517070 Offset: 0x1517171 VA: 0x1517070
	internal void MarkForCompletionWhenAvailable() { }

	// RVA: 0x1516810 Offset: 0x1516911 VA: 0x1516810
	internal void SetFlags() { }

	// RVA: 0x1517080 Offset: 0x1517181 VA: 0x1517080
	internal bool get_IsIncompleteObjectReference() { }

	// RVA: 0x1517090 Offset: 0x1517191 VA: 0x1517090
	internal void set_IsIncompleteObjectReference(bool value) { }

	// RVA: 0x15170B0 Offset: 0x15171B1 VA: 0x15170B0
	internal bool get_RequiresDelayedFixup() { }

	// RVA: 0x1516960 Offset: 0x1516A61 VA: 0x1516960
	internal bool get_RequiresValueTypeFixup() { }

	// RVA: 0x15170C0 Offset: 0x15171C1 VA: 0x15170C0
	internal bool get_ValueTypeFixupPerformed() { }

	// RVA: 0x1517100 Offset: 0x1517201 VA: 0x1517100
	internal void set_ValueTypeFixupPerformed(bool value) { }

	// RVA: 0x1517120 Offset: 0x1517221 VA: 0x1517120
	internal bool get_HasISerializable() { }

	// RVA: 0x1517130 Offset: 0x1517231 VA: 0x1517130
	internal bool get_HasSurrogate() { }

	// RVA: 0x1517140 Offset: 0x1517241 VA: 0x1517140
	internal bool get_CanSurrogatedObjectValueChange() { }

	// RVA: 0x15171F0 Offset: 0x15172F1 VA: 0x15171F0
	internal bool get_CanObjectValueChange() { }

	// RVA: 0x15172C0 Offset: 0x15173C1 VA: 0x15172C0
	internal int get_DirectlyDependentObjects() { }

	// RVA: 0x15172D0 Offset: 0x15173D1 VA: 0x15172D0
	internal int get_TotalDependentObjects() { }

	// RVA: 0x15172E0 Offset: 0x15173E1 VA: 0x15172E0
	internal bool get_Reachable() { }

	// RVA: 0x15172F0 Offset: 0x15173F1 VA: 0x15172F0
	internal void set_Reachable(bool value) { }

	// RVA: 0x1517300 Offset: 0x1517401 VA: 0x1517300
	internal bool get_TypeLoadExceptionReachable() { }

	// RVA: 0x1517310 Offset: 0x1517411 VA: 0x1517310
	internal TypeLoadExceptionHolder get_TypeLoadException() { }

	// RVA: 0x1517320 Offset: 0x1517421 VA: 0x1517320
	internal void set_TypeLoadException(TypeLoadExceptionHolder value) { }

	// RVA: 0x1517330 Offset: 0x1517431 VA: 0x1517330
	internal object get_ObjectValue() { }

	// RVA: 0x1516F80 Offset: 0x1517081 VA: 0x1516F80
	internal void SetObjectValue(object obj, ObjectManager manager) { }

	// RVA: 0x1517AD0 Offset: 0x1517BD1 VA: 0x1517AD0
	internal SerializationInfo get_SerializationInfo() { }

	// RVA: 0x1517AE0 Offset: 0x1517BE1 VA: 0x1517AE0
	internal void set_SerializationInfo(SerializationInfo value) { }

	// RVA: 0x1517AF0 Offset: 0x1517BF1 VA: 0x1517AF0
	internal ISerializationSurrogate get_Surrogate() { }

	// RVA: 0x1517B00 Offset: 0x1517C01 VA: 0x1517B00
	internal LongList get_DependentObjects() { }

	// RVA: 0x1517B10 Offset: 0x1517C11 VA: 0x1517B10
	internal void set_DependentObjects(LongList value) { }

	// RVA: 0x1517B20 Offset: 0x1517C21 VA: 0x1517B20
	internal bool get_RequiresSerInfoFixup() { }

	// RVA: 0x1517B40 Offset: 0x1517C41 VA: 0x1517B40
	internal void set_RequiresSerInfoFixup(bool value) { }

	// RVA: 0x1517B60 Offset: 0x1517C61 VA: 0x1517B60
	internal ValueTypeFixupInfo get_ValueFixup() { }

	// RVA: 0x1517B70 Offset: 0x1517C71 VA: 0x1517B70
	internal bool get_CompletelyFixed() { }

	// RVA: 0x1516B10 Offset: 0x1516C11 VA: 0x1516B10
	internal long get_ContainerID() { }
}

internal sealed class ObjectHolder // TypeDefIndex: 1011
{
	// Fields
	private object m_object; // 0x10
	internal long m_id; // 0x18
	private int m_missingElementsRemaining; // 0x20
	private int m_missingDecendents; // 0x24
	internal SerializationInfo m_serInfo; // 0x28
	internal ISerializationSurrogate m_surrogate; // 0x30
	internal FixupHolderList m_missingElements; // 0x38
	internal LongList m_dependentObjects; // 0x40
	internal ObjectHolder m_next; // 0x48
	internal int m_flags; // 0x50
	private bool m_markForFixupWhenAvailable; // 0x54
	private ValueTypeFixupInfo m_valueFixup; // 0x58
	private TypeLoadExceptionHolder m_typeLoad; // 0x60
	private bool m_reachable; // 0x68

	// Properties
	internal bool IsIncompleteObjectReference { get; set; }
	internal bool RequiresDelayedFixup { get; }
	internal bool RequiresValueTypeFixup { get; }
	internal bool ValueTypeFixupPerformed { get; set; }
	internal bool HasISerializable { get; }
	internal bool HasSurrogate { get; }
	internal bool CanSurrogatedObjectValueChange { get; }
	internal bool CanObjectValueChange { get; }
	internal int DirectlyDependentObjects { get; }
	internal int TotalDependentObjects { get; }
	internal bool Reachable { get; set; }
	internal bool TypeLoadExceptionReachable { get; }
	internal TypeLoadExceptionHolder TypeLoadException { get; set; }
	internal object ObjectValue { get; }
	internal SerializationInfo SerializationInfo { get; set; }
	internal ISerializationSurrogate Surrogate { get; }
	internal LongList DependentObjects { get; set; }
	internal bool RequiresSerInfoFixup { get; set; }
	internal ValueTypeFixupInfo ValueFixup { get; }
	internal bool CompletelyFixed { get; }
	internal long ContainerID { get; }

	// Methods

	// RVA: 0x1516250 Offset: 0x1516351 VA: 0x1516250
	internal void .ctor(long objID) { }

	// RVA: 0x15163D0 Offset: 0x15164D1 VA: 0x15163D0
	internal void .ctor(object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x1516290 Offset: 0x1516391 VA: 0x1516290
	internal void .ctor(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x15168D0 Offset: 0x15169D1 VA: 0x15168D0
	private void IncrementDescendentFixups(int amount) { }

	// RVA: 0x15168E0 Offset: 0x15169E1 VA: 0x15168E0
	internal void DecrementFixupsRemaining(ObjectManager manager) { }

	// RVA: 0x15169E0 Offset: 0x1516AE1 VA: 0x15169E0
	internal void RemoveDependency(long id) { }

	// RVA: 0x1516A00 Offset: 0x1516B01 VA: 0x1516A00
	internal void AddFixup(FixupHolder fixup, ObjectManager manager) { }

	// RVA: 0x1516970 Offset: 0x1516A71 VA: 0x1516970
	private void UpdateDescendentDependencyChain(int amount, ObjectManager manager) { }

	// RVA: 0x1516C20 Offset: 0x1516D21 VA: 0x1516C20
	internal void AddDependency(long dependentObject) { }

	// RVA: 0x1516D10 Offset: 0x1516E11 VA: 0x1516D10
	internal void UpdateData(object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, FieldInfo field, int[] arrayIndex, ObjectManager manager) { }

	// RVA: 0x1517070 Offset: 0x1517171 VA: 0x1517070
	internal void MarkForCompletionWhenAvailable() { }

	// RVA: 0x1516810 Offset: 0x1516911 VA: 0x1516810
	internal void SetFlags() { }

	// RVA: 0x1517080 Offset: 0x1517181 VA: 0x1517080
	internal bool get_IsIncompleteObjectReference() { }

	// RVA: 0x1517090 Offset: 0x1517191 VA: 0x1517090
	internal void set_IsIncompleteObjectReference(bool value) { }

	// RVA: 0x15170B0 Offset: 0x15171B1 VA: 0x15170B0
	internal bool get_RequiresDelayedFixup() { }

	// RVA: 0x1516960 Offset: 0x1516A61 VA: 0x1516960
	internal bool get_RequiresValueTypeFixup() { }

	// RVA: 0x15170C0 Offset: 0x15171C1 VA: 0x15170C0
	internal bool get_ValueTypeFixupPerformed() { }

	// RVA: 0x1517100 Offset: 0x1517201 VA: 0x1517100
	internal void set_ValueTypeFixupPerformed(bool value) { }

	// RVA: 0x1517120 Offset: 0x1517221 VA: 0x1517120
	internal bool get_HasISerializable() { }

	// RVA: 0x1517130 Offset: 0x1517231 VA: 0x1517130
	internal bool get_HasSurrogate() { }

	// RVA: 0x1517140 Offset: 0x1517241 VA: 0x1517140
	internal bool get_CanSurrogatedObjectValueChange() { }

	// RVA: 0x15171F0 Offset: 0x15172F1 VA: 0x15171F0
	internal bool get_CanObjectValueChange() { }

	// RVA: 0x15172C0 Offset: 0x15173C1 VA: 0x15172C0
	internal int get_DirectlyDependentObjects() { }

	// RVA: 0x15172D0 Offset: 0x15173D1 VA: 0x15172D0
	internal int get_TotalDependentObjects() { }

	// RVA: 0x15172E0 Offset: 0x15173E1 VA: 0x15172E0
	internal bool get_Reachable() { }

	// RVA: 0x15172F0 Offset: 0x15173F1 VA: 0x15172F0
	internal void set_Reachable(bool value) { }

	// RVA: 0x1517300 Offset: 0x1517401 VA: 0x1517300
	internal bool get_TypeLoadExceptionReachable() { }

	// RVA: 0x1517310 Offset: 0x1517411 VA: 0x1517310
	internal TypeLoadExceptionHolder get_TypeLoadException() { }

	// RVA: 0x1517320 Offset: 0x1517421 VA: 0x1517320
	internal void set_TypeLoadException(TypeLoadExceptionHolder value) { }

	// RVA: 0x1517330 Offset: 0x1517431 VA: 0x1517330
	internal object get_ObjectValue() { }

	// RVA: 0x1516F80 Offset: 0x1517081 VA: 0x1516F80
	internal void SetObjectValue(object obj, ObjectManager manager) { }

	// RVA: 0x1517AD0 Offset: 0x1517BD1 VA: 0x1517AD0
	internal SerializationInfo get_SerializationInfo() { }

	// RVA: 0x1517AE0 Offset: 0x1517BE1 VA: 0x1517AE0
	internal void set_SerializationInfo(SerializationInfo value) { }

	// RVA: 0x1517AF0 Offset: 0x1517BF1 VA: 0x1517AF0
	internal ISerializationSurrogate get_Surrogate() { }

	// RVA: 0x1517B00 Offset: 0x1517C01 VA: 0x1517B00
	internal LongList get_DependentObjects() { }

	// RVA: 0x1517B10 Offset: 0x1517C11 VA: 0x1517B10
	internal void set_DependentObjects(LongList value) { }

	// RVA: 0x1517B20 Offset: 0x1517C21 VA: 0x1517B20
	internal bool get_RequiresSerInfoFixup() { }

	// RVA: 0x1517B40 Offset: 0x1517C41 VA: 0x1517B40
	internal void set_RequiresSerInfoFixup(bool value) { }

	// RVA: 0x1517B60 Offset: 0x1517C61 VA: 0x1517B60
	internal ValueTypeFixupInfo get_ValueFixup() { }

	// RVA: 0x1517B70 Offset: 0x1517C71 VA: 0x1517B70
	internal bool get_CompletelyFixed() { }

	// RVA: 0x1516B10 Offset: 0x1516C11 VA: 0x1516B10
	internal long get_ContainerID() { }
}

