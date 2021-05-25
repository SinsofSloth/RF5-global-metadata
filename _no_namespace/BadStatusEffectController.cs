[Serializable]
public class BadStatusEffectController : MonoBehaviour // TypeDefIndex: 8277
{
	// Fields
	public const string PointName = "StatusEffect_Point";
	private static readonly Dictionary<BadStatus, Prefab> AssetIDs; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x16E8E0 Offset: 0x16E9E1 VA: 0x16E8E0
	private SEController <SEController>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x16E8F0 Offset: 0x16E9F1 VA: 0x16E8F0
	private Dictionary<BadStatus, BadStatusEffectController.ObjInfo> <EffectObjectDic>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x16E900 Offset: 0x16EA01 VA: 0x16E900
	private List<BadStatus> <BadStatusList>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x16E910 Offset: 0x16EA11 VA: 0x16E910
	private BadStatus <PrevFrameBadStatus>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x16E920 Offset: 0x16EA21 VA: 0x16E920
	private Character <Character>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x16E930 Offset: 0x16EA31 VA: 0x16E930
	private int <CurrentBadStatusIndex>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x16E940 Offset: 0x16EA41 VA: 0x16E940
	private float <ElapsedTime>k__BackingField; // 0x44
	private readonly float MultiDisplayTime; // 0x48
	public bool IsInvisibleEffect; // 0x4C

	// Properties
	private SEController SEController { get; set; }
	private Dictionary<BadStatus, BadStatusEffectController.ObjInfo> EffectObjectDic { get; set; }
	private List<BadStatus> BadStatusList { get; set; }
	private BadStatus PrevFrameBadStatus { get; set; }
	private Character Character { get; set; }
	private int CurrentBadStatusIndex { get; set; }
	private float ElapsedTime { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A6770 Offset: 0x1A6871 VA: 0x1A6770
	// RVA: 0x2155C80 Offset: 0x2155D81 VA: 0x2155C80
	private SEController get_SEController() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6780 Offset: 0x1A6881 VA: 0x1A6780
	// RVA: 0x2155C90 Offset: 0x2155D91 VA: 0x2155C90
	private void set_SEController(SEController value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6790 Offset: 0x1A6891 VA: 0x1A6790
	// RVA: 0x2155CA0 Offset: 0x2155DA1 VA: 0x2155CA0
	private Dictionary<BadStatus, BadStatusEffectController.ObjInfo> get_EffectObjectDic() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A67A0 Offset: 0x1A68A1 VA: 0x1A67A0
	// RVA: 0x2155CB0 Offset: 0x2155DB1 VA: 0x2155CB0
	private void set_EffectObjectDic(Dictionary<BadStatus, BadStatusEffectController.ObjInfo> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A67B0 Offset: 0x1A68B1 VA: 0x1A67B0
	// RVA: 0x2155CC0 Offset: 0x2155DC1 VA: 0x2155CC0
	private List<BadStatus> get_BadStatusList() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A67C0 Offset: 0x1A68C1 VA: 0x1A67C0
	// RVA: 0x2155CD0 Offset: 0x2155DD1 VA: 0x2155CD0
	private void set_BadStatusList(List<BadStatus> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A67D0 Offset: 0x1A68D1 VA: 0x1A67D0
	// RVA: 0x2155CE0 Offset: 0x2155DE1 VA: 0x2155CE0
	private BadStatus get_PrevFrameBadStatus() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A67E0 Offset: 0x1A68E1 VA: 0x1A67E0
	// RVA: 0x2155CF0 Offset: 0x2155DF1 VA: 0x2155CF0
	private void set_PrevFrameBadStatus(BadStatus value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A67F0 Offset: 0x1A68F1 VA: 0x1A67F0
	// RVA: 0x2155D00 Offset: 0x2155E01 VA: 0x2155D00
	private Character get_Character() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6800 Offset: 0x1A6901 VA: 0x1A6800
	// RVA: 0x2155D10 Offset: 0x2155E11 VA: 0x2155D10
	private void set_Character(Character value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6810 Offset: 0x1A6911 VA: 0x1A6810
	// RVA: 0x2155D20 Offset: 0x2155E21 VA: 0x2155D20
	private int get_CurrentBadStatusIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6820 Offset: 0x1A6921 VA: 0x1A6820
	// RVA: 0x2155D30 Offset: 0x2155E31 VA: 0x2155D30
	private void set_CurrentBadStatusIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6830 Offset: 0x1A6931 VA: 0x1A6830
	// RVA: 0x2155D40 Offset: 0x2155E41 VA: 0x2155D40
	private float get_ElapsedTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6840 Offset: 0x1A6941 VA: 0x1A6840
	// RVA: 0x2155D50 Offset: 0x2155E51 VA: 0x2155D50
	private void set_ElapsedTime(float value) { }

	// RVA: 0x2155D60 Offset: 0x2155E61 VA: 0x2155D60
	private void Awake() { }

	// RVA: 0x2155DC0 Offset: 0x2155EC1 VA: 0x2155DC0
	private void Update() { }

	// RVA: 0x21567B0 Offset: 0x21568B1 VA: 0x21567B0
	private void Display(BadStatus id) { }

	// RVA: 0x2156A80 Offset: 0x2156B81 VA: 0x2156A80
	private void Remove(BadStatus id) { }

	// RVA: 0x2156B80 Offset: 0x2156C81 VA: 0x2156B80
	private void SetDisplayBadStatus(BadStatus badStatus, bool isEnable) { }

	// RVA: 0x2156CA0 Offset: 0x2156DA1 VA: 0x2156CA0
	private void OnDestroy() { }

	// RVA: 0x2156E50 Offset: 0x2156F51 VA: 0x2156E50
	public void .ctor() { }

	// RVA: 0x2157160 Offset: 0x2157261 VA: 0x2157160
	private static void .cctor() { }
}

