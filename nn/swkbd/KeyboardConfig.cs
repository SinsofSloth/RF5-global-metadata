public struct KeyboardConfig // TypeDefIndex: 11458
{
	// Fields
	public KeyboardMode keyboardMode; // 0x0
	public string okText; // 0x8
	public char leftOptionalSymbolKey; // 0x10
	public char rightOptionalSymbolKey; // 0x12
	public bool isPredictionEnabled; // 0x14
	public InvalidChar invalidCharFlag; // 0x18
	public InitialCursorPos initialCursorPos; // 0x1C
	public string headerText; // 0x20
	public string subText; // 0x28
	public string guideText; // 0x30
	public int textMaxLength; // 0x38
	public int textMinLength; // 0x3C
	public PasswordMode passwordMode; // 0x40
	public InputFormMode inputFormMode; // 0x44
	public bool isUseNewLine; // 0x48
	public bool isUseUtf8; // 0x49
	public bool isUseBlurBackground; // 0x4A
	private int _initialStringOffset; // 0x4C
	private int _initialStringLength; // 0x50
	private int _userDictionaryOffset; // 0x54
	private int _userDictionaryNum; // 0x58
	private bool _isUseTextCheck; // 0x5C
	private IntPtr _textCheckCallback; // 0x60
	public int[] separateTextPos; // 0x68
	private DictionaryInfo[] _customizedDicInfoList; // 0x70
	private byte _customizedDicCount; // 0x78
	private byte[] _reserved; // 0x80
}

