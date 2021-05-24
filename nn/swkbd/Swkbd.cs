public static class Swkbd // TypeDefIndex: 11457
{
	// Fields
	public const int TextMaxLength = 500;
	public const int SeparateModeTextMaxLength = 24;
	public const int HeaderTextMaxLength = 64;
	public const int SubTextMaxLength = 128;
	public const int GuideTextMaxLength = 256;
	public const int OkTextMaxLength = 8;
	public const int UnfixedStringLengthMax = 24;
	public const int UserWordMax = 5000;
	public const int DialogTextMaxLength = 500;
	public const int SepareteTextPosMax = 8;
	public const int CustomizedDicionarySetMax = 24;

	// Properties
	public static ErrorRange ResultCanceled { get; }

	// Methods

	// RVA: 0x34F2F80 Offset: 0x34F3081 VA: 0x34F2F80
	public static Result ShowKeyboard(StringBuilder pOutResultString, ShowKeyboardArg showKeyboardArg, bool suspendUnityThreads) { }

	// RVA: 0x34F3280 Offset: 0x34F3381 VA: 0x34F3280
	public static Result ShowKeyboard(byte[] pOutResultString, ShowKeyboardArg showKeyboardArg, bool suspendUnityThreads) { }

	// RVA: 0x34F34F0 Offset: 0x34F35F1 VA: 0x34F34F0
	public static Result ShowKeyboard(StringBuilder pOutResultString, ShowKeyboardArg showKeyboardArg) { }

	// RVA: 0x34F3600 Offset: 0x34F3701 VA: 0x34F3600
	public static Result ShowKeyboard(byte[] pOutResultString, ShowKeyboardArg showKeyboardArg) { }

	// RVA: 0x34F31A0 Offset: 0x34F32A1 VA: 0x34F31A0
	private static extern Result ShowKeyboard([In] [Out] StringBuilder pOutResultString, long bufSize, ShowKeyboardArg showKeyboardArg) { }

	// RVA: 0x34F3420 Offset: 0x34F3521 VA: 0x34F3420
	private static extern Result ShowKeyboard([In] [Out] byte[] pOutResultString, long bufSize, ShowKeyboardArg showKeyboardArg) { }

	// RVA: 0x34F36E0 Offset: 0x34F37E1 VA: 0x34F36E0
	public static extern void InitializeKeyboardConfig(ref KeyboardConfig pOutKeyboardConfig) { }

	// RVA: 0x34F3780 Offset: 0x34F3881 VA: 0x34F3780
	public static extern void MakePreset(ref KeyboardConfig pOutKeyboardConfig, Preset preset) { }

	// RVA: 0x34F3830 Offset: 0x34F3931 VA: 0x34F3830
	public static extern long GetRequiredStringBufferSize() { }

	// RVA: 0x34F3840 Offset: 0x34F3941 VA: 0x34F3840
	public static extern void SetLeftOptionalSymbolKey(ref KeyboardConfig pOutKeyboardConfig, char code) { }

	// RVA: 0x34F38F0 Offset: 0x34F39F1 VA: 0x34F38F0
	public static extern void SetLeftOptionalSymbolKeyUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] code) { }

	// RVA: 0x34F39A0 Offset: 0x34F3AA1 VA: 0x34F39A0
	public static extern void SetRightOptionalSymbolKey(ref KeyboardConfig pOutKeyboardConfig, char code) { }

	// RVA: 0x34F3A50 Offset: 0x34F3B51 VA: 0x34F3A50
	public static extern void SetRightOptionalSymbolKeyUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] code) { }

	// RVA: 0x34F3B00 Offset: 0x34F3C01 VA: 0x34F3B00
	public static extern void SetOkText(ref KeyboardConfig pOutKeyboardConfig, [In] string pStr) { }

	// RVA: 0x34F3BB0 Offset: 0x34F3CB1 VA: 0x34F3BB0
	public static extern void SetOkTextUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] pStr) { }

	// RVA: 0x34F3C60 Offset: 0x34F3D61 VA: 0x34F3C60
	public static extern void SetHeaderText(ref KeyboardConfig pOutKeyboardConfig, [In] string pStr) { }

	// RVA: 0x34F3D10 Offset: 0x34F3E11 VA: 0x34F3D10
	public static extern void SetHeaderTextUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] pStr) { }

	// RVA: 0x34F3DC0 Offset: 0x34F3EC1 VA: 0x34F3DC0
	public static extern void SetSubText(ref KeyboardConfig pOutKeyboardConfig, [In] string pStr) { }

	// RVA: 0x34F3E70 Offset: 0x34F3F71 VA: 0x34F3E70
	public static extern void SetSubTextUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] pStr) { }

	// RVA: 0x34F3F20 Offset: 0x34F4021 VA: 0x34F3F20
	public static extern void SetGuideText(ref KeyboardConfig pOutKeyboardConfig, [In] string pStr) { }

	// RVA: 0x34F3FD0 Offset: 0x34F40D1 VA: 0x34F3FD0
	public static extern void SetGuideTextUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] pStr) { }

	// RVA: 0x34F4080 Offset: 0x34F4181 VA: 0x34F4080
	public static extern void SetInitialText(ref ShowKeyboardArg pOutShowKeyboardArg, [In] string pStr) { }

	// RVA: 0x34F41F0 Offset: 0x34F42F1 VA: 0x34F41F0
	public static extern void SetInitialTextUtf8(ref ShowKeyboardArg pOutShowKeyboardArg, [In] byte[] pStr) { }

	// RVA: 0x34F4360 Offset: 0x34F4461 VA: 0x34F4360
	public static extern void SetUserWordList(ref ShowKeyboardArg pOutShowKeyboardArg, [In] UserWord[] pUserWord, int userWordNum) { }

	// RVA: 0x34F4560 Offset: 0x34F4661 VA: 0x34F4560
	public static extern void SetTextCheckCallback(ref ShowKeyboardArg pOutShowKeyboardArg, [In] TextCheckCallback pCallback) { }

	// RVA: 0x34F46D0 Offset: 0x34F47D1 VA: 0x34F46D0
	public static extern void SetCustomizedDictionaries(ref ShowKeyboardArg pOutShowKeyboardArg, CustomizedDictionarySet dicSet) { }

	// RVA: 0x34F4850 Offset: 0x34F4951 VA: 0x34F4850
	public static extern void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, bool useDirectory, bool useTextCheck) { }

	// RVA: 0x34F49C0 Offset: 0x34F4AC1 VA: 0x34F49C0
	public static void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, bool useDirectory) { }

	// RVA: 0x34F4B30 Offset: 0x34F4C31 VA: 0x34F4B30
	public static void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg) { }

	// RVA: 0x34F4C90 Offset: 0x34F4D91 VA: 0x34F4C90
	public static extern void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, int userWordNum, bool useTextCheck) { }

	// RVA: 0x34F4E00 Offset: 0x34F4F01 VA: 0x34F4E00
	public static void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, int userWordNum) { }

	// RVA: 0x34F4F70 Offset: 0x34F5071 VA: 0x34F4F70
	public static extern void Destroy(ref ShowKeyboardArg pOutShowKeyboardArg) { }

	// RVA: 0x34F3170 Offset: 0x34F3271 VA: 0x34F3170
	private static int GetByteSize(StringBuilder sb) { }

	// RVA: 0x34F50D0 Offset: 0x34F51D1 VA: 0x34F50D0
	public static ErrorRange get_ResultCanceled() { }
}

public static class Swkbd // TypeDefIndex: 11457
{
	// Fields
	public const int TextMaxLength = 500;
	public const int SeparateModeTextMaxLength = 24;
	public const int HeaderTextMaxLength = 64;
	public const int SubTextMaxLength = 128;
	public const int GuideTextMaxLength = 256;
	public const int OkTextMaxLength = 8;
	public const int UnfixedStringLengthMax = 24;
	public const int UserWordMax = 5000;
	public const int DialogTextMaxLength = 500;
	public const int SepareteTextPosMax = 8;
	public const int CustomizedDicionarySetMax = 24;

	// Properties
	public static ErrorRange ResultCanceled { get; }

	// Methods

	// RVA: 0x34F2F80 Offset: 0x34F3081 VA: 0x34F2F80
	public static Result ShowKeyboard(StringBuilder pOutResultString, ShowKeyboardArg showKeyboardArg, bool suspendUnityThreads) { }

	// RVA: 0x34F3280 Offset: 0x34F3381 VA: 0x34F3280
	public static Result ShowKeyboard(byte[] pOutResultString, ShowKeyboardArg showKeyboardArg, bool suspendUnityThreads) { }

	// RVA: 0x34F34F0 Offset: 0x34F35F1 VA: 0x34F34F0
	public static Result ShowKeyboard(StringBuilder pOutResultString, ShowKeyboardArg showKeyboardArg) { }

	// RVA: 0x34F3600 Offset: 0x34F3701 VA: 0x34F3600
	public static Result ShowKeyboard(byte[] pOutResultString, ShowKeyboardArg showKeyboardArg) { }

	// RVA: 0x34F31A0 Offset: 0x34F32A1 VA: 0x34F31A0
	private static extern Result ShowKeyboard([In] [Out] StringBuilder pOutResultString, long bufSize, ShowKeyboardArg showKeyboardArg) { }

	// RVA: 0x34F3420 Offset: 0x34F3521 VA: 0x34F3420
	private static extern Result ShowKeyboard([In] [Out] byte[] pOutResultString, long bufSize, ShowKeyboardArg showKeyboardArg) { }

	// RVA: 0x34F36E0 Offset: 0x34F37E1 VA: 0x34F36E0
	public static extern void InitializeKeyboardConfig(ref KeyboardConfig pOutKeyboardConfig) { }

	// RVA: 0x34F3780 Offset: 0x34F3881 VA: 0x34F3780
	public static extern void MakePreset(ref KeyboardConfig pOutKeyboardConfig, Preset preset) { }

	// RVA: 0x34F3830 Offset: 0x34F3931 VA: 0x34F3830
	public static extern long GetRequiredStringBufferSize() { }

	// RVA: 0x34F3840 Offset: 0x34F3941 VA: 0x34F3840
	public static extern void SetLeftOptionalSymbolKey(ref KeyboardConfig pOutKeyboardConfig, char code) { }

	// RVA: 0x34F38F0 Offset: 0x34F39F1 VA: 0x34F38F0
	public static extern void SetLeftOptionalSymbolKeyUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] code) { }

	// RVA: 0x34F39A0 Offset: 0x34F3AA1 VA: 0x34F39A0
	public static extern void SetRightOptionalSymbolKey(ref KeyboardConfig pOutKeyboardConfig, char code) { }

	// RVA: 0x34F3A50 Offset: 0x34F3B51 VA: 0x34F3A50
	public static extern void SetRightOptionalSymbolKeyUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] code) { }

	// RVA: 0x34F3B00 Offset: 0x34F3C01 VA: 0x34F3B00
	public static extern void SetOkText(ref KeyboardConfig pOutKeyboardConfig, [In] string pStr) { }

	// RVA: 0x34F3BB0 Offset: 0x34F3CB1 VA: 0x34F3BB0
	public static extern void SetOkTextUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] pStr) { }

	// RVA: 0x34F3C60 Offset: 0x34F3D61 VA: 0x34F3C60
	public static extern void SetHeaderText(ref KeyboardConfig pOutKeyboardConfig, [In] string pStr) { }

	// RVA: 0x34F3D10 Offset: 0x34F3E11 VA: 0x34F3D10
	public static extern void SetHeaderTextUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] pStr) { }

	// RVA: 0x34F3DC0 Offset: 0x34F3EC1 VA: 0x34F3DC0
	public static extern void SetSubText(ref KeyboardConfig pOutKeyboardConfig, [In] string pStr) { }

	// RVA: 0x34F3E70 Offset: 0x34F3F71 VA: 0x34F3E70
	public static extern void SetSubTextUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] pStr) { }

	// RVA: 0x34F3F20 Offset: 0x34F4021 VA: 0x34F3F20
	public static extern void SetGuideText(ref KeyboardConfig pOutKeyboardConfig, [In] string pStr) { }

	// RVA: 0x34F3FD0 Offset: 0x34F40D1 VA: 0x34F3FD0
	public static extern void SetGuideTextUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] pStr) { }

	// RVA: 0x34F4080 Offset: 0x34F4181 VA: 0x34F4080
	public static extern void SetInitialText(ref ShowKeyboardArg pOutShowKeyboardArg, [In] string pStr) { }

	// RVA: 0x34F41F0 Offset: 0x34F42F1 VA: 0x34F41F0
	public static extern void SetInitialTextUtf8(ref ShowKeyboardArg pOutShowKeyboardArg, [In] byte[] pStr) { }

	// RVA: 0x34F4360 Offset: 0x34F4461 VA: 0x34F4360
	public static extern void SetUserWordList(ref ShowKeyboardArg pOutShowKeyboardArg, [In] UserWord[] pUserWord, int userWordNum) { }

	// RVA: 0x34F4560 Offset: 0x34F4661 VA: 0x34F4560
	public static extern void SetTextCheckCallback(ref ShowKeyboardArg pOutShowKeyboardArg, [In] TextCheckCallback pCallback) { }

	// RVA: 0x34F46D0 Offset: 0x34F47D1 VA: 0x34F46D0
	public static extern void SetCustomizedDictionaries(ref ShowKeyboardArg pOutShowKeyboardArg, CustomizedDictionarySet dicSet) { }

	// RVA: 0x34F4850 Offset: 0x34F4951 VA: 0x34F4850
	public static extern void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, bool useDirectory, bool useTextCheck) { }

	// RVA: 0x34F49C0 Offset: 0x34F4AC1 VA: 0x34F49C0
	public static void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, bool useDirectory) { }

	// RVA: 0x34F4B30 Offset: 0x34F4C31 VA: 0x34F4B30
	public static void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg) { }

	// RVA: 0x34F4C90 Offset: 0x34F4D91 VA: 0x34F4C90
	public static extern void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, int userWordNum, bool useTextCheck) { }

	// RVA: 0x34F4E00 Offset: 0x34F4F01 VA: 0x34F4E00
	public static void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, int userWordNum) { }

	// RVA: 0x34F4F70 Offset: 0x34F5071 VA: 0x34F4F70
	public static extern void Destroy(ref ShowKeyboardArg pOutShowKeyboardArg) { }

	// RVA: 0x34F3170 Offset: 0x34F3271 VA: 0x34F3170
	private static int GetByteSize(StringBuilder sb) { }

	// RVA: 0x34F50D0 Offset: 0x34F51D1 VA: 0x34F50D0
	public static ErrorRange get_ResultCanceled() { }
}

public static class Swkbd // TypeDefIndex: 11457
{
	// Fields
	public const int TextMaxLength = 500;
	public const int SeparateModeTextMaxLength = 24;
	public const int HeaderTextMaxLength = 64;
	public const int SubTextMaxLength = 128;
	public const int GuideTextMaxLength = 256;
	public const int OkTextMaxLength = 8;
	public const int UnfixedStringLengthMax = 24;
	public const int UserWordMax = 5000;
	public const int DialogTextMaxLength = 500;
	public const int SepareteTextPosMax = 8;
	public const int CustomizedDicionarySetMax = 24;

	// Properties
	public static ErrorRange ResultCanceled { get; }

	// Methods

	// RVA: 0x34F2F80 Offset: 0x34F3081 VA: 0x34F2F80
	public static Result ShowKeyboard(StringBuilder pOutResultString, ShowKeyboardArg showKeyboardArg, bool suspendUnityThreads) { }

	// RVA: 0x34F3280 Offset: 0x34F3381 VA: 0x34F3280
	public static Result ShowKeyboard(byte[] pOutResultString, ShowKeyboardArg showKeyboardArg, bool suspendUnityThreads) { }

	// RVA: 0x34F34F0 Offset: 0x34F35F1 VA: 0x34F34F0
	public static Result ShowKeyboard(StringBuilder pOutResultString, ShowKeyboardArg showKeyboardArg) { }

	// RVA: 0x34F3600 Offset: 0x34F3701 VA: 0x34F3600
	public static Result ShowKeyboard(byte[] pOutResultString, ShowKeyboardArg showKeyboardArg) { }

	// RVA: 0x34F31A0 Offset: 0x34F32A1 VA: 0x34F31A0
	private static extern Result ShowKeyboard([In] [Out] StringBuilder pOutResultString, long bufSize, ShowKeyboardArg showKeyboardArg) { }

	// RVA: 0x34F3420 Offset: 0x34F3521 VA: 0x34F3420
	private static extern Result ShowKeyboard([In] [Out] byte[] pOutResultString, long bufSize, ShowKeyboardArg showKeyboardArg) { }

	// RVA: 0x34F36E0 Offset: 0x34F37E1 VA: 0x34F36E0
	public static extern void InitializeKeyboardConfig(ref KeyboardConfig pOutKeyboardConfig) { }

	// RVA: 0x34F3780 Offset: 0x34F3881 VA: 0x34F3780
	public static extern void MakePreset(ref KeyboardConfig pOutKeyboardConfig, Preset preset) { }

	// RVA: 0x34F3830 Offset: 0x34F3931 VA: 0x34F3830
	public static extern long GetRequiredStringBufferSize() { }

	// RVA: 0x34F3840 Offset: 0x34F3941 VA: 0x34F3840
	public static extern void SetLeftOptionalSymbolKey(ref KeyboardConfig pOutKeyboardConfig, char code) { }

	// RVA: 0x34F38F0 Offset: 0x34F39F1 VA: 0x34F38F0
	public static extern void SetLeftOptionalSymbolKeyUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] code) { }

	// RVA: 0x34F39A0 Offset: 0x34F3AA1 VA: 0x34F39A0
	public static extern void SetRightOptionalSymbolKey(ref KeyboardConfig pOutKeyboardConfig, char code) { }

	// RVA: 0x34F3A50 Offset: 0x34F3B51 VA: 0x34F3A50
	public static extern void SetRightOptionalSymbolKeyUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] code) { }

	// RVA: 0x34F3B00 Offset: 0x34F3C01 VA: 0x34F3B00
	public static extern void SetOkText(ref KeyboardConfig pOutKeyboardConfig, [In] string pStr) { }

	// RVA: 0x34F3BB0 Offset: 0x34F3CB1 VA: 0x34F3BB0
	public static extern void SetOkTextUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] pStr) { }

	// RVA: 0x34F3C60 Offset: 0x34F3D61 VA: 0x34F3C60
	public static extern void SetHeaderText(ref KeyboardConfig pOutKeyboardConfig, [In] string pStr) { }

	// RVA: 0x34F3D10 Offset: 0x34F3E11 VA: 0x34F3D10
	public static extern void SetHeaderTextUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] pStr) { }

	// RVA: 0x34F3DC0 Offset: 0x34F3EC1 VA: 0x34F3DC0
	public static extern void SetSubText(ref KeyboardConfig pOutKeyboardConfig, [In] string pStr) { }

	// RVA: 0x34F3E70 Offset: 0x34F3F71 VA: 0x34F3E70
	public static extern void SetSubTextUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] pStr) { }

	// RVA: 0x34F3F20 Offset: 0x34F4021 VA: 0x34F3F20
	public static extern void SetGuideText(ref KeyboardConfig pOutKeyboardConfig, [In] string pStr) { }

	// RVA: 0x34F3FD0 Offset: 0x34F40D1 VA: 0x34F3FD0
	public static extern void SetGuideTextUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] pStr) { }

	// RVA: 0x34F4080 Offset: 0x34F4181 VA: 0x34F4080
	public static extern void SetInitialText(ref ShowKeyboardArg pOutShowKeyboardArg, [In] string pStr) { }

	// RVA: 0x34F41F0 Offset: 0x34F42F1 VA: 0x34F41F0
	public static extern void SetInitialTextUtf8(ref ShowKeyboardArg pOutShowKeyboardArg, [In] byte[] pStr) { }

	// RVA: 0x34F4360 Offset: 0x34F4461 VA: 0x34F4360
	public static extern void SetUserWordList(ref ShowKeyboardArg pOutShowKeyboardArg, [In] UserWord[] pUserWord, int userWordNum) { }

	// RVA: 0x34F4560 Offset: 0x34F4661 VA: 0x34F4560
	public static extern void SetTextCheckCallback(ref ShowKeyboardArg pOutShowKeyboardArg, [In] TextCheckCallback pCallback) { }

	// RVA: 0x34F46D0 Offset: 0x34F47D1 VA: 0x34F46D0
	public static extern void SetCustomizedDictionaries(ref ShowKeyboardArg pOutShowKeyboardArg, CustomizedDictionarySet dicSet) { }

	// RVA: 0x34F4850 Offset: 0x34F4951 VA: 0x34F4850
	public static extern void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, bool useDirectory, bool useTextCheck) { }

	// RVA: 0x34F49C0 Offset: 0x34F4AC1 VA: 0x34F49C0
	public static void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, bool useDirectory) { }

	// RVA: 0x34F4B30 Offset: 0x34F4C31 VA: 0x34F4B30
	public static void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg) { }

	// RVA: 0x34F4C90 Offset: 0x34F4D91 VA: 0x34F4C90
	public static extern void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, int userWordNum, bool useTextCheck) { }

	// RVA: 0x34F4E00 Offset: 0x34F4F01 VA: 0x34F4E00
	public static void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, int userWordNum) { }

	// RVA: 0x34F4F70 Offset: 0x34F5071 VA: 0x34F4F70
	public static extern void Destroy(ref ShowKeyboardArg pOutShowKeyboardArg) { }

	// RVA: 0x34F3170 Offset: 0x34F3271 VA: 0x34F3170
	private static int GetByteSize(StringBuilder sb) { }

	// RVA: 0x34F50D0 Offset: 0x34F51D1 VA: 0x34F50D0
	public static ErrorRange get_ResultCanceled() { }
}

public static class Swkbd // TypeDefIndex: 11457
{
	// Fields
	public const int TextMaxLength = 500;
	public const int SeparateModeTextMaxLength = 24;
	public const int HeaderTextMaxLength = 64;
	public const int SubTextMaxLength = 128;
	public const int GuideTextMaxLength = 256;
	public const int OkTextMaxLength = 8;
	public const int UnfixedStringLengthMax = 24;
	public const int UserWordMax = 5000;
	public const int DialogTextMaxLength = 500;
	public const int SepareteTextPosMax = 8;
	public const int CustomizedDicionarySetMax = 24;

	// Properties
	public static ErrorRange ResultCanceled { get; }

	// Methods

	// RVA: 0x34F2F80 Offset: 0x34F3081 VA: 0x34F2F80
	public static Result ShowKeyboard(StringBuilder pOutResultString, ShowKeyboardArg showKeyboardArg, bool suspendUnityThreads) { }

	// RVA: 0x34F3280 Offset: 0x34F3381 VA: 0x34F3280
	public static Result ShowKeyboard(byte[] pOutResultString, ShowKeyboardArg showKeyboardArg, bool suspendUnityThreads) { }

	// RVA: 0x34F34F0 Offset: 0x34F35F1 VA: 0x34F34F0
	public static Result ShowKeyboard(StringBuilder pOutResultString, ShowKeyboardArg showKeyboardArg) { }

	// RVA: 0x34F3600 Offset: 0x34F3701 VA: 0x34F3600
	public static Result ShowKeyboard(byte[] pOutResultString, ShowKeyboardArg showKeyboardArg) { }

	// RVA: 0x34F31A0 Offset: 0x34F32A1 VA: 0x34F31A0
	private static extern Result ShowKeyboard([In] [Out] StringBuilder pOutResultString, long bufSize, ShowKeyboardArg showKeyboardArg) { }

	// RVA: 0x34F3420 Offset: 0x34F3521 VA: 0x34F3420
	private static extern Result ShowKeyboard([In] [Out] byte[] pOutResultString, long bufSize, ShowKeyboardArg showKeyboardArg) { }

	// RVA: 0x34F36E0 Offset: 0x34F37E1 VA: 0x34F36E0
	public static extern void InitializeKeyboardConfig(ref KeyboardConfig pOutKeyboardConfig) { }

	// RVA: 0x34F3780 Offset: 0x34F3881 VA: 0x34F3780
	public static extern void MakePreset(ref KeyboardConfig pOutKeyboardConfig, Preset preset) { }

	// RVA: 0x34F3830 Offset: 0x34F3931 VA: 0x34F3830
	public static extern long GetRequiredStringBufferSize() { }

	// RVA: 0x34F3840 Offset: 0x34F3941 VA: 0x34F3840
	public static extern void SetLeftOptionalSymbolKey(ref KeyboardConfig pOutKeyboardConfig, char code) { }

	// RVA: 0x34F38F0 Offset: 0x34F39F1 VA: 0x34F38F0
	public static extern void SetLeftOptionalSymbolKeyUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] code) { }

	// RVA: 0x34F39A0 Offset: 0x34F3AA1 VA: 0x34F39A0
	public static extern void SetRightOptionalSymbolKey(ref KeyboardConfig pOutKeyboardConfig, char code) { }

	// RVA: 0x34F3A50 Offset: 0x34F3B51 VA: 0x34F3A50
	public static extern void SetRightOptionalSymbolKeyUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] code) { }

	// RVA: 0x34F3B00 Offset: 0x34F3C01 VA: 0x34F3B00
	public static extern void SetOkText(ref KeyboardConfig pOutKeyboardConfig, [In] string pStr) { }

	// RVA: 0x34F3BB0 Offset: 0x34F3CB1 VA: 0x34F3BB0
	public static extern void SetOkTextUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] pStr) { }

	// RVA: 0x34F3C60 Offset: 0x34F3D61 VA: 0x34F3C60
	public static extern void SetHeaderText(ref KeyboardConfig pOutKeyboardConfig, [In] string pStr) { }

	// RVA: 0x34F3D10 Offset: 0x34F3E11 VA: 0x34F3D10
	public static extern void SetHeaderTextUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] pStr) { }

	// RVA: 0x34F3DC0 Offset: 0x34F3EC1 VA: 0x34F3DC0
	public static extern void SetSubText(ref KeyboardConfig pOutKeyboardConfig, [In] string pStr) { }

	// RVA: 0x34F3E70 Offset: 0x34F3F71 VA: 0x34F3E70
	public static extern void SetSubTextUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] pStr) { }

	// RVA: 0x34F3F20 Offset: 0x34F4021 VA: 0x34F3F20
	public static extern void SetGuideText(ref KeyboardConfig pOutKeyboardConfig, [In] string pStr) { }

	// RVA: 0x34F3FD0 Offset: 0x34F40D1 VA: 0x34F3FD0
	public static extern void SetGuideTextUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] pStr) { }

	// RVA: 0x34F4080 Offset: 0x34F4181 VA: 0x34F4080
	public static extern void SetInitialText(ref ShowKeyboardArg pOutShowKeyboardArg, [In] string pStr) { }

	// RVA: 0x34F41F0 Offset: 0x34F42F1 VA: 0x34F41F0
	public static extern void SetInitialTextUtf8(ref ShowKeyboardArg pOutShowKeyboardArg, [In] byte[] pStr) { }

	// RVA: 0x34F4360 Offset: 0x34F4461 VA: 0x34F4360
	public static extern void SetUserWordList(ref ShowKeyboardArg pOutShowKeyboardArg, [In] UserWord[] pUserWord, int userWordNum) { }

	// RVA: 0x34F4560 Offset: 0x34F4661 VA: 0x34F4560
	public static extern void SetTextCheckCallback(ref ShowKeyboardArg pOutShowKeyboardArg, [In] TextCheckCallback pCallback) { }

	// RVA: 0x34F46D0 Offset: 0x34F47D1 VA: 0x34F46D0
	public static extern void SetCustomizedDictionaries(ref ShowKeyboardArg pOutShowKeyboardArg, CustomizedDictionarySet dicSet) { }

	// RVA: 0x34F4850 Offset: 0x34F4951 VA: 0x34F4850
	public static extern void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, bool useDirectory, bool useTextCheck) { }

	// RVA: 0x34F49C0 Offset: 0x34F4AC1 VA: 0x34F49C0
	public static void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, bool useDirectory) { }

	// RVA: 0x34F4B30 Offset: 0x34F4C31 VA: 0x34F4B30
	public static void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg) { }

	// RVA: 0x34F4C90 Offset: 0x34F4D91 VA: 0x34F4C90
	public static extern void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, int userWordNum, bool useTextCheck) { }

	// RVA: 0x34F4E00 Offset: 0x34F4F01 VA: 0x34F4E00
	public static void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, int userWordNum) { }

	// RVA: 0x34F4F70 Offset: 0x34F5071 VA: 0x34F4F70
	public static extern void Destroy(ref ShowKeyboardArg pOutShowKeyboardArg) { }

	// RVA: 0x34F3170 Offset: 0x34F3271 VA: 0x34F3170
	private static int GetByteSize(StringBuilder sb) { }

	// RVA: 0x34F50D0 Offset: 0x34F51D1 VA: 0x34F50D0
	public static ErrorRange get_ResultCanceled() { }
}

public static class Swkbd // TypeDefIndex: 11457
{
	// Fields
	public const int TextMaxLength = 500;
	public const int SeparateModeTextMaxLength = 24;
	public const int HeaderTextMaxLength = 64;
	public const int SubTextMaxLength = 128;
	public const int GuideTextMaxLength = 256;
	public const int OkTextMaxLength = 8;
	public const int UnfixedStringLengthMax = 24;
	public const int UserWordMax = 5000;
	public const int DialogTextMaxLength = 500;
	public const int SepareteTextPosMax = 8;
	public const int CustomizedDicionarySetMax = 24;

	// Properties
	public static ErrorRange ResultCanceled { get; }

	// Methods

	// RVA: 0x34F2F80 Offset: 0x34F3081 VA: 0x34F2F80
	public static Result ShowKeyboard(StringBuilder pOutResultString, ShowKeyboardArg showKeyboardArg, bool suspendUnityThreads) { }

	// RVA: 0x34F3280 Offset: 0x34F3381 VA: 0x34F3280
	public static Result ShowKeyboard(byte[] pOutResultString, ShowKeyboardArg showKeyboardArg, bool suspendUnityThreads) { }

	// RVA: 0x34F34F0 Offset: 0x34F35F1 VA: 0x34F34F0
	public static Result ShowKeyboard(StringBuilder pOutResultString, ShowKeyboardArg showKeyboardArg) { }

	// RVA: 0x34F3600 Offset: 0x34F3701 VA: 0x34F3600
	public static Result ShowKeyboard(byte[] pOutResultString, ShowKeyboardArg showKeyboardArg) { }

	// RVA: 0x34F31A0 Offset: 0x34F32A1 VA: 0x34F31A0
	private static extern Result ShowKeyboard([In] [Out] StringBuilder pOutResultString, long bufSize, ShowKeyboardArg showKeyboardArg) { }

	// RVA: 0x34F3420 Offset: 0x34F3521 VA: 0x34F3420
	private static extern Result ShowKeyboard([In] [Out] byte[] pOutResultString, long bufSize, ShowKeyboardArg showKeyboardArg) { }

	// RVA: 0x34F36E0 Offset: 0x34F37E1 VA: 0x34F36E0
	public static extern void InitializeKeyboardConfig(ref KeyboardConfig pOutKeyboardConfig) { }

	// RVA: 0x34F3780 Offset: 0x34F3881 VA: 0x34F3780
	public static extern void MakePreset(ref KeyboardConfig pOutKeyboardConfig, Preset preset) { }

	// RVA: 0x34F3830 Offset: 0x34F3931 VA: 0x34F3830
	public static extern long GetRequiredStringBufferSize() { }

	// RVA: 0x34F3840 Offset: 0x34F3941 VA: 0x34F3840
	public static extern void SetLeftOptionalSymbolKey(ref KeyboardConfig pOutKeyboardConfig, char code) { }

	// RVA: 0x34F38F0 Offset: 0x34F39F1 VA: 0x34F38F0
	public static extern void SetLeftOptionalSymbolKeyUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] code) { }

	// RVA: 0x34F39A0 Offset: 0x34F3AA1 VA: 0x34F39A0
	public static extern void SetRightOptionalSymbolKey(ref KeyboardConfig pOutKeyboardConfig, char code) { }

	// RVA: 0x34F3A50 Offset: 0x34F3B51 VA: 0x34F3A50
	public static extern void SetRightOptionalSymbolKeyUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] code) { }

	// RVA: 0x34F3B00 Offset: 0x34F3C01 VA: 0x34F3B00
	public static extern void SetOkText(ref KeyboardConfig pOutKeyboardConfig, [In] string pStr) { }

	// RVA: 0x34F3BB0 Offset: 0x34F3CB1 VA: 0x34F3BB0
	public static extern void SetOkTextUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] pStr) { }

	// RVA: 0x34F3C60 Offset: 0x34F3D61 VA: 0x34F3C60
	public static extern void SetHeaderText(ref KeyboardConfig pOutKeyboardConfig, [In] string pStr) { }

	// RVA: 0x34F3D10 Offset: 0x34F3E11 VA: 0x34F3D10
	public static extern void SetHeaderTextUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] pStr) { }

	// RVA: 0x34F3DC0 Offset: 0x34F3EC1 VA: 0x34F3DC0
	public static extern void SetSubText(ref KeyboardConfig pOutKeyboardConfig, [In] string pStr) { }

	// RVA: 0x34F3E70 Offset: 0x34F3F71 VA: 0x34F3E70
	public static extern void SetSubTextUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] pStr) { }

	// RVA: 0x34F3F20 Offset: 0x34F4021 VA: 0x34F3F20
	public static extern void SetGuideText(ref KeyboardConfig pOutKeyboardConfig, [In] string pStr) { }

	// RVA: 0x34F3FD0 Offset: 0x34F40D1 VA: 0x34F3FD0
	public static extern void SetGuideTextUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] pStr) { }

	// RVA: 0x34F4080 Offset: 0x34F4181 VA: 0x34F4080
	public static extern void SetInitialText(ref ShowKeyboardArg pOutShowKeyboardArg, [In] string pStr) { }

	// RVA: 0x34F41F0 Offset: 0x34F42F1 VA: 0x34F41F0
	public static extern void SetInitialTextUtf8(ref ShowKeyboardArg pOutShowKeyboardArg, [In] byte[] pStr) { }

	// RVA: 0x34F4360 Offset: 0x34F4461 VA: 0x34F4360
	public static extern void SetUserWordList(ref ShowKeyboardArg pOutShowKeyboardArg, [In] UserWord[] pUserWord, int userWordNum) { }

	// RVA: 0x34F4560 Offset: 0x34F4661 VA: 0x34F4560
	public static extern void SetTextCheckCallback(ref ShowKeyboardArg pOutShowKeyboardArg, [In] TextCheckCallback pCallback) { }

	// RVA: 0x34F46D0 Offset: 0x34F47D1 VA: 0x34F46D0
	public static extern void SetCustomizedDictionaries(ref ShowKeyboardArg pOutShowKeyboardArg, CustomizedDictionarySet dicSet) { }

	// RVA: 0x34F4850 Offset: 0x34F4951 VA: 0x34F4850
	public static extern void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, bool useDirectory, bool useTextCheck) { }

	// RVA: 0x34F49C0 Offset: 0x34F4AC1 VA: 0x34F49C0
	public static void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, bool useDirectory) { }

	// RVA: 0x34F4B30 Offset: 0x34F4C31 VA: 0x34F4B30
	public static void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg) { }

	// RVA: 0x34F4C90 Offset: 0x34F4D91 VA: 0x34F4C90
	public static extern void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, int userWordNum, bool useTextCheck) { }

	// RVA: 0x34F4E00 Offset: 0x34F4F01 VA: 0x34F4E00
	public static void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, int userWordNum) { }

	// RVA: 0x34F4F70 Offset: 0x34F5071 VA: 0x34F4F70
	public static extern void Destroy(ref ShowKeyboardArg pOutShowKeyboardArg) { }

	// RVA: 0x34F3170 Offset: 0x34F3271 VA: 0x34F3170
	private static int GetByteSize(StringBuilder sb) { }

	// RVA: 0x34F50D0 Offset: 0x34F51D1 VA: 0x34F50D0
	public static ErrorRange get_ResultCanceled() { }
}

