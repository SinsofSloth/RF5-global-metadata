internal sealed class ObjectReader // TypeDefIndex: 1085
{
	// Fields
	internal Stream m_stream; // 0x10
	internal ISurrogateSelector m_surrogates; // 0x18
	internal StreamingContext m_context; // 0x20
	internal ObjectManager m_objectManager; // 0x30
	internal InternalFE formatterEnums; // 0x38
	internal SerializationBinder m_binder; // 0x40
	internal long topId; // 0x48
	internal bool bSimpleAssembly; // 0x50
	internal object handlerObject; // 0x58
	internal object m_topObject; // 0x60
	internal Header[] headers; // 0x68
	internal HeaderHandler handler; // 0x70
	internal SerObjectInfoInit serObjectInfoInit; // 0x78
	internal IFormatterConverter m_formatterConverter; // 0x80
	internal SerStack stack; // 0x88
	private SerStack valueFixupStack; // 0x90
	internal object[] crossAppDomainArray; // 0x98
	private bool bFullDeserialization; // 0xA0
	private bool bOldFormatDetected; // 0xA1
	private IntSizedArray valTypeObjectIdTable; // 0xA8
	private NameCache typeCache; // 0xB0
	private string previousAssemblyString; // 0xB8
	private string previousName; // 0xC0
	private Type previousType; // 0xC8

	// Properties
	private SerStack ValueFixupStack { get; }
	internal object TopObject { get; set; }

	// Methods

	// RVA: 0x1608960 Offset: 0x1608A61 VA: 0x1608960
	private SerStack get_ValueFixupStack() { }

	// RVA: 0x1608A00 Offset: 0x1608B01 VA: 0x1608A00
	internal object get_TopObject() { }

	// RVA: 0x1608A10 Offset: 0x1608B11 VA: 0x1608A10
	internal void set_TopObject(object value) { }

	// RVA: 0x1602F90 Offset: 0x1603091 VA: 0x1602F90
	internal void .ctor(Stream stream, ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	// RVA: 0x16030F0 Offset: 0x16031F1 VA: 0x16030F0
	internal object Deserialize(HeaderHandler handler, __BinaryParser serParser, bool fCheck) { }

	// RVA: 0x1608A60 Offset: 0x1608B61 VA: 0x1608A60
	private bool HasSurrogate(Type t) { }

	// RVA: 0x1608B50 Offset: 0x1608C51 VA: 0x1608B50
	private void CheckSerializable(Type t) { }

	// RVA: 0x1608D60 Offset: 0x1608E61 VA: 0x1608D60
	private void InitFullDeserialization() { }

	// RVA: 0x1608E80 Offset: 0x1608F81 VA: 0x1608E80
	internal object CrossAppDomainArray(int index) { }

	// RVA: 0x1607CD0 Offset: 0x1607DD1 VA: 0x1607CD0
	internal ReadObjectInfo CreateReadObjectInfo(Type objectType) { }

	// RVA: 0x16080C0 Offset: 0x16081C1 VA: 0x16080C0
	internal ReadObjectInfo CreateReadObjectInfo(Type objectType, string[] memberNames, Type[] memberTypes) { }

	// RVA: 0x1608EC0 Offset: 0x1608FC1 VA: 0x1608EC0
	internal void Parse(ParseRecord pr) { }

	// RVA: 0x1609DF0 Offset: 0x1609EF1 VA: 0x1609DF0
	private void ParseError(ParseRecord processing, ParseRecord onStack) { }

	// RVA: 0x1609070 Offset: 0x1609171 VA: 0x1609070
	private void ParseSerializedStreamHeader(ParseRecord pr) { }

	// RVA: 0x1609090 Offset: 0x1609191 VA: 0x1609090
	private void ParseSerializedStreamHeaderEnd(ParseRecord pr) { }

	// RVA: 0x16090B0 Offset: 0x16091B1 VA: 0x16090B0
	private void ParseObject(ParseRecord pr) { }

	// RVA: 0x1609440 Offset: 0x1609541 VA: 0x1609440
	private void ParseObjectEnd(ParseRecord pr) { }

	// RVA: 0x160A050 Offset: 0x160A151 VA: 0x160A050
	private void ParseArray(ParseRecord pr) { }

	// RVA: 0x160A7D0 Offset: 0x160A8D1 VA: 0x160A7D0
	private void NextRectangleMap(ParseRecord pr) { }

	// RVA: 0x160A8B0 Offset: 0x160A9B1 VA: 0x160A8B0
	private void ParseArrayMember(ParseRecord pr) { }

	// RVA: 0x160B160 Offset: 0x160B261 VA: 0x160B160
	private void ParseArrayMemberEnd(ParseRecord pr) { }

	// RVA: 0x1609770 Offset: 0x1609871 VA: 0x1609770
	private void ParseMember(ParseRecord pr) { }

	// RVA: 0x1609D30 Offset: 0x1609E31 VA: 0x1609D30
	private void ParseMemberEnd(ParseRecord pr) { }

	// RVA: 0x160B120 Offset: 0x160B221 VA: 0x160B120
	private void ParseString(ParseRecord pr, ParseRecord parentPr) { }

	// RVA: 0x160A7C0 Offset: 0x160A8C1 VA: 0x160A7C0
	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr) { }

	// RVA: 0x160B190 Offset: 0x160B291 VA: 0x160B190
	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr, bool bIsString) { }

	// RVA: 0x160B2F0 Offset: 0x160B3F1 VA: 0x160B2F0
	internal long GetId(long objectId) { }

	// RVA: 0x160B470 Offset: 0x160B571 VA: 0x160B470
	internal Type Bind(string assemblyString, string typeString) { }

	// RVA: 0x160B4E0 Offset: 0x160B5E1 VA: 0x160B4E0
	internal Type FastBindToType(string assemblyName, string typeName) { }

	// RVA: 0x160B840 Offset: 0x160B941 VA: 0x160B840
	private static Assembly ResolveSimpleAssemblyName(AssemblyName assemblyName) { }

	// RVA: 0x160B8B0 Offset: 0x160B9B1 VA: 0x160B8B0
	private static void GetSimplyNamedTypeFromAssembly(Assembly assm, string typeName, ref Type type) { }

	// RVA: 0x1602950 Offset: 0x1602A51 VA: 0x1602950
	internal Type GetType(BinaryAssemblyInfo assemblyInfo, string name) { }

	// RVA: 0x160BB10 Offset: 0x160BC11 VA: 0x160BB10
	private static void CheckTypeForwardedTo(Assembly sourceAssembly, Assembly destAssembly, Type resolvedType) { }
}

