[ComVisibleAttribute] // RVA: 0xAD1A0 Offset: 0xAD2A1 VA: 0xAD1A0
[DefaultMemberAttribute] // RVA: 0xAD1A0 Offset: 0xAD2A1 VA: 0xAD1A0
[Serializable]
public sealed class StringBuilder : ISerializable // TypeDefIndex: 473
{
	// Fields
	internal char[] m_ChunkChars; // 0x10
	internal StringBuilder m_ChunkPrevious; // 0x18
	internal int m_ChunkLength; // 0x20
	internal int m_ChunkOffset; // 0x24
	internal int m_MaxCapacity; // 0x28
	internal const int DefaultCapacity = 16;
	private const string CapacityField = "Capacity";
	private const string MaxCapacityField = "m_MaxCapacity";
	private const string StringValueField = "m_StringValue";
	private const string ThreadIDField = "m_currentThread";
	internal const int MaxChunkSize = 8000;

	// Properties
	public int Capacity { get; }
	public int MaxCapacity { get; }
	public int Length { get; set; }
	public char Chars { get; set; }

	// Methods

	// RVA: 0x2A6D500 Offset: 0x2A6D601 VA: 0x2A6D500
	public void .ctor() { }

	// RVA: 0x2A73D00 Offset: 0x2A73E01 VA: 0x2A73D00
	public void .ctor(int capacity) { }

	// RVA: 0x2A82CE0 Offset: 0x2A82DE1 VA: 0x2A82CE0
	public void .ctor(string value) { }

	// RVA: 0x2A82CB0 Offset: 0x2A82DB1 VA: 0x2A82CB0
	public void .ctor(string value, int capacity) { }

	// RVA: 0x2A82D10 Offset: 0x2A82E11 VA: 0x2A82D10
	public void .ctor(string value, int startIndex, int length, int capacity) { }

	// RVA: 0x2A83090 Offset: 0x2A83191 VA: 0x2A83090
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A83390 Offset: 0x2A83491 VA: 0x2A83390 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A834B0 Offset: 0x2A835B1 VA: 0x2A834B0
	public int get_Capacity() { }

	// RVA: 0x2A834E0 Offset: 0x2A835E1 VA: 0x2A834E0
	public int get_MaxCapacity() { }

	// RVA: 0x2A834F0 Offset: 0x2A835F1 VA: 0x2A834F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2A83650 Offset: 0x2A83751 VA: 0x2A83650
	public string ToString(int startIndex, int length) { }

	// RVA: 0x2A838A0 Offset: 0x2A839A1 VA: 0x2A838A0
	public StringBuilder Clear() { }

	// RVA: 0x2A6D580 Offset: 0x2A6D681 VA: 0x2A6D580
	public int get_Length() { }

	// RVA: 0x2A6D680 Offset: 0x2A6D781 VA: 0x2A6D680
	public void set_Length(int value) { }

	// RVA: 0x2A6D840 Offset: 0x2A6D941 VA: 0x2A6D840
	public char get_Chars(int index) { }

	// RVA: 0x2A81710 Offset: 0x2A81811 VA: 0x2A81710
	public void set_Chars(int index, char value) { }

	// RVA: 0x2A838D0 Offset: 0x2A839D1 VA: 0x2A838D0
	public StringBuilder Append(char value, int repeatCount) { }

	// RVA: 0x2A83C20 Offset: 0x2A83D21 VA: 0x2A83C20
	public StringBuilder Append(char[] value, int startIndex, int charCount) { }

	// RVA: 0x2A73D90 Offset: 0x2A73E91 VA: 0x2A73D90
	public StringBuilder Append(string value) { }

	// RVA: 0x2A83F10 Offset: 0x2A84011 VA: 0x2A83F10
	private void AppendHelper(string value) { }

	// RVA: 0x2A81E80 Offset: 0x2A81F81 VA: 0x2A81E80
	public StringBuilder Append(string value, int startIndex, int count) { }

	[ComVisibleAttribute] // RVA: 0xB79B0 Offset: 0xB7AB1 VA: 0xB79B0
	// RVA: 0x2A83F50 Offset: 0x2A84051 VA: 0x2A83F50
	public StringBuilder AppendLine() { }

	[ComVisibleAttribute] // RVA: 0xB79D0 Offset: 0xB7AD1 VA: 0xB79D0
	// RVA: 0x2A83F80 Offset: 0x2A84081 VA: 0x2A83F80
	public StringBuilder AppendLine(string value) { }

	// RVA: 0x2A83FB0 Offset: 0x2A840B1 VA: 0x2A83FB0
	public StringBuilder Insert(int index, string value, int count) { }

	// RVA: 0x2A81810 Offset: 0x2A81911 VA: 0x2A81810
	public StringBuilder Remove(int startIndex, int length) { }

	// RVA: 0x2A84850 Offset: 0x2A84951 VA: 0x2A84850
	public StringBuilder Append(byte value) { }

	// RVA: 0x2A6D590 Offset: 0x2A6D691 VA: 0x2A6D590
	public StringBuilder Append(char value) { }

	// RVA: 0x2A848E0 Offset: 0x2A849E1 VA: 0x2A848E0
	public StringBuilder Append(int value) { }

	// RVA: 0x2A84970 Offset: 0x2A84A71 VA: 0x2A84970
	public StringBuilder Append(long value) { }

	// RVA: 0x2A84A00 Offset: 0x2A84B01 VA: 0x2A84A00
	public StringBuilder Append(double value) { }

	// RVA: 0x2A84A90 Offset: 0x2A84B91 VA: 0x2A84A90
	public StringBuilder Append(object value) { }

	// RVA: 0x2A84AE0 Offset: 0x2A84BE1 VA: 0x2A84AE0
	public StringBuilder Insert(int index, string value) { }

	// RVA: 0x2A84CD0 Offset: 0x2A84DD1 VA: 0x2A84CD0
	public StringBuilder Insert(int index, char value) { }

	// RVA: 0x2A84D00 Offset: 0x2A84E01 VA: 0x2A84D00
	public StringBuilder AppendFormat(string format, object arg0) { }

	// RVA: 0x2A855C0 Offset: 0x2A856C1 VA: 0x2A855C0
	public StringBuilder AppendFormat(string format, object arg0, object arg1) { }

	// RVA: 0x2A85630 Offset: 0x2A85731 VA: 0x2A85630
	public StringBuilder AppendFormat(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x2A856A0 Offset: 0x2A857A1 VA: 0x2A856A0
	public StringBuilder AppendFormat(string format, object[] args) { }

	// RVA: 0x2A85790 Offset: 0x2A85891 VA: 0x2A85790
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0) { }

	// RVA: 0x2A85800 Offset: 0x2A85901 VA: 0x2A85800
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1) { }

	// RVA: 0x2A85880 Offset: 0x2A85981 VA: 0x2A85880
	private static void FormatError() { }

	// RVA: 0x2A84D70 Offset: 0x2A84E71 VA: 0x2A84D70
	internal StringBuilder AppendFormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	// RVA: 0x2A85900 Offset: 0x2A85A01 VA: 0x2A85900
	public StringBuilder Replace(string oldValue, string newValue) { }

	// RVA: 0x2A85910 Offset: 0x2A85A11 VA: 0x2A85910
	public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count) { }

	[CLSCompliantAttribute] // RVA: 0xB79F0 Offset: 0xB7AF1 VA: 0xB79F0
	// RVA: 0x2A83DD0 Offset: 0x2A83ED1 VA: 0x2A83DD0
	public StringBuilder Append(char* value, int valueCount) { }

	// RVA: 0x2A84BC0 Offset: 0x2A84CC1 VA: 0x2A84BC0
	private void Insert(int index, char* value, int valueCount) { }

	// RVA: 0x2A85E00 Offset: 0x2A85F01 VA: 0x2A85E00
	private void ReplaceAllInChunk(int[] replacements, int replacementsCount, StringBuilder sourceChunk, int removeCount, string value) { }

	// RVA: 0x2A85C60 Offset: 0x2A85D61 VA: 0x2A85C60
	private bool StartsWith(StringBuilder chunk, int indexInChunk, int count, string value) { }

	// RVA: 0x2A84500 Offset: 0x2A84601 VA: 0x2A84500
	private void ReplaceInPlaceAtChunk(ref StringBuilder chunk, ref int indexInChunk, char* value, int count) { }

	// RVA: 0x2A82F70 Offset: 0x2A83071 VA: 0x2A82F70
	private static void ThreadSafeCopy(char* sourcePtr, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x2A86080 Offset: 0x2A86181 VA: 0x2A86080
	private static void ThreadSafeCopy(char[] source, int sourceIndex, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x2A83A00 Offset: 0x2A83B01 VA: 0x2A83A00
	private StringBuilder FindChunkForIndex(int index) { }

	// RVA: 0x2A86030 Offset: 0x2A86131 VA: 0x2A86030
	private StringBuilder Next(StringBuilder chunk) { }

	// RVA: 0x2A83A30 Offset: 0x2A83B31 VA: 0x2A83A30
	private void ExpandByABlock(int minBlockCharCount) { }

	// RVA: 0x2A861A0 Offset: 0x2A862A1 VA: 0x2A861A0
	private void .ctor(StringBuilder from) { }

	// RVA: 0x2A84170 Offset: 0x2A84271 VA: 0x2A84170
	private void MakeRoom(int index, int count, out StringBuilder chunk, out int indexInChunk, bool doneMoveFollowingChars) { }

	// RVA: 0x2A86210 Offset: 0x2A86311 VA: 0x2A86210
	private void .ctor(int size, int maxCapacity, StringBuilder previousBlock) { }

	// RVA: 0x2A846E0 Offset: 0x2A847E1 VA: 0x2A846E0
	private void Remove(int startIndex, int count, out StringBuilder chunk, out int indexInChunk) { }
}

