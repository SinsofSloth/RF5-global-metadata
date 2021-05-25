internal class KeyHandler // TypeDefIndex: 93
{
	// Fields
	private static Hashtable key_to_handler; // 0x0
	private static Hashtable dir_to_handler; // 0x8
	public string Dir; // 0x10
	private string ActualDir; // 0x18
	public bool IsVolatile; // 0x20
	private Hashtable values; // 0x28
	private string file; // 0x30
	private bool dirty; // 0x38
	private static string user_store; // 0x10
	private static string machine_store; // 0x18

	// Properties
	public bool IsMarkedForDeletion { get; }
	private static string UserStore { get; }
	private static string MachineStore { get; }

	// Methods

	// RVA: 0x1924DA0 Offset: 0x1924EA1 VA: 0x1924DA0
	private static void .cctor() { }

	// RVA: 0x1925120 Offset: 0x1925221 VA: 0x1925120
	private void .ctor(RegistryKey rkey, string basedir) { }

	// RVA: 0x1925130 Offset: 0x1925231 VA: 0x1925130
	private void .ctor(RegistryKey rkey, string basedir, bool is_volatile) { }

	// RVA: 0x1925400 Offset: 0x1925501 VA: 0x1925400
	public void Load() { }

	// RVA: 0x1925AB0 Offset: 0x1925BB1 VA: 0x1925AB0
	private void LoadKey(SecurityElement se) { }

	// RVA: 0x1926280 Offset: 0x1926381 VA: 0x1926280
	public RegistryKey Ensure(RegistryKey rkey, string extra, bool writable, bool is_volatile) { }

	// RVA: 0x19266C0 Offset: 0x19267C1 VA: 0x19266C0
	public RegistryKey Probe(RegistryKey rkey, string extra, bool writable) { }

	// RVA: 0x19265C0 Offset: 0x19266C1 VA: 0x19265C0
	private static string CombineName(RegistryKey rkey, string extra) { }

	// RVA: 0x1926D50 Offset: 0x1926E51 VA: 0x1926D50
	private static long GetSystemBootTime() { }

	// RVA: 0x1927070 Offset: 0x1927171 VA: 0x1927070
	private static long GetRegisteredBootTime(string path) { }

	// RVA: 0x1927360 Offset: 0x1927461 VA: 0x1927360
	private static void SaveRegisteredBootTime(string path, long btime) { }

	// RVA: 0x1924EC0 Offset: 0x1924FC1 VA: 0x1924EC0
	private static void CleanVolatileKeys() { }

	// RVA: 0x1926B10 Offset: 0x1926C11 VA: 0x1926B10
	public static bool VolatileKeyExists(string dir) { }

	// RVA: 0x1925340 Offset: 0x1925441 VA: 0x1925340
	public static string GetVolatileDir(string dir) { }

	// RVA: 0x1927970 Offset: 0x1927A71 VA: 0x1927970
	public static KeyHandler Lookup(RegistryKey rkey, bool createNonExisting) { }

	// RVA: 0x1927820 Offset: 0x1927921 VA: 0x1927820
	private static string GetRootFromDir(string dir) { }

	// RVA: 0x1927F40 Offset: 0x1928041 VA: 0x1927F40
	public static void Drop(RegistryKey rkey) { }

	// RVA: 0x1928460 Offset: 0x1928561 VA: 0x1928460
	public object GetValue(string name, RegistryValueOptions options) { }

	// RVA: 0x19286E0 Offset: 0x19287E1 VA: 0x19286E0
	public string[] GetSubKeyNames() { }

	// RVA: 0x1928BB0 Offset: 0x1928CB1 VA: 0x1928BB0
	public void Flush() { }

	// RVA: 0x1929930 Offset: 0x1929A31 VA: 0x1929930
	public bool ValueExists(string name) { }

	// RVA: 0x1928650 Offset: 0x1928751 VA: 0x1928650
	public bool get_IsMarkedForDeletion() { }

	// RVA: 0x1929A40 Offset: 0x1929B41 VA: 0x1929A40 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1928CD0 Offset: 0x1928DD1 VA: 0x1928CD0
	private void Save() { }

	// RVA: 0x1927540 Offset: 0x1927641 VA: 0x1927540
	private static string get_UserStore() { }

	// RVA: 0x1927660 Offset: 0x1927761 VA: 0x1927660
	private static string get_MachineStore() { }
}

