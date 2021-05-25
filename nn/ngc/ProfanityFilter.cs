public sealed class ProfanityFilter : IDisposable // TypeDefIndex: 11481
{
	// Fields
	private IntPtr _profanityFilter; // 0x10
	private IntPtr _ngcWorkBuffer; // 0x18

	// Methods

	// RVA: 0x34F0D10 Offset: 0x34F0E11 VA: 0x34F0D10
	public void .ctor() { }

	// RVA: 0x34F0DC0 Offset: 0x34F0EC1 VA: 0x34F0DC0
	public void .ctor(bool checkDesiredLanguage) { }

	// RVA: 0x34F0E50 Offset: 0x34F0F51 VA: 0x34F0E50 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x34F0F90 Offset: 0x34F1091 VA: 0x34F0F90 Slot: 4
	public void Dispose() { }

	// RVA: 0x34F0F10 Offset: 0x34F1011 VA: 0x34F0F10
	private void Dispose(bool disposing) { }

	// RVA: 0x34F1070 Offset: 0x34F1171 VA: 0x34F1070
	public uint GetContentVersion() { }

	// RVA: 0x34F1090 Offset: 0x34F1191 VA: 0x34F1090
	public Result CheckProfanityWords([Out] ProfanityFilter.PatternList[] checkResults, ProfanityFilter.PatternList patterns, string[] words) { }

	// RVA: 0x34F1270 Offset: 0x34F1371 VA: 0x34F1270
	public Result MaskProfanityWordsInText(ref int profanityWordCount, string inText, out string outText, ProfanityFilter.PatternList patterns) { }

	// RVA: 0x34F1390 Offset: 0x34F1491 VA: 0x34F1390
	public void SetMaskMode(ProfanityFilter.MaskMode mode) { }

	// RVA: 0x34F13B0 Offset: 0x34F14B1 VA: 0x34F13B0
	public void SkipAtSignCheck(ProfanityFilter.SkipMode skipMode) { }

	// RVA: 0x34F1060 Offset: 0x34F1161 VA: 0x34F1060
	private static extern void Destroy(IntPtr profanityFilter, IntPtr ngcWorkBuffer) { }

	// RVA: 0x34F0DA0 Offset: 0x34F0EA1 VA: 0x34F0DA0
	private static extern Result Initialize(ref IntPtr profanityFilter, ref IntPtr ngcWorkBuffer, bool checkDesiredLanguage) { }

	// RVA: 0x34F1080 Offset: 0x34F1181 VA: 0x34F1080
	private static extern uint GetContentVersion(IntPtr profanityFilter) { }

	// RVA: 0x34F10C0 Offset: 0x34F11C1 VA: 0x34F10C0
	private static extern Result CheckProfanityWords(IntPtr profanityFilter, [Out] ProfanityFilter.PatternList[] checkResults, ProfanityFilter.PatternList patterns, string[] words, long wordCount) { }

	// RVA: 0x34F1360 Offset: 0x34F1461 VA: 0x34F1360
	private static extern Result MaskProfanityWordsInText(IntPtr profanityFilter, ref int profanityWordCount, string text, ProfanityFilter.PatternList patterns) { }

	// RVA: 0x34F13A0 Offset: 0x34F14A1 VA: 0x34F13A0
	private static extern void SetMaskMode(IntPtr profanityFilter, ProfanityFilter.MaskMode mode) { }

	// RVA: 0x34F13C0 Offset: 0x34F14C1 VA: 0x34F13C0
	private static extern void SkipAtSignCheck(IntPtr profanityFilter, ProfanityFilter.SkipMode skipMode) { }
}

