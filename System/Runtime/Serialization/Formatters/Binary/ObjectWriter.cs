internal sealed class ObjectWriter // TypeDefIndex: 1088
{
	// Fields
	private Queue m_objectQueue; // 0x10
	private ObjectIDGenerator m_idGenerator; // 0x18
	private int m_currentId; // 0x20
	private ISurrogateSelector m_surrogates; // 0x28
	private StreamingContext m_context; // 0x30
	private __BinaryWriter serWriter; // 0x40
	private SerializationObjectManager m_objectManager; // 0x48
	private long topId; // 0x50
	private string topName; // 0x58
	private Header[] headers; // 0x60
	private InternalFE formatterEnums; // 0x68
	private SerializationBinder m_binder; // 0x70
	private SerObjectInfoInit serObjectInfoInit; // 0x78
	private IFormatterConverter m_formatterConverter; // 0x80
	internal object[] crossAppDomainArray; // 0x88
	private object previousObj; // 0x90
	private long previousId; // 0x98
	private Type previousType; // 0xA0
	private InternalPrimitiveTypeE previousCode; // 0xA8
	private Hashtable assemblyToIdTable; // 0xB0
	private SerStack niPool; // 0xB8

	// Properties
	internal SerializationObjectManager ObjectManager { get; }

	// Methods

	// RVA: 0x1603760 Offset: 0x1603861 VA: 0x1603760
	internal void .ctor(ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	// RVA: 0x1603890 Offset: 0x1603991 VA: 0x1603890
	internal void Serialize(object graph, Header[] inHeaders, __BinaryWriter serWriter, bool fCheck) { }

	// RVA: 0x160C880 Offset: 0x160C981 VA: 0x160C880
	internal SerializationObjectManager get_ObjectManager() { }

	// RVA: 0x160C230 Offset: 0x160C331 VA: 0x160C230
	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x160D090 Offset: 0x160D191 VA: 0x160D090
	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string[] memberNames, Type[] memberTypes, object[] memberData, WriteObjectInfo[] memberObjectInfos) { }

	// RVA: 0x160D380 Offset: 0x160D481 VA: 0x160D380
	private void WriteMemberSetup(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string memberName, Type memberType, object memberData, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x160D570 Offset: 0x160D671 VA: 0x160D570
	private void WriteMembers(NameInfo memberNameInfo, NameInfo memberTypeNameInfo, object memberData, WriteObjectInfo objectInfo, NameInfo typeNameInfo, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x160C890 Offset: 0x160C991 VA: 0x160C890
	private void WriteArray(WriteObjectInfo objectInfo, NameInfo memberNameInfo, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x160DE90 Offset: 0x160DF91 VA: 0x160DE90
	private void WriteArrayMember(WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, object data) { }

	// RVA: 0x160E1A0 Offset: 0x160E2A1 VA: 0x160E1A0
	private void WriteRectangle(WriteObjectInfo objectInfo, int rank, int[] maxA, Array array, NameInfo arrayElemNameTypeInfo, int[] lowerBoundA) { }

	// RVA: 0x160C6F0 Offset: 0x160C7F1 VA: 0x160C6F0
	private object GetNext(out long objID) { }

	// RVA: 0x160BD60 Offset: 0x160BE61 VA: 0x160BD60
	private long InternalGetId(object obj, bool assignUniqueIdToValueType, Type type, out bool isNew) { }

	// RVA: 0x160E430 Offset: 0x160E531 VA: 0x160E430
	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type) { }

	// RVA: 0x160DCB0 Offset: 0x160DDB1 VA: 0x160DCB0
	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type, WriteObjectInfo objectInfo) { }

	// RVA: 0x160DD70 Offset: 0x160DE71 VA: 0x160DD70
	private bool WriteKnownValueClass(NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	// RVA: 0x160DD50 Offset: 0x160DE51 VA: 0x160DD50
	private void WriteObjectRef(NameInfo nameInfo, long objectId) { }

	// RVA: 0x160E4B0 Offset: 0x160E5B1 VA: 0x160E4B0
	private void WriteString(NameInfo memberNameInfo, NameInfo typeNameInfo, object stringObject) { }

	// RVA: 0x160D9E0 Offset: 0x160DAE1 VA: 0x160D9E0
	private bool CheckForNull(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	// RVA: 0x160BD30 Offset: 0x160BE31 VA: 0x160BD30
	private void WriteSerializedStreamHeader(long topId, long headerId) { }

	// RVA: 0x160E620 Offset: 0x160E721 VA: 0x160E620
	private NameInfo TypeToNameInfo(Type type, WriteObjectInfo objectInfo, InternalPrimitiveTypeE code, NameInfo nameInfo) { }

	// RVA: 0x160D490 Offset: 0x160D591 VA: 0x160D490
	private NameInfo TypeToNameInfo(Type type) { }

	// RVA: 0x160C0E0 Offset: 0x160C1E1 VA: 0x160C0E0
	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo) { }

	// RVA: 0x160DBD0 Offset: 0x160DCD1 VA: 0x160DBD0
	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo, NameInfo nameInfo) { }

	// RVA: 0x160DAB0 Offset: 0x160DBB1 VA: 0x160DAB0
	private void TypeToNameInfo(Type type, NameInfo nameInfo) { }

	// RVA: 0x160D340 Offset: 0x160D441 VA: 0x160D340
	private NameInfo MemberToNameInfo(string name) { }

	// RVA: 0x1601D70 Offset: 0x1601E71 VA: 0x1601D70
	internal InternalPrimitiveTypeE ToCode(Type type) { }

	// RVA: 0x160BE40 Offset: 0x160BF41 VA: 0x160BE40
	private long GetAssemblyId(WriteObjectInfo objectInfo) { }

	// RVA: 0x160D070 Offset: 0x160D171 VA: 0x160D070
	private Type GetType(object obj) { }

	// RVA: 0x160E700 Offset: 0x160E801 VA: 0x160E700
	private NameInfo GetNameInfo() { }

	// RVA: 0x160D060 Offset: 0x160D161 VA: 0x160D060
	private bool CheckTypeFormat(FormatterTypeStyle test, FormatterTypeStyle want) { }

	// RVA: 0x160C6D0 Offset: 0x160C7D1 VA: 0x160C6D0
	private void PutNameInfo(NameInfo nameInfo) { }
}

