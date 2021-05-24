[ObsoleteAttribute] // RVA: 0xBAC60 Offset: 0xBAD61 VA: 0xBAC60
public class ChallengeResponse : IDisposable // TypeDefIndex: 1563
{
	// Fields
	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8
	private bool _disposed; // 0x10
	private byte[] _challenge; // 0x18
	private byte[] _lmpwd; // 0x20
	private byte[] _ntpwd; // 0x28

	// Properties
	public string Password { set; }
	public byte[] Challenge { set; }
	public byte[] LM { get; }
	public byte[] NT { get; }

	// Methods

	// RVA: 0x1A6E7A0 Offset: 0x1A6E8A1 VA: 0x1A6E7A0
	public void .ctor() { }

	// RVA: 0x1A6E840 Offset: 0x1A6E941 VA: 0x1A6E840
	public void .ctor(string password, byte[] challenge) { }

	// RVA: 0x1A6EE80 Offset: 0x1A6EF81 VA: 0x1A6EE80 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A6E900 Offset: 0x1A6EA01 VA: 0x1A6E900
	public void set_Password(string value) { }

	// RVA: 0x1A6ED70 Offset: 0x1A6EE71 VA: 0x1A6ED70
	public void set_Challenge(byte[] value) { }

	// RVA: 0x1A6F120 Offset: 0x1A6F221 VA: 0x1A6F120
	public byte[] get_LM() { }

	// RVA: 0x1A6F4A0 Offset: 0x1A6F5A1 VA: 0x1A6F4A0
	public byte[] get_NT() { }

	// RVA: 0x1A6EF00 Offset: 0x1A6F001 VA: 0x1A6EF00 Slot: 4
	public void Dispose() { }

	// RVA: 0x1A6F530 Offset: 0x1A6F631 VA: 0x1A6F530
	private void Dispose(bool disposing) { }

	// RVA: 0x1A6F1B0 Offset: 0x1A6F2B1 VA: 0x1A6F1B0
	private byte[] GetResponse(byte[] pwd) { }

	// RVA: 0x1A6F5C0 Offset: 0x1A6F6C1 VA: 0x1A6F5C0
	private byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x1A6EFD0 Offset: 0x1A6F0D1 VA: 0x1A6EFD0
	private byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x1A6F7D0 Offset: 0x1A6F8D1 VA: 0x1A6F7D0
	private static void .cctor() { }
}

[ObsoleteAttribute] // RVA: 0xBAC60 Offset: 0xBAD61 VA: 0xBAC60
public class ChallengeResponse : IDisposable // TypeDefIndex: 1563
{
	// Fields
	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8
	private bool _disposed; // 0x10
	private byte[] _challenge; // 0x18
	private byte[] _lmpwd; // 0x20
	private byte[] _ntpwd; // 0x28

	// Properties
	public string Password { set; }
	public byte[] Challenge { set; }
	public byte[] LM { get; }
	public byte[] NT { get; }

	// Methods

	// RVA: 0x1A6E7A0 Offset: 0x1A6E8A1 VA: 0x1A6E7A0
	public void .ctor() { }

	// RVA: 0x1A6E840 Offset: 0x1A6E941 VA: 0x1A6E840
	public void .ctor(string password, byte[] challenge) { }

	// RVA: 0x1A6EE80 Offset: 0x1A6EF81 VA: 0x1A6EE80 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A6E900 Offset: 0x1A6EA01 VA: 0x1A6E900
	public void set_Password(string value) { }

	// RVA: 0x1A6ED70 Offset: 0x1A6EE71 VA: 0x1A6ED70
	public void set_Challenge(byte[] value) { }

	// RVA: 0x1A6F120 Offset: 0x1A6F221 VA: 0x1A6F120
	public byte[] get_LM() { }

	// RVA: 0x1A6F4A0 Offset: 0x1A6F5A1 VA: 0x1A6F4A0
	public byte[] get_NT() { }

	// RVA: 0x1A6EF00 Offset: 0x1A6F001 VA: 0x1A6EF00 Slot: 4
	public void Dispose() { }

	// RVA: 0x1A6F530 Offset: 0x1A6F631 VA: 0x1A6F530
	private void Dispose(bool disposing) { }

	// RVA: 0x1A6F1B0 Offset: 0x1A6F2B1 VA: 0x1A6F1B0
	private byte[] GetResponse(byte[] pwd) { }

	// RVA: 0x1A6F5C0 Offset: 0x1A6F6C1 VA: 0x1A6F5C0
	private byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x1A6EFD0 Offset: 0x1A6F0D1 VA: 0x1A6EFD0
	private byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x1A6F7D0 Offset: 0x1A6F8D1 VA: 0x1A6F7D0
	private static void .cctor() { }
}

[ObsoleteAttribute] // RVA: 0xBAC60 Offset: 0xBAD61 VA: 0xBAC60
public class ChallengeResponse : IDisposable // TypeDefIndex: 1563
{
	// Fields
	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8
	private bool _disposed; // 0x10
	private byte[] _challenge; // 0x18
	private byte[] _lmpwd; // 0x20
	private byte[] _ntpwd; // 0x28

	// Properties
	public string Password { set; }
	public byte[] Challenge { set; }
	public byte[] LM { get; }
	public byte[] NT { get; }

	// Methods

	// RVA: 0x1A6E7A0 Offset: 0x1A6E8A1 VA: 0x1A6E7A0
	public void .ctor() { }

	// RVA: 0x1A6E840 Offset: 0x1A6E941 VA: 0x1A6E840
	public void .ctor(string password, byte[] challenge) { }

	// RVA: 0x1A6EE80 Offset: 0x1A6EF81 VA: 0x1A6EE80 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A6E900 Offset: 0x1A6EA01 VA: 0x1A6E900
	public void set_Password(string value) { }

	// RVA: 0x1A6ED70 Offset: 0x1A6EE71 VA: 0x1A6ED70
	public void set_Challenge(byte[] value) { }

	// RVA: 0x1A6F120 Offset: 0x1A6F221 VA: 0x1A6F120
	public byte[] get_LM() { }

	// RVA: 0x1A6F4A0 Offset: 0x1A6F5A1 VA: 0x1A6F4A0
	public byte[] get_NT() { }

	// RVA: 0x1A6EF00 Offset: 0x1A6F001 VA: 0x1A6EF00 Slot: 4
	public void Dispose() { }

	// RVA: 0x1A6F530 Offset: 0x1A6F631 VA: 0x1A6F530
	private void Dispose(bool disposing) { }

	// RVA: 0x1A6F1B0 Offset: 0x1A6F2B1 VA: 0x1A6F1B0
	private byte[] GetResponse(byte[] pwd) { }

	// RVA: 0x1A6F5C0 Offset: 0x1A6F6C1 VA: 0x1A6F5C0
	private byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x1A6EFD0 Offset: 0x1A6F0D1 VA: 0x1A6EFD0
	private byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x1A6F7D0 Offset: 0x1A6F8D1 VA: 0x1A6F7D0
	private static void .cctor() { }
}

[ObsoleteAttribute] // RVA: 0xBAC60 Offset: 0xBAD61 VA: 0xBAC60
public class ChallengeResponse : IDisposable // TypeDefIndex: 1563
{
	// Fields
	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8
	private bool _disposed; // 0x10
	private byte[] _challenge; // 0x18
	private byte[] _lmpwd; // 0x20
	private byte[] _ntpwd; // 0x28

	// Properties
	public string Password { set; }
	public byte[] Challenge { set; }
	public byte[] LM { get; }
	public byte[] NT { get; }

	// Methods

	// RVA: 0x1A6E7A0 Offset: 0x1A6E8A1 VA: 0x1A6E7A0
	public void .ctor() { }

	// RVA: 0x1A6E840 Offset: 0x1A6E941 VA: 0x1A6E840
	public void .ctor(string password, byte[] challenge) { }

	// RVA: 0x1A6EE80 Offset: 0x1A6EF81 VA: 0x1A6EE80 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A6E900 Offset: 0x1A6EA01 VA: 0x1A6E900
	public void set_Password(string value) { }

	// RVA: 0x1A6ED70 Offset: 0x1A6EE71 VA: 0x1A6ED70
	public void set_Challenge(byte[] value) { }

	// RVA: 0x1A6F120 Offset: 0x1A6F221 VA: 0x1A6F120
	public byte[] get_LM() { }

	// RVA: 0x1A6F4A0 Offset: 0x1A6F5A1 VA: 0x1A6F4A0
	public byte[] get_NT() { }

	// RVA: 0x1A6EF00 Offset: 0x1A6F001 VA: 0x1A6EF00 Slot: 4
	public void Dispose() { }

	// RVA: 0x1A6F530 Offset: 0x1A6F631 VA: 0x1A6F530
	private void Dispose(bool disposing) { }

	// RVA: 0x1A6F1B0 Offset: 0x1A6F2B1 VA: 0x1A6F1B0
	private byte[] GetResponse(byte[] pwd) { }

	// RVA: 0x1A6F5C0 Offset: 0x1A6F6C1 VA: 0x1A6F5C0
	private byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x1A6EFD0 Offset: 0x1A6F0D1 VA: 0x1A6EFD0
	private byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x1A6F7D0 Offset: 0x1A6F8D1 VA: 0x1A6F7D0
	private static void .cctor() { }
}

[ObsoleteAttribute] // RVA: 0xBAC60 Offset: 0xBAD61 VA: 0xBAC60
public class ChallengeResponse : IDisposable // TypeDefIndex: 1563
{
	// Fields
	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8
	private bool _disposed; // 0x10
	private byte[] _challenge; // 0x18
	private byte[] _lmpwd; // 0x20
	private byte[] _ntpwd; // 0x28

	// Properties
	public string Password { set; }
	public byte[] Challenge { set; }
	public byte[] LM { get; }
	public byte[] NT { get; }

	// Methods

	// RVA: 0x1A6E7A0 Offset: 0x1A6E8A1 VA: 0x1A6E7A0
	public void .ctor() { }

	// RVA: 0x1A6E840 Offset: 0x1A6E941 VA: 0x1A6E840
	public void .ctor(string password, byte[] challenge) { }

	// RVA: 0x1A6EE80 Offset: 0x1A6EF81 VA: 0x1A6EE80 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A6E900 Offset: 0x1A6EA01 VA: 0x1A6E900
	public void set_Password(string value) { }

	// RVA: 0x1A6ED70 Offset: 0x1A6EE71 VA: 0x1A6ED70
	public void set_Challenge(byte[] value) { }

	// RVA: 0x1A6F120 Offset: 0x1A6F221 VA: 0x1A6F120
	public byte[] get_LM() { }

	// RVA: 0x1A6F4A0 Offset: 0x1A6F5A1 VA: 0x1A6F4A0
	public byte[] get_NT() { }

	// RVA: 0x1A6EF00 Offset: 0x1A6F001 VA: 0x1A6EF00 Slot: 4
	public void Dispose() { }

	// RVA: 0x1A6F530 Offset: 0x1A6F631 VA: 0x1A6F530
	private void Dispose(bool disposing) { }

	// RVA: 0x1A6F1B0 Offset: 0x1A6F2B1 VA: 0x1A6F1B0
	private byte[] GetResponse(byte[] pwd) { }

	// RVA: 0x1A6F5C0 Offset: 0x1A6F6C1 VA: 0x1A6F5C0
	private byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x1A6EFD0 Offset: 0x1A6F0D1 VA: 0x1A6EFD0
	private byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x1A6F7D0 Offset: 0x1A6F8D1 VA: 0x1A6F7D0
	private static void .cctor() { }
}

[ObsoleteAttribute] // RVA: 0xBAC60 Offset: 0xBAD61 VA: 0xBAC60
public class ChallengeResponse : IDisposable // TypeDefIndex: 1563
{
	// Fields
	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8
	private bool _disposed; // 0x10
	private byte[] _challenge; // 0x18
	private byte[] _lmpwd; // 0x20
	private byte[] _ntpwd; // 0x28

	// Properties
	public string Password { set; }
	public byte[] Challenge { set; }
	public byte[] LM { get; }
	public byte[] NT { get; }

	// Methods

	// RVA: 0x1A6E7A0 Offset: 0x1A6E8A1 VA: 0x1A6E7A0
	public void .ctor() { }

	// RVA: 0x1A6E840 Offset: 0x1A6E941 VA: 0x1A6E840
	public void .ctor(string password, byte[] challenge) { }

	// RVA: 0x1A6EE80 Offset: 0x1A6EF81 VA: 0x1A6EE80 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A6E900 Offset: 0x1A6EA01 VA: 0x1A6E900
	public void set_Password(string value) { }

	// RVA: 0x1A6ED70 Offset: 0x1A6EE71 VA: 0x1A6ED70
	public void set_Challenge(byte[] value) { }

	// RVA: 0x1A6F120 Offset: 0x1A6F221 VA: 0x1A6F120
	public byte[] get_LM() { }

	// RVA: 0x1A6F4A0 Offset: 0x1A6F5A1 VA: 0x1A6F4A0
	public byte[] get_NT() { }

	// RVA: 0x1A6EF00 Offset: 0x1A6F001 VA: 0x1A6EF00 Slot: 4
	public void Dispose() { }

	// RVA: 0x1A6F530 Offset: 0x1A6F631 VA: 0x1A6F530
	private void Dispose(bool disposing) { }

	// RVA: 0x1A6F1B0 Offset: 0x1A6F2B1 VA: 0x1A6F1B0
	private byte[] GetResponse(byte[] pwd) { }

	// RVA: 0x1A6F5C0 Offset: 0x1A6F6C1 VA: 0x1A6F5C0
	private byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x1A6EFD0 Offset: 0x1A6F0D1 VA: 0x1A6EFD0
	private byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x1A6F7D0 Offset: 0x1A6F8D1 VA: 0x1A6F7D0
	private static void .cctor() { }
}

