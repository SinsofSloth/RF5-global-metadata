[ComVisibleAttribute] // RVA: 0xAD350 Offset: 0xAD451 VA: 0xAD350
public sealed class ResourceReader : IResourceReader, IEnumerable, IDisposable // TypeDefIndex: 505
{
	// Fields
	private BinaryReader _store; // 0x10
	internal Dictionary<string, ResourceLocator> _resCache; // 0x18
	private long _nameSectionOffset; // 0x20
	private long _dataSectionOffset; // 0x28
	private int[] _nameHashes; // 0x30
	private int* _nameHashesPtr; // 0x38
	private int[] _namePositions; // 0x40
	private int* _namePositionsPtr; // 0x48
	private RuntimeType[] _typeTable; // 0x50
	private int[] _typeNamePositions; // 0x58
	private BinaryFormatter _objFormatter; // 0x60
	private int _numResources; // 0x68
	private UnmanagedMemoryStream _ums; // 0x70
	private int _version; // 0x78

	// Methods

	// RVA: 0x17FA8B0 Offset: 0x17FA9B1 VA: 0x17FA8B0
	internal void .ctor(Stream stream, Dictionary<string, ResourceLocator> resCache) { }

	// RVA: 0x17FAB40 Offset: 0x17FAC41 VA: 0x17FAB40 Slot: 4
	public void Close() { }

	// RVA: 0x17FAC10 Offset: 0x17FAD11 VA: 0x17FAC10 Slot: 7
	public void Dispose() { }

	// RVA: 0x17FAB50 Offset: 0x17FAC51 VA: 0x17FAB50
	private void Dispose(bool disposing) { }

	// RVA: 0x17FAC20 Offset: 0x17FAD21 VA: 0x17FAC20
	internal static int ReadUnalignedI4(int* p) { }

	// RVA: 0x17FAC30 Offset: 0x17FAD31 VA: 0x17FAC30
	private void SkipString() { }

	// RVA: 0x17FAD10 Offset: 0x17FAE11 VA: 0x17FAD10
	private int GetNameHash(int index) { }

	// RVA: 0x17FAD70 Offset: 0x17FAE71 VA: 0x17FAD70
	private int GetNamePosition(int index) { }

	// RVA: 0x17FAEC0 Offset: 0x17FAFC1 VA: 0x17FAEC0 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x17FAED0 Offset: 0x17FAFD1 VA: 0x17FAED0 Slot: 5
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x17FB000 Offset: 0x17FB101 VA: 0x17FB000
	internal ResourceReader.ResourceEnumerator GetEnumeratorInternal() { }

	// RVA: 0x17FB080 Offset: 0x17FB181 VA: 0x17FB080
	internal int FindPosForResource(string name) { }

	// RVA: 0x17FB670 Offset: 0x17FB771 VA: 0x17FB670
	private bool CompareStringEqualsName(string name) { }

	// RVA: 0x17FB8D0 Offset: 0x17FB9D1 VA: 0x17FB8D0
	private string AllocateStringForNameIndex(int index, out int dataOffset) { }

	// RVA: 0x17FC3A0 Offset: 0x17FC4A1 VA: 0x17FC3A0
	private object GetValueForNameIndex(int index) { }

	// RVA: 0x17FC940 Offset: 0x17FCA41 VA: 0x17FC940
	internal string LoadString(int pos) { }

	// RVA: 0x17FCFA0 Offset: 0x17FD0A1 VA: 0x17FCFA0
	internal object LoadObject(int pos) { }

	// RVA: 0x17FCFE0 Offset: 0x17FD0E1 VA: 0x17FCFE0
	internal object LoadObject(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0x17FC6D0 Offset: 0x17FC7D1 VA: 0x17FC6D0
	internal object LoadObjectV1(int pos) { }

	// RVA: 0x17FD080 Offset: 0x17FD181 VA: 0x17FD080
	private object _LoadObjectV1(int pos) { }

	// RVA: 0x17FC800 Offset: 0x17FC901 VA: 0x17FC800
	internal object LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0x17FD9C0 Offset: 0x17FDAC1 VA: 0x17FD9C0
	private object _LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0x17FD7E0 Offset: 0x17FD8E1 VA: 0x17FD7E0
	private object DeserializeObject(int typeIndex) { }

	// RVA: 0x17FA9C0 Offset: 0x17FAAC1 VA: 0x17FA9C0
	private void ReadResources() { }

	// RVA: 0x17FE010 Offset: 0x17FE111 VA: 0x17FE010
	private void _ReadResources() { }

	// RVA: 0x17FCC00 Offset: 0x17FCD01 VA: 0x17FCC00
	private RuntimeType FindType(int typeIndex) { }
}

