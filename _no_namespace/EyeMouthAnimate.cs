public class EyeMouthAnimate : MonoBehaviour // TypeDefIndex: 8434
{
	// Fields
	private bool PlayEye; // 0x18
	private bool PlayEyeBrows; // 0x19
	private bool MouthSeted; // 0x1A
	private bool _PlayMouth; // 0x1B
	[CompilerGeneratedAttribute] // RVA: 0x16F610 Offset: 0x16F711 VA: 0x16F610
	private int <CharactorId>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x16F620 Offset: 0x16F721 VA: 0x16F620
	private int <VariationId>k__BackingField; // 0x20
	public Image MainImage; // 0x28
	public Image NoFaceImage; // 0x30
	public Image EyeImage; // 0x38
	public Image EyeBrowsImage; // 0x40
	public Image MouthImage; // 0x48
	public Sprite[] BaseImage; // 0x50
	[SerializeField] // RVA: 0x16F630 Offset: 0x16F731 VA: 0x16F630
	private Sprite[] EyeImgs; // 0x58
	[SerializeField] // RVA: 0x16F640 Offset: 0x16F741 VA: 0x16F640
	private Sprite[] EyeBrowsImgs; // 0x60
	[SerializeField] // RVA: 0x16F650 Offset: 0x16F751 VA: 0x16F650
	private Sprite[] MouthImgs; // 0x68
	[SerializeField] // RVA: 0x16F660 Offset: 0x16F761 VA: 0x16F660
	private int MaxEyeId; // 0x70
	[SerializeField] // RVA: 0x16F670 Offset: 0x16F771 VA: 0x16F670
	private int MaxEyeBrowsId; // 0x74
	[SerializeField] // RVA: 0x16F680 Offset: 0x16F781 VA: 0x16F680
	private int MaxMouthId; // 0x78
	[SerializeField] // RVA: 0x16F690 Offset: 0x16F791 VA: 0x16F690
	private EyeMouthAnimate.EMAnimSet[] EyeSet; // 0x80
	[SerializeField] // RVA: 0x16F6A0 Offset: 0x16F7A1 VA: 0x16F6A0
	private EyeMouthAnimate.EMAnimSet[] EyeBrowsSet; // 0x88
	[SerializeField] // RVA: 0x16F6B0 Offset: 0x16F7B1 VA: 0x16F6B0
	private EyeMouthAnimate.EMAnimSet[] MouthSet; // 0x90
	[SerializeField] // RVA: 0x16F6C0 Offset: 0x16F7C1 VA: 0x16F6C0
	private float EyeFrame; // 0x98
	[SerializeField] // RVA: 0x16F6D0 Offset: 0x16F7D1 VA: 0x16F6D0
	private float EyeBrowsFrame; // 0x9C
	[SerializeField] // RVA: 0x16F6E0 Offset: 0x16F7E1 VA: 0x16F6E0
	private float MouthFrame; // 0xA0
	[SerializeField] // RVA: 0x16F6F0 Offset: 0x16F7F1 VA: 0x16F6F0
	private int EyeAnimPoint; // 0xA4
	[SerializeField] // RVA: 0x16F700 Offset: 0x16F801 VA: 0x16F700
	private int EyeBrowsAnimPoint; // 0xA8
	[SerializeField] // RVA: 0x16F710 Offset: 0x16F811 VA: 0x16F710
	private int MouthAnimPoint; // 0xAC
	[SerializeField] // RVA: 0x16F720 Offset: 0x16F821 VA: 0x16F720
	private float EyeWaitTimeMin; // 0xB0
	[SerializeField] // RVA: 0x16F730 Offset: 0x16F831 VA: 0x16F730
	private float EyeWaitTimeMax; // 0xB4
	private Image ParentImage; // 0xB8
	public SpriteAtlas spriteAtlas; // 0xC0
	private int EyeVariation; // 0xC8
	private int EyeBrowsVariation; // 0xCC
	private int MouthVariation; // 0xD0
	private BustupDataList.MouthTable mouthTable; // 0xD8
	private int defaultMouthVal; // 0xE0
	private bool fadeInCompleted; // 0xE4

	// Properties
	private bool PlayMouth { get; set; }
	public int CharactorId { get; set; }
	public int VariationId { get; set; }

	// Methods

	// RVA: 0x207AE10 Offset: 0x207AF11 VA: 0x207AE10
	private bool get_PlayMouth() { }

	// RVA: 0x207AE20 Offset: 0x207AF21 VA: 0x207AE20
	private void set_PlayMouth(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A75C0 Offset: 0x1A76C1 VA: 0x1A75C0
	// RVA: 0x207AE40 Offset: 0x207AF41 VA: 0x207AE40
	public int get_CharactorId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A75D0 Offset: 0x1A76D1 VA: 0x1A75D0
	// RVA: 0x207AE50 Offset: 0x207AF51 VA: 0x207AE50
	private void set_CharactorId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A75E0 Offset: 0x1A76E1 VA: 0x1A75E0
	// RVA: 0x207AE60 Offset: 0x207AF61 VA: 0x207AE60
	public int get_VariationId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A75F0 Offset: 0x1A76F1 VA: 0x1A75F0
	// RVA: 0x207AE70 Offset: 0x207AF71 VA: 0x207AE70
	private void set_VariationId(int value) { }

	// RVA: 0x207AE80 Offset: 0x207AF81 VA: 0x207AE80
	public void StartMouth() { }

	// RVA: 0x207AEA0 Offset: 0x207AFA1 VA: 0x207AEA0
	public void StopMouth() { }

	// RVA: 0x207AFC0 Offset: 0x207B0C1 VA: 0x207AFC0
	public void EndAnim() { }

	// RVA: 0x207AFD0 Offset: 0x207B0D1 VA: 0x207AFD0
	private Sprite GetEyesSprite(int charaId, int faceId, int costumeId, int poseId, int animId) { }

	// RVA: 0x207B240 Offset: 0x207B341 VA: 0x207B240
	private Sprite GetEyeBrowsSprite(int charaId, int faceId, int costumeId, int poseId, int animId) { }

	// RVA: 0x207B4B0 Offset: 0x207B5B1 VA: 0x207B4B0
	private Sprite GetMouthSprite(int charaId, int faceId, int costumeId, int poseId, int animId) { }

	// RVA: 0x207B720 Offset: 0x207B821 VA: 0x207B720
	private Sprite GetMainSprite(int charaId, int faceId, int costumeId, int poseId) { }

	// RVA: 0x207B9A0 Offset: 0x207BAA1 VA: 0x207B9A0
	private Sprite GetNoFaceSprite(int charaId, int faceId, int costumeId, int poseId) { }

	// RVA: 0x207BAB0 Offset: 0x207BBB1 VA: 0x207BAB0
	private void GetImageSet() { }

	// RVA: 0x207C0B0 Offset: 0x207C1B1 VA: 0x207C0B0
	public void SetImage(Image parentImg, int charaId, int variationId, int EyeVar, int EyeBrowsVar, int MouthVar) { }

	// RVA: 0x207C470 Offset: 0x207C571 VA: 0x207C470
	private void Start() { }

	// RVA: 0x207C6A0 Offset: 0x207C7A1 VA: 0x207C6A0
	private void SetStartFace() { }

	// RVA: 0x207C8F0 Offset: 0x207C9F1 VA: 0x207C8F0
	private void SetEndFace() { }

	// RVA: 0x207C960 Offset: 0x207CA61 VA: 0x207C960
	private void LateUpdate() { }

	// RVA: 0x207CA00 Offset: 0x207CB01 VA: 0x207CA00
	private void Update() { }

	// RVA: 0x207AF10 Offset: 0x207B011 VA: 0x207AF10
	private void SetNullImageOff(Image image) { }

	// RVA: 0x207C3E0 Offset: 0x207C4E1 VA: 0x207C3E0
	private void SetFaceImageEnable(Image image) { }

	// RVA: 0x207CDC0 Offset: 0x207CEC1 VA: 0x207CDC0
	public void .ctor() { }
}

