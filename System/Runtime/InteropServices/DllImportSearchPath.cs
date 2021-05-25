[FlagsAttribute] // RVA: 0xB1EE0 Offset: 0xB1FE1 VA: 0xB1EE0
public enum DllImportSearchPath // TypeDefIndex: 1308
{
	// Fields
	public int value__; // 0x0
	public const DllImportSearchPath UseDllDirectoryForDependencies = 256;
	public const DllImportSearchPath ApplicationDirectory = 512;
	public const DllImportSearchPath UserDirectories = 1024;
	public const DllImportSearchPath System32 = 2048;
	public const DllImportSearchPath SafeDirectories = 4096;
	public const DllImportSearchPath AssemblyDirectory = 2;
	public const DllImportSearchPath LegacyBehavior = 0;
}

