internal sealed class WriteObjectInfo // TypeDefIndex: 1080
{
	// Fields
	internal int objectInfoId; // 0x10
	internal object obj; // 0x18
	internal Type objectType; // 0x20
	internal bool isSi; // 0x28
	internal bool isNamed; // 0x29
	internal bool isTyped; // 0x2A
	internal bool isArray; // 0x2B
	internal SerializationInfo si; // 0x30
	internal SerObjectInfoCache cache; // 0x38
	internal object[] memberData; // 0x40
	internal ISerializationSurrogate serializationSurrogate; // 0x48
	internal StreamingContext context; // 0x50
	internal SerObjectInfoInit serObjectInfoInit; // 0x60
	internal long objectId; // 0x68
	internal long assemId; // 0x70
	private string binderTypeName; // 0x78
	private string binderAssemblyString; // 0x80

	// Methods

	// RVA: 0x150B930 Offset: 0x150BA31 VA: 0x150B930
	internal void .ctor() { }

	// RVA: 0x150B940 Offset: 0x150BA41 VA: 0x150B940
	internal void ObjectEnd() { }

	// RVA: 0x150B990 Offset: 0x150BA91 VA: 0x150B990
	private void InternalInit() { }

	// RVA: 0x150BA20 Offset: 0x150BB21 VA: 0x150BA20
	internal static WriteObjectInfo Serialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

	// RVA: 0x150BC10 Offset: 0x150BD11 VA: 0x150BC10
	internal void InitSerialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

	// RVA: 0x150CDF0 Offset: 0x150CEF1 VA: 0x150CDF0
	internal static WriteObjectInfo Serialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

	// RVA: 0x150CE80 Offset: 0x150CF81 VA: 0x150CE80
	internal void InitSerialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

	// RVA: 0x150C3C0 Offset: 0x150C4C1 VA: 0x150C3C0
	private void InitSiWrite() { }

	// RVA: 0x150C940 Offset: 0x150CA41 VA: 0x150C940
	private static void CheckTypeForwardedFrom(SerObjectInfoCache cache, Type objectType, string binderAssemblyString) { }

	// RVA: 0x150C150 Offset: 0x150C251 VA: 0x150C150
	private void InitNoMembers() { }

	// RVA: 0x150CAB0 Offset: 0x150CBB1 VA: 0x150CAB0
	private void InitMemberInfo() { }

	// RVA: 0x150D810 Offset: 0x150D911 VA: 0x150D810
	internal string GetTypeFullName() { }

	// RVA: 0x150D840 Offset: 0x150D941 VA: 0x150D840
	internal string GetAssemblyString() { }

	// RVA: 0x150C260 Offset: 0x150C361 VA: 0x150C260
	private void InvokeSerializationBinder(SerializationBinder binder) { }

	// RVA: 0x150D6A0 Offset: 0x150D7A1 VA: 0x150D6A0
	internal Type GetMemberType(MemberInfo objMember) { }

	// RVA: 0x150D870 Offset: 0x150D971 VA: 0x150D870
	internal void GetMemberInfo(out string[] outMemberNames, out Type[] outMemberTypes, out object[] outMemberData) { }

	// RVA: 0x150BAC0 Offset: 0x150BBC1 VA: 0x150BAC0
	private static WriteObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }

	// RVA: 0x150B970 Offset: 0x150BA71 VA: 0x150B970
	private static void PutObjectInfo(SerObjectInfoInit serObjectInfoInit, WriteObjectInfo objectInfo) { }
}

