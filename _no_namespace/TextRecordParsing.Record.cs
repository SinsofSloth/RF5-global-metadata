public class TextRecordParsing.Record // TypeDefIndex: 9189
{
	// Fields
	private List<string> items; // 0x10

	// Properties
	public int Count { get; }
	public IEnumerable<string> Items { get; }

	// Methods

	// RVA: 0x23A6800 Offset: 0x23A6901 VA: 0x23A6800
	public void .ctor(IEnumerable<string> initialItems) { }

	// RVA: 0x23A6D90 Offset: 0x23A6E91 VA: 0x23A6D90
	public int get_Count() { }

	// RVA: 0x23A6DE0 Offset: 0x23A6EE1 VA: 0x23A6DE0
	public IEnumerable<string> get_Items() { }

	// RVA: 0x239F4B0 Offset: 0x239F5B1 VA: 0x239F4B0
	public string GetString(int index) { }

	// RVA: 0x23A6DF0 Offset: 0x23A6EF1 VA: 0x23A6DF0
	public bool GetBool(int index) { }

	// RVA: 0x23A6E00 Offset: 0x23A6F01 VA: 0x23A6E00
	public bool TryGetInt(int index, ref int output) { }

	// RVA: 0x23A6EC0 Offset: 0x23A6FC1 VA: 0x23A6EC0
	public bool TryGetFloat(int index, ref float output) { }

	// RVA: 0x23A6F80 Offset: 0x23A7081 VA: 0x23A6F80
	public bool TryGetVector3(int startIndex, ref Vector3 output) { }

	// RVA: 0x23A6F90 Offset: 0x23A7091 VA: 0x23A6F90
	public Queue<string> ToQueue() { }
}

