[ComVisibleAttribute] // RVA: 0xB01F0 Offset: 0xB02F1 VA: 0xB01F0
public sealed class RSACryptoServiceProvider : RSA // TypeDefIndex: 957
{
	// Fields
	private static CspProviderFlags s_UseMachineKeyStore; // 0x0
	private KeyPairPersistence store; // 0x20
	private bool persistKey; // 0x28
	private bool persisted; // 0x29
	private bool privateKeyExportable; // 0x2A
	private bool m_disposed; // 0x2B
	private RSAManaged rsa; // 0x30

	// Properties
	public static bool UseMachineKeyStore { get; }
	public override int KeySize { get; }
	[ComVisibleAttribute] // RVA: 0xBA4B0 Offset: 0xBA5B1 VA: 0xBA4B0
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x1955330 Offset: 0x1955431 VA: 0x1955330
	public static bool get_UseMachineKeyStore() { }

	// RVA: 0x1945E40 Offset: 0x1945F41 VA: 0x1945E40
	public void .ctor() { }

	// RVA: 0x19553D0 Offset: 0x19554D1 VA: 0x19553D0
	public void .ctor(CspParameters parameters) { }

	// RVA: 0x1955390 Offset: 0x1955491 VA: 0x1955390
	public void .ctor(int dwKeySize) { }

	// RVA: 0x1955430 Offset: 0x1955531 VA: 0x1955430
	public void .ctor(int dwKeySize, CspParameters parameters) { }

	// RVA: 0x19554A0 Offset: 0x19555A1 VA: 0x19554A0
	private void Common(int dwKeySize, bool parameters) { }

	// RVA: 0x1955750 Offset: 0x1955851 VA: 0x1955750
	private void Common(CspParameters p) { }

	// RVA: 0x1955880 Offset: 0x1955981 VA: 0x1955880 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1955900 Offset: 0x1955A01 VA: 0x1955900 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x1955920 Offset: 0x1955A21 VA: 0x1955920
	public bool get_PublicOnly() { }

	// RVA: 0x1955940 Offset: 0x1955A41 VA: 0x1955940 Slot: 10
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x1955AD0 Offset: 0x1955BD1 VA: 0x1955AD0 Slot: 11
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x1955B50 Offset: 0x1955C51 VA: 0x1955B50 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1955C30 Offset: 0x1955D31 VA: 0x1955C30
	private void OnKeyGenerated(object sender, EventArgs e) { }
}

[ComVisibleAttribute] // RVA: 0xB01F0 Offset: 0xB02F1 VA: 0xB01F0
public sealed class RSACryptoServiceProvider : RSA // TypeDefIndex: 957
{
	// Fields
	private static CspProviderFlags s_UseMachineKeyStore; // 0x0
	private KeyPairPersistence store; // 0x20
	private bool persistKey; // 0x28
	private bool persisted; // 0x29
	private bool privateKeyExportable; // 0x2A
	private bool m_disposed; // 0x2B
	private RSAManaged rsa; // 0x30

	// Properties
	public static bool UseMachineKeyStore { get; }
	public override int KeySize { get; }
	[ComVisibleAttribute] // RVA: 0xBA4B0 Offset: 0xBA5B1 VA: 0xBA4B0
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x1955330 Offset: 0x1955431 VA: 0x1955330
	public static bool get_UseMachineKeyStore() { }

	// RVA: 0x1945E40 Offset: 0x1945F41 VA: 0x1945E40
	public void .ctor() { }

	// RVA: 0x19553D0 Offset: 0x19554D1 VA: 0x19553D0
	public void .ctor(CspParameters parameters) { }

	// RVA: 0x1955390 Offset: 0x1955491 VA: 0x1955390
	public void .ctor(int dwKeySize) { }

	// RVA: 0x1955430 Offset: 0x1955531 VA: 0x1955430
	public void .ctor(int dwKeySize, CspParameters parameters) { }

	// RVA: 0x19554A0 Offset: 0x19555A1 VA: 0x19554A0
	private void Common(int dwKeySize, bool parameters) { }

	// RVA: 0x1955750 Offset: 0x1955851 VA: 0x1955750
	private void Common(CspParameters p) { }

	// RVA: 0x1955880 Offset: 0x1955981 VA: 0x1955880 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1955900 Offset: 0x1955A01 VA: 0x1955900 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x1955920 Offset: 0x1955A21 VA: 0x1955920
	public bool get_PublicOnly() { }

	// RVA: 0x1955940 Offset: 0x1955A41 VA: 0x1955940 Slot: 10
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x1955AD0 Offset: 0x1955BD1 VA: 0x1955AD0 Slot: 11
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x1955B50 Offset: 0x1955C51 VA: 0x1955B50 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1955C30 Offset: 0x1955D31 VA: 0x1955C30
	private void OnKeyGenerated(object sender, EventArgs e) { }
}

[ComVisibleAttribute] // RVA: 0xB01F0 Offset: 0xB02F1 VA: 0xB01F0
public sealed class RSACryptoServiceProvider : RSA // TypeDefIndex: 957
{
	// Fields
	private static CspProviderFlags s_UseMachineKeyStore; // 0x0
	private KeyPairPersistence store; // 0x20
	private bool persistKey; // 0x28
	private bool persisted; // 0x29
	private bool privateKeyExportable; // 0x2A
	private bool m_disposed; // 0x2B
	private RSAManaged rsa; // 0x30

	// Properties
	public static bool UseMachineKeyStore { get; }
	public override int KeySize { get; }
	[ComVisibleAttribute] // RVA: 0xBA4B0 Offset: 0xBA5B1 VA: 0xBA4B0
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x1955330 Offset: 0x1955431 VA: 0x1955330
	public static bool get_UseMachineKeyStore() { }

	// RVA: 0x1945E40 Offset: 0x1945F41 VA: 0x1945E40
	public void .ctor() { }

	// RVA: 0x19553D0 Offset: 0x19554D1 VA: 0x19553D0
	public void .ctor(CspParameters parameters) { }

	// RVA: 0x1955390 Offset: 0x1955491 VA: 0x1955390
	public void .ctor(int dwKeySize) { }

	// RVA: 0x1955430 Offset: 0x1955531 VA: 0x1955430
	public void .ctor(int dwKeySize, CspParameters parameters) { }

	// RVA: 0x19554A0 Offset: 0x19555A1 VA: 0x19554A0
	private void Common(int dwKeySize, bool parameters) { }

	// RVA: 0x1955750 Offset: 0x1955851 VA: 0x1955750
	private void Common(CspParameters p) { }

	// RVA: 0x1955880 Offset: 0x1955981 VA: 0x1955880 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1955900 Offset: 0x1955A01 VA: 0x1955900 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x1955920 Offset: 0x1955A21 VA: 0x1955920
	public bool get_PublicOnly() { }

	// RVA: 0x1955940 Offset: 0x1955A41 VA: 0x1955940 Slot: 10
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x1955AD0 Offset: 0x1955BD1 VA: 0x1955AD0 Slot: 11
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x1955B50 Offset: 0x1955C51 VA: 0x1955B50 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1955C30 Offset: 0x1955D31 VA: 0x1955C30
	private void OnKeyGenerated(object sender, EventArgs e) { }
}

[ComVisibleAttribute] // RVA: 0xB01F0 Offset: 0xB02F1 VA: 0xB01F0
public sealed class RSACryptoServiceProvider : RSA // TypeDefIndex: 957
{
	// Fields
	private static CspProviderFlags s_UseMachineKeyStore; // 0x0
	private KeyPairPersistence store; // 0x20
	private bool persistKey; // 0x28
	private bool persisted; // 0x29
	private bool privateKeyExportable; // 0x2A
	private bool m_disposed; // 0x2B
	private RSAManaged rsa; // 0x30

	// Properties
	public static bool UseMachineKeyStore { get; }
	public override int KeySize { get; }
	[ComVisibleAttribute] // RVA: 0xBA4B0 Offset: 0xBA5B1 VA: 0xBA4B0
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x1955330 Offset: 0x1955431 VA: 0x1955330
	public static bool get_UseMachineKeyStore() { }

	// RVA: 0x1945E40 Offset: 0x1945F41 VA: 0x1945E40
	public void .ctor() { }

	// RVA: 0x19553D0 Offset: 0x19554D1 VA: 0x19553D0
	public void .ctor(CspParameters parameters) { }

	// RVA: 0x1955390 Offset: 0x1955491 VA: 0x1955390
	public void .ctor(int dwKeySize) { }

	// RVA: 0x1955430 Offset: 0x1955531 VA: 0x1955430
	public void .ctor(int dwKeySize, CspParameters parameters) { }

	// RVA: 0x19554A0 Offset: 0x19555A1 VA: 0x19554A0
	private void Common(int dwKeySize, bool parameters) { }

	// RVA: 0x1955750 Offset: 0x1955851 VA: 0x1955750
	private void Common(CspParameters p) { }

	// RVA: 0x1955880 Offset: 0x1955981 VA: 0x1955880 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1955900 Offset: 0x1955A01 VA: 0x1955900 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x1955920 Offset: 0x1955A21 VA: 0x1955920
	public bool get_PublicOnly() { }

	// RVA: 0x1955940 Offset: 0x1955A41 VA: 0x1955940 Slot: 10
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x1955AD0 Offset: 0x1955BD1 VA: 0x1955AD0 Slot: 11
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x1955B50 Offset: 0x1955C51 VA: 0x1955B50 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1955C30 Offset: 0x1955D31 VA: 0x1955C30
	private void OnKeyGenerated(object sender, EventArgs e) { }
}

[ComVisibleAttribute] // RVA: 0xB01F0 Offset: 0xB02F1 VA: 0xB01F0
public sealed class RSACryptoServiceProvider : RSA // TypeDefIndex: 957
{
	// Fields
	private static CspProviderFlags s_UseMachineKeyStore; // 0x0
	private KeyPairPersistence store; // 0x20
	private bool persistKey; // 0x28
	private bool persisted; // 0x29
	private bool privateKeyExportable; // 0x2A
	private bool m_disposed; // 0x2B
	private RSAManaged rsa; // 0x30

	// Properties
	public static bool UseMachineKeyStore { get; }
	public override int KeySize { get; }
	[ComVisibleAttribute] // RVA: 0xBA4B0 Offset: 0xBA5B1 VA: 0xBA4B0
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x1955330 Offset: 0x1955431 VA: 0x1955330
	public static bool get_UseMachineKeyStore() { }

	// RVA: 0x1945E40 Offset: 0x1945F41 VA: 0x1945E40
	public void .ctor() { }

	// RVA: 0x19553D0 Offset: 0x19554D1 VA: 0x19553D0
	public void .ctor(CspParameters parameters) { }

	// RVA: 0x1955390 Offset: 0x1955491 VA: 0x1955390
	public void .ctor(int dwKeySize) { }

	// RVA: 0x1955430 Offset: 0x1955531 VA: 0x1955430
	public void .ctor(int dwKeySize, CspParameters parameters) { }

	// RVA: 0x19554A0 Offset: 0x19555A1 VA: 0x19554A0
	private void Common(int dwKeySize, bool parameters) { }

	// RVA: 0x1955750 Offset: 0x1955851 VA: 0x1955750
	private void Common(CspParameters p) { }

	// RVA: 0x1955880 Offset: 0x1955981 VA: 0x1955880 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1955900 Offset: 0x1955A01 VA: 0x1955900 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x1955920 Offset: 0x1955A21 VA: 0x1955920
	public bool get_PublicOnly() { }

	// RVA: 0x1955940 Offset: 0x1955A41 VA: 0x1955940 Slot: 10
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x1955AD0 Offset: 0x1955BD1 VA: 0x1955AD0 Slot: 11
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x1955B50 Offset: 0x1955C51 VA: 0x1955B50 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1955C30 Offset: 0x1955D31 VA: 0x1955C30
	private void OnKeyGenerated(object sender, EventArgs e) { }
}

[ComVisibleAttribute] // RVA: 0xB01F0 Offset: 0xB02F1 VA: 0xB01F0
public sealed class RSACryptoServiceProvider : RSA // TypeDefIndex: 957
{
	// Fields
	private static CspProviderFlags s_UseMachineKeyStore; // 0x0
	private KeyPairPersistence store; // 0x20
	private bool persistKey; // 0x28
	private bool persisted; // 0x29
	private bool privateKeyExportable; // 0x2A
	private bool m_disposed; // 0x2B
	private RSAManaged rsa; // 0x30

	// Properties
	public static bool UseMachineKeyStore { get; }
	public override int KeySize { get; }
	[ComVisibleAttribute] // RVA: 0xBA4B0 Offset: 0xBA5B1 VA: 0xBA4B0
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x1955330 Offset: 0x1955431 VA: 0x1955330
	public static bool get_UseMachineKeyStore() { }

	// RVA: 0x1945E40 Offset: 0x1945F41 VA: 0x1945E40
	public void .ctor() { }

	// RVA: 0x19553D0 Offset: 0x19554D1 VA: 0x19553D0
	public void .ctor(CspParameters parameters) { }

	// RVA: 0x1955390 Offset: 0x1955491 VA: 0x1955390
	public void .ctor(int dwKeySize) { }

	// RVA: 0x1955430 Offset: 0x1955531 VA: 0x1955430
	public void .ctor(int dwKeySize, CspParameters parameters) { }

	// RVA: 0x19554A0 Offset: 0x19555A1 VA: 0x19554A0
	private void Common(int dwKeySize, bool parameters) { }

	// RVA: 0x1955750 Offset: 0x1955851 VA: 0x1955750
	private void Common(CspParameters p) { }

	// RVA: 0x1955880 Offset: 0x1955981 VA: 0x1955880 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1955900 Offset: 0x1955A01 VA: 0x1955900 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x1955920 Offset: 0x1955A21 VA: 0x1955920
	public bool get_PublicOnly() { }

	// RVA: 0x1955940 Offset: 0x1955A41 VA: 0x1955940 Slot: 10
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x1955AD0 Offset: 0x1955BD1 VA: 0x1955AD0 Slot: 11
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x1955B50 Offset: 0x1955C51 VA: 0x1955B50 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1955C30 Offset: 0x1955D31 VA: 0x1955C30
	private void OnKeyGenerated(object sender, EventArgs e) { }
}

