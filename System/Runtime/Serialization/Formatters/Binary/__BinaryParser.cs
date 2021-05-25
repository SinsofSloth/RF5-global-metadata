internal sealed class __BinaryParser // TypeDefIndex: 1089
{
	// Fields
	internal ObjectReader objectReader; // 0x10
	internal Stream input; // 0x18
	internal long topId; // 0x20
	internal long headerId; // 0x28
	internal SizedArray objectMapIdTable; // 0x30
	internal SizedArray assemIdToAssemblyTable; // 0x38
	internal SerStack stack; // 0x40
	internal BinaryTypeEnum expectedType; // 0x48
	internal object expectedTypeInformation; // 0x50
	internal ParseRecord PRS; // 0x58
	private BinaryAssemblyInfo systemAssemblyInfo; // 0x60
	private BinaryReader dataReader; // 0x68
	private static Encoding encoding; // 0x0
	private SerStack opPool; // 0x70
	private BinaryObject binaryObject; // 0x78
	private BinaryObjectWithMap bowm; // 0x80
	private BinaryObjectWithMapTyped bowmt; // 0x88
	internal BinaryObjectString objectString; // 0x90
	internal BinaryCrossAppDomainString crossAppDomainString; // 0x98
	internal MemberPrimitiveTyped memberPrimitiveTyped; // 0xA0
	private byte[] byteBuffer; // 0xA8
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped; // 0xB0
	internal MemberReference memberReference; // 0xB8
	internal ObjectNull objectNull; // 0xC0
	internal static MessageEnd messageEnd; // 0x8

	// Properties
	internal BinaryAssemblyInfo SystemAssemblyInfo { get; }
	internal SizedArray ObjectMapIdTable { get; }
	internal SizedArray AssemIdToAssemblyTable { get; }
	internal ParseRecord prs { get; }

	// Methods

	// RVA: 0x150D970 Offset: 0x150DA71 VA: 0x150D970
	internal void .ctor(Stream stream, ObjectReader objectReader) { }

	// RVA: 0x150DB00 Offset: 0x150DC01 VA: 0x150DB00
	internal BinaryAssemblyInfo get_SystemAssemblyInfo() { }

	// RVA: 0x150DBD0 Offset: 0x150DCD1 VA: 0x150DBD0
	internal SizedArray get_ObjectMapIdTable() { }

	// RVA: 0x150DCD0 Offset: 0x150DDD1 VA: 0x150DCD0
	internal SizedArray get_AssemIdToAssemblyTable() { }

	// RVA: 0x150DDD0 Offset: 0x150DED1 VA: 0x150DDD0
	internal ParseRecord get_prs() { }

	// RVA: 0x150DE60 Offset: 0x150DF61 VA: 0x150DE60
	internal void Run() { }

	// RVA: 0x150E960 Offset: 0x150EA61 VA: 0x150E960
	internal void ReadBegin() { }

	// RVA: 0x15119C0 Offset: 0x1511AC1 VA: 0x15119C0
	internal void ReadEnd() { }

	// RVA: 0x15120E0 Offset: 0x15121E1 VA: 0x15120E0
	internal bool ReadBoolean() { }

	// RVA: 0x1512100 Offset: 0x1512201 VA: 0x1512100
	internal byte ReadByte() { }

	// RVA: 0x150AD90 Offset: 0x150AE91 VA: 0x150AD90
	internal byte[] ReadBytes(int length) { }

	// RVA: 0x1512120 Offset: 0x1512221 VA: 0x1512120
	internal void ReadBytes(byte[] byteA, int offset, int size) { }

	// RVA: 0x15121C0 Offset: 0x15122C1 VA: 0x15121C0
	internal char ReadChar() { }

	// RVA: 0x15121E0 Offset: 0x15122E1 VA: 0x15121E0
	internal char[] ReadChars(int length) { }

	// RVA: 0x1512210 Offset: 0x1512311 VA: 0x1512210
	internal Decimal ReadDecimal() { }

	// RVA: 0x15122D0 Offset: 0x15123D1 VA: 0x15122D0
	internal float ReadSingle() { }

	// RVA: 0x1512300 Offset: 0x1512401 VA: 0x1512300
	internal double ReadDouble() { }

	// RVA: 0x1512330 Offset: 0x1512431 VA: 0x1512330
	internal short ReadInt16() { }

	// RVA: 0x1512360 Offset: 0x1512461 VA: 0x1512360
	internal int ReadInt32() { }

	// RVA: 0x1512390 Offset: 0x1512491 VA: 0x1512390
	internal long ReadInt64() { }

	// RVA: 0x15123C0 Offset: 0x15124C1 VA: 0x15123C0
	internal sbyte ReadSByte() { }

	// RVA: 0x15123E0 Offset: 0x15124E1 VA: 0x15123E0
	internal string ReadString() { }

	// RVA: 0x1512410 Offset: 0x1512511 VA: 0x1512410
	internal TimeSpan ReadTimeSpan() { }

	// RVA: 0x1512440 Offset: 0x1512541 VA: 0x1512440
	internal DateTime ReadDateTime() { }

	// RVA: 0x15124D0 Offset: 0x15125D1 VA: 0x15124D0
	internal ushort ReadUInt16() { }

	// RVA: 0x1512500 Offset: 0x1512601 VA: 0x1512500
	internal uint ReadUInt32() { }

	// RVA: 0x1512530 Offset: 0x1512631 VA: 0x1512530
	internal ulong ReadUInt64() { }

	// RVA: 0x150E970 Offset: 0x150EA71 VA: 0x150E970
	internal void ReadSerializationHeaderRecord() { }

	// RVA: 0x150EA50 Offset: 0x150EB51 VA: 0x150EA50
	internal void ReadAssembly(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x150ECB0 Offset: 0x150EDB1 VA: 0x150ECB0
	private void ReadObject() { }

	// RVA: 0x150F0F0 Offset: 0x150F1F1 VA: 0x150F0F0
	internal void ReadCrossAppDomainMap() { }

	// RVA: 0x150F2A0 Offset: 0x150F3A1 VA: 0x150F2A0
	internal void ReadObjectWithMap(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x1512620 Offset: 0x1512721 VA: 0x1512620
	private void ReadObjectWithMap(BinaryObjectWithMap record) { }

	// RVA: 0x150F370 Offset: 0x150F471 VA: 0x150F370
	internal void ReadObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x1512B00 Offset: 0x1512C01 VA: 0x1512B00
	private void ReadObjectWithMapTyped(BinaryObjectWithMapTyped record) { }

	// RVA: 0x150F430 Offset: 0x150F531 VA: 0x150F430
	private void ReadObjectString(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x1510630 Offset: 0x1510731 VA: 0x1510630
	private void ReadMemberPrimitiveTyped() { }

	// RVA: 0x150FFE0 Offset: 0x15100E1 VA: 0x150FFE0
	private void ReadArray(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x1512FD0 Offset: 0x15130D1 VA: 0x1512FD0
	private void ReadArrayAsBytes(ParseRecord pr) { }

	// RVA: 0x15119D0 Offset: 0x1511AD1 VA: 0x15119D0
	private void ReadMemberPrimitiveUnTyped() { }

	// RVA: 0x1510E80 Offset: 0x1510F81 VA: 0x1510E80
	private void ReadMemberReference() { }

	// RVA: 0x1511330 Offset: 0x1511431 VA: 0x1511330
	private void ReadObjectNull(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x1511800 Offset: 0x1511901 VA: 0x1511800
	private void ReadMessageEnd() { }

	// RVA: 0x1513400 Offset: 0x1513501 VA: 0x1513400
	internal object ReadValue(InternalPrimitiveTypeE code) { }

	// RVA: 0x1512560 Offset: 0x1512661 VA: 0x1512560
	private ObjectProgress GetOp() { }

	// RVA: 0x1511FD0 Offset: 0x15120D1 VA: 0x1511FD0
	private void PutOp(ObjectProgress op) { }

	// RVA: 0x15137D0 Offset: 0x15138D1 VA: 0x15137D0
	private static void .cctor() { }
}

