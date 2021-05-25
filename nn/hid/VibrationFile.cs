public static class VibrationFile // TypeDefIndex: 11582
{
	// Properties
	public static ErrorRange ResultInvalid { get; }

	// Methods

	// RVA: 0x2C79BA0 Offset: 0x2C79CA1 VA: 0x2C79BA0
	public static ErrorRange get_ResultInvalid() { }

	// RVA: 0x2C79BE0 Offset: 0x2C79CE1 VA: 0x2C79BE0
	public static extern Result Parse(ref VibrationFileInfo pOutInfo, ref VibrationFileParserContext pOutContext, byte[] address, long fileSize) { }

	// RVA: 0x2C79C10 Offset: 0x2C79D11 VA: 0x2C79C10
	public static extern void RetrieveValue(ref VibrationValue pOutValue, int position, ref VibrationFileParserContext pContext) { }

	// RVA: 0x2C79C20 Offset: 0x2C79D21 VA: 0x2C79C20
	private static extern void Generate(ref long pOutSize, byte[] outBuffer, long bufferSize, VibrationValueArrayInfo info, VibrationValue[] pValues) { }

	// RVA: 0x2C79C70 Offset: 0x2C79D71 VA: 0x2C79C70
	public static void Generate(ref long pOutSize, byte[] outBuffer, VibrationValueArrayInfo info, VibrationValue[] pValues) { }

	// RVA: 0x2C79CD0 Offset: 0x2C79DD1 VA: 0x2C79CD0
	public static extern long CalculateSize(VibrationValueArrayInfo info) { }
}

