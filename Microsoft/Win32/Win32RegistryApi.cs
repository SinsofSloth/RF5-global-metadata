internal class Win32RegistryApi : IRegistryApi // TypeDefIndex: 95
{
	// Fields
	private readonly int NativeBytesPerCharacter; // 0x10

	// Methods

	// RVA: 0x192BD40 Offset: 0x192BE41 VA: 0x192BD40
	private static extern int RegCloseKey(IntPtr keyHandle) { }

	// RVA: 0x192BDC0 Offset: 0x192BEC1 VA: 0x192BDC0
	private static extern int RegFlushKey(IntPtr keyHandle) { }

	// RVA: 0x192BE40 Offset: 0x192BF41 VA: 0x192BE40
	private static extern int RegOpenKeyEx(IntPtr keyBase, string keyName, IntPtr reserved, int access, out IntPtr keyHandle) { }

	// RVA: 0x192BEF0 Offset: 0x192BFF1 VA: 0x192BEF0
	internal static extern int RegEnumKeyEx(IntPtr keyHandle, int dwIndex, char* lpName, ref int lpcbName, int[] lpReserved, [Out] StringBuilder lpClass, int[] lpcbClass, long[] lpftLastWriteTime) { }

	// RVA: 0x192C010 Offset: 0x192C111 VA: 0x192C010
	private static extern int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, IntPtr zero, ref int dataSize) { }

	// RVA: 0x192C0E0 Offset: 0x192C1E1 VA: 0x192C0E0
	private static extern int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, [Out] byte[] data, ref int dataSize) { }

	// RVA: 0x192C290 Offset: 0x192C391 VA: 0x192C290
	private static extern int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, ref int data, ref int dataSize) { }

	// RVA: 0x192C360 Offset: 0x192C461 VA: 0x192C360
	private static extern int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, ref long data, ref int dataSize) { }

	// RVA: 0x192C430 Offset: 0x192C531 VA: 0x192C430
	internal static extern int RegQueryInfoKey(IntPtr hKey, [Out] StringBuilder lpClass, int[] lpcbClass, IntPtr lpReserved_MustBeZero, ref int lpcSubKeys, int[] lpcbMaxSubKeyLen, int[] lpcbMaxClassLen, ref int lpcValues, int[] lpcbMaxValueNameLen, int[] lpcbMaxValueLen, int[] lpcbSecurityDescriptor, int[] lpftLastWriteTime) { }

	// RVA: 0x192C580 Offset: 0x192C681 VA: 0x192C580 Slot: 10
	public IntPtr GetHandle(RegistryKey key) { }

	// RVA: 0x192C600 Offset: 0x192C701 VA: 0x192C600
	private static bool IsHandleValid(RegistryKey key) { }

	// RVA: 0x192C620 Offset: 0x192C721 VA: 0x192C620 Slot: 7
	public object GetValue(RegistryKey rkey, string name, object defaultValue, RegistryValueOptions options) { }

	// RVA: 0x192CC30 Offset: 0x192CD31 VA: 0x192CC30
	private int GetBinaryValue(RegistryKey rkey, string name, RegistryValueKind type, out byte[] data, int size) { }

	// RVA: 0x192CD40 Offset: 0x192CE41 VA: 0x192CD40 Slot: 11
	public int SubKeyCount(RegistryKey rkey) { }

	// RVA: 0x192CEC0 Offset: 0x192CFC1 VA: 0x192CEC0 Slot: 4
	public RegistryKey OpenSubKey(RegistryKey rkey, string keyName, bool writable) { }

	// RVA: 0x192D150 Offset: 0x192D251 VA: 0x192D150 Slot: 5
	public void Flush(RegistryKey rkey) { }

	// RVA: 0x192D240 Offset: 0x192D341 VA: 0x192D240 Slot: 6
	public void Close(RegistryKey rkey) { }

	// RVA: 0x192D350 Offset: 0x192D451 VA: 0x192D350 Slot: 8
	public string[] GetSubKeyNames(RegistryKey rkey) { }

	// RVA: 0x192CAB0 Offset: 0x192CBB1 VA: 0x192CAB0
	private void GenerateException(int errorCode) { }

	// RVA: 0x192D670 Offset: 0x192D771 VA: 0x192D670 Slot: 9
	public string ToString(RegistryKey rkey) { }

	// RVA: 0x192D0E0 Offset: 0x192D1E1 VA: 0x192D0E0
	internal static string CombineName(RegistryKey rkey, string localName) { }

	// RVA: 0x1929EA0 Offset: 0x1929FA1 VA: 0x1929EA0
	public void .ctor() { }
}

