public class AdvDialogControl : MonoBehaviour // TypeDefIndex: 8411
{
	// Fields
	[SerializeField] // RVA: 0x16F530 Offset: 0x16F631 VA: 0x16F530
	private RectTransform[] CharaBasePoint; // 0x18
	private AdvCharaImageControl[] AdvCharaImageControls; // 0x20
	[SerializeField] // RVA: 0x16F540 Offset: 0x16F641 VA: 0x16F540
	private AdvCharaImageControl AdvCharaImageControlPrefab; // 0x28
	public NameWindow NameText; // 0x30
	public TextWindow ChatText; // 0x38
	[SerializeField] // RVA: 0x16F550 Offset: 0x16F651 VA: 0x16F550
	private AdvByTheWayMove ByTheWayIcon; // 0x40
	[SerializeField] // RVA: 0x16F560 Offset: 0x16F661 VA: 0x16F560
	private SText byTheWayText; // 0x48
	private bool ByTheWayShaking; // 0x50
	[SerializeField] // RVA: 0x16F570 Offset: 0x16F671 VA: 0x16F570
	private AdvChatWindowOnOff ChatWindow; // 0x58
	[SerializeField] // RVA: 0x16F580 Offset: 0x16F681 VA: 0x16F580
	private Image[] ChatWindowImage; // 0x60
	[SerializeField] // RVA: 0x16F590 Offset: 0x16F691 VA: 0x16F590
	private AdvShowOneImage AdvShowOneImage; // 0x68
	[SerializeField] // RVA: 0x16F5A0 Offset: 0x16F6A1 VA: 0x16F5A0
	private AdvStaffRollBase AdvStaffRollBase; // 0x70
	public SpriteDataResource FaceData; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x16F5B0 Offset: 0x16F6B1 VA: 0x16F5B0
	private bool <IsOpening>k__BackingField; // 0x80
	private VoiceController OnTextPlayingVoiceController; // 0x88
	private readonly bool[] hasSwimsuitPajama; // 0x90
	private readonly bool[] HasMarryForm; // 0x98

	// Properties
	public bool IsByTheWayShaking { get; }
	public bool IsByTheWayViewing { get; }
	public bool IsOpening { get; set; }

	// Methods

	// RVA: 0x1BF9AC0 Offset: 0x1BF9BC1 VA: 0x1BF9AC0
	public bool get_IsByTheWayShaking() { }

	// RVA: 0x1BF9B00 Offset: 0x1BF9C01 VA: 0x1BF9B00
	public bool get_IsByTheWayViewing() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7510 Offset: 0x1A7611 VA: 0x1A7510
	// RVA: 0x1BF9B20 Offset: 0x1BF9C21 VA: 0x1BF9B20
	public bool get_IsOpening() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7520 Offset: 0x1A7621 VA: 0x1A7520
	// RVA: 0x1BF9B30 Offset: 0x1BF9C31 VA: 0x1BF9B30
	private void set_IsOpening(bool value) { }

	// RVA: 0x1BF9B40 Offset: 0x1BF9C41 VA: 0x1BF9B40
	public void Open() { }

	// RVA: 0x1BF9BA0 Offset: 0x1BF9CA1 VA: 0x1BF9BA0
	public void Close(bool _is_hide = False) { }

	// RVA: 0x1BF9D60 Offset: 0x1BF9E61 VA: 0x1BF9D60
	public void SetByTheWayActive(bool value, ByTheWayType ByTheWayType = 0) { }

	// RVA: 0x1BF9E70 Offset: 0x1BF9F71 VA: 0x1BF9E70
	private void SetShakeByTheWayIcon(bool value) { }

	// RVA: 0x1BF9EB0 Offset: 0x1BF9FB1 VA: 0x1BF9EB0
	public void SetTextBySpeaker(string str, int speakerChId) { }

	// RVA: 0x1BF9F30 Offset: 0x1BFA031 VA: 0x1BF9F30
	public void ChangeChatWindow(int chatWindowId) { }

	// RVA: 0x1BF9C40 Offset: 0x1BF9D41 VA: 0x1BF9C40
	public void CloseAllCharactor() { }

	// RVA: 0x1BF9FB0 Offset: 0x1BFA0B1 VA: 0x1BF9FB0
	public void PlayMouth(int _positionId, VoiceController voiceController) { }

	// RVA: 0x1BFA2A0 Offset: 0x1BFA3A1 VA: 0x1BFA2A0
	public void StopMouth(int _positionId) { }

	// RVA: 0x1BFA130 Offset: 0x1BFA231 VA: 0x1BFA130
	public void StopAllMouth() { }

	// RVA: 0x1BFA3F0 Offset: 0x1BFA4F1 VA: 0x1BFA3F0
	private int UseAdvCharactor(int _charactorId, int _positionId, int _variationId) { }

	// RVA: 0x1BFA690 Offset: 0x1BFA791 VA: 0x1BFA690
	public void SetCharaLayerToFront(int _positionId) { }

	// RVA: 0x1BFA6E0 Offset: 0x1BFA7E1 VA: 0x1BFA6E0
	public void SetCharaLayerToBack(int _positionId) { }

	// RVA: 0x1BFA730 Offset: 0x1BFA831 VA: 0x1BFA730
	public void SetEmocon(int _positionId, int no, int loop = 0) { }

	// RVA: 0x1BFA840 Offset: 0x1BFA941 VA: 0x1BFA840
	public void EndEmoconLoop(int _positionId, int no, int loop = 0) { }

	// RVA: 0x1BFA940 Offset: 0x1BFAA41 VA: 0x1BFA940
	public void EndEmocon(int _positionId) { }

	// RVA: 0x1BFAAA0 Offset: 0x1BFABA1 VA: 0x1BFAAA0
	public void CharacterSwapFilter(ref int charaId, ref int variationId) { }

	// RVA: 0x1BFAB70 Offset: 0x1BFAC71 VA: 0x1BFAB70
	private void PlayerGenderCheck(ref int charaId) { }

	// RVA: 0x1BFAC00 Offset: 0x1BFAD01 VA: 0x1BFAC00
	public void AppearCharacter(int charaId, int variationId, int _positionId, int motionId, int EyeVar = 0, int EyeBrowsVar = 0, int MouthVar = 0) { }

	// RVA: 0x1BFAE00 Offset: 0x1BFAF01 VA: 0x1BFAE00
	public void UpdateCharacter(int charaId, int variationId, int _positionId, int motionId = 0, int EyeVar = 0, int EyeBrowsVar = 0, int MouthVar = 0) { }

	// RVA: 0x1BFB010 Offset: 0x1BFB111 VA: 0x1BFB010
	public void DisappearCharacter(int charaId, int variationId, int _positionId, int motionId, int EyeVar = 0, int EyeBrowsVar = 0, int MouthVar = 0) { }

	// RVA: 0x1BFB2E0 Offset: 0x1BFB3E1 VA: 0x1BFB2E0
	public void PlayCharaAnim(int _positionId, AdvCharaImageControl.CharaAnimateType type) { }

	// RVA: 0x1BFB410 Offset: 0x1BFB511 VA: 0x1BFB410
	public void OpenSingleImage(int imageId, int x = 0, int y = 0, int _time = 150) { }

	// RVA: 0x1BFB430 Offset: 0x1BFB531 VA: 0x1BFB430
	public void EndSingleImage(int imageId = 0, int _time = 150) { }

	// RVA: 0x1BFB460 Offset: 0x1BFB561 VA: 0x1BFB460
	public void StartStaffRoll(int type, float time) { }

	// RVA: 0x1BFB480 Offset: 0x1BFB581 VA: 0x1BFB480
	public void EndStaffRoll() { }

	// RVA: 0x1BFB4A0 Offset: 0x1BFB5A1 VA: 0x1BFB4A0
	private void Start() { }

	// RVA: 0x1BFB6D0 Offset: 0x1BFB7D1 VA: 0x1BFB6D0
	private void Update() { }

	// RVA: 0x1BFB9A0 Offset: 0x1BFBAA1 VA: 0x1BFB9A0
	public int ConvertCostumeFromNormal(int charaId, int variationId) { }

	// RVA: 0x1BFBC30 Offset: 0x1BFBD31 VA: 0x1BFBC30
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7530 Offset: 0x1A7631 VA: 0x1A7530
	// RVA: 0x1BFBD40 Offset: 0x1BFBE41 VA: 0x1BFBD40
	private void <Start>b__48_1(BaseEventData _data) { }
}

