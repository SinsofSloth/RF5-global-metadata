[AddComponentMenu] // RVA: 0x148FB0 Offset: 0x1490B1 VA: 0x148FB0
public class CaptureGUI : MonoBehaviour // TypeDefIndex: 9599
{
	// Fields
	public CaptureBase _movieCapture; // 0x18
	public bool _showUI; // 0x20
	public bool _whenRecordingAutoHideUI; // 0x21
	public GUISkin _guiSkin; // 0x28
	private int _shownSection; // 0x30
	private string[] _videoCodecNames; // 0x38
	private string[] _audioCodecNames; // 0x40
	private bool[] _videoCodecConfigurable; // 0x48
	private bool[] _audioCodecConfigurable; // 0x50
	private string[] _audioDeviceNames; // 0x58
	private string[] _downScales; // 0x60
	private string[] _frameRates; // 0x68
	private string[] _outputType; // 0x70
	private int _downScaleIndex; // 0x78
	private int _frameRateIndex; // 0x7C
	private Vector2 _videoPos; // 0x80
	private Vector2 _audioPos; // 0x88
	private Vector2 _audioCodecPos; // 0x90
	private long _lastFileSize; // 0x98
	private uint _lastEncodedMinutes; // 0xA0
	private uint _lastEncodedSeconds; // 0xA4
	private uint _lastEncodedFrame; // 0xA8

	// Methods

	// RVA: 0x231E5B0 Offset: 0x231E6B1 VA: 0x231E5B0
	private void Start() { }

	// RVA: 0x231E640 Offset: 0x231E741 VA: 0x231E640
	private void CreateGUI() { }

	// RVA: 0x231FB10 Offset: 0x231FC11 VA: 0x231FB10
	private void OnGUI() { }

	// RVA: 0x231FE30 Offset: 0x231FF31 VA: 0x231FE30
	private void MyWindow(int id) { }

	// RVA: 0x2322710 Offset: 0x2322811 VA: 0x2322710
	private void GUI_RecordingStatus() { }

	// RVA: 0x23240E0 Offset: 0x23241E1 VA: 0x23240E0
	private void DrawGuiField(string a, string b) { }

	// RVA: 0x2323E70 Offset: 0x2323F71 VA: 0x2323E70
	private void StartCapture() { }

	// RVA: 0x2324510 Offset: 0x2324611 VA: 0x2324510
	private void StopCapture() { }

	// RVA: 0x2324470 Offset: 0x2324571 VA: 0x2324470
	private void CancelCapture() { }

	// RVA: 0x23243D0 Offset: 0x23244D1 VA: 0x23243D0
	private void ResumeCapture() { }

	// RVA: 0x2324330 Offset: 0x2324431 VA: 0x2324330
	private void PauseCapture() { }

	// RVA: 0x23245B0 Offset: 0x23246B1 VA: 0x23245B0
	private void Update() { }

	// RVA: 0x2324770 Offset: 0x2324871 VA: 0x2324770
	public void .ctor() { }
}

