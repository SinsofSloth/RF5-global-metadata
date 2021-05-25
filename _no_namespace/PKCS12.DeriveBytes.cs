public class PKCS12.DeriveBytes // TypeDefIndex: 52
{
	// Fields
	private static byte[] keyDiversifier; // 0x0
	private static byte[] ivDiversifier; // 0x8
	private static byte[] macDiversifier; // 0x10
	private string _hashName; // 0x10
	private int _iterations; // 0x18
	private byte[] _password; // 0x20
	private byte[] _salt; // 0x28

	// Properties
	public string HashName { set; }
	public int IterationCount { set; }
	public byte[] Password { set; }
	public byte[] Salt { set; }

	// Methods

	// RVA: 0x18FE470 Offset: 0x18FE571 VA: 0x18FE470
	public void .ctor() { }

	// RVA: 0x1903BB0 Offset: 0x1903CB1 VA: 0x1903BB0
	public void set_HashName(string value) { }

	// RVA: 0x1903BC0 Offset: 0x1903CC1 VA: 0x1903BC0
	public void set_IterationCount(int value) { }

	// RVA: 0x18FE480 Offset: 0x18FE581 VA: 0x18FE480
	public void set_Password(byte[] value) { }

	// RVA: 0x18FE540 Offset: 0x18FE641 VA: 0x18FE540
	public void set_Salt(byte[] value) { }

	// RVA: 0x1903BD0 Offset: 0x1903CD1 VA: 0x1903BD0
	private void Adjust(byte[] a, int aOff, byte[] b) { }

	// RVA: 0x1903CC0 Offset: 0x1903DC1 VA: 0x1903CC0
	private byte[] Derive(byte[] diversifier, int n) { }

	// RVA: 0x18FE600 Offset: 0x18FE701 VA: 0x18FE600
	public byte[] DeriveKey(int size) { }

	// RVA: 0x18FE680 Offset: 0x18FE781 VA: 0x18FE680
	public byte[] DeriveIV(int size) { }

	// RVA: 0x19002E0 Offset: 0x19003E1 VA: 0x19002E0
	public byte[] DeriveMAC(int size) { }

	// RVA: 0x1904110 Offset: 0x1904211 VA: 0x1904110
	private static void .cctor() { }
}

public class PKCS12.DeriveBytes // TypeDefIndex: 1556
{
	// Fields
	private static byte[] keyDiversifier; // 0x0
	private static byte[] ivDiversifier; // 0x8
	private static byte[] macDiversifier; // 0x10
	private string _hashName; // 0x10
	private int _iterations; // 0x18
	private byte[] _password; // 0x20
	private byte[] _salt; // 0x28

	// Properties
	public string HashName { set; }
	public int IterationCount { set; }
	public byte[] Password { set; }
	public byte[] Salt { set; }

	// Methods

	// RVA: 0x1A75CE0 Offset: 0x1A75DE1 VA: 0x1A75CE0
	public void .ctor() { }

	// RVA: 0x1A7B880 Offset: 0x1A7B981 VA: 0x1A7B880
	public void set_HashName(string value) { }

	// RVA: 0x1A7B890 Offset: 0x1A7B991 VA: 0x1A7B890
	public void set_IterationCount(int value) { }

	// RVA: 0x1A75CF0 Offset: 0x1A75DF1 VA: 0x1A75CF0
	public void set_Password(byte[] value) { }

	// RVA: 0x1A75DB0 Offset: 0x1A75EB1 VA: 0x1A75DB0
	public void set_Salt(byte[] value) { }

	// RVA: 0x1A7B8A0 Offset: 0x1A7B9A1 VA: 0x1A7B8A0
	private void Adjust(byte[] a, int aOff, byte[] b) { }

	// RVA: 0x1A7B990 Offset: 0x1A7BA91 VA: 0x1A7B990
	private byte[] Derive(byte[] diversifier, int n) { }

	// RVA: 0x1A75E70 Offset: 0x1A75F71 VA: 0x1A75E70
	public byte[] DeriveKey(int size) { }

	// RVA: 0x1A75EF0 Offset: 0x1A75FF1 VA: 0x1A75EF0
	public byte[] DeriveIV(int size) { }

	// RVA: 0x1A77910 Offset: 0x1A77A11 VA: 0x1A77910
	public byte[] DeriveMAC(int size) { }

	// RVA: 0x1A7BDE0 Offset: 0x1A7BEE1 VA: 0x1A7BDE0
	private static void .cctor() { }
}

