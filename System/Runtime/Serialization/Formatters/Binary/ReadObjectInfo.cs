internal sealed class ReadObjectInfo // TypeDefIndex: 1081
{
	// Fields
	internal int objectInfoId; // 0x10
	internal static int readObjectInfoCounter; // 0x0
	internal Type objectType; // 0x18
	internal ObjectManager objectManager; // 0x20
	internal int count; // 0x28
	internal bool isSi; // 0x2C
	internal bool isNamed; // 0x2D
	internal bool isTyped; // 0x2E
	internal bool bSimpleAssembly; // 0x2F
	internal SerObjectInfoCache cache; // 0x30
	internal string[] wireMemberNames; // 0x38
	internal Type[] wireMemberTypes; // 0x40
	private int lastPosition; // 0x48
	internal ISerializationSurrogate serializationSurrogate; // 0x50
	internal StreamingContext context; // 0x58
	internal List<Type> memberTypesList; // 0x68
	internal SerObjectInfoInit serObjectInfoInit; // 0x70
	internal IFormatterConverter formatterConverter; // 0x78

	// Methods

	// RVA: 0x15089C0 Offset: 0x1508AC1 VA: 0x15089C0
	internal void .ctor() { }

	// RVA: 0x15089D0 Offset: 0x1508AD1 VA: 0x15089D0
	internal void ObjectEnd() { }

	// RVA: 0x15089E0 Offset: 0x1508AE1 VA: 0x15089E0
	internal void PrepareForReuse() { }

	// RVA: 0x15089F0 Offset: 0x1508AF1 VA: 0x15089F0
	internal static ReadObjectInfo Create(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1508BA0 Offset: 0x1508CA1 VA: 0x1508BA0
	internal void Init(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1508EE0 Offset: 0x1508FE1 VA: 0x1508EE0
	internal static ReadObjectInfo Create(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1508FE0 Offset: 0x15090E1 VA: 0x1508FE0
	internal void Init(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1508C70 Offset: 0x1508D71 VA: 0x1508C70
	private void InitReadConstructor(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context) { }

	// RVA: 0x1509190 Offset: 0x1509291 VA: 0x1509190
	private void InitSiRead() { }

	// RVA: 0x1509110 Offset: 0x1509211 VA: 0x1509110
	private void InitNoMembers() { }

	// RVA: 0x1509220 Offset: 0x1509321 VA: 0x1509220
	private void InitMemberInfo() { }

	// RVA: 0x15096B0 Offset: 0x15097B1 VA: 0x15096B0
	internal MemberInfo GetMemberInfo(string name) { }

	// RVA: 0x1509A30 Offset: 0x1509B31 VA: 0x1509A30
	internal Type GetType(string name) { }

	// RVA: 0x1509BC0 Offset: 0x1509CC1 VA: 0x1509BC0
	internal void AddValue(string name, object value, ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x1509D50 Offset: 0x1509E51 VA: 0x1509D50
	internal void InitDataStore(ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x1509E60 Offset: 0x1509F61 VA: 0x1509E60
	internal void RecordFixup(long objectId, string name, long idRef) { }

	// RVA: 0x1509F20 Offset: 0x150A021 VA: 0x1509F20
	internal void PopulateObjectMembers(object obj, object[] memberData) { }

	// RVA: 0x15098E0 Offset: 0x15099E1 VA: 0x15098E0
	private int Position(string name) { }

	// RVA: 0x1509FD0 Offset: 0x150A0D1 VA: 0x1509FD0
	internal Type[] GetMemberTypes(string[] inMemberNames, Type objectType) { }

	// RVA: 0x1509540 Offset: 0x1509641 VA: 0x1509540
	internal Type GetMemberType(MemberInfo objMember) { }

	// RVA: 0x1508B20 Offset: 0x1508C21 VA: 0x1508B20
	private static ReadObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }
}

internal sealed class ReadObjectInfo // TypeDefIndex: 1081
{
	// Fields
	internal int objectInfoId; // 0x10
	internal static int readObjectInfoCounter; // 0x0
	internal Type objectType; // 0x18
	internal ObjectManager objectManager; // 0x20
	internal int count; // 0x28
	internal bool isSi; // 0x2C
	internal bool isNamed; // 0x2D
	internal bool isTyped; // 0x2E
	internal bool bSimpleAssembly; // 0x2F
	internal SerObjectInfoCache cache; // 0x30
	internal string[] wireMemberNames; // 0x38
	internal Type[] wireMemberTypes; // 0x40
	private int lastPosition; // 0x48
	internal ISerializationSurrogate serializationSurrogate; // 0x50
	internal StreamingContext context; // 0x58
	internal List<Type> memberTypesList; // 0x68
	internal SerObjectInfoInit serObjectInfoInit; // 0x70
	internal IFormatterConverter formatterConverter; // 0x78

	// Methods

	// RVA: 0x15089C0 Offset: 0x1508AC1 VA: 0x15089C0
	internal void .ctor() { }

	// RVA: 0x15089D0 Offset: 0x1508AD1 VA: 0x15089D0
	internal void ObjectEnd() { }

	// RVA: 0x15089E0 Offset: 0x1508AE1 VA: 0x15089E0
	internal void PrepareForReuse() { }

	// RVA: 0x15089F0 Offset: 0x1508AF1 VA: 0x15089F0
	internal static ReadObjectInfo Create(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1508BA0 Offset: 0x1508CA1 VA: 0x1508BA0
	internal void Init(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1508EE0 Offset: 0x1508FE1 VA: 0x1508EE0
	internal static ReadObjectInfo Create(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1508FE0 Offset: 0x15090E1 VA: 0x1508FE0
	internal void Init(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1508C70 Offset: 0x1508D71 VA: 0x1508C70
	private void InitReadConstructor(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context) { }

	// RVA: 0x1509190 Offset: 0x1509291 VA: 0x1509190
	private void InitSiRead() { }

	// RVA: 0x1509110 Offset: 0x1509211 VA: 0x1509110
	private void InitNoMembers() { }

	// RVA: 0x1509220 Offset: 0x1509321 VA: 0x1509220
	private void InitMemberInfo() { }

	// RVA: 0x15096B0 Offset: 0x15097B1 VA: 0x15096B0
	internal MemberInfo GetMemberInfo(string name) { }

	// RVA: 0x1509A30 Offset: 0x1509B31 VA: 0x1509A30
	internal Type GetType(string name) { }

	// RVA: 0x1509BC0 Offset: 0x1509CC1 VA: 0x1509BC0
	internal void AddValue(string name, object value, ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x1509D50 Offset: 0x1509E51 VA: 0x1509D50
	internal void InitDataStore(ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x1509E60 Offset: 0x1509F61 VA: 0x1509E60
	internal void RecordFixup(long objectId, string name, long idRef) { }

	// RVA: 0x1509F20 Offset: 0x150A021 VA: 0x1509F20
	internal void PopulateObjectMembers(object obj, object[] memberData) { }

	// RVA: 0x15098E0 Offset: 0x15099E1 VA: 0x15098E0
	private int Position(string name) { }

	// RVA: 0x1509FD0 Offset: 0x150A0D1 VA: 0x1509FD0
	internal Type[] GetMemberTypes(string[] inMemberNames, Type objectType) { }

	// RVA: 0x1509540 Offset: 0x1509641 VA: 0x1509540
	internal Type GetMemberType(MemberInfo objMember) { }

	// RVA: 0x1508B20 Offset: 0x1508C21 VA: 0x1508B20
	private static ReadObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }
}

internal sealed class ReadObjectInfo // TypeDefIndex: 1081
{
	// Fields
	internal int objectInfoId; // 0x10
	internal static int readObjectInfoCounter; // 0x0
	internal Type objectType; // 0x18
	internal ObjectManager objectManager; // 0x20
	internal int count; // 0x28
	internal bool isSi; // 0x2C
	internal bool isNamed; // 0x2D
	internal bool isTyped; // 0x2E
	internal bool bSimpleAssembly; // 0x2F
	internal SerObjectInfoCache cache; // 0x30
	internal string[] wireMemberNames; // 0x38
	internal Type[] wireMemberTypes; // 0x40
	private int lastPosition; // 0x48
	internal ISerializationSurrogate serializationSurrogate; // 0x50
	internal StreamingContext context; // 0x58
	internal List<Type> memberTypesList; // 0x68
	internal SerObjectInfoInit serObjectInfoInit; // 0x70
	internal IFormatterConverter formatterConverter; // 0x78

	// Methods

	// RVA: 0x15089C0 Offset: 0x1508AC1 VA: 0x15089C0
	internal void .ctor() { }

	// RVA: 0x15089D0 Offset: 0x1508AD1 VA: 0x15089D0
	internal void ObjectEnd() { }

	// RVA: 0x15089E0 Offset: 0x1508AE1 VA: 0x15089E0
	internal void PrepareForReuse() { }

	// RVA: 0x15089F0 Offset: 0x1508AF1 VA: 0x15089F0
	internal static ReadObjectInfo Create(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1508BA0 Offset: 0x1508CA1 VA: 0x1508BA0
	internal void Init(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1508EE0 Offset: 0x1508FE1 VA: 0x1508EE0
	internal static ReadObjectInfo Create(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1508FE0 Offset: 0x15090E1 VA: 0x1508FE0
	internal void Init(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1508C70 Offset: 0x1508D71 VA: 0x1508C70
	private void InitReadConstructor(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context) { }

	// RVA: 0x1509190 Offset: 0x1509291 VA: 0x1509190
	private void InitSiRead() { }

	// RVA: 0x1509110 Offset: 0x1509211 VA: 0x1509110
	private void InitNoMembers() { }

	// RVA: 0x1509220 Offset: 0x1509321 VA: 0x1509220
	private void InitMemberInfo() { }

	// RVA: 0x15096B0 Offset: 0x15097B1 VA: 0x15096B0
	internal MemberInfo GetMemberInfo(string name) { }

	// RVA: 0x1509A30 Offset: 0x1509B31 VA: 0x1509A30
	internal Type GetType(string name) { }

	// RVA: 0x1509BC0 Offset: 0x1509CC1 VA: 0x1509BC0
	internal void AddValue(string name, object value, ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x1509D50 Offset: 0x1509E51 VA: 0x1509D50
	internal void InitDataStore(ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x1509E60 Offset: 0x1509F61 VA: 0x1509E60
	internal void RecordFixup(long objectId, string name, long idRef) { }

	// RVA: 0x1509F20 Offset: 0x150A021 VA: 0x1509F20
	internal void PopulateObjectMembers(object obj, object[] memberData) { }

	// RVA: 0x15098E0 Offset: 0x15099E1 VA: 0x15098E0
	private int Position(string name) { }

	// RVA: 0x1509FD0 Offset: 0x150A0D1 VA: 0x1509FD0
	internal Type[] GetMemberTypes(string[] inMemberNames, Type objectType) { }

	// RVA: 0x1509540 Offset: 0x1509641 VA: 0x1509540
	internal Type GetMemberType(MemberInfo objMember) { }

	// RVA: 0x1508B20 Offset: 0x1508C21 VA: 0x1508B20
	private static ReadObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }
}

internal sealed class ReadObjectInfo // TypeDefIndex: 1081
{
	// Fields
	internal int objectInfoId; // 0x10
	internal static int readObjectInfoCounter; // 0x0
	internal Type objectType; // 0x18
	internal ObjectManager objectManager; // 0x20
	internal int count; // 0x28
	internal bool isSi; // 0x2C
	internal bool isNamed; // 0x2D
	internal bool isTyped; // 0x2E
	internal bool bSimpleAssembly; // 0x2F
	internal SerObjectInfoCache cache; // 0x30
	internal string[] wireMemberNames; // 0x38
	internal Type[] wireMemberTypes; // 0x40
	private int lastPosition; // 0x48
	internal ISerializationSurrogate serializationSurrogate; // 0x50
	internal StreamingContext context; // 0x58
	internal List<Type> memberTypesList; // 0x68
	internal SerObjectInfoInit serObjectInfoInit; // 0x70
	internal IFormatterConverter formatterConverter; // 0x78

	// Methods

	// RVA: 0x15089C0 Offset: 0x1508AC1 VA: 0x15089C0
	internal void .ctor() { }

	// RVA: 0x15089D0 Offset: 0x1508AD1 VA: 0x15089D0
	internal void ObjectEnd() { }

	// RVA: 0x15089E0 Offset: 0x1508AE1 VA: 0x15089E0
	internal void PrepareForReuse() { }

	// RVA: 0x15089F0 Offset: 0x1508AF1 VA: 0x15089F0
	internal static ReadObjectInfo Create(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1508BA0 Offset: 0x1508CA1 VA: 0x1508BA0
	internal void Init(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1508EE0 Offset: 0x1508FE1 VA: 0x1508EE0
	internal static ReadObjectInfo Create(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1508FE0 Offset: 0x15090E1 VA: 0x1508FE0
	internal void Init(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1508C70 Offset: 0x1508D71 VA: 0x1508C70
	private void InitReadConstructor(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context) { }

	// RVA: 0x1509190 Offset: 0x1509291 VA: 0x1509190
	private void InitSiRead() { }

	// RVA: 0x1509110 Offset: 0x1509211 VA: 0x1509110
	private void InitNoMembers() { }

	// RVA: 0x1509220 Offset: 0x1509321 VA: 0x1509220
	private void InitMemberInfo() { }

	// RVA: 0x15096B0 Offset: 0x15097B1 VA: 0x15096B0
	internal MemberInfo GetMemberInfo(string name) { }

	// RVA: 0x1509A30 Offset: 0x1509B31 VA: 0x1509A30
	internal Type GetType(string name) { }

	// RVA: 0x1509BC0 Offset: 0x1509CC1 VA: 0x1509BC0
	internal void AddValue(string name, object value, ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x1509D50 Offset: 0x1509E51 VA: 0x1509D50
	internal void InitDataStore(ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x1509E60 Offset: 0x1509F61 VA: 0x1509E60
	internal void RecordFixup(long objectId, string name, long idRef) { }

	// RVA: 0x1509F20 Offset: 0x150A021 VA: 0x1509F20
	internal void PopulateObjectMembers(object obj, object[] memberData) { }

	// RVA: 0x15098E0 Offset: 0x15099E1 VA: 0x15098E0
	private int Position(string name) { }

	// RVA: 0x1509FD0 Offset: 0x150A0D1 VA: 0x1509FD0
	internal Type[] GetMemberTypes(string[] inMemberNames, Type objectType) { }

	// RVA: 0x1509540 Offset: 0x1509641 VA: 0x1509540
	internal Type GetMemberType(MemberInfo objMember) { }

	// RVA: 0x1508B20 Offset: 0x1508C21 VA: 0x1508B20
	private static ReadObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }
}

internal sealed class ReadObjectInfo // TypeDefIndex: 1081
{
	// Fields
	internal int objectInfoId; // 0x10
	internal static int readObjectInfoCounter; // 0x0
	internal Type objectType; // 0x18
	internal ObjectManager objectManager; // 0x20
	internal int count; // 0x28
	internal bool isSi; // 0x2C
	internal bool isNamed; // 0x2D
	internal bool isTyped; // 0x2E
	internal bool bSimpleAssembly; // 0x2F
	internal SerObjectInfoCache cache; // 0x30
	internal string[] wireMemberNames; // 0x38
	internal Type[] wireMemberTypes; // 0x40
	private int lastPosition; // 0x48
	internal ISerializationSurrogate serializationSurrogate; // 0x50
	internal StreamingContext context; // 0x58
	internal List<Type> memberTypesList; // 0x68
	internal SerObjectInfoInit serObjectInfoInit; // 0x70
	internal IFormatterConverter formatterConverter; // 0x78

	// Methods

	// RVA: 0x15089C0 Offset: 0x1508AC1 VA: 0x15089C0
	internal void .ctor() { }

	// RVA: 0x15089D0 Offset: 0x1508AD1 VA: 0x15089D0
	internal void ObjectEnd() { }

	// RVA: 0x15089E0 Offset: 0x1508AE1 VA: 0x15089E0
	internal void PrepareForReuse() { }

	// RVA: 0x15089F0 Offset: 0x1508AF1 VA: 0x15089F0
	internal static ReadObjectInfo Create(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1508BA0 Offset: 0x1508CA1 VA: 0x1508BA0
	internal void Init(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1508EE0 Offset: 0x1508FE1 VA: 0x1508EE0
	internal static ReadObjectInfo Create(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1508FE0 Offset: 0x15090E1 VA: 0x1508FE0
	internal void Init(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1508C70 Offset: 0x1508D71 VA: 0x1508C70
	private void InitReadConstructor(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context) { }

	// RVA: 0x1509190 Offset: 0x1509291 VA: 0x1509190
	private void InitSiRead() { }

	// RVA: 0x1509110 Offset: 0x1509211 VA: 0x1509110
	private void InitNoMembers() { }

	// RVA: 0x1509220 Offset: 0x1509321 VA: 0x1509220
	private void InitMemberInfo() { }

	// RVA: 0x15096B0 Offset: 0x15097B1 VA: 0x15096B0
	internal MemberInfo GetMemberInfo(string name) { }

	// RVA: 0x1509A30 Offset: 0x1509B31 VA: 0x1509A30
	internal Type GetType(string name) { }

	// RVA: 0x1509BC0 Offset: 0x1509CC1 VA: 0x1509BC0
	internal void AddValue(string name, object value, ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x1509D50 Offset: 0x1509E51 VA: 0x1509D50
	internal void InitDataStore(ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x1509E60 Offset: 0x1509F61 VA: 0x1509E60
	internal void RecordFixup(long objectId, string name, long idRef) { }

	// RVA: 0x1509F20 Offset: 0x150A021 VA: 0x1509F20
	internal void PopulateObjectMembers(object obj, object[] memberData) { }

	// RVA: 0x15098E0 Offset: 0x15099E1 VA: 0x15098E0
	private int Position(string name) { }

	// RVA: 0x1509FD0 Offset: 0x150A0D1 VA: 0x1509FD0
	internal Type[] GetMemberTypes(string[] inMemberNames, Type objectType) { }

	// RVA: 0x1509540 Offset: 0x1509641 VA: 0x1509540
	internal Type GetMemberType(MemberInfo objMember) { }

	// RVA: 0x1508B20 Offset: 0x1508C21 VA: 0x1508B20
	private static ReadObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }
}

internal sealed class ReadObjectInfo // TypeDefIndex: 1081
{
	// Fields
	internal int objectInfoId; // 0x10
	internal static int readObjectInfoCounter; // 0x0
	internal Type objectType; // 0x18
	internal ObjectManager objectManager; // 0x20
	internal int count; // 0x28
	internal bool isSi; // 0x2C
	internal bool isNamed; // 0x2D
	internal bool isTyped; // 0x2E
	internal bool bSimpleAssembly; // 0x2F
	internal SerObjectInfoCache cache; // 0x30
	internal string[] wireMemberNames; // 0x38
	internal Type[] wireMemberTypes; // 0x40
	private int lastPosition; // 0x48
	internal ISerializationSurrogate serializationSurrogate; // 0x50
	internal StreamingContext context; // 0x58
	internal List<Type> memberTypesList; // 0x68
	internal SerObjectInfoInit serObjectInfoInit; // 0x70
	internal IFormatterConverter formatterConverter; // 0x78

	// Methods

	// RVA: 0x15089C0 Offset: 0x1508AC1 VA: 0x15089C0
	internal void .ctor() { }

	// RVA: 0x15089D0 Offset: 0x1508AD1 VA: 0x15089D0
	internal void ObjectEnd() { }

	// RVA: 0x15089E0 Offset: 0x1508AE1 VA: 0x15089E0
	internal void PrepareForReuse() { }

	// RVA: 0x15089F0 Offset: 0x1508AF1 VA: 0x15089F0
	internal static ReadObjectInfo Create(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1508BA0 Offset: 0x1508CA1 VA: 0x1508BA0
	internal void Init(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1508EE0 Offset: 0x1508FE1 VA: 0x1508EE0
	internal static ReadObjectInfo Create(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1508FE0 Offset: 0x15090E1 VA: 0x1508FE0
	internal void Init(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1508C70 Offset: 0x1508D71 VA: 0x1508C70
	private void InitReadConstructor(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context) { }

	// RVA: 0x1509190 Offset: 0x1509291 VA: 0x1509190
	private void InitSiRead() { }

	// RVA: 0x1509110 Offset: 0x1509211 VA: 0x1509110
	private void InitNoMembers() { }

	// RVA: 0x1509220 Offset: 0x1509321 VA: 0x1509220
	private void InitMemberInfo() { }

	// RVA: 0x15096B0 Offset: 0x15097B1 VA: 0x15096B0
	internal MemberInfo GetMemberInfo(string name) { }

	// RVA: 0x1509A30 Offset: 0x1509B31 VA: 0x1509A30
	internal Type GetType(string name) { }

	// RVA: 0x1509BC0 Offset: 0x1509CC1 VA: 0x1509BC0
	internal void AddValue(string name, object value, ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x1509D50 Offset: 0x1509E51 VA: 0x1509D50
	internal void InitDataStore(ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x1509E60 Offset: 0x1509F61 VA: 0x1509E60
	internal void RecordFixup(long objectId, string name, long idRef) { }

	// RVA: 0x1509F20 Offset: 0x150A021 VA: 0x1509F20
	internal void PopulateObjectMembers(object obj, object[] memberData) { }

	// RVA: 0x15098E0 Offset: 0x15099E1 VA: 0x15098E0
	private int Position(string name) { }

	// RVA: 0x1509FD0 Offset: 0x150A0D1 VA: 0x1509FD0
	internal Type[] GetMemberTypes(string[] inMemberNames, Type objectType) { }

	// RVA: 0x1509540 Offset: 0x1509641 VA: 0x1509540
	internal Type GetMemberType(MemberInfo objMember) { }

	// RVA: 0x1508B20 Offset: 0x1508C21 VA: 0x1508B20
	private static ReadObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }
}

