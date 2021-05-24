internal sealed class __BinaryWriter // TypeDefIndex: 1078
{
	// Fields
	internal Stream sout; // 0x10
	internal FormatterTypeStyle formatterTypeStyle; // 0x18
	internal Hashtable objectMapTable; // 0x20
	internal ObjectWriter objectWriter; // 0x28
	internal BinaryWriter dataWriter; // 0x30
	internal int m_nestedObjectCount; // 0x38
	private int nullCount; // 0x3C
	internal BinaryMethodCall binaryMethodCall; // 0x40
	internal BinaryMethodReturn binaryMethodReturn; // 0x48
	internal BinaryObject binaryObject; // 0x50
	internal BinaryObjectWithMap binaryObjectWithMap; // 0x58
	internal BinaryObjectWithMapTyped binaryObjectWithMapTyped; // 0x60
	internal BinaryObjectString binaryObjectString; // 0x68
	internal BinaryArray binaryArray; // 0x70
	private byte[] byteBuffer; // 0x78
	private int chunkSize; // 0x80
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped; // 0x88
	internal MemberPrimitiveTyped memberPrimitiveTyped; // 0x90
	internal ObjectNull objectNull; // 0x98
	internal MemberReference memberReference; // 0xA0
	internal BinaryAssembly binaryAssembly; // 0xA8

	// Methods

	// RVA: 0x1513850 Offset: 0x1513951 VA: 0x1513850
	internal void .ctor(Stream sout, ObjectWriter objectWriter, FormatterTypeStyle formatterTypeStyle) { }

	// RVA: 0x1513930 Offset: 0x1513A31 VA: 0x1513930
	internal void WriteBegin() { }

	// RVA: 0x1513940 Offset: 0x1513A41 VA: 0x1513940
	internal void WriteEnd() { }

	// RVA: 0x1513960 Offset: 0x1513A61 VA: 0x1513960
	internal void WriteBoolean(bool value) { }

	// RVA: 0x150AB10 Offset: 0x150AC11 VA: 0x150AB10
	internal void WriteByte(byte value) { }

	// RVA: 0x1513990 Offset: 0x1513A91 VA: 0x1513990
	private void WriteBytes(byte[] value) { }

	// RVA: 0x15139B0 Offset: 0x1513AB1 VA: 0x15139B0
	private void WriteBytes(byte[] byteA, int offset, int size) { }

	// RVA: 0x15139D0 Offset: 0x1513AD1 VA: 0x15139D0
	internal void WriteChar(char value) { }

	// RVA: 0x15139F0 Offset: 0x1513AF1 VA: 0x15139F0
	internal void WriteChars(char[] value) { }

	// RVA: 0x1513A10 Offset: 0x1513B11 VA: 0x1513A10
	internal void WriteDecimal(Decimal value) { }

	// RVA: 0x1513AF0 Offset: 0x1513BF1 VA: 0x1513AF0
	internal void WriteSingle(float value) { }

	// RVA: 0x1513B20 Offset: 0x1513C21 VA: 0x1513B20
	internal void WriteDouble(double value) { }

	// RVA: 0x1513B50 Offset: 0x1513C51 VA: 0x1513B50
	internal void WriteInt16(short value) { }

	// RVA: 0x150AB30 Offset: 0x150AC31 VA: 0x150AB30
	internal void WriteInt32(int value) { }

	// RVA: 0x1513B80 Offset: 0x1513C81 VA: 0x1513B80
	internal void WriteInt64(long value) { }

	// RVA: 0x1513BB0 Offset: 0x1513CB1 VA: 0x1513BB0
	internal void WriteSByte(sbyte value) { }

	// RVA: 0x1513AC0 Offset: 0x1513BC1 VA: 0x1513AC0
	internal void WriteString(string value) { }

	// RVA: 0x1513BD0 Offset: 0x1513CD1 VA: 0x1513BD0
	internal void WriteTimeSpan(TimeSpan value) { }

	// RVA: 0x1513C00 Offset: 0x1513D01 VA: 0x1513C00
	internal void WriteDateTime(DateTime value) { }

	// RVA: 0x1513C30 Offset: 0x1513D31 VA: 0x1513C30
	internal void WriteUInt16(ushort value) { }

	// RVA: 0x1513C60 Offset: 0x1513D61 VA: 0x1513C60
	internal void WriteUInt32(uint value) { }

	// RVA: 0x1513C90 Offset: 0x1513D91 VA: 0x1513C90
	internal void WriteUInt64(ulong value) { }

	// RVA: 0x1513CC0 Offset: 0x1513DC1 VA: 0x1513CC0
	internal void WriteObjectEnd(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x1513CD0 Offset: 0x1513DD1 VA: 0x1513CD0
	internal void WriteSerializationHeaderEnd() { }

	// RVA: 0x1513D50 Offset: 0x1513E51 VA: 0x1513D50
	internal void WriteSerializationHeader(int topId, int headerId, int minorVersion, int majorVersion) { }

	// RVA: 0x1513DF0 Offset: 0x1513EF1 VA: 0x1513DF0
	internal void WriteMethodCall() { }

	// RVA: 0x1513EA0 Offset: 0x1513FA1 VA: 0x1513EA0
	internal void WriteMethodReturn() { }

	// RVA: 0x1513F50 Offset: 0x1514051 VA: 0x1513F50
	internal void WriteObject(NameInfo nameInfo, NameInfo typeNameInfo, int numMembers, string[] memberNames, Type[] memberTypes, WriteObjectInfo[] memberObjectInfos) { }

	// RVA: 0x1514570 Offset: 0x1514671 VA: 0x1514570
	internal void WriteObjectString(int objectId, string value) { }

	// RVA: 0x1514640 Offset: 0x1514741 VA: 0x1514640
	internal void WriteSingleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Array array) { }

	// RVA: 0x1514940 Offset: 0x1514A41 VA: 0x1514940
	private void WriteArrayAsBytes(Array array, int typeLength) { }

	// RVA: 0x1514BC0 Offset: 0x1514CC1 VA: 0x1514BC0
	internal void WriteJaggedArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound) { }

	// RVA: 0x1514D80 Offset: 0x1514E81 VA: 0x1514D80
	internal void WriteRectangleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int rank, int[] lengthA, int[] lowerBoundA) { }

	// RVA: 0x1514F20 Offset: 0x1515021 VA: 0x1514F20
	internal void WriteObjectByteArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, byte[] byteA) { }

	// RVA: 0x1514F90 Offset: 0x1515091 VA: 0x1514F90
	internal void WriteMember(NameInfo memberNameInfo, NameInfo typeNameInfo, object value) { }

	// RVA: 0x1515100 Offset: 0x1515201 VA: 0x1515100
	internal void WriteNullMember(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x15151F0 Offset: 0x15152F1 VA: 0x15151F0
	internal void WriteMemberObjectRef(NameInfo memberNameInfo, int idRef) { }

	// RVA: 0x15152C0 Offset: 0x15153C1 VA: 0x15152C0
	internal void WriteMemberNested(NameInfo memberNameInfo) { }

	// RVA: 0x15152F0 Offset: 0x15153F1 VA: 0x15152F0
	internal void WriteMemberString(NameInfo memberNameInfo, NameInfo typeNameInfo, string value) { }

	// RVA: 0x1515340 Offset: 0x1515441 VA: 0x1515340
	internal void WriteItem(NameInfo itemNameInfo, NameInfo typeNameInfo, object value) { }

	// RVA: 0x1515390 Offset: 0x1515491 VA: 0x1515390
	internal void WriteNullItem(NameInfo itemNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x15153A0 Offset: 0x15154A1 VA: 0x15153A0
	internal void WriteDelayedNullItem() { }

	// RVA: 0x15153B0 Offset: 0x15154B1 VA: 0x15153B0
	internal void WriteItemEnd() { }

	// RVA: 0x15144A0 Offset: 0x15145A1 VA: 0x15144A0
	private void InternalWriteItemNull() { }

	// RVA: 0x15153C0 Offset: 0x15154C1 VA: 0x15153C0
	internal void WriteItemObjectRef(NameInfo nameInfo, int idRef) { }

	// RVA: 0x1515400 Offset: 0x1515501 VA: 0x1515400
	internal void WriteAssembly(Type type, string assemblyString, int assemId, bool isNew) { }

	// RVA: 0x1515520 Offset: 0x1515621 VA: 0x1515520
	internal void WriteValue(InternalPrimitiveTypeE code, object value) { }
}

