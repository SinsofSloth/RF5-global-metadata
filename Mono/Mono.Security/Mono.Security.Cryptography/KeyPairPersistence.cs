internal class KeyPairPersistence // TypeDefIndex: 61
{
	// Fields
	private static bool _userPathExists; // 0x0
	private static string _userPath; // 0x8
	private static bool _machinePathExists; // 0x10
	private static string _machinePath; // 0x18
	private CspParameters _params; // 0x10
	private string _keyvalue; // 0x18
	private string _filename; // 0x20
	private string _container; // 0x28
	private static object lockobj; // 0x20

	// Properties
	public string Filename { get; }
	public string KeyValue { get; set; }
	private static string UserPath { get; }
	private static string MachinePath { get; }
	private bool CanChange { get; }
	private bool UseDefaultKeyContainer { get; }
	private bool UseMachineKeyStore { get; }
	private string ContainerName { get; }

	// Methods

	// RVA: 0x18F19C0 Offset: 0x18F1AC1 VA: 0x18F19C0
	public void .ctor(CspParameters parameters) { }

	// RVA: 0x18F19D0 Offset: 0x18F1AD1 VA: 0x18F19D0
	public void .ctor(CspParameters parameters, string keyPair) { }

	// RVA: 0x18F1B40 Offset: 0x18F1C41 VA: 0x18F1B40
	public string get_Filename() { }

	// RVA: 0x18F2BC0 Offset: 0x18F2CC1 VA: 0x18F2BC0
	public string get_KeyValue() { }

	// RVA: 0x18F2BD0 Offset: 0x18F2CD1 VA: 0x18F2BD0
	public void set_KeyValue(string value) { }

	// RVA: 0x18F2C00 Offset: 0x18F2D01 VA: 0x18F2C00
	public bool Load() { }

	// RVA: 0x18F2ED0 Offset: 0x18F2FD1 VA: 0x18F2ED0
	public void Save() { }

	// RVA: 0x18F3500 Offset: 0x18F3601 VA: 0x18F3500
	public void Remove() { }

	// RVA: 0x18F2500 Offset: 0x18F2601 VA: 0x18F2500
	private static string get_UserPath() { }

	// RVA: 0x18F1E50 Offset: 0x18F1F51 VA: 0x18F1E50
	private static string get_MachinePath() { }

	// RVA: 0x18F36A0 Offset: 0x18F37A1 VA: 0x18F36A0
	internal static bool _CanSecure(string root) { }

	// RVA: 0x18F36B0 Offset: 0x18F37B1 VA: 0x18F36B0
	internal static bool _ProtectUser(string path) { }

	// RVA: 0x18F36C0 Offset: 0x18F37C1 VA: 0x18F36C0
	internal static bool _ProtectMachine(string path) { }

	// RVA: 0x18F36D0 Offset: 0x18F37D1 VA: 0x18F36D0
	internal static bool _IsUserProtected(string path) { }

	// RVA: 0x18F36E0 Offset: 0x18F37E1 VA: 0x18F36E0
	internal static bool _IsMachineProtected(string path) { }

	// RVA: 0x18F36F0 Offset: 0x18F37F1 VA: 0x18F36F0
	private static bool CanSecure(string path) { }

	// RVA: 0x18F3440 Offset: 0x18F3541 VA: 0x18F3440
	private static bool ProtectUser(string path) { }

	// RVA: 0x18F3380 Offset: 0x18F3481 VA: 0x18F3380
	private static bool ProtectMachine(string path) { }

	// RVA: 0x18F3520 Offset: 0x18F3621 VA: 0x18F3520
	private static bool IsUserProtected(string path) { }

	// RVA: 0x18F35E0 Offset: 0x18F36E1 VA: 0x18F35E0
	private static bool IsMachineProtected(string path) { }

	// RVA: 0x18F2BF0 Offset: 0x18F2CF1 VA: 0x18F2BF0
	private bool get_CanChange() { }

	// RVA: 0x18F37D0 Offset: 0x18F38D1 VA: 0x18F37D0
	private bool get_UseDefaultKeyContainer() { }

	// RVA: 0x18F1E30 Offset: 0x18F1F31 VA: 0x18F1E30
	private bool get_UseMachineKeyStore() { }

	// RVA: 0x18F1CF0 Offset: 0x18F1DF1 VA: 0x18F1CF0
	private string get_ContainerName() { }

	// RVA: 0x18F1A90 Offset: 0x18F1B91 VA: 0x18F1A90
	private CspParameters Copy(CspParameters p) { }

	// RVA: 0x18F2D50 Offset: 0x18F2E51 VA: 0x18F2D50
	private void FromXml(string xml) { }

	// RVA: 0x18F31B0 Offset: 0x18F32B1 VA: 0x18F31B0
	private string ToXml() { }

	// RVA: 0x18F3910 Offset: 0x18F3A11 VA: 0x18F3910
	private static void .cctor() { }
}

