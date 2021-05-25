public class Type3Message : MessageBase // TypeDefIndex: 1571
{
	// Fields
	private NtlmAuthLevel _level; // 0x18
	private byte[] _challenge; // 0x20
	private string _host; // 0x28
	private string _domain; // 0x30
	private string _username; // 0x38
	private string _password; // 0x40
	private Type2Message _type2; // 0x48
	private byte[] _lm; // 0x50
	private byte[] _nt; // 0x58

	// Properties
	public string Domain { set; }
	public string Password { set; }
	public string Username { set; }

	// Methods

	// RVA: 0x1A720E0 Offset: 0x1A721E1 VA: 0x1A720E0
	public void .ctor(Type2Message type2) { }

	// RVA: 0x1A723D0 Offset: 0x1A724D1 VA: 0x1A723D0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A724A0 Offset: 0x1A725A1 VA: 0x1A724A0
	public void set_Domain(string value) { }

	// RVA: 0x1A72530 Offset: 0x1A72631 VA: 0x1A72530
	public void set_Password(string value) { }

	// RVA: 0x1A72540 Offset: 0x1A72641 VA: 0x1A72540
	public void set_Username(string value) { }

	// RVA: 0x1A72550 Offset: 0x1A72651 VA: 0x1A72550 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x1A72860 Offset: 0x1A72961 VA: 0x1A72860
	private string DecodeString(byte[] buffer, int offset, int len) { }

	// RVA: 0x1A728D0 Offset: 0x1A729D1 VA: 0x1A728D0
	private byte[] EncodeString(string text) { }

	// RVA: 0x1A72980 Offset: 0x1A72A81 VA: 0x1A72980 Slot: 5
	public override byte[] GetBytes() { }
}

