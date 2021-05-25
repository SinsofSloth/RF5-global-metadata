public class AdvCharaImageControl : MonoBehaviour // TypeDefIndex: 8407
{
	// Fields
	[SerializeField] // RVA: 0x16F400 Offset: 0x16F501 VA: 0x16F400
	private Animator CharactorAnimator; // 0x18
	[SerializeField] // RVA: 0x16F410 Offset: 0x16F511 VA: 0x16F410
	private Image CharactorImages; // 0x20
	[SerializeField] // RVA: 0x16F420 Offset: 0x16F521 VA: 0x16F420
	private Animator CharactorFadeAnimator; // 0x28
	[SerializeField] // RVA: 0x16F430 Offset: 0x16F531 VA: 0x16F430
	private AdvEmoconControl LeftEmoconPrefab; // 0x30
	[SerializeField] // RVA: 0x16F440 Offset: 0x16F541 VA: 0x16F440
	private AdvEmoconControl RightEmoconPrefab; // 0x38
	[SerializeField] // RVA: 0x16F450 Offset: 0x16F551 VA: 0x16F450
	private GameObject AnimateMovePoint; // 0x40
	private AdvCharaAnim[] CharaAnimate; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x16F460 Offset: 0x16F561 VA: 0x16F460
	private StandPoint <standPoint>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x16F470 Offset: 0x16F571 VA: 0x16F470
	private int <CharactorId>k__BackingField; // 0x54
	[CompilerGeneratedAttribute] // RVA: 0x16F480 Offset: 0x16F581 VA: 0x16F480
	private int <VariationId>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x16F490 Offset: 0x16F591 VA: 0x16F490
	private int <MotionId>k__BackingField; // 0x5C
	[CompilerGeneratedAttribute] // RVA: 0x16F4A0 Offset: 0x16F5A1 VA: 0x16F4A0
	private int <PlayingCharactorId>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x16F4B0 Offset: 0x16F5B1 VA: 0x16F4B0
	private int <PlayingVariationId>k__BackingField; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x16F4C0 Offset: 0x16F5C1 VA: 0x16F4C0
	private int <PlayingMotionId>k__BackingField; // 0x68
	private int PlayingEyeVariation; // 0x6C
	private int PlayingEyeBrowsVariation; // 0x70
	private int PlayingMouthVariation; // 0x74
	private EyeMouthAnimate EyeMouthAnimate; // 0x78
	private AdvEmoconControl Emocon; // 0x80
	private bool waitPlayMouth; // 0x88
	private int waitPlayEmoconType; // 0x8C
	private int waitPlayEmoconLoopStat; // 0x90
	private int EyeVariation; // 0x94
	private int EyeBrowsVariation; // 0x98
	private int MouthVariation; // 0x9C
	private EyeMouthAnimate EyeMouthAnimatorPref; // 0xA0
	private static EyeMouthAnimate[] EyeMouthAnimates; // 0x0
	private int LoaderId; // 0xA8
	private AdvCharaImageControl.AnimStat nowStat; // 0xAC

	// Properties
	public StandPoint standPoint { get; set; }
	public int CharactorId { get; set; }
	public int VariationId { get; set; }
	public int MotionId { get; set; }
	public int PlayingCharactorId { get; set; }
	public int PlayingVariationId { get; set; }
	public int PlayingMotionId { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A7430 Offset: 0x1A7531 VA: 0x1A7430
	// RVA: 0x1BF7790 Offset: 0x1BF7891 VA: 0x1BF7790
	public StandPoint get_standPoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7440 Offset: 0x1A7541 VA: 0x1A7440
	// RVA: 0x1BF77A0 Offset: 0x1BF78A1 VA: 0x1BF77A0
	private void set_standPoint(StandPoint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7450 Offset: 0x1A7551 VA: 0x1A7450
	// RVA: 0x1BF77B0 Offset: 0x1BF78B1 VA: 0x1BF77B0
	public int get_CharactorId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7460 Offset: 0x1A7561 VA: 0x1A7460
	// RVA: 0x1BF77C0 Offset: 0x1BF78C1 VA: 0x1BF77C0
	private void set_CharactorId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7470 Offset: 0x1A7571 VA: 0x1A7470
	// RVA: 0x1BF77D0 Offset: 0x1BF78D1 VA: 0x1BF77D0
	public int get_VariationId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7480 Offset: 0x1A7581 VA: 0x1A7480
	// RVA: 0x1BF77E0 Offset: 0x1BF78E1 VA: 0x1BF77E0
	private void set_VariationId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7490 Offset: 0x1A7591 VA: 0x1A7490
	// RVA: 0x1BF77F0 Offset: 0x1BF78F1 VA: 0x1BF77F0
	public int get_MotionId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A74A0 Offset: 0x1A75A1 VA: 0x1A74A0
	// RVA: 0x1BF7800 Offset: 0x1BF7901 VA: 0x1BF7800
	private void set_MotionId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A74B0 Offset: 0x1A75B1 VA: 0x1A74B0
	// RVA: 0x1BF7810 Offset: 0x1BF7911 VA: 0x1BF7810
	public int get_PlayingCharactorId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A74C0 Offset: 0x1A75C1 VA: 0x1A74C0
	// RVA: 0x1BF7820 Offset: 0x1BF7921 VA: 0x1BF7820
	private void set_PlayingCharactorId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A74D0 Offset: 0x1A75D1 VA: 0x1A74D0
	// RVA: 0x1BF7830 Offset: 0x1BF7931 VA: 0x1BF7830
	public int get_PlayingVariationId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A74E0 Offset: 0x1A75E1 VA: 0x1A74E0
	// RVA: 0x1BF7840 Offset: 0x1BF7941 VA: 0x1BF7840
	private void set_PlayingVariationId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A74F0 Offset: 0x1A75F1 VA: 0x1A74F0
	// RVA: 0x1BF7850 Offset: 0x1BF7951 VA: 0x1BF7850
	public int get_PlayingMotionId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7500 Offset: 0x1A7601 VA: 0x1A7500
	// RVA: 0x1BF7860 Offset: 0x1BF7961 VA: 0x1BF7860
	private void set_PlayingMotionId(int value) { }

	// RVA: 0x1BF7870 Offset: 0x1BF7971 VA: 0x1BF7870
	private void OnDestroy() { }

	// RVA: 0x1BF78F0 Offset: 0x1BF79F1 VA: 0x1BF78F0
	public bool CheckCanUseSavePrefebs(int _CharactorId, int _VariationId) { }

	// RVA: 0x1BF7970 Offset: 0x1BF7A71 VA: 0x1BF7970
	public void InitOnCreate(StandPoint _standPoint) { }

	// RVA: 0x1BF7B10 Offset: 0x1BF7C11 VA: 0x1BF7B10
	public void SetAppear() { }

	// RVA: 0x1BF6F70 Offset: 0x1BF7071 VA: 0x1BF6F70
	public void SetLoadedEMA(GameObject _eyeMouthAnimatorPref, int loaderId) { }

	// RVA: 0x1BF7D50 Offset: 0x1BF7E51 VA: 0x1BF7D50
	private bool LoadFace(int charaId, int VariationId) { }

	// RVA: 0x1BF7E70 Offset: 0x1BF7F71 VA: 0x1BF7E70
	private bool SetFace(int charaId, int variationId, int EyeVar, int EyeBrowsVar, int MouthVar, int clothId = 0) { }

	// RVA: 0x1BF8280 Offset: 0x1BF8381 VA: 0x1BF8280
	public void SetCharaMotion(int motionId) { }

	// RVA: 0x1BF7B70 Offset: 0x1BF7C71 VA: 0x1BF7B70
	private void SetIn() { }

	// RVA: 0x1BF7C80 Offset: 0x1BF7D81 VA: 0x1BF7C80
	private void SetOut() { }

	// RVA: 0x1BF8360 Offset: 0x1BF8461 VA: 0x1BF8360
	private int DoMotionAnim(int motionId) { }

	// RVA: 0x1BF84F0 Offset: 0x1BF85F1 VA: 0x1BF84F0
	public void SetChara(int charaId, int variationId, int EyeVar, int EyeBrowsVar, int MouthVar, int motionId) { }

	// RVA: 0x1BF8650 Offset: 0x1BF8751 VA: 0x1BF8650
	public void SetEndChara(int charaId, int faceId, int EyeVar, int EyeBrowsVar, int MouthVar, int motionId) { }

	// RVA: 0x1BF86A0 Offset: 0x1BF87A1 VA: 0x1BF86A0
	public void RemoveChara() { }

	// RVA: 0x1BF87F0 Offset: 0x1BF88F1 VA: 0x1BF87F0
	public void StartMouth() { }

	// RVA: 0x1BF88A0 Offset: 0x1BF89A1 VA: 0x1BF88A0
	public void EndMouth() { }

	// RVA: 0x1BF8940 Offset: 0x1BF8A41 VA: 0x1BF8940
	public void PlayEmocon(int no, int loop = 0) { }

	// RVA: 0x1BF8A00 Offset: 0x1BF8B01 VA: 0x1BF8A00
	public void EndEmoconLoop(int no) { }

	// RVA: 0x1BF8BA0 Offset: 0x1BF8CA1 VA: 0x1BF8BA0
	public void ForceEndEmocon() { }

	// RVA: 0x1BF8DC0 Offset: 0x1BF8EC1 VA: 0x1BF8DC0
	public void EndAllAnim() { }

	// RVA: 0x1BF8490 Offset: 0x1BF8591 VA: 0x1BF8490
	public void PlayAnim(AdvCharaImageControl.CharaAnimateType type) { }

	// RVA: 0x1BF8EB0 Offset: 0x1BF8FB1 VA: 0x1BF8EB0
	public void .ctor() { }
}

