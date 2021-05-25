public class PKCS8.EncryptedPrivateKeyInfo // TypeDefIndex: 69
{
	// Fields
	private string _algorithm; // 0x10
	private byte[] _salt; // 0x18
	private int _iterations; // 0x20
	private byte[] _data; // 0x28

	// Properties
	public string Algorithm { get; }
	public byte[] EncryptedData { get; }
	public byte[] Salt { get; }
	public int IterationCount { get; }

	// Methods

	// RVA: 0x18F5650 Offset: 0x18F5751 VA: 0x18F5650
	public void .ctor() { }

	// RVA: 0x18F5660 Offset: 0x18F5761 VA: 0x18F5660
	public void .ctor(byte[] data) { }

	// RVA: 0x18F5940 Offset: 0x18F5A41 VA: 0x18F5940
	public string get_Algorithm() { }

	// RVA: 0x18F5950 Offset: 0x18F5A51 VA: 0x18F5950
	public byte[] get_EncryptedData() { }

	// RVA: 0x18F59D0 Offset: 0x18F5AD1 VA: 0x18F59D0
	public byte[] get_Salt() { }

	// RVA: 0x18F5AA0 Offset: 0x18F5BA1 VA: 0x18F5AA0
	public int get_IterationCount() { }

	// RVA: 0x18F5690 Offset: 0x18F5791 VA: 0x18F5690
	private void Decode(byte[] data) { }
}

public class PKCS8.EncryptedPrivateKeyInfo // TypeDefIndex: 1597
{
	// Fields
	private string _algorithm; // 0x10
	private byte[] _salt; // 0x18
	private int _iterations; // 0x20
	private byte[] _data; // 0x28

	// Properties
	public string Algorithm { get; }
	public byte[] EncryptedData { get; }
	public byte[] Salt { get; }
	public int IterationCount { get; }

	// Methods

	// RVA: 0x1A69510 Offset: 0x1A69611 VA: 0x1A69510
	public void .ctor() { }

	// RVA: 0x1A69520 Offset: 0x1A69621 VA: 0x1A69520
	public void .ctor(byte[] data) { }

	// RVA: 0x1A697F0 Offset: 0x1A698F1 VA: 0x1A697F0
	public string get_Algorithm() { }

	// RVA: 0x1A69800 Offset: 0x1A69901 VA: 0x1A69800
	public byte[] get_EncryptedData() { }

	// RVA: 0x1A69880 Offset: 0x1A69981 VA: 0x1A69880
	public byte[] get_Salt() { }

	// RVA: 0x1A69950 Offset: 0x1A69A51 VA: 0x1A69950
	public int get_IterationCount() { }

	// RVA: 0x1A69550 Offset: 0x1A69651 VA: 0x1A69550
	private void Decode(byte[] data) { }
}

