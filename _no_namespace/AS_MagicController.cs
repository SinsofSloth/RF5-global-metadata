public class AS_MagicController : ActionScriptControllerBase // TypeDefIndex: 6157
{
	// Fields
	protected Character creater; // 0x140
	[SerializeField] // RVA: 0x15B950 Offset: 0x15BA51 VA: 0x15B950
	protected List<BulletBase> m_Bullets; // 0x148
	[SerializeField] // RVA: 0x15B960 Offset: 0x15BA61 VA: 0x15B960
	protected List<BulletID> m_LoadedBulletID; // 0x150
	protected int m_Level; // 0x158
	protected AttackAttribute m_AttackAttribute; // 0x15C
	protected MagicID m_MagicID; // 0x160
	protected MagicData m_MagicData; // 0x168

	// Properties
	public override Character Character { get; }

	// Methods

	// RVA: 0x1E650A0 Offset: 0x1E651A1 VA: 0x1E650A0 Slot: 4
	public override Character get_Character() { }

	// RVA: 0x1E650B0 Offset: 0x1E651B1 VA: 0x1E650B0
	public void DoAction(MagicID magicId, Character character, int level, AttackAttribute attribute) { }

	// RVA: 0x1E65220 Offset: 0x1E65321 VA: 0x1E65220 Slot: 19
	public override void DoMagicEfficacy(MagicParamID magicParamID, int level) { }

	// RVA: 0x1E65E20 Offset: 0x1E65F21 VA: 0x1E65E20 Slot: 20
	public override void DoMagicMedi(MagicParamID magicParamID1, MagicParamID magicParamID2, MagicParamID magicParamID3, int level) { }

	// RVA: 0x1E65EC0 Offset: 0x1E65FC1 VA: 0x1E65EC0 Slot: 17
	protected override void CreateBullet(BulletID useBulletID, Character chara, Vector3 offset, Quaternion rotation, bool isTargetParent, bool isLateral) { }

	// RVA: 0x1E66660 Offset: 0x1E66761 VA: 0x1E66660 Slot: 15
	public override void OnBulletLoad(BulletLoadCommand bulletLoadCmmand) { }

	// RVA: 0x1E668C0 Offset: 0x1E669C1 VA: 0x1E668C0 Slot: 22
	public override void DoScore(ScoreType scoreType, int level) { }

	// RVA: 0x1E670D0 Offset: 0x1E671D1 VA: 0x1E670D0
	public void UpdateBulletExtension() { }

	// RVA: 0x1E67240 Offset: 0x1E67341 VA: 0x1E67240 Slot: 21
	public override void DoCallBit(BitID bitID, int level) { }

	// RVA: 0x1E67330 Offset: 0x1E67431 VA: 0x1E67330
	public void DoBranchAttributeMagic(AtrubuteMagicCommand atrubuteMagicCommand) { }

	// RVA: 0x1E67590 Offset: 0x1E67691 VA: 0x1E67590
	public void .ctor() { }
}

