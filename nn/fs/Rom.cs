public static class Rom // TypeDefIndex: 11667
{
	// Properties
	public static ErrorRange ResultRomHostFileSystemCorrupted { get; }
	public static ErrorRange ResultRomHostEntryCorrupted { get; }
	public static ErrorRange ResultRomHostFileDataCorrupted { get; }
	public static ErrorRange ResultRomHostFileCorrupted { get; }
	public static ErrorRange ResultInvalidRomHostHandle { get; }

	// Methods

	// RVA: 0x26ADE40 Offset: 0x26ADF41 VA: 0x26ADE40
	public static ErrorRange get_ResultRomHostFileSystemCorrupted() { }

	// RVA: 0x26ADE50 Offset: 0x26ADF51 VA: 0x26ADE50
	public static ErrorRange get_ResultRomHostEntryCorrupted() { }

	// RVA: 0x26ADE60 Offset: 0x26ADF61 VA: 0x26ADE60
	public static ErrorRange get_ResultRomHostFileDataCorrupted() { }

	// RVA: 0x26ADE70 Offset: 0x26ADF71 VA: 0x26ADE70
	public static ErrorRange get_ResultRomHostFileCorrupted() { }

	// RVA: 0x26ADE80 Offset: 0x26ADF81 VA: 0x26ADE80
	public static ErrorRange get_ResultInvalidRomHostHandle() { }

	// RVA: 0x26ADE90 Offset: 0x26ADF91 VA: 0x26ADE90
	public static extern Result QueryMountRomCacheSize(ref long pOutValue) { }

	// RVA: 0x26ADEB0 Offset: 0x26ADFB1 VA: 0x26ADEB0
	public static extern Result MountRom(string name, byte[] pFileSystemCacheBuffer, long fileSystemCacheBufferSize) { }

	// RVA: 0x26ADF10 Offset: 0x26AE011 VA: 0x26ADF10
	public static bool CanMountRomForDebug() { }
}

