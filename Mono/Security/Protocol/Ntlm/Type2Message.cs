public class Type2Message : MessageBase // TypeDefIndex: 1570
{
	// Fields
	private byte[] _nonce; // 0x18
	private string _targetName; // 0x20
	private byte[] _targetInfo; // 0x28

	// Properties
	public byte[] Nonce { get; }
	public string TargetName { get; }
	public byte[] TargetInfo { get; }

	// Methods

	// RVA: 0x1A71D10 Offset: 0x1A71E11 VA: 0x1A71D10
	public void .ctor(byte[] message) { }

	// RVA: 0x1A71DD0 Offset: 0x1A71ED1 VA: 0x1A71DD0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A70A70 Offset: 0x1A70B71 VA: 0x1A70A70
	public byte[] get_Nonce() { }

	// RVA: 0x1A71E50 Offset: 0x1A71F51 VA: 0x1A71E50
	public string get_TargetName() { }

	// RVA: 0x1A709F0 Offset: 0x1A70AF1 VA: 0x1A709F0
	public byte[] get_TargetInfo() { }

	// RVA: 0x1A71E60 Offset: 0x1A71F61 VA: 0x1A71E60 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x1A72010 Offset: 0x1A72111 VA: 0x1A72010 Slot: 5
	public override byte[] GetBytes() { }
}

