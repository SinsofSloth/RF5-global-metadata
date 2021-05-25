[Serializable]
internal class CallContextRemotingData : ICloneable // TypeDefIndex: 1193
{
	// Fields
	private string _logicalCallID; // 0x10

	// Properties
	internal string LogicalCallID { get; set; }
	internal bool HasInfo { get; }

	// Methods

	// RVA: 0x1750590 Offset: 0x1750691 VA: 0x1750590
	internal string get_LogicalCallID() { }

	// RVA: 0x17505A0 Offset: 0x17506A1 VA: 0x17505A0
	internal void set_LogicalCallID(string value) { }

	// RVA: 0x17505B0 Offset: 0x17506B1 VA: 0x17505B0
	internal bool get_HasInfo() { }

	// RVA: 0x17505C0 Offset: 0x17506C1 VA: 0x17505C0 Slot: 4
	public object Clone() { }

	// RVA: 0x1750640 Offset: 0x1750741 VA: 0x1750640
	public void .ctor() { }
}

