public static class Host // TypeDefIndex: 11663
{
	// Properties
	public static ErrorRange ResultSaveDataHostFileSystemCorrupted { get; }
	public static ErrorRange ResultSaveDataHostEntryCorrupted { get; }
	public static ErrorRange ResultSaveDataHostFileDataCorrupted { get; }
	public static ErrorRange ResultSaveDataHostFileCorrupted { get; }
	public static ErrorRange ResultInvalidSaveDataHostHandle { get; }
	public static ErrorRange ResultHostFileSystemCorrupted { get; }
	public static ErrorRange ResultHostEntryCorrupted { get; }
	public static ErrorRange ResultHostFileDataCorrupted { get; }
	public static ErrorRange ResultHostFileCorrupted { get; }
	public static ErrorRange ResultInvalidHostHandle { get; }

	// Methods

	// RVA: 0x26ADBB0 Offset: 0x26ADCB1 VA: 0x26ADBB0
	public static Result MountHost(string name, string rootPath) { }

	// RVA: 0x26ADC10 Offset: 0x26ADD11 VA: 0x26ADC10
	public static Result MountHost(string name, string rootPath, Host.MountHostOption option) { }

	// RVA: 0x26ADC70 Offset: 0x26ADD71 VA: 0x26ADC70
	public static Result MountHostRoot() { }

	// RVA: 0x26ADCD0 Offset: 0x26ADDD1 VA: 0x26ADCD0
	public static Result MountHostRoot(Host.MountHostOption option) { }

	// RVA: 0x26ADD30 Offset: 0x26ADE31 VA: 0x26ADD30
	public static void UnMountHostRoot() { }

	// RVA: 0x26ADD90 Offset: 0x26ADE91 VA: 0x26ADD90
	public static ErrorRange get_ResultSaveDataHostFileSystemCorrupted() { }

	// RVA: 0x26ADDA0 Offset: 0x26ADEA1 VA: 0x26ADDA0
	public static ErrorRange get_ResultSaveDataHostEntryCorrupted() { }

	// RVA: 0x26ADDB0 Offset: 0x26ADEB1 VA: 0x26ADDB0
	public static ErrorRange get_ResultSaveDataHostFileDataCorrupted() { }

	// RVA: 0x26ADDC0 Offset: 0x26ADEC1 VA: 0x26ADDC0
	public static ErrorRange get_ResultSaveDataHostFileCorrupted() { }

	// RVA: 0x26ADDD0 Offset: 0x26ADED1 VA: 0x26ADDD0
	public static ErrorRange get_ResultInvalidSaveDataHostHandle() { }

	// RVA: 0x26ADDE0 Offset: 0x26ADEE1 VA: 0x26ADDE0
	public static ErrorRange get_ResultHostFileSystemCorrupted() { }

	// RVA: 0x26ADDF0 Offset: 0x26ADEF1 VA: 0x26ADDF0
	public static ErrorRange get_ResultHostEntryCorrupted() { }

	// RVA: 0x26ADE00 Offset: 0x26ADF01 VA: 0x26ADE00
	public static ErrorRange get_ResultHostFileDataCorrupted() { }

	// RVA: 0x26ADE10 Offset: 0x26ADF11 VA: 0x26ADE10
	public static ErrorRange get_ResultHostFileCorrupted() { }

	// RVA: 0x26ADE20 Offset: 0x26ADF21 VA: 0x26ADE20
	public static ErrorRange get_ResultInvalidHostHandle() { }
}

