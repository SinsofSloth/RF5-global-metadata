public static class FileSystem // TypeDefIndex: 11660
{
	// Fields
	public const int MountNameLengthMax = 15;

	// Properties
	public static ErrorRange ResultHandledByAllProcess { get; }
	public static ErrorRange ResultPathNotFound { get; }
	public static ErrorRange ResultPathAlreadyExists { get; }
	public static ErrorRange ResultTargetLocked { get; }
	public static ErrorRange ResultDirectoryNotEmpty { get; }
	public static ErrorRange ResultDirectoryStatusChanged { get; }
	public static ErrorRange ResultUsableSpaceNotEnough { get; }
	public static ErrorRange ResultUnsupportedSdkVersion { get; }
	public static ErrorRange ResultMountNameAlreadyExists { get; }
	public static ErrorRange ResultTargetNotFound { get; }

	// Methods

	// RVA: 0x26AD8E0 Offset: 0x26AD9E1 VA: 0x26AD8E0
	public static extern Result GetEntryType(ref EntryType outValue, string path) { }

	// RVA: 0x26AD930 Offset: 0x26ADA31 VA: 0x26AD930
	public static extern Result GetFreeSpaceSize(ref long outValue, string path) { }

	// RVA: 0x26AD980 Offset: 0x26ADA81 VA: 0x26AD980
	public static extern void Unmount(string name) { }

	// RVA: 0x26AD9B0 Offset: 0x26ADAB1 VA: 0x26AD9B0
	public static ErrorRange get_ResultHandledByAllProcess() { }

	// RVA: 0x26AD9C0 Offset: 0x26ADAC1 VA: 0x26AD9C0
	public static ErrorRange get_ResultPathNotFound() { }

	// RVA: 0x26AD9D0 Offset: 0x26ADAD1 VA: 0x26AD9D0
	public static ErrorRange get_ResultPathAlreadyExists() { }

	// RVA: 0x26AD9E0 Offset: 0x26ADAE1 VA: 0x26AD9E0
	public static ErrorRange get_ResultTargetLocked() { }

	// RVA: 0x26AD9F0 Offset: 0x26ADAF1 VA: 0x26AD9F0
	public static ErrorRange get_ResultDirectoryNotEmpty() { }

	// RVA: 0x26ADA00 Offset: 0x26ADB01 VA: 0x26ADA00
	public static ErrorRange get_ResultDirectoryStatusChanged() { }

	// RVA: 0x26ADA10 Offset: 0x26ADB11 VA: 0x26ADA10
	public static ErrorRange get_ResultUsableSpaceNotEnough() { }

	// RVA: 0x26ADA20 Offset: 0x26ADB21 VA: 0x26ADA20
	public static ErrorRange get_ResultUnsupportedSdkVersion() { }

	// RVA: 0x26ADA30 Offset: 0x26ADB31 VA: 0x26ADA30
	public static ErrorRange get_ResultMountNameAlreadyExists() { }

	// RVA: 0x26ADA40 Offset: 0x26ADB41 VA: 0x26ADA40
	public static ErrorRange get_ResultTargetNotFound() { }

	// RVA: 0x26ADA50 Offset: 0x26ADB51 VA: 0x26ADA50
	public static extern Result Commit(string name) { }

	// RVA: 0x26ADA90 Offset: 0x26ADB91 VA: 0x26ADA90
	private static extern Result Commit(string[] name, int nameCount) { }

	// RVA: 0x26ADB80 Offset: 0x26ADC81 VA: 0x26ADB80
	public static Result Commit(string[] name) { }
}

